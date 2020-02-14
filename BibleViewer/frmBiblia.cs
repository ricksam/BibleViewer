using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BibleViewer
{
  public partial class frmBiblia : lib.Visual.Models.frmBase
  {
    #region public frmBiblia()
    public frmBiblia()
    {
      InitializeComponent();
    }
    #endregion

    #region Fields
    dsBIBLIA dsBiblia { get; set; }
    dsCAPITULOS dsCap { get; set; }
    CAPITULOS CAPITULO { get; set; }
    int SelVersiculo { get; set; }
    #endregion

    #region private void Carregar()
    private void Carregar() 
    {
      dsBiblia = new dsBIBLIA(Utilities.Cnn);
      dsCap = new dsCAPITULOS(Utilities.Cnn);
      CAPITULO = new CAPITULOS() { CAPITULO = 1, LIVRO = "Gênesis" };
      ExibirCapitulo();
    }
    #endregion

    #region private void PesquisaLivros()
    private void PesquisaLivros() 
    {
      frmLivros f = new frmLivros();
      if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        if (f.CAPITULO != null)
        {
          CAPITULO = f.CAPITULO;
          SelVersiculo = 0;
          ExibirCapitulo();
        }
      }
    }
    #endregion

    #region private void ExibirCapitulo()
    private void ExibirCapitulo()
    {
      lblTitulo.Text = CAPITULO.LIVRO + " " + CAPITULO.CAPITULO;
      BIBLIA[] Versiculos = dsBiblia.GetList_FromCapitulo(CAPITULO);

      txtConteudo.Text = "";
      int SelStart = -1;
      int SelLenght = -1; 
      for (int i = 0; i < Versiculos.Length; i++)
      {
        if (Versiculos[i].VERSICULO == SelVersiculo)
        { SelStart = txtConteudo.Text.Length; }

        string versiculo = Versiculos[i].ToString() ;
        txtConteudo.Text += versiculo + "\r\n\r\n";

        if (Versiculos[i].VERSICULO == SelVersiculo)
        { SelLenght = versiculo.Length; }
      }

      if (SelStart != -1 && SelLenght != -1)
      {
        txtConteudo.Select();
        txtConteudo.SelectionStart = SelStart;
        txtConteudo.SelectionLength = SelLenght;
        txtConteudo.ScrollToCaret();
      }
    }
    #endregion

    #region private void Pesquisar()
    private void Pesquisar() 
    {
      frmPesquisa f = new frmPesquisa();
      if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        CAPITULO = new CAPITULOS();
        CAPITULO.LIVRO = f.Selecionado.LIVRO;
        CAPITULO.CAPITULO = f.Selecionado.CAPITULO;
        SelVersiculo = f.Selecionado.VERSICULO;
        ExibirCapitulo();
      }
    }
    #endregion

    #region Events
    private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PesquisaLivros();
    }

    private void frmBiblia_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      CAPITULO = dsCap.GetProximo(CAPITULO);
      ExibirCapitulo();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      CAPITULO = dsCap.GetAnterior(CAPITULO);
      ExibirCapitulo();
    }

    private void lblTitulo_Click(object sender, EventArgs e)
    {
      PesquisaLivros();
    }
    
    private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Pesquisar();
    }

    private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lib.Visual.Msg.Information(
         "Desenvolvedor: Ricardo Sampaio\n" +
         "Empresa: RCK Software\n" +
         "Contato: jricksam@gmail.com" +
         " \n",
         "Bible Viewer"
         );
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Pesquisar();
    }
    #endregion
  }
}
