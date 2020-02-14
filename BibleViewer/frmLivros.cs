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
  public partial class frmLivros : lib.Visual.Models.frmBase
  {
    public frmLivros()
    {
      InitializeComponent();
    }

    dsLIVROS dsLivros = new dsLIVROS(Utilities.Cnn);
    dsCAPITULOS dsCap = new dsCAPITULOS(Utilities.Cnn);

    public CAPITULOS CAPITULO { get; set; }

    private void PesquisaLivro(string s)
    {
      lstLivros.MultiColumn = false;
      lstLivros.Items.Clear();

      if (string.IsNullOrEmpty(s))
      { lstLivros.Items.AddRange(dsLivros.List()); }
      else
      { lstLivros.Items.AddRange(dsLivros.GetList_Search(s)); }
    }

    private void PesquisaCapitulos(string Livro) 
    {
      lstLivros.MultiColumn = true;
      lstLivros.Items.Clear();
      lstLivros.Items.AddRange(dsCap.GetList_FromLivro(Livro));
    }

    private void EscolheOpcao() 
    {
      if (lstLivros.SelectedIndex != -1)
      {
        if (lstLivros.MultiColumn)
        {
          if (lstLivros.SelectedItem != null)
          { CAPITULO = ((CAPITULOS)lstLivros.SelectedItem); }
          else 
          { CAPITULO = null; }

          this.DialogResult = System.Windows.Forms.DialogResult.OK; }
        else 
        { PesquisaCapitulos(lstLivros.Items[lstLivros.SelectedIndex].ToString()); }
      }
    }

    private void Livros_Load(object sender, EventArgs e)
    {
      PesquisaLivro("");
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
      PesquisaLivro(txtSearch.Text);
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter && lstLivros.Items.Count != 0)
      {
        lstLivros.Select();
        lstLivros.SelectedIndex = 0;
      }
      
      if (e.KeyData == Keys.Down || e.KeyData == Keys.Up)
      { lstLivros.Select(); }
    }

    private void lstLivros_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { EscolheOpcao(); }
      if (char.IsLetter(((char)e.KeyValue)))
      {
        txtSearch.Select();
        txtSearch.Text = ((char)e.KeyValue).ToString();
        txtSearch.SelectionStart = txtSearch.Text.Length;
      }
    }

    private void lstLivros_DoubleClick(object sender, EventArgs e)
    {
      EscolheOpcao();
    }

    private void lstLivros_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == ((char)8))
      {
        txtSearch.Select();
        if (e.KeyChar != ((char)8))
        {
          txtSearch.Text = e.KeyChar.ToString();
          txtSearch.SelectionStart = 1;
        }
      }
    }
  }
}
