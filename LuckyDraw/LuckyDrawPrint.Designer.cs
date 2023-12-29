namespace LuckyDraw
{
    partial class LuckyDrawPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuckyDrawPrint));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.enableCuponNum = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cuponNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.printNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponNum)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(88, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Thank You";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(88, 195);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            // 
            // printNum
            // 
            this.printNum.Location = new System.Drawing.Point(88, 86);
            this.printNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.printNum.Name = "printNum";
            this.printNum.Size = new System.Drawing.Size(132, 20);
            this.printNum.TabIndex = 3;
            this.printNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NumberOfPrint";
            // 
            // enableCuponNum
            // 
            this.enableCuponNum.AutoSize = true;
            this.enableCuponNum.Location = new System.Drawing.Point(88, 152);
            this.enableCuponNum.Name = "enableCuponNum";
            this.enableCuponNum.Size = new System.Drawing.Size(111, 17);
            this.enableCuponNum.TabIndex = 4;
            this.enableCuponNum.Text = "enableCuponNum";
            this.enableCuponNum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "StartCuponNum";
            // 
            // cuponNum
            // 
            this.cuponNum.Location = new System.Drawing.Point(88, 112);
            this.cuponNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cuponNum.Name = "cuponNum";
            this.cuponNum.Size = new System.Drawing.Size(132, 20);
            this.cuponNum.TabIndex = 3;
            this.cuponNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.enableCuponNum);
            this.Controls.Add(this.cuponNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.printNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LuckyDrawPrint";
            ((System.ComponentModel.ISupportInitialize)(this.printNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown printNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox enableCuponNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cuponNum;
    }
}

