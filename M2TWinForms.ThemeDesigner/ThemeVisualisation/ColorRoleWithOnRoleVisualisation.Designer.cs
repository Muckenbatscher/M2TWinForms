namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    partial class ColorRoleWithOnRoleVisualisation
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
            TLP_Roles = new TableLayoutPanel();
            CRV_ColorRole = new ColorRoleVisualisation();
            CRV_OnColorRole = new ColorRoleVisualisation();
            TLP_Roles.SuspendLayout();
            SuspendLayout();
            // 
            // TLP_Roles
            // 
            TLP_Roles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Roles.ColumnCount = 1;
            TLP_Roles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLP_Roles.Controls.Add(CRV_ColorRole, 0, 0);
            TLP_Roles.Controls.Add(CRV_OnColorRole, 0, 1);
            TLP_Roles.Location = new Point(0, 0);
            TLP_Roles.Margin = new Padding(0);
            TLP_Roles.Name = "TLP_Roles";
            TLP_Roles.RowCount = 2;
            TLP_Roles.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            TLP_Roles.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            TLP_Roles.Size = new Size(200, 102);
            TLP_Roles.TabIndex = 0;
            // 
            // CRV_ColorRole
            // 
            CRV_ColorRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_ColorRole.BackColor = Color.LightGray;
            CRV_ColorRole.Color = Color.LightGray;
            CRV_ColorRole.ColorRoleName = "Color Role";
            CRV_ColorRole.Location = new Point(1, 1);
            CRV_ColorRole.Margin = new Padding(1);
            CRV_ColorRole.Name = "CRV_ColorRole";
            CRV_ColorRole.Size = new Size(198, 59);
            CRV_ColorRole.TabIndex = 0;
            CRV_ColorRole.TextColor = Color.Black;
            // 
            // CRV_OnColorRole
            // 
            CRV_OnColorRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_OnColorRole.BackColor = Color.Black;
            CRV_OnColorRole.Color = Color.Black;
            CRV_OnColorRole.ColorRoleName = "On Color Role";
            CRV_OnColorRole.Location = new Point(1, 62);
            CRV_OnColorRole.Margin = new Padding(1);
            CRV_OnColorRole.Name = "CRV_OnColorRole";
            CRV_OnColorRole.Size = new Size(198, 39);
            CRV_OnColorRole.TabIndex = 1;
            CRV_OnColorRole.TextColor = Color.LightGray;
            // 
            // ColorRoleWithOnRoleVisualisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TLP_Roles);
            Name = "ColorRoleWithOnRoleVisualisation";
            Size = new Size(200, 102);
            TLP_Roles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Roles;
        private ColorRoleVisualisation CRV_ColorRole;
        private ColorRoleVisualisation CRV_OnColorRole;
    }
}
