namespace PersembeGunu17AralikUyg
{
    partial class Form1
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
            this.cbDaire = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKonum = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEsya = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDaire
            // 
            this.cbDaire.FormattingEnabled = true;
            this.cbDaire.Items.AddRange(new object[] {
            "Sıfır",
            "İkinci El"});
            this.cbDaire.Location = new System.Drawing.Point(177, 36);
            this.cbDaire.Name = "cbDaire";
            this.cbDaire.Size = new System.Drawing.Size(160, 24);
            this.cbDaire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daire Durumu";
            // 
            // cbOda
            // 
            this.cbOda.FormattingEnabled = true;
            this.cbOda.Items.AddRange(new object[] {
            "0 + 1",
            "1 + 1",
            "2 + 1",
            "3 + 1"});
            this.cbOda.Location = new System.Drawing.Point(177, 112);
            this.cbOda.Name = "cbOda";
            this.cbOda.Size = new System.Drawing.Size(160, 24);
            this.cbOda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oda Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kat Bilgisi";
            // 
            // cbKat
            // 
            this.cbKat.FormattingEnabled = true;
            this.cbKat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbKat.Location = new System.Drawing.Point(547, 39);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(160, 24);
            this.cbKat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Konum";
            // 
            // cbKonum
            // 
            this.cbKonum.FormattingEnabled = true;
            this.cbKonum.Items.AddRange(new object[] {
            "Merkez",
            "Merkez Dışı"});
            this.cbKonum.Location = new System.Drawing.Point(547, 115);
            this.cbKonum.Name = "cbKonum";
            this.cbKonum.Size = new System.Drawing.Size(160, 24);
            this.cbKonum.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 82);
            this.button1.TabIndex = 8;
            this.button1.Text = "Değer Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eşya Durumu";
            // 
            // cbEsya
            // 
            this.cbEsya.FormattingEnabled = true;
            this.cbEsya.Items.AddRange(new object[] {
            "Eşyalı",
            "Eşyasız"});
            this.cbEsya.Location = new System.Drawing.Point(177, 186);
            this.cbEsya.Name = "cbEsya";
            this.cbEsya.Size = new System.Drawing.Size(160, 24);
            this.cbEsya.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Daire Değeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 468);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbEsya);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKonum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDaire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKonum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEsya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

