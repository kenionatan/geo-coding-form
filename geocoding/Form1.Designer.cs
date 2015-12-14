namespace geocoding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.cBoxUf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wbBrow = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(13, 252);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(147, 20);
            this.txtLat.TabIndex = 0;
            this.txtLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLat_KeyPress);
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(13, 306);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(147, 20);
            this.txtLong.TabIndex = 1;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(12, 185);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 34);
            this.btnCalcula.TabIndex = 2;
            this.btnCalcula.Text = "Gerar";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longitude:";
            // 
            // txtLine1
            // 
            this.txtLine1.Location = new System.Drawing.Point(12, 29);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(219, 20);
            this.txtLine1.TabIndex = 5;
            // 
            // txtLine2
            // 
            this.txtLine2.Location = new System.Drawing.Point(12, 72);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(219, 20);
            this.txtLine2.TabIndex = 6;
            // 
            // cBoxUf
            // 
            this.cBoxUf.FormattingEnabled = true;
            this.cBoxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cBoxUf.Location = new System.Drawing.Point(12, 112);
            this.cBoxUf.Name = "cBoxUf";
            this.cBoxUf.Size = new System.Drawing.Size(57, 21);
            this.cBoxUf.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(100, 112);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(131, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wbBrow);
            this.panel1.Location = new System.Drawing.Point(266, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 538);
            this.panel1.TabIndex = 13;
            // 
            // wbBrow
            // 
            this.wbBrow.Location = new System.Drawing.Point(0, 0);
            this.wbBrow.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrow.Name = "wbBrow";
            this.wbBrow.Size = new System.Drawing.Size(614, 524);
            this.wbBrow.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxUf);
            this.Controls.Add(this.txtLine2);
            this.Controls.Add(this.txtLine1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerar Coordenadas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLine1;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.ComboBox cBoxUf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser wbBrow;
    }
}

