namespace SecHex_GUI
{
    partial class Spoofy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spoofy));
            req = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            spoofall = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            backup = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            systemcleaner = new MetroFramework.Controls.MetroCheckBox();
            logwind = new MetroFramework.Controls.MetroCheckBox();
            label1 = new Label();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            autostart = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            SuspendLayout();
            // 
            // req
            // 
            req.Animated = true;
            req.AutoRoundedCorners = true;
            req.BackColor = Color.Transparent;
            req.BorderColor = Color.White;
            req.BorderRadius = 20;
            req.BorderThickness = 1;
            req.CustomBorderColor = Color.Transparent;
            req.CustomizableEdges.BottomLeft = false;
            req.CustomizableEdges.BottomRight = false;
            req.CustomizableEdges.TopLeft = false;
            req.CustomizableEdges.TopRight = false;
            req.DisabledState.BorderColor = Color.DarkGray;
            req.DisabledState.CustomBorderColor = Color.DarkGray;
            req.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            req.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            req.FillColor = Color.Transparent;
            req.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            req.ForeColor = Color.White;
            req.Location = new Point(14, 165);
            req.Margin = new Padding(5, 4, 5, 4);
            req.Name = "req";
            req.PressedDepth = 60;
            req.Size = new Size(552, 42);
            req.TabIndex = 11;
            req.Text = "SYSTEM CHECKS";
            req.Click += req_Click;
            // 
            // spoofall
            // 
            spoofall.Animated = true;
            spoofall.AutoRoundedCorners = true;
            spoofall.BackColor = Color.Transparent;
            spoofall.BorderColor = Color.White;
            spoofall.BorderRadius = 20;
            spoofall.BorderThickness = 1;
            spoofall.CustomBorderColor = Color.Transparent;
            spoofall.CustomizableEdges.BottomLeft = false;
            spoofall.CustomizableEdges.BottomRight = false;
            spoofall.CustomizableEdges.TopLeft = false;
            spoofall.CustomizableEdges.TopRight = false;
            spoofall.DisabledState.BorderColor = Color.DarkGray;
            spoofall.DisabledState.CustomBorderColor = Color.DarkGray;
            spoofall.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            spoofall.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            spoofall.FillColor = Color.Transparent;
            spoofall.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            spoofall.ForeColor = Color.White;
            spoofall.Location = new Point(14, 211);
            spoofall.Margin = new Padding(5, 4, 5, 4);
            spoofall.Name = "spoofall";
            spoofall.PressedDepth = 60;
            spoofall.Size = new Size(552, 42);
            spoofall.TabIndex = 17;
            spoofall.Text = "SPOOF";
            spoofall.Click += spoofall_Click;
            // 
            // backup
            // 
            backup.Animated = true;
            backup.AutoRoundedCorners = true;
            backup.BackColor = Color.Transparent;
            backup.BorderColor = Color.White;
            backup.BorderRadius = 20;
            backup.BorderThickness = 1;
            backup.CustomBorderColor = Color.Transparent;
            backup.CustomizableEdges.BottomLeft = false;
            backup.CustomizableEdges.BottomRight = false;
            backup.CustomizableEdges.TopLeft = false;
            backup.CustomizableEdges.TopRight = false;
            backup.DisabledState.BorderColor = Color.DarkGray;
            backup.DisabledState.CustomBorderColor = Color.DarkGray;
            backup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            backup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            backup.FillColor = Color.Transparent;
            backup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backup.ForeColor = Color.White;
            backup.Location = new Point(14, 118);
            backup.Margin = new Padding(5, 4, 5, 4);
            backup.Name = "backup";
            backup.PressedDepth = 60;
            backup.Size = new Size(552, 42);
            backup.TabIndex = 19;
            backup.Text = "BACKUP";
            backup.Click += backup_Click;
            // 
            // systemcleaner
            // 
            systemcleaner.AutoSize = true;
            systemcleaner.Location = new Point(14, 286);
            systemcleaner.Margin = new Padding(5, 4, 5, 4);
            systemcleaner.Name = "systemcleaner";
            systemcleaner.Size = new Size(105, 15);
            systemcleaner.Style = MetroFramework.MetroColorStyle.Purple;
            systemcleaner.TabIndex = 33;
            systemcleaner.Text = "CLEAN SYSTEM";
            systemcleaner.Theme = MetroFramework.MetroThemeStyle.Dark;
            systemcleaner.UseVisualStyleBackColor = true;
            systemcleaner.CheckedChanged += systemcleaner_CheckedChanged;
            // 
            // logwind
            // 
            logwind.AutoSize = true;
            logwind.Location = new Point(14, 312);
            logwind.Margin = new Padding(5, 4, 5, 4);
            logwind.Name = "logwind";
            logwind.Size = new Size(52, 15);
            logwind.Style = MetroFramework.MetroColorStyle.Purple;
            logwind.TabIndex = 34;
            logwind.Text = "LOGS";
            logwind.Theme = MetroFramework.MetroThemeStyle.Dark;
            logwind.UseVisualStyleBackColor = true;
            logwind.CheckedChanged += logwind_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(408, 282);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 38;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.ForeColor = SystemColors.Control;
            metroLabel1.Location = new Point(408, 311);
            metroLabel1.Margin = new Padding(5, 0, 5, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(86, 19);
            metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            metroLabel1.TabIndex = 41;
            metroLabel1.Text = "AUTO-START";
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // autostart
            // 
            autostart.Animated = true;
            autostart.CheckedState.BorderColor = Color.Purple;
            autostart.CheckedState.BorderRadius = 0;
            autostart.CheckedState.BorderThickness = 1;
            autostart.CheckedState.FillColor = Color.FromArgb(23, 23, 23);
            autostart.CheckedState.InnerBorderColor = Color.White;
            autostart.CheckedState.InnerBorderRadius = 0;
            autostart.CheckedState.InnerColor = Color.White;
            autostart.CustomizableEdges.BottomLeft = false;
            autostart.CustomizableEdges.BottomRight = false;
            autostart.CustomizableEdges.TopLeft = false;
            autostart.CustomizableEdges.TopRight = false;
            autostart.Location = new Point(515, 312);
            autostart.Margin = new Padding(5, 4, 5, 4);
            autostart.Name = "autostart";
            autostart.ShadowDecoration.BorderRadius = 9;
            autostart.ShadowDecoration.Color = Color.Azure;
            autostart.Size = new Size(42, 21);
            autostart.TabIndex = 40;
            autostart.UncheckedState.BorderColor = Color.White;
            autostart.UncheckedState.BorderRadius = 0;
            autostart.UncheckedState.BorderThickness = 1;
            autostart.UncheckedState.FillColor = Color.FromArgb(23, 23, 23);
            autostart.UncheckedState.InnerBorderColor = Color.White;
            autostart.UncheckedState.InnerBorderRadius = 0;
            autostart.UncheckedState.InnerColor = Color.White;
            autostart.CheckedChanged += autostart_CheckedChanged;
            // 
            // Spoofy
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(584, 363);
            Controls.Add(metroLabel1);
            Controls.Add(autostart);
            Controls.Add(label1);
            Controls.Add(logwind);
            Controls.Add(systemcleaner);
            Controls.Add(backup);
            Controls.Add(spoofall);
            Controls.Add(req);
            Cursor = Cursors.PanNW;
            Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Spoofy";
            Padding = new Padding(23, 76, 23, 25);
            Resizable = false;
            RightToLeft = RightToLeft.No;
            //ShadowType = MetroFormShadowType.DropShadow;
            Style = MetroFramework.MetroColorStyle.Purple;
            Text = "SPOOFIE";
            //TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton req;
        private Siticone.Desktop.UI.WinForms.SiticoneButton spoofall;
        private Siticone.Desktop.UI.WinForms.SiticoneButton backup;
        private MetroFramework.Controls.MetroCheckBox systemcleaner;
        private MetroFramework.Controls.MetroCheckBox logwind;
        private Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch autostart;
    }
}