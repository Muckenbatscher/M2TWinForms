namespace M2TWinForms.Demo
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
            m2tButton1 = new Controls.Inputs.Buttons.M2TButton();
            m2tPositiveConfirmationButton1 = new Controls.Inputs.Buttons.M2TPositiveConfirmationButton();
            m2tNegativeConfirmationButton1 = new Controls.Inputs.Buttons.M2TNegativeConfirmationButton();
            SuspendLayout();
            // 
            // m2tButton1
            // 
            m2tButton1.BackColor = Color.FromArgb(61, 171, 60);
            m2tButton1.BackColorType = Enumerations.ColorType.HighlightBackgroundPrimary;
            m2tButton1.FlatAppearance.BorderColor = Color.FromArgb(88, 219, 86);
            m2tButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            m2tButton1.FlatStyle = FlatStyle.Flat;
            m2tButton1.ForeColor = Color.FromArgb(88, 219, 86);
            m2tButton1.ForeColorType = Enumerations.ColorType.HighlightForegroundPrimary;
            m2tButton1.HoverBackColorType = Enumerations.ColorType.ForegroundHoverPrimary;
            m2tButton1.HoverForeColorType = Enumerations.ColorType.BackgroundHoverPrimary;
            m2tButton1.Location = new Point(23, 70);
            m2tButton1.Name = "m2tButton1";
            m2tButton1.Size = new Size(136, 45);
            m2tButton1.TabIndex = 12;
            m2tButton1.Text = "m2tButton1";
            m2tButton1.UseVisualStyleBackColor = false;
            // 
            // m2tPositiveConfirmationButton1
            // 
            m2tPositiveConfirmationButton1.BackColor = Color.FromArgb(97, 201, 119);
            m2tPositiveConfirmationButton1.BackColorType = Enumerations.ColorType.PositiveConfirmationBackground;
            m2tPositiveConfirmationButton1.FlatAppearance.BorderColor = Color.FromArgb(10, 54, 20);
            m2tPositiveConfirmationButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(94, 199, 117);
            m2tPositiveConfirmationButton1.FlatStyle = FlatStyle.Flat;
            m2tPositiveConfirmationButton1.ForeColor = Color.FromArgb(10, 54, 20);
            m2tPositiveConfirmationButton1.ForeColorType = Enumerations.ColorType.PositiveConfirmationForeground;
            m2tPositiveConfirmationButton1.HoverBackColorType = Enumerations.ColorType.PositiveConfirmationHoverBackground;
            m2tPositiveConfirmationButton1.HoverForeColorType = Enumerations.ColorType.PositiveConfirmationHoverForeground;
            m2tPositiveConfirmationButton1.Location = new Point(23, 199);
            m2tPositiveConfirmationButton1.Name = "m2tPositiveConfirmationButton1";
            m2tPositiveConfirmationButton1.Size = new Size(136, 45);
            m2tPositiveConfirmationButton1.TabIndex = 13;
            m2tPositiveConfirmationButton1.Text = "m2tPositiveConfirmationButton1";
            m2tPositiveConfirmationButton1.UseVisualStyleBackColor = false;
            // 
            // m2tNegativeConfirmationButton1
            // 
            m2tNegativeConfirmationButton1.BackColor = Color.FromArgb(212, 56, 51);
            m2tNegativeConfirmationButton1.BackColorType = Enumerations.ColorType.NegativeConfirmationBackground;
            m2tNegativeConfirmationButton1.FlatAppearance.BorderColor = Color.FromArgb(71, 13, 11);
            m2tNegativeConfirmationButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 54, 49);
            m2tNegativeConfirmationButton1.FlatStyle = FlatStyle.Flat;
            m2tNegativeConfirmationButton1.ForeColor = Color.FromArgb(71, 13, 11);
            m2tNegativeConfirmationButton1.ForeColorType = Enumerations.ColorType.NegativeConfirmationForeground;
            m2tNegativeConfirmationButton1.HoverBackColorType = Enumerations.ColorType.NegativeConfirmationHoverBackground;
            m2tNegativeConfirmationButton1.HoverForeColorType = Enumerations.ColorType.NegativeConfirmationHoverForeground;
            m2tNegativeConfirmationButton1.Location = new Point(23, 135);
            m2tNegativeConfirmationButton1.Name = "m2tNegativeConfirmationButton1";
            m2tNegativeConfirmationButton1.Size = new Size(136, 45);
            m2tNegativeConfirmationButton1.TabIndex = 14;
            m2tNegativeConfirmationButton1.Text = "m2tNegativeConfirmationButton1";
            m2tNegativeConfirmationButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(m2tNegativeConfirmationButton1);
            Controls.Add(m2tPositiveConfirmationButton1);
            Controls.Add(m2tButton1);
            HasImage = false;
            Name = "Form1";
            Text = "Form1";
            Controls.SetChildIndex(m2tButton1, 0);
            Controls.SetChildIndex(m2tPositiveConfirmationButton1, 0);
            Controls.SetChildIndex(m2tNegativeConfirmationButton1, 0);
            ResumeLayout(false);
        }

        #endregion

        private Controls.Inputs.Buttons.M2TButton m2tButton1;
        private Controls.Inputs.Buttons.M2TPositiveConfirmationButton m2tPositiveConfirmationButton1;
        private Controls.Inputs.Buttons.M2TNegativeConfirmationButton m2tNegativeConfirmationButton1;
    }
}