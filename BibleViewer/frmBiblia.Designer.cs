namespace BibleViewer
{
  partial class frmBiblia
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblia));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.txtConteudo = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.sobreToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(734, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // livrosToolStripMenuItem
      // 
      this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
      this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.livrosToolStripMenuItem.Text = "Livros";
      this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
      // 
      // pesquisaToolStripMenuItem
      // 
      this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
      this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
      this.pesquisaToolStripMenuItem.Text = "Pesquisa";
      this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
      // 
      // sobreToolStripMenuItem
      // 
      this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
      this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
      this.sobreToolStripMenuItem.Text = "Sobre";
      this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.lblTitulo);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(734, 55);
      this.panel1.TabIndex = 1;
      // 
      // lblTitulo
      // 
      this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
      this.lblTitulo.Location = new System.Drawing.Point(131, 3);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(227, 49);
      this.lblTitulo.TabIndex = 2;
      this.lblTitulo.Text = "label1";
      this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
      // 
      // txtConteudo
      // 
      this.txtConteudo.BackColor = System.Drawing.Color.White;
      this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtConteudo.Font = new System.Drawing.Font("Segoe UI", 15.75F);
      this.txtConteudo.Location = new System.Drawing.Point(0, 79);
      this.txtConteudo.Multiline = true;
      this.txtConteudo.Name = "txtConteudo";
      this.txtConteudo.ReadOnly = true;
      this.txtConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtConteudo.Size = new System.Drawing.Size(734, 433);
      this.txtConteudo.TabIndex = 2;
      // 
      // button2
      // 
      this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Image = global::BibleViewer.Properties.Resources._1358556974_arrowright;
      this.button2.Location = new System.Drawing.Point(364, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(58, 49);
      this.button2.TabIndex = 1;
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Image = global::BibleViewer.Properties.Resources._1358556974_arrowleft;
      this.button1.Location = new System.Drawing.Point(67, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(58, 49);
      this.button1.TabIndex = 0;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button3
      // 
      this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Image = global::BibleViewer.Properties.Resources._1364850615_Search;
      this.button3.Location = new System.Drawing.Point(3, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(58, 49);
      this.button3.TabIndex = 3;
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // frmBiblia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 512);
      this.Controls.Add(this.txtConteudo);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmBiblia";
      this.Text = "Biblia";
      this.Load += new System.EventHandler(this.frmBiblia_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox txtConteudo;
    private System.Windows.Forms.Button button3;
  }
}

