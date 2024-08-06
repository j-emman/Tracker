namespace Tracker.UserControls
{
    partial class TitleBar
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
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.TitleBarExitButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarLabel
            // 
            this.TitleBarLabel.AutoSize = true;
            this.TitleBarLabel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBarLabel.ForeColor = System.Drawing.Color.White;
            this.TitleBarLabel.Location = new System.Drawing.Point(175, 32);
            this.TitleBarLabel.Name = "TitleBarLabel";
            this.TitleBarLabel.Size = new System.Drawing.Size(231, 37);
            this.TitleBarLabel.TabIndex = 31;
            this.TitleBarLabel.Text = "Project Manager";
            // 
            // TitleBarExitButton
            // 
            this.TitleBarExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleBarExitButton.AutoSize = true;
            this.TitleBarExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TitleBarExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TitleBarExitButton.FlatAppearance.BorderSize = 0;
            this.TitleBarExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarExitButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBarExitButton.ForeColor = System.Drawing.Color.Silver;
            this.TitleBarExitButton.Location = new System.Drawing.Point(872, -1);
            this.TitleBarExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBarExitButton.Name = "TitleBarExitButton";
            this.TitleBarExitButton.Size = new System.Drawing.Size(34, 31);
            this.TitleBarExitButton.TabIndex = 12;
            this.TitleBarExitButton.Text = "X";
            this.TitleBarExitButton.UseVisualStyleBackColor = true;
            this.TitleBarExitButton.Click += new System.EventHandler(this.TitleBarExitButton_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleBarPanel.Controls.Add(this.TitleBarLabel);
            this.titleBarPanel.Controls.Add(this.TitleBarExitButton);
            this.titleBarPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(902, 71);
            this.titleBarPanel.TabIndex = 56;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleBarPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(902, 71);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleBarLabel;
        private System.Windows.Forms.Button TitleBarExitButton;
        private System.Windows.Forms.Panel titleBarPanel;
    }
}
