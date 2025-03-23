namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    partial class ColorRoleVisualisation
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
            LB_ColorRoleName = new Label();
            SuspendLayout();
            // 
            // LB_ColorRoleName
            // 
            LB_ColorRoleName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_ColorRoleName.Location = new Point(9, 9);
            LB_ColorRoleName.Name = "LB_ColorRoleName";
            LB_ColorRoleName.Size = new Size(183, 17);
            LB_ColorRoleName.TabIndex = 0;
            LB_ColorRoleName.Text = "label1";
            // 
            // ColorRoleVisualisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LB_ColorRoleName);
            Name = "ColorRoleVisualisation";
            Size = new Size(200, 35);
            ResumeLayout(false);
        }

        #endregion

        private Label LB_ColorRoleName;
    }
}
