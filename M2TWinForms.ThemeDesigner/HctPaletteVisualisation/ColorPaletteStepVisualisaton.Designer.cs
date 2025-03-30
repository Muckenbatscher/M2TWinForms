namespace M2TWinForms.ThemeDesigner.HctPaletteVisualisation
{
    partial class ColorPaletteStepVisualisaton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LB_StepName = new Label();
            LB_StepColor = new Label();
            SuspendLayout();
            // 
            // LB_StepName
            // 
            LB_StepName.AutoSize = true;
            LB_StepName.Location = new Point(3, 10);
            LB_StepName.Name = "LB_StepName";
            LB_StepName.Size = new Size(38, 15);
            LB_StepName.TabIndex = 0;
            LB_StepName.Text = "label1";
            // 
            // LB_StepColor
            // 
            LB_StepColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LB_StepColor.AutoSize = true;
            LB_StepColor.Location = new Point(3, 100);
            LB_StepColor.Name = "LB_StepColor";
            LB_StepColor.Size = new Size(38, 15);
            LB_StepColor.TabIndex = 1;
            LB_StepColor.Text = "label1";
            // 
            // ColorPaletteStepVisualisaton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LB_StepColor);
            Controls.Add(LB_StepName);
            Name = "ColorPaletteStepVisualisaton";
            Size = new Size(152, 127);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB_StepName;
        private Label LB_StepColor;
    }
}
