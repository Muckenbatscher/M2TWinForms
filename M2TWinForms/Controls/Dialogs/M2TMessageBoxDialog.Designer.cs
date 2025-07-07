namespace M2TWinForms
{
    partial class M2TMessageBoxDialog
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
            TLP_Main = new TableLayoutPanel();
            LB_Message = new M2TLabel();
            PN_Buttons = new M2TPanel();
            m2tButton3 = new M2TButton();
            m2tButton1 = new M2TButton();
            m2tButton2 = new M2TButton();
            TLP_Main.SuspendLayout();
            PN_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // TLP_Main
            // 
            TLP_Main.AutoSize = true;
            TLP_Main.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TLP_Main.ColumnCount = 1;
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLP_Main.Controls.Add(LB_Message, 0, 0);
            TLP_Main.Controls.Add(PN_Buttons, 0, 1);
            TLP_Main.Location = new Point(5, 42);
            TLP_Main.Name = "TLP_Main";
            TLP_Main.RowCount = 2;
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLP_Main.Size = new Size(284, 95);
            TLP_Main.TabIndex = 14;
            // 
            // LB_Message
            // 
            LB_Message.AutoSize = true;
            LB_Message.Location = new Point(3, 0);
            LB_Message.MaximumSize = new Size(300, 0);
            LB_Message.Name = "LB_Message";
            LB_Message.Padding = new Padding(0, 15, 0, 15);
            LB_Message.Size = new Size(278, 60);
            LB_Message.TabIndex = 0;
            LB_Message.Text = "Some arbitrary MessageText that would commonly \r\nappear in a MessageBox.";
            // 
            // PN_Buttons
            // 
            PN_Buttons.Controls.Add(m2tButton3);
            PN_Buttons.Controls.Add(m2tButton1);
            PN_Buttons.Controls.Add(m2tButton2);
            PN_Buttons.Dock = DockStyle.Fill;
            PN_Buttons.Location = new Point(0, 60);
            PN_Buttons.Margin = new Padding(0);
            PN_Buttons.Name = "PN_Buttons";
            PN_Buttons.Size = new Size(284, 35);
            PN_Buttons.TabIndex = 1;
            // 
            // m2tButton3
            // 
            m2tButton3.ColorRole = M2TButtonColorRoleSelection.SurfaceContainer;
            m2tButton3.Location = new Point(44, 3);
            m2tButton3.Name = "m2tButton3";
            m2tButton3.Size = new Size(75, 29);
            m2tButton3.TabIndex = 3;
            m2tButton3.Text = "m2tButton3";
            // 
            // m2tButton1
            // 
            m2tButton1.ColorRole = M2TButtonColorRoleSelection.Primary;
            m2tButton1.Location = new Point(206, 3);
            m2tButton1.Name = "m2tButton1";
            m2tButton1.Size = new Size(75, 29);
            m2tButton1.TabIndex = 1;
            m2tButton1.Text = "m2tButton1";
            // 
            // m2tButton2
            // 
            m2tButton2.ColorRole = M2TButtonColorRoleSelection.SurfaceContainer;
            m2tButton2.Location = new Point(125, 3);
            m2tButton2.Name = "m2tButton2";
            m2tButton2.Size = new Size(75, 29);
            m2tButton2.TabIndex = 2;
            m2tButton2.Text = "m2tButton2";
            // 
            // M2TMessageBoxDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CanMaximize = false;
            CanMinimize = false;
            ClientSize = new Size(327, 203);
            Controls.Add(TLP_Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "M2TMessageBoxDialog";
            Text = "M2TMessageBox";
            Controls.SetChildIndex(TLP_Main, 0);
            TLP_Main.ResumeLayout(false);
            TLP_Main.PerformLayout();
            PN_Buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TLP_Main;
        private M2TLabel LB_Message;
        private M2TButton m2tButton2;
        private M2TButton m2tButton1;
        private M2TPanel PN_Buttons;
        private M2TButton m2tButton3;
    }
}