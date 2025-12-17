namespace Quiz05___Methods
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            santaPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)santaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(38, 112);
            label1.Name = "label1";
            label1.Size = new Size(401, 223);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // santaPictureBox
            // 
            santaPictureBox.BackgroundImageLayout = ImageLayout.Center;
            santaPictureBox.Location = new Point(0, 0);
            santaPictureBox.Name = "santaPictureBox";
            santaPictureBox.Size = new Size(506, 470);
            santaPictureBox.TabIndex = 1;
            santaPictureBox.TabStop = false;
            santaPictureBox.Click += santaPictureBox_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 457);
            Controls.Add(santaPictureBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Holiday Bonus";
            Load += Form3_Load;
            Click += Form3_Click;
            ((System.ComponentModel.ISupportInitialize)santaPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox santaPictureBox;
    }
}