﻿namespace ConnectCsharpToMysql
{
    partial class UZYTKOWNIK
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.ciD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOSTÊPNOŒÆ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "SZUKAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(245, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 30;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(301, 386);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Model";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(245, 386);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Marka";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.zalogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.autorzyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "Plik";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.quitToolStripMenuItem.Text = "Zakoncz";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.autorzyToolStripMenuItem.Text = "Autorzy";
            this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.autorzyToolStripMenuItem_Click);
            // 
            // zalogujToolStripMenuItem
            // 
            this.zalogujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem});
            this.zalogujToolStripMenuItem.Name = "zalogujToolStripMenuItem";
            this.zalogujToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.zalogujToolStripMenuItem.Text = "Logowanie";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.wylogujToolStripMenuItem.Text = "wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // dgDisplay
            // 
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciD,
            this.cName,
            this.cAge,
            this.Author_name,
            this.Column2,
            this.DOSTÊPNOŒÆ,
            this.Column3});
            this.dgDisplay.Location = new System.Drawing.Point(0, 112);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.ReadOnly = true;
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDisplay.Size = new System.Drawing.Size(705, 230);
            this.dgDisplay.TabIndex = 34;
            this.dgDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplay_CellContentClick);
            // 
            // ciD
            // 
            this.ciD.HeaderText = "ID";
            this.ciD.Name = "ciD";
            this.ciD.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "MARKA";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cAge
            // 
            this.cAge.HeaderText = "MODEL";
            this.cAge.Name = "cAge";
            this.cAge.ReadOnly = true;
            // 
            // Author_name
            // 
            this.Author_name.HeaderText = "KOLOR";
            this.Author_name.Name = "Author_name";
            this.Author_name.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SILNIK";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // DOSTÊPNOŒÆ
            // 
            this.DOSTÊPNOŒÆ.HeaderText = "DOSTEPNOSC";
            this.DOSTÊPNOŒÆ.Name = "DOSTÊPNOŒÆ";
            this.DOSTÊPNOŒÆ.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "REZERWACJA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UZYTKOWNIK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ConnectCsharpToMysql.Properties.Resources.tlo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(698, 424);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UZYTKOWNIK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UZYTKOWNIK";
            this.Load += new System.EventHandler(this.UZYTKOWNIK_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOSTÊPNOŒÆ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}