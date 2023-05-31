namespace Laba {
    partial class PrepareForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            setAy = new NumericUpDown();
            setAx = new NumericUpDown();
            groupBox2 = new GroupBox();
            setBy = new NumericUpDown();
            setBx = new NumericUpDown();
            groupBox3 = new GroupBox();
            setCy = new NumericUpDown();
            setCx = new NumericUpDown();
            accept = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setAx).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setBy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setBx).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setCy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setCx).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(setAy);
            groupBox1.Controls.Add(setAx);
            groupBox1.Location = new Point(4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 46);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Точка А";
            // 
            // setAy
            // 
            setAy.Location = new Point(111, 16);
            setAy.Maximum = new decimal(new int[] { 380, 0, 0, 0 });
            setAy.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            setAy.Name = "setAy";
            setAy.Size = new Size(104, 23);
            setAy.TabIndex = 1;
            setAy.Value = new decimal(new int[] { 340, 0, 0, 0 });
            // 
            // setAx
            // 
            setAx.Location = new Point(5, 16);
            setAx.Maximum = new decimal(new int[] { 380, 0, 0, 0 });
            setAx.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            setAx.Name = "setAx";
            setAx.Size = new Size(100, 23);
            setAx.TabIndex = 0;
            setAx.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(setBy);
            groupBox2.Controls.Add(setBx);
            groupBox2.Location = new Point(4, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 46);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Точка В";
            // 
            // setBy
            // 
            setBy.Location = new Point(111, 17);
            setBy.Maximum = new decimal(new int[] { 380, 0, 0, 0 });
            setBy.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            setBy.Name = "setBy";
            setBy.Size = new Size(100, 23);
            setBy.TabIndex = 3;
            setBy.Value = new decimal(new int[] { 110, 0, 0, 0 });
            // 
            // setBx
            // 
            setBx.Location = new Point(5, 17);
            setBx.Maximum = new decimal(new int[] { 380, 0, 0, 0 });
            setBx.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            setBx.Name = "setBx";
            setBx.Size = new Size(100, 23);
            setBx.TabIndex = 2;
            setBx.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(setCy);
            groupBox3.Controls.Add(setCx);
            groupBox3.Location = new Point(4, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(222, 46);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Точка С";
            // 
            // setCy
            // 
            setCy.Location = new Point(111, 17);
            setCy.Maximum = new decimal(new int[] { 380, 0, 0, 0 });
            setCy.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            setCy.Name = "setCy";
            setCy.Size = new Size(100, 23);
            setCy.TabIndex = 5;
            setCy.Value = new decimal(new int[] { 340, 0, 0, 0 });
            // 
            // setCx
            // 
            setCx.Location = new Point(5, 17);
            setCx.Maximum = new decimal(new int[] { 380, 0, 0, 0 });
            setCx.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            setCx.Name = "setCx";
            setCx.Size = new Size(100, 23);
            setCx.TabIndex = 4;
            setCx.Value = new decimal(new int[] { 340, 0, 0, 0 });
            // 
            // accept
            // 
            accept.Location = new Point(4, 150);
            accept.Name = "accept";
            accept.Size = new Size(222, 23);
            accept.TabIndex = 2;
            accept.Text = "Принять";
            accept.UseVisualStyleBackColor = true;
            accept.Click += accept_Click;
            // 
            // PrepareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 179);
            ControlBox = false;
            Controls.Add(accept);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PrepareForm";
            ShowInTaskbar = false;
            Text = "Настройка первого треугольника";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)setAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)setAx).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)setBy).EndInit();
            ((System.ComponentModel.ISupportInitialize)setBx).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)setCy).EndInit();
            ((System.ComponentModel.ISupportInitialize)setCx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown setAy;
        private NumericUpDown setAx;
        private GroupBox groupBox2;
        private NumericUpDown setBy;
        private NumericUpDown setBx;
        private GroupBox groupBox3;
        private NumericUpDown setCy;
        private NumericUpDown setCx;
        private Button accept;
    }
}