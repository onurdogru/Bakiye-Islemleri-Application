namespace BakiyeIslemleri
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
            this.lblLOGO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBAKIYE = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonParaCek = new System.Windows.Forms.Button();
            this.numericUpDownPARACEK = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPARAYATIR = new System.Windows.Forms.Button();
            this.numericUpDownPARAYATIR = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTABLO = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPARACEK)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPARAYATIR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLOGO
            // 
            this.lblLOGO.AutoSize = true;
            this.lblLOGO.BackColor = System.Drawing.Color.GreenYellow;
            this.lblLOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLOGO.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblLOGO.Location = new System.Drawing.Point(453, 26);
            this.lblLOGO.Name = "lblLOGO";
            this.lblLOGO.Size = new System.Drawing.Size(422, 55);
            this.lblLOGO.TabIndex = 0;
            this.lblLOGO.Text = "Migros JET KASA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(573, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakiye :";
            // 
            // labelBAKIYE
            // 
            this.labelBAKIYE.AutoSize = true;
            this.labelBAKIYE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBAKIYE.Location = new System.Drawing.Point(686, 100);
            this.labelBAKIYE.Name = "labelBAKIYE";
            this.labelBAKIYE.Size = new System.Drawing.Size(72, 31);
            this.labelBAKIYE.TabIndex = 2;
            this.labelBAKIYE.Text = "0 TL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.buttonParaCek);
            this.groupBox1.Controls.Add(this.numericUpDownPARACEK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(361, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARA ÇEK";
            // 
            // buttonParaCek
            // 
            this.buttonParaCek.ForeColor = System.Drawing.Color.Maroon;
            this.buttonParaCek.Location = new System.Drawing.Point(55, 94);
            this.buttonParaCek.Name = "buttonParaCek";
            this.buttonParaCek.Size = new System.Drawing.Size(130, 40);
            this.buttonParaCek.TabIndex = 2;
            this.buttonParaCek.Text = "Para Çek";
            this.buttonParaCek.UseVisualStyleBackColor = true;
            this.buttonParaCek.Click += new System.EventHandler(this.buttonParaCek_Click);
            // 
            // numericUpDownPARACEK
            // 
            this.numericUpDownPARACEK.Location = new System.Drawing.Point(105, 42);
            this.numericUpDownPARACEK.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPARACEK.Name = "numericUpDownPARACEK";
            this.numericUpDownPARACEK.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownPARACEK.TabIndex = 1;
            this.numericUpDownPARACEK.ValueChanged += new System.EventHandler(this.numericUpDownPARACEK_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktar :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.buttonPARAYATIR);
            this.groupBox2.Controls.Add(this.numericUpDownPARAYATIR);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(627, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 254);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PARA YATIR";
            // 
            // buttonPARAYATIR
            // 
            this.buttonPARAYATIR.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPARAYATIR.Location = new System.Drawing.Point(63, 94);
            this.buttonPARAYATIR.Name = "buttonPARAYATIR";
            this.buttonPARAYATIR.Size = new System.Drawing.Size(131, 40);
            this.buttonPARAYATIR.TabIndex = 3;
            this.buttonPARAYATIR.Text = "Para Yatır";
            this.buttonPARAYATIR.UseVisualStyleBackColor = true;
            this.buttonPARAYATIR.Click += new System.EventHandler(this.buttonPARAYATIR_Click);
            // 
            // numericUpDownPARAYATIR
            // 
            this.numericUpDownPARAYATIR.Location = new System.Drawing.Point(103, 42);
            this.numericUpDownPARAYATIR.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPARAYATIR.Name = "numericUpDownPARAYATIR";
            this.numericUpDownPARAYATIR.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownPARAYATIR.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miktar :";
            // 
            // listBoxTABLO
            // 
            this.listBoxTABLO.BackColor = System.Drawing.Color.Gold;
            this.listBoxTABLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxTABLO.FormattingEnabled = true;
            this.listBoxTABLO.ItemHeight = 16;
            this.listBoxTABLO.Location = new System.Drawing.Point(92, 194);
            this.listBoxTABLO.Name = "listBoxTABLO";
            this.listBoxTABLO.Size = new System.Drawing.Size(247, 260);
            this.listBoxTABLO.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(896, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 254);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KAMPANYA";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ekmek 10 TL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Şeker 20 TL";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(22, 84);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(125, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Çikolata 30 TL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(22, 114);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(112, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Peynir 50 TL";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(22, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Alışveriş Tamamla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1279, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBoxTABLO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelBAKIYE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLOGO);
            this.Name = "Form1";
            this.Text = "MigrosJET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPARACEK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPARAYATIR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLOGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBAKIYE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonParaCek;
        private System.Windows.Forms.NumericUpDown numericUpDownPARACEK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPARAYATIR;
        private System.Windows.Forms.NumericUpDown numericUpDownPARAYATIR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxTABLO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

