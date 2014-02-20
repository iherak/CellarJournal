namespace CellarJournal.App
{
    partial class MainWindowForm
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
            this.components = new System.ComponentModel.Container();
            this.listWines = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajOpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nagradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaBerbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajVinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajBačvuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drvenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poVinuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poBačviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poDatumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stvoriGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.listGroup = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // listWines
            // 
            this.listWines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listWines.ContextMenuStrip = this.contextMenuStrip1;
            this.listWines.FullRowSelect = true;
            this.listWines.Location = new System.Drawing.Point(0, 0);
            this.listWines.MultiSelect = false;
            this.listWines.Name = "listWines";
            this.listWines.Size = new System.Drawing.Size(409, 254);
            this.listWines.TabIndex = 0;
            this.listWines.UseCompatibleStateImageBehavior = false;
            this.listWines.View = System.Windows.Forms.View.Details;
            this.listWines.DoubleClick += new System.EventHandler(this.listWines_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Naziv vina";
            this.ColumnHeader1.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sorta";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bačva";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Napomena";
            this.columnHeader6.Width = 173;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajOpisToolStripMenuItem,
            this.dnevnikToolStripMenuItem,
            this.nagradeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dodajOpisToolStripMenuItem
            // 
            this.dodajOpisToolStripMenuItem.Name = "dodajOpisToolStripMenuItem";
            this.dodajOpisToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.dodajOpisToolStripMenuItem.Text = "Dodaj opis";
            this.dodajOpisToolStripMenuItem.Click += new System.EventHandler(this.dodajOpisToolStripMenuItem_Click);
            // 
            // dnevnikToolStripMenuItem
            // 
            this.dnevnikToolStripMenuItem.Name = "dnevnikToolStripMenuItem";
            this.dnevnikToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.dnevnikToolStripMenuItem.Text = "Dnevnik...";
            this.dnevnikToolStripMenuItem.Click += new System.EventHandler(this.dnevnikToolStripMenuItem_Click);
            // 
            // nagradeToolStripMenuItem
            // 
            this.nagradeToolStripMenuItem.Name = "nagradeToolStripMenuItem";
            this.nagradeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.nagradeToolStripMenuItem.Text = "Nagrade...";
            this.nagradeToolStripMenuItem.Click += new System.EventHandler(this.nagradeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem,
            this.pretragaToolStripMenuItem,
            this.grupeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaBerbaToolStripMenuItem,
            this.dodajVinoToolStripMenuItem,
            this.dodajBačvuToolStripMenuItem,
            this.pretokToolStripMenuItem});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // novaBerbaToolStripMenuItem
            // 
            this.novaBerbaToolStripMenuItem.Name = "novaBerbaToolStripMenuItem";
            this.novaBerbaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novaBerbaToolStripMenuItem.Text = "Nova berba...";
            this.novaBerbaToolStripMenuItem.Click += new System.EventHandler(this.novaBerbaToolStripMenuItem_Click);
            // 
            // dodajVinoToolStripMenuItem
            // 
            this.dodajVinoToolStripMenuItem.Name = "dodajVinoToolStripMenuItem";
            this.dodajVinoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dodajVinoToolStripMenuItem.Text = "Dodaj vino";
            this.dodajVinoToolStripMenuItem.Click += new System.EventHandler(this.dodajVinoToolStripMenuItem_Click);
            // 
            // dodajBačvuToolStripMenuItem
            // 
            this.dodajBačvuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inoxToolStripMenuItem,
            this.drvenaToolStripMenuItem});
            this.dodajBačvuToolStripMenuItem.Name = "dodajBačvuToolStripMenuItem";
            this.dodajBačvuToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dodajBačvuToolStripMenuItem.Text = "Dodaj bačvu...";
            // 
            // inoxToolStripMenuItem
            // 
            this.inoxToolStripMenuItem.Name = "inoxToolStripMenuItem";
            this.inoxToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.inoxToolStripMenuItem.Text = "Inox";
            this.inoxToolStripMenuItem.Click += new System.EventHandler(this.inoxToolStripMenuItem_Click);
            // 
            // drvenaToolStripMenuItem
            // 
            this.drvenaToolStripMenuItem.Name = "drvenaToolStripMenuItem";
            this.drvenaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.drvenaToolStripMenuItem.Text = "Drvena";
            this.drvenaToolStripMenuItem.Click += new System.EventHandler(this.drvenaToolStripMenuItem_Click);
            // 
            // pretokToolStripMenuItem
            // 
            this.pretokToolStripMenuItem.Name = "pretokToolStripMenuItem";
            this.pretokToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pretokToolStripMenuItem.Text = "Pretok...";
            this.pretokToolStripMenuItem.Click += new System.EventHandler(this.pretokToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poVinuToolStripMenuItem,
            this.poBačviToolStripMenuItem,
            this.poDatumuToolStripMenuItem});
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.pretragaToolStripMenuItem.Text = "Pretraga...";
            // 
            // poVinuToolStripMenuItem
            // 
            this.poVinuToolStripMenuItem.Name = "poVinuToolStripMenuItem";
            this.poVinuToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.poVinuToolStripMenuItem.Text = "...vina";
            this.poVinuToolStripMenuItem.Click += new System.EventHandler(this.poVinuToolStripMenuItem_Click);
            // 
            // poBačviToolStripMenuItem
            // 
            this.poBačviToolStripMenuItem.Enabled = false;
            this.poBačviToolStripMenuItem.Name = "poBačviToolStripMenuItem";
            this.poBačviToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.poBačviToolStripMenuItem.Text = "...bačvi";
            // 
            // poDatumuToolStripMenuItem
            // 
            this.poDatumuToolStripMenuItem.Enabled = false;
            this.poDatumuToolStripMenuItem.Name = "poDatumuToolStripMenuItem";
            this.poDatumuToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.poDatumuToolStripMenuItem.Text = "...aktivnosti";
            // 
            // grupeToolStripMenuItem
            // 
            this.grupeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stvoriGrupuToolStripMenuItem,
            this.urediGrupuToolStripMenuItem});
            this.grupeToolStripMenuItem.Name = "grupeToolStripMenuItem";
            this.grupeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.grupeToolStripMenuItem.Text = "Grupe...";
            // 
            // stvoriGrupuToolStripMenuItem
            // 
            this.stvoriGrupuToolStripMenuItem.Name = "stvoriGrupuToolStripMenuItem";
            this.stvoriGrupuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.stvoriGrupuToolStripMenuItem.Text = "Stvori grupu";
            this.stvoriGrupuToolStripMenuItem.Click += new System.EventHandler(this.stvoriGrupuToolStripMenuItem_Click);
            // 
            // urediGrupuToolStripMenuItem
            // 
            this.urediGrupuToolStripMenuItem.Name = "urediGrupuToolStripMenuItem";
            this.urediGrupuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.urediGrupuToolStripMenuItem.Text = "Uredi grupu";
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(12, 52);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYears.TabIndex = 2;
            this.comboBoxYears.SelectionChangeCommitted += new System.EventHandler(this.comboBoxYears_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj praznih bačvi: ";
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(149, 52);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroups.TabIndex = 4;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Berba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grupe";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listWines);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 254);
            this.panel1.TabIndex = 7;
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.listGroup);
            this.panelGroups.Location = new System.Drawing.Point(24, 27);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(405, 254);
            this.panelGroups.TabIndex = 1;
            // 
            // listGroup
            // 
            this.listGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8});
            this.listGroup.ContextMenuStrip = this.contextMenuStrip1;
            this.listGroup.FullRowSelect = true;
            this.listGroup.Location = new System.Drawing.Point(0, -1);
            this.listGroup.MultiSelect = false;
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(409, 254);
            this.listGroup.TabIndex = 1;
            this.listGroup.UseCompatibleStateImageBehavior = false;
            this.listGroup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv vina";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sorta";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bačva";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Napomena";
            this.columnHeader8.Width = 173;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxYears);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindowForm";
            this.Text = "CellarJournal";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGroups.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listWines;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaBerbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajVinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajBačvuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poVinuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poBačviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poDatumuToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem inoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drvenaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajOpisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nagradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stvoriGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediGrupuToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.ListView listGroup;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem pretokToolStripMenuItem;
    }
}

