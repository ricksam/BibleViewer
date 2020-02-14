namespace BibleViewer
{
  partial class frmPesquisa
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
      this.lstVersiculos = new System.Windows.Forms.ListBox();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.txtVersiculo = new System.Windows.Forms.TextBox();
      this.lblPesquisados = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lstVersiculos
      // 
      this.lstVersiculos.ColumnWidth = 50;
      this.lstVersiculos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstVersiculos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstVersiculos.FormattingEnabled = true;
      this.lstVersiculos.ItemHeight = 30;
      this.lstVersiculos.Location = new System.Drawing.Point(0, 52);
      this.lstVersiculos.Name = "lstVersiculos";
      this.lstVersiculos.Size = new System.Drawing.Size(484, 155);
      this.lstVersiculos.TabIndex = 3;
      this.lstVersiculos.SelectedIndexChanged += new System.EventHandler(this.lstVersiculos_SelectedIndexChanged);
      this.lstVersiculos.DoubleClick += new System.EventHandler(this.lstVersiculos_DoubleClick);
      this.lstVersiculos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstVersiculos_KeyDown);
      this.lstVersiculos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstVersiculos_KeyPress);
      // 
      // txtSearch
      // 
      this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSearch.Location = new System.Drawing.Point(0, 0);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(484, 35);
      this.txtSearch.TabIndex = 2;
      this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
      this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
      // 
      // splitter1
      // 
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(0, 207);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(484, 5);
      this.splitter1.TabIndex = 4;
      this.splitter1.TabStop = false;
      // 
      // txtVersiculo
      // 
      this.txtVersiculo.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.txtVersiculo.Font = new System.Drawing.Font("Segoe UI", 15.75F);
      this.txtVersiculo.Location = new System.Drawing.Point(0, 212);
      this.txtVersiculo.Multiline = true;
      this.txtVersiculo.Name = "txtVersiculo";
      this.txtVersiculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtVersiculo.Size = new System.Drawing.Size(484, 250);
      this.txtVersiculo.TabIndex = 5;
      // 
      // lblPesquisados
      // 
      this.lblPesquisados.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblPesquisados.Location = new System.Drawing.Point(0, 35);
      this.lblPesquisados.Name = "lblPesquisados";
      this.lblPesquisados.Size = new System.Drawing.Size(484, 17);
      this.lblPesquisados.TabIndex = 6;
      // 
      // frmPesquisa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 462);
      this.Controls.Add(this.lstVersiculos);
      this.Controls.Add(this.lblPesquisados);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.txtVersiculo);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmPesquisa";
      this.Text = "Pesquisa";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstVersiculos;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.TextBox txtVersiculo;
    private System.Windows.Forms.Label lblPesquisados;
  }
}