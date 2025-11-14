namespace M2TWinForms.Demo
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
            m2tButton1 = new M2TButton();
            SuspendLayout();
            // 
            // m2tButton1
            // 
            m2tButton1.ColorRole = M2TButtonColorRoleSelection.Tertiary;
            m2tButton1.Location = new Point(213, 141);
            m2tButton1.Name = "m2tButton1";
            m2tButton1.Size = new Size(116, 65);
            m2tButton1.TabIndex = 0;
            m2tButton1.Text = "m2tButton1";
            m2tButton1.Click += m2tButton1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(m2tButton1);
            Name = "Form2";
            Text = "Form2";
            Activated += Form2_Activated;
            Deactivate += Form2_Deactivate;
            ResumeLayout(false);
        }

        #endregion

        private M2TButton m2tButton1;
    }
}