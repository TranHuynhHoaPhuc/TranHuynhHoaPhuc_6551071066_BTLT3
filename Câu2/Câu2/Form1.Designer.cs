namespace Câu2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntClickMe = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bntClickMe
            // 
            bntClickMe.BackColor = SystemColors.ControlLightLight;
            bntClickMe.FlatAppearance.BorderColor = Color.Cyan;
            bntClickMe.FlatAppearance.MouseDownBackColor = Color.Cyan;
            bntClickMe.FlatAppearance.MouseOverBackColor = Color.Cyan;
            bntClickMe.FlatStyle = FlatStyle.Flat;
            bntClickMe.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntClickMe.ForeColor = Color.Red;
            bntClickMe.Location = new Point(222, 123);
            bntClickMe.Name = "bntClickMe";
            bntClickMe.Size = new Size(318, 185);
            bntClickMe.TabIndex = 0;
            bntClickMe.Text = "Click Me";
            bntClickMe.UseVisualStyleBackColor = false;
            bntClickMe.Click += bntClickMe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 1;
            label1.Text = "6551071066";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(bntClickMe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntClickMe;
        private Label label1;
    }
}
