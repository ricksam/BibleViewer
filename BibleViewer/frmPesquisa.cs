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
  public partial class frmPesquisa : lib.Visual.Models.frmBase
  {
    public frmPesquisa()
    {
      InitializeComponent();
    }

    System.Threading.Thread Processo { get; set; }
    dsBIBLIA Biblia = new dsBIBLIA(Utilities.Cnn);
    string uDate { get; set; }
    public BIBLIA Selecionado { get; set; }

    private void ProcessaPesquisa(object cmp)
    {
      try
      {
        int Interval = 200;

        if (txtSearch.Text.Length < 3) { Interval = 2000; }
        if (txtSearch.Text.Length < 4) { Interval = 1000; }
        if (txtSearch.Text.Length < 5) { Interval = 800; }
        if (txtSearch.Text.Length < 6) { Interval = 400; }
        if (txtSearch.Text.Length < 7) { Interval = 200; }
        if (txtSearch.Text.Length < 8) { Interval = 100; }
        if (txtSearch.Text.Length < 9) { Interval = 50; }
        
        for (int i = 0; i < Interval; i++)
        {
          if (cmp.ToString() != uDate)
          { return; }
          System.Threading.Thread.Sleep(2);
        }

        if (cmp.ToString() == uDate)
        {
          this.BeginInvoke((Action)delegate()
            {
              if (cmp.ToString() != uDate)
              { return; }

              lstVersiculos.Items.Clear();
              txtVersiculo.Text = "";
              lblPesquisados.Text = "";
              if (txtSearch.Text.Length > 1)
              {
                BIBLIA[] versiculos = Biblia.Search(txtSearch.Text);
                lblPesquisados.Text = versiculos.Length + " registros encontrados.";
                lstVersiculos.Items.AddRange(versiculos);
              }
            });
        }
      }
      catch { return; }
    }

    private void Pesquisa() 
    {
      uDate = DateTime.Now.ToString("yyMMddHHmmss") + DateTime.Now.Millisecond.ToString() + txtSearch.Text.Length;

      System.Threading.Thread.Sleep(10);
      if (Processo != null && Processo.IsAlive)
      {
        Processo.Interrupt();
        Processo = null;
      }
                 
      Processo = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(ProcessaPesquisa));
      Processo.Start(uDate);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
      Pesquisa();
    }

    private void lstVersiculos_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstVersiculos.SelectedIndex != -1)
      { txtVersiculo.Text = lstVersiculos.Items[lstVersiculos.SelectedIndex].ToString(); }
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { Pesquisa(); }

      if (e.KeyData == Keys.Down || e.KeyData == Keys.Up)
      { lstVersiculos.Select(); }
    }

    private void lstVersiculos_KeyPress(object sender, KeyPressEventArgs e)
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

    private void lstVersiculos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter&&lstVersiculos.SelectedIndex!=-1) 
      {
        Selecionado = (BIBLIA)lstVersiculos.SelectedItem;
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
    }

    private void lstVersiculos_DoubleClick(object sender, EventArgs e)
    {
      if (lstVersiculos.SelectedIndex != -1)
      {
        Selecionado = (BIBLIA)lstVersiculos.SelectedItem;
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
    }
  }
}
