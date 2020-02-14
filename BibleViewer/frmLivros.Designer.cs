namespace BibleViewer
{
  partial class frmLivros
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivros));
      this.lstLivros = new System.Windows.Forms.ListBox();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lstLivros
      // 
      this.lstLivros.ColumnWidth = 50;
      this.lstLivros.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstLivros.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstLivros.FormattingEnabled = true;
      this.lstLivros.ItemHeight = 30;
      this.lstLivros.Location = new System.Drawing.Point(0, 35);
      this.lstLivros.MultiColumn = true;
      this.lstLivros.Name = "lstLivros";
      this.lstLivros.Size = new System.Drawing.Size(484, 427);
      this.lstLivros.TabIndex = 1;
      this.lstLivros.DoubleClick += new System.EventHandler(this.lstLivros_DoubleClick);
      this.lstLivros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLivros_KeyDown);
      this.lstLivros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstLivros_KeyPress);
      // 
      // txtSearch
      // 
      this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSearch.Location = new System.Drawing.Point(0, 0);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(484, 35);
      this.txtSearch.TabIndex = 0;
      this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
      this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
      // 
      // frmLivros
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 462);
      this.Controls.Add(this.lstLivros);
      this.Controls.Add(this.txtSearch);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmLivros";
      this.Text = "Livro";
      this.Load += new System.EventHandler(this.Livros_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstLivros;
    private System.Windows.Forms.TextBox txtSearch;
  }
}