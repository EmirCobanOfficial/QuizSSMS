namespace Quiz
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnbasla = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblsoru2 = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblzaman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 210);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(199, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(199, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnbasla
            // 
            this.btnbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.Location = new System.Drawing.Point(869, 12);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(142, 47);
            this.btnbasla.TabIndex = 5;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(910, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puan:";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpuan.Location = new System.Drawing.Point(985, 140);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(24, 25);
            this.lblpuan.TabIndex = 7;
            this.lblpuan.Text = "0";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldogru.Location = new System.Drawing.Point(841, 234);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(77, 25);
            this.lbldogru.TabIndex = 8;
            this.lbldogru.Text = "Doğru:";
            // 
            // lblsoru2
            // 
            this.lblsoru2.AutoSize = true;
            this.lblsoru2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoru2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblsoru2.Location = new System.Drawing.Point(985, 174);
            this.lblsoru2.Name = "lblsoru2";
            this.lblsoru2.Size = new System.Drawing.Size(24, 25);
            this.lblsoru2.TabIndex = 10;
            this.lblsoru2.Text = "0";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoru.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblsoru.Location = new System.Drawing.Point(910, 174);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(65, 25);
            this.lblsoru.TabIndex = 9;
            this.lblsoru.Text = "Soru:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblzaman.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblzaman.Location = new System.Drawing.Point(985, 101);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(24, 25);
            this.lblzaman.TabIndex = 12;
            this.lblzaman.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(910, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Süre:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1023, 552);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsoru2);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnbasla;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblsoru2;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Label label3;
    }
}