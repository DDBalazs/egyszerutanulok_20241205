namespace egyszerutanulok_20241205
{
    partial class Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtelepules = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbigszam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txigszam = new System.Windows.Forms.TextBox();
            this.txosztaly = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtszuletett = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igazolvany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgadatok);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbtelepules);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(421, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Válasszon települést!";
            // 
            // cbtelepules
            // 
            this.cbtelepules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtelepules.FormattingEnabled = true;
            this.cbtelepules.Location = new System.Drawing.Point(7, 40);
            this.cbtelepules.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbtelepules.Name = "cbtelepules";
            this.cbtelepules.Size = new System.Drawing.Size(406, 21);
            this.cbtelepules.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kattintson az elejére a kiválasztáshoz!";
            // 
            // rbigszam
            // 
            this.rbigszam.AutoSize = true;
            this.rbigszam.Location = new System.Drawing.Point(444, 22);
            this.rbigszam.Name = "rbigszam";
            this.rbigszam.Size = new System.Drawing.Size(177, 17);
            this.rbigszam.TabIndex = 1;
            this.rbigszam.TabStop = true;
            this.rbigszam.Text = "Igazolvány száma változik!";
            this.rbigszam.UseVisualStyleBackColor = true;
            this.rbigszam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Igazolvány száma: ";
            // 
            // txigszam
            // 
            this.txigszam.Enabled = false;
            this.txigszam.Location = new System.Drawing.Point(555, 56);
            this.txigszam.Name = "txigszam";
            this.txigszam.Size = new System.Drawing.Size(100, 20);
            this.txigszam.TabIndex = 3;
            // 
            // txosztaly
            // 
            this.txosztaly.Location = new System.Drawing.Point(723, 57);
            this.txosztaly.Name = "txosztaly";
            this.txosztaly.Size = new System.Drawing.Size(62, 20);
            this.txosztaly.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Osztály: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Név: ";
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(555, 90);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(230, 20);
            this.txnev.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Született: ";
            // 
            // dtszuletett
            // 
            this.dtszuletett.CustomFormat = "yyyy MMMM dd.";
            this.dtszuletett.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtszuletett.Location = new System.Drawing.Point(555, 121);
            this.dtszuletett.Name = "dtszuletett";
            this.dtszuletett.Size = new System.Drawing.Size(230, 20);
            this.dtszuletett.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lakcím:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(555, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(555, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(555, 228);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(230, 20);
            this.textBox6.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 73);
            this.button1.TabIndex = 14;
            this.button1.Text = "Adatok módosítása";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(444, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 37);
            this.panel1.TabIndex = 15;
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.igazolvany});
            this.dgadatok.Location = new System.Drawing.Point(20, 94);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(379, 262);
            this.dgadatok.TabIndex = 2;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 150;
            // 
            // igazolvany
            // 
            this.igazolvany.HeaderText = "Igazolvány";
            this.igazolvany.Name = "igazolvany";
            this.igazolvany.ReadOnly = true;
            this.igazolvany.Width = 150;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtszuletett);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txosztaly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txigszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbigszam);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form";
            this.Text = "Tanulók adatai";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtelepules;
        private System.Windows.Forms.RadioButton rbigszam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txigszam;
        private System.Windows.Forms.TextBox txosztaly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtszuletett;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn igazolvany;
    }
}

