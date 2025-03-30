namespace M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection
{
    partial class Selection<I, T>
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
            LB_SelectionPrompt = new Label();
            CB_Selection = new ComboBox();
            TLP_Main.SuspendLayout();
            SuspendLayout();
            // 
            // TLP_Main
            // 
            TLP_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.ColumnCount = 2;
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Main.Controls.Add(LB_SelectionPrompt, 0, 0);
            TLP_Main.Controls.Add(CB_Selection, 1, 0);
            TLP_Main.Location = new Point(0, 0);
            TLP_Main.Name = "TLP_Main";
            TLP_Main.RowCount = 1;
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLP_Main.Size = new Size(500, 40);
            TLP_Main.TabIndex = 0;
            // 
            // LB_SelectionPrompt
            // 
            LB_SelectionPrompt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LB_SelectionPrompt.AutoSize = true;
            LB_SelectionPrompt.Location = new Point(0, 10);
            LB_SelectionPrompt.Name = "LB_SelectionPrompt";
            LB_SelectionPrompt.Size = new Size(243, 15);
            LB_SelectionPrompt.TabIndex = 0;
            LB_SelectionPrompt.Text = "label1";
            LB_SelectionPrompt.Margin = new Padding(0);
            // 
            // CB_Selection
            // 
            CB_Selection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CB_Selection.FormattingEnabled = true;
            CB_Selection.Location = new Point(252, 6);
            CB_Selection.Name = "CB_Selection";
            CB_Selection.Size = new Size(244, 23);
            CB_Selection.TabIndex = 1;
            CB_Selection.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Selection.Margin = new Padding(0);
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TLP_Main);
            Name = "Selection";
            Size = new Size(500, 40);
            TLP_Main.ResumeLayout(false);
            TLP_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Main;
        private Label LB_SelectionPrompt;
        private ComboBox CB_Selection;
    }
}
