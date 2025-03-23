namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    partial class ColorSchemeVisualisation
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
            TLP_Main = new TableLayoutPanel();
            TLP_Surface = new TableLayoutPanel();
            CRV_OnSurfaceVariant = new ColorRoleVisualisation();
            CRV_OnSurface = new ColorRoleVisualisation();
            CRV_Surface = new ColorRoleVisualisation();
            TLP_SurfaceContainer = new TableLayoutPanel();
            CRV_SurfaceContainerHighest = new ColorRoleVisualisation();
            CRV_SurfaceContainerHigh = new ColorRoleVisualisation();
            CRV_SurfaceContainer = new ColorRoleVisualisation();
            CRV_SurfaceContainerLow = new ColorRoleVisualisation();
            CRV_SurfaceContainerLowest = new ColorRoleVisualisation();
            CRV_Primary = new ColorRoleWithOnRoleVisualisation();
            CRV_PrimaryContainer = new ColorRoleWithOnRoleVisualisation();
            CRV_Secondary = new ColorRoleWithOnRoleVisualisation();
            CRV_SecondaryContainer = new ColorRoleWithOnRoleVisualisation();
            CRV_Tertiary = new ColorRoleWithOnRoleVisualisation();
            CRV_TertiaryContainer = new ColorRoleWithOnRoleVisualisation();
            CRV_Error = new ColorRoleWithOnRoleVisualisation();
            CRV_ErrorContainer = new ColorRoleWithOnRoleVisualisation();
            TLP_Main.SuspendLayout();
            TLP_Surface.SuspendLayout();
            TLP_SurfaceContainer.SuspendLayout();
            SuspendLayout();
            // 
            // TLP_Main
            // 
            TLP_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.ColumnCount = 4;
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.Controls.Add(CRV_ErrorContainer, 3, 1);
            TLP_Main.Controls.Add(CRV_Error, 3, 0);
            TLP_Main.Controls.Add(CRV_Tertiary, 2, 0);
            TLP_Main.Controls.Add(CRV_Secondary, 1, 0);
            TLP_Main.Controls.Add(TLP_Surface, 0, 2);
            TLP_Main.Controls.Add(TLP_SurfaceContainer, 0, 3);
            TLP_Main.Controls.Add(CRV_Primary, 0, 0);
            TLP_Main.Controls.Add(CRV_PrimaryContainer, 0, 1);
            TLP_Main.Controls.Add(CRV_SecondaryContainer, 1, 1);
            TLP_Main.Controls.Add(CRV_TertiaryContainer, 2, 1);
            TLP_Main.Location = new Point(3, 3);
            TLP_Main.Name = "TLP_Main";
            TLP_Main.RowCount = 4;
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            TLP_Main.Size = new Size(852, 476);
            TLP_Main.TabIndex = 0;
            // 
            // TLP_Surface
            // 
            TLP_Surface.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Surface.ColumnCount = 3;
            TLP_Main.SetColumnSpan(TLP_Surface, 4);
            TLP_Surface.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_Surface.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_Surface.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_Surface.Controls.Add(CRV_OnSurfaceVariant, 2, 0);
            TLP_Surface.Controls.Add(CRV_OnSurface, 1, 0);
            TLP_Surface.Controls.Add(CRV_Surface, 0, 0);
            TLP_Surface.Location = new Point(3, 317);
            TLP_Surface.Name = "TLP_Surface";
            TLP_Surface.RowCount = 1;
            TLP_Surface.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_Surface.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLP_Surface.Size = new Size(846, 74);
            TLP_Surface.TabIndex = 0;
            // 
            // CRV_OnSurfaceVariant
            // 
            CRV_OnSurfaceVariant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_OnSurfaceVariant.BackColor = Color.LightGray;
            CRV_OnSurfaceVariant.Color = Color.LightGray;
            CRV_OnSurfaceVariant.ColorRoleName = "On Surface Variant";
            CRV_OnSurfaceVariant.Location = new Point(565, 3);
            CRV_OnSurfaceVariant.Name = "CRV_OnSurfaceVariant";
            CRV_OnSurfaceVariant.Size = new Size(278, 68);
            CRV_OnSurfaceVariant.TabIndex = 2;
            CRV_OnSurfaceVariant.TextColor = Color.Black;
            // 
            // CRV_OnSurface
            // 
            CRV_OnSurface.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_OnSurface.BackColor = Color.LightGray;
            CRV_OnSurface.Color = Color.LightGray;
            CRV_OnSurface.ColorRoleName = "On Surface";
            CRV_OnSurface.Location = new Point(284, 3);
            CRV_OnSurface.Name = "CRV_OnSurface";
            CRV_OnSurface.Size = new Size(275, 68);
            CRV_OnSurface.TabIndex = 1;
            CRV_OnSurface.TextColor = Color.Black;
            // 
            // CRV_Surface
            // 
            CRV_Surface.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_Surface.BackColor = Color.LightGray;
            CRV_Surface.Color = Color.LightGray;
            CRV_Surface.ColorRoleName = "Surface";
            CRV_Surface.Location = new Point(3, 3);
            CRV_Surface.Name = "CRV_Surface";
            CRV_Surface.Size = new Size(275, 68);
            CRV_Surface.TabIndex = 0;
            CRV_Surface.TextColor = Color.Black;
            // 
            // TLP_SurfaceContainer
            // 
            TLP_SurfaceContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_SurfaceContainer.ColumnCount = 5;
            TLP_Main.SetColumnSpan(TLP_SurfaceContainer, 4);
            TLP_SurfaceContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_SurfaceContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_SurfaceContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_SurfaceContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_SurfaceContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_SurfaceContainer.Controls.Add(CRV_SurfaceContainerHighest, 4, 0);
            TLP_SurfaceContainer.Controls.Add(CRV_SurfaceContainerHigh, 3, 0);
            TLP_SurfaceContainer.Controls.Add(CRV_SurfaceContainer, 2, 0);
            TLP_SurfaceContainer.Controls.Add(CRV_SurfaceContainerLow, 1, 0);
            TLP_SurfaceContainer.Controls.Add(CRV_SurfaceContainerLowest, 0, 0);
            TLP_SurfaceContainer.Location = new Point(3, 397);
            TLP_SurfaceContainer.Name = "TLP_SurfaceContainer";
            TLP_SurfaceContainer.RowCount = 1;
            TLP_SurfaceContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_SurfaceContainer.Size = new Size(846, 76);
            TLP_SurfaceContainer.TabIndex = 1;
            // 
            // CRV_SurfaceContainerHighest
            // 
            CRV_SurfaceContainerHighest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_SurfaceContainerHighest.BackColor = Color.LightGray;
            CRV_SurfaceContainerHighest.Color = Color.LightGray;
            CRV_SurfaceContainerHighest.ColorRoleName = "Surface Container Highest";
            CRV_SurfaceContainerHighest.Location = new Point(679, 3);
            CRV_SurfaceContainerHighest.Name = "CRV_SurfaceContainerHighest";
            CRV_SurfaceContainerHighest.Size = new Size(164, 70);
            CRV_SurfaceContainerHighest.TabIndex = 7;
            CRV_SurfaceContainerHighest.TextColor = Color.Black;
            // 
            // CRV_SurfaceContainerHigh
            // 
            CRV_SurfaceContainerHigh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_SurfaceContainerHigh.BackColor = Color.LightGray;
            CRV_SurfaceContainerHigh.Color = Color.LightGray;
            CRV_SurfaceContainerHigh.ColorRoleName = "Surface Container High";
            CRV_SurfaceContainerHigh.Location = new Point(510, 3);
            CRV_SurfaceContainerHigh.Name = "CRV_SurfaceContainerHigh";
            CRV_SurfaceContainerHigh.Size = new Size(163, 70);
            CRV_SurfaceContainerHigh.TabIndex = 6;
            CRV_SurfaceContainerHigh.TextColor = Color.Black;
            // 
            // CRV_SurfaceContainer
            // 
            CRV_SurfaceContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_SurfaceContainer.BackColor = Color.LightGray;
            CRV_SurfaceContainer.Color = Color.LightGray;
            CRV_SurfaceContainer.ColorRoleName = "Surface Container";
            CRV_SurfaceContainer.Location = new Point(341, 3);
            CRV_SurfaceContainer.Name = "CRV_SurfaceContainer";
            CRV_SurfaceContainer.Size = new Size(163, 70);
            CRV_SurfaceContainer.TabIndex = 5;
            CRV_SurfaceContainer.TextColor = Color.Black;
            // 
            // CRV_SurfaceContainerLow
            // 
            CRV_SurfaceContainerLow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_SurfaceContainerLow.BackColor = Color.LightGray;
            CRV_SurfaceContainerLow.Color = Color.LightGray;
            CRV_SurfaceContainerLow.ColorRoleName = "Surface Container Low";
            CRV_SurfaceContainerLow.Location = new Point(172, 3);
            CRV_SurfaceContainerLow.Name = "CRV_SurfaceContainerLow";
            CRV_SurfaceContainerLow.Size = new Size(163, 70);
            CRV_SurfaceContainerLow.TabIndex = 4;
            CRV_SurfaceContainerLow.TextColor = Color.Black;
            // 
            // CRV_SurfaceContainerLowest
            // 
            CRV_SurfaceContainerLowest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_SurfaceContainerLowest.BackColor = Color.LightGray;
            CRV_SurfaceContainerLowest.Color = Color.LightGray;
            CRV_SurfaceContainerLowest.ColorRoleName = "Surface Container Lowest";
            CRV_SurfaceContainerLowest.Location = new Point(3, 3);
            CRV_SurfaceContainerLowest.Name = "CRV_SurfaceContainerLowest";
            CRV_SurfaceContainerLowest.Size = new Size(163, 70);
            CRV_SurfaceContainerLowest.TabIndex = 3;
            CRV_SurfaceContainerLowest.TextColor = Color.Black;
            // 
            // CRV_Primary
            // 
            CRV_Primary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_Primary.Color = Color.LightGray;
            CRV_Primary.ColorRoleName = "Primary";
            CRV_Primary.Location = new Point(3, 3);
            CRV_Primary.Name = "CRV_Primary";
            CRV_Primary.OnColor = Color.Black;
            CRV_Primary.Size = new Size(207, 151);
            CRV_Primary.TabIndex = 4;
            // 
            // CRV_PrimaryContainer
            // 
            CRV_PrimaryContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_PrimaryContainer.Color = Color.LightGray;
            CRV_PrimaryContainer.ColorRoleName = "Primary Container";
            CRV_PrimaryContainer.Location = new Point(3, 160);
            CRV_PrimaryContainer.Name = "CRV_PrimaryContainer";
            CRV_PrimaryContainer.OnColor = Color.Black;
            CRV_PrimaryContainer.Size = new Size(207, 151);
            CRV_PrimaryContainer.TabIndex = 5;
            // 
            // CRV_Secondary
            // 
            CRV_Secondary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_Secondary.Color = Color.LightGray;
            CRV_Secondary.ColorRoleName = "Secondary";
            CRV_Secondary.Location = new Point(216, 3);
            CRV_Secondary.Name = "CRV_Secondary";
            CRV_Secondary.OnColor = Color.Black;
            CRV_Secondary.Size = new Size(207, 151);
            CRV_Secondary.TabIndex = 6;
            // 
            // CRV_SecondaryContainer
            // 
            CRV_SecondaryContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_SecondaryContainer.Color = Color.LightGray;
            CRV_SecondaryContainer.ColorRoleName = "Secondary";
            CRV_SecondaryContainer.Location = new Point(216, 160);
            CRV_SecondaryContainer.Name = "CRV_SecondaryContainer";
            CRV_SecondaryContainer.OnColor = Color.Black;
            CRV_SecondaryContainer.Size = new Size(207, 151);
            CRV_SecondaryContainer.TabIndex = 7;
            // 
            // CRV_Tertiary
            // 
            CRV_Tertiary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_Tertiary.Color = Color.LightGray;
            CRV_Tertiary.ColorRoleName = "Tertiary";
            CRV_Tertiary.Location = new Point(429, 3);
            CRV_Tertiary.Name = "CRV_Tertiary";
            CRV_Tertiary.OnColor = Color.Black;
            CRV_Tertiary.Size = new Size(207, 151);
            CRV_Tertiary.TabIndex = 8;
            // 
            // CRV_TertiaryContainer
            // 
            CRV_TertiaryContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_TertiaryContainer.Color = Color.LightGray;
            CRV_TertiaryContainer.ColorRoleName = "Tertiary Container";
            CRV_TertiaryContainer.Location = new Point(429, 160);
            CRV_TertiaryContainer.Name = "CRV_TertiaryContainer";
            CRV_TertiaryContainer.OnColor = Color.Black;
            CRV_TertiaryContainer.Size = new Size(207, 151);
            CRV_TertiaryContainer.TabIndex = 9;
            // 
            // CRV_Error
            // 
            CRV_Error.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_Error.Color = Color.LightGray;
            CRV_Error.ColorRoleName = "Error";
            CRV_Error.Location = new Point(642, 3);
            CRV_Error.Name = "CRV_Error";
            CRV_Error.OnColor = Color.Black;
            CRV_Error.Size = new Size(207, 151);
            CRV_Error.TabIndex = 10;
            // 
            // CRV_ErrorContainer
            // 
            CRV_ErrorContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CRV_ErrorContainer.Color = Color.LightGray;
            CRV_ErrorContainer.ColorRoleName = "Error Container";
            CRV_ErrorContainer.Location = new Point(642, 160);
            CRV_ErrorContainer.Name = "CRV_ErrorContainer";
            CRV_ErrorContainer.OnColor = Color.Black;
            CRV_ErrorContainer.Size = new Size(207, 151);
            CRV_ErrorContainer.TabIndex = 11;
            // 
            // ColorSchemeVisualisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TLP_Main);
            Name = "ColorSchemeVisualisation";
            Size = new Size(858, 482);
            TLP_Main.ResumeLayout(false);
            TLP_Surface.ResumeLayout(false);
            TLP_SurfaceContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Main;
        private TableLayoutPanel TLP_Surface;
        private TableLayoutPanel TLP_SurfaceContainer;
        private ColorRoleVisualisation CRV_OnSurfaceVariant;
        private ColorRoleVisualisation CRV_OnSurface;
        private ColorRoleVisualisation CRV_Surface;
        private ColorRoleVisualisation CRV_SurfaceContainerHighest;
        private ColorRoleVisualisation CRV_SurfaceContainerHigh;
        private ColorRoleVisualisation CRV_SurfaceContainer;
        private ColorRoleVisualisation CRV_SurfaceContainerLow;
        private ColorRoleVisualisation CRV_SurfaceContainerLowest;
        private ColorRoleWithOnRoleVisualisation CRV_Primary;
        private ColorRoleWithOnRoleVisualisation CRV_ErrorContainer;
        private ColorRoleWithOnRoleVisualisation CRV_Error;
        private ColorRoleWithOnRoleVisualisation CRV_Tertiary;
        private ColorRoleWithOnRoleVisualisation CRV_Secondary;
        private ColorRoleWithOnRoleVisualisation CRV_PrimaryContainer;
        private ColorRoleWithOnRoleVisualisation CRV_SecondaryContainer;
        private ColorRoleWithOnRoleVisualisation CRV_TertiaryContainer;
    }
}
