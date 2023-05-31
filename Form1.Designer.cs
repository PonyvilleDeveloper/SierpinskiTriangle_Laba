namespace Laba {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel2 = new Panel();
            save = new Button();
            StepShow = new Label();
            groupBox1 = new GroupBox();
            changeScale = new NumericUpDown();
            label1 = new Label();
            next = new Button();
            panel1 = new Panel();
            FractalPlace = new PictureBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)changeScale).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FractalPlace).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.AutoSize = true;
            panel2.Controls.Add(save);
            panel2.Controls.Add(StepShow);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(next);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 65);
            panel2.TabIndex = 1;
            // 
            // save
            // 
            save.AutoSize = true;
            save.Location = new Point(110, 35);
            save.Name = "save";
            save.Size = new Size(110, 25);
            save.TabIndex = 3;
            save.Text = "Сохранить изоб.";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // StepShow
            // 
            StepShow.AutoSize = true;
            StepShow.Location = new Point(10, 25);
            StepShow.Name = "StepShow";
            StepShow.Size = new Size(71, 15);
            StepShow.TabIndex = 2;
            StepShow.Text = "Шаг номер ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(changeScale);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(230, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Коэфф. масштаба";
            // 
            // changeScale
            // 
            changeScale.Location = new Point(20, 21);
            changeScale.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            changeScale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            changeScale.Name = "changeScale";
            changeScale.Size = new Size(120, 23);
            changeScale.TabIndex = 1;
            changeScale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 19);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 0;
            label1.Text = "×";
            // 
            // next
            // 
            next.AutoSize = true;
            next.Location = new Point(110, 5);
            next.Name = "next";
            next.Size = new Size(110, 25);
            next.TabIndex = 0;
            next.Text = "Следующий шаг";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(FractalPlace);
            panel1.Location = new Point(0, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 242);
            panel1.TabIndex = 2;
            // 
            // FractalPlace
            // 
            FractalPlace.BackColor = Color.White;
            FractalPlace.Location = new Point(4, 9);
            FractalPlace.Margin = new Padding(0);
            FractalPlace.Name = "FractalPlace";
            FractalPlace.Size = new Size(4000, 4000);
            FractalPlace.TabIndex = 3;
            FractalPlace.TabStop = false;
            FractalPlace.Paint += FractalPlace_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Треугольник Серпинского";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)changeScale).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FractalPlace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Button next;
        private NumericUpDown changeScale;
        private Label StepShow;
        private Panel panel1;
        private PictureBox FractalPlace;
        private Button save;
    }
}