namespace DisCon1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDataAdapter = new System.Windows.Forms.Button();
            this.buttonDsread = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.dataGridViewAusgabe = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonArtikeladapter = new System.Windows.Forms.Button();
            this.buttonArtikellesen = new System.Windows.Forms.Button();
            this.buttonwrite = new System.Windows.Forms.Button();
            this.buttonread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDataAdapter
            // 
            this.buttonDataAdapter.Location = new System.Drawing.Point(84, 12);
            this.buttonDataAdapter.Name = "buttonDataAdapter";
            this.buttonDataAdapter.Size = new System.Drawing.Size(140, 36);
            this.buttonDataAdapter.TabIndex = 0;
            this.buttonDataAdapter.Text = "Datenadapter";
            this.buttonDataAdapter.UseVisualStyleBackColor = true;
            this.buttonDataAdapter.Click += new System.EventHandler(this.buttonDataAdapter_Click);
            // 
            // buttonDsread
            // 
            this.buttonDsread.Location = new System.Drawing.Point(84, 54);
            this.buttonDsread.Name = "buttonDsread";
            this.buttonDsread.Size = new System.Drawing.Size(140, 40);
            this.buttonDsread.TabIndex = 1;
            this.buttonDsread.Text = "DS-Kunde auslesen";
            this.buttonDsread.UseVisualStyleBackColor = true;
            this.buttonDsread.Click += new System.EventHandler(this.buttonDsread_Click_1);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(230, 12);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(202, 199);
            this.listBoxAusgabe.TabIndex = 2;
            // 
            // dataGridViewAusgabe
            // 
            this.dataGridViewAusgabe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAusgabe.Location = new System.Drawing.Point(12, 243);
            this.dataGridViewAusgabe.Name = "dataGridViewAusgabe";
            this.dataGridViewAusgabe.Size = new System.Drawing.Size(514, 190);
            this.dataGridViewAusgabe.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(532, 332);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 29);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonArtikeladapter
            // 
            this.buttonArtikeladapter.Location = new System.Drawing.Point(438, 12);
            this.buttonArtikeladapter.Name = "buttonArtikeladapter";
            this.buttonArtikeladapter.Size = new System.Drawing.Size(140, 36);
            this.buttonArtikeladapter.TabIndex = 5;
            this.buttonArtikeladapter.Text = "Adapter Artikel";
            this.buttonArtikeladapter.UseVisualStyleBackColor = true;
            this.buttonArtikeladapter.Click += new System.EventHandler(this.buttonArtikeladapter_Click_1);
            // 
            // buttonArtikellesen
            // 
            this.buttonArtikellesen.Location = new System.Drawing.Point(438, 54);
            this.buttonArtikellesen.Name = "buttonArtikellesen";
            this.buttonArtikellesen.Size = new System.Drawing.Size(140, 40);
            this.buttonArtikellesen.TabIndex = 6;
            this.buttonArtikellesen.Text = "DS-Artikel auslesen";
            this.buttonArtikellesen.UseVisualStyleBackColor = true;
            this.buttonArtikellesen.Click += new System.EventHandler(this.buttonArtikellesen_Click);
            // 
            // buttonwrite
            // 
            this.buttonwrite.Location = new System.Drawing.Point(734, 54);
            this.buttonwrite.Name = "buttonwrite";
            this.buttonwrite.Size = new System.Drawing.Size(152, 40);
            this.buttonwrite.TabIndex = 7;
            this.buttonwrite.Text = "Serialisieren";
            this.buttonwrite.UseVisualStyleBackColor = true;
            this.buttonwrite.Click += new System.EventHandler(this.buttonwrite_Click);
            // 
            // buttonread
            // 
            this.buttonread.Location = new System.Drawing.Point(734, 100);
            this.buttonread.Name = "buttonread";
            this.buttonread.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonread.Size = new System.Drawing.Size(152, 40);
            this.buttonread.TabIndex = 8;
            this.buttonread.Text = "Deserialisieren";
            this.buttonread.UseVisualStyleBackColor = true;
            this.buttonread.Click += new System.EventHandler(this.buttonread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 518);
            this.Controls.Add(this.buttonread);
            this.Controls.Add(this.buttonwrite);
            this.Controls.Add(this.buttonArtikellesen);
            this.Controls.Add(this.buttonArtikeladapter);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewAusgabe);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonDsread);
            this.Controls.Add(this.buttonDataAdapter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDataAdapter;
        private System.Windows.Forms.Button buttonDsread;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.DataGridView dataGridViewAusgabe;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonArtikeladapter;
        private System.Windows.Forms.Button buttonArtikellesen;
        private System.Windows.Forms.Button buttonwrite;
        private System.Windows.Forms.Button buttonread;
    }
}

