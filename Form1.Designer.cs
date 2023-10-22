namespace DndHelper
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            RandomBtn = new System.Windows.Forms.Button();
            ItemTextBox = new System.Windows.Forms.TextBox();
            TypesComboBox = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // RandomBtn
            // 
            RandomBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RandomBtn.Location = new System.Drawing.Point(698, 354);
            RandomBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            RandomBtn.Size = new System.Drawing.Size(117, 27);
            RandomBtn.TabIndex = 1;
            RandomBtn.Text = "Get Random Item";
            RandomBtn.UseVisualStyleBackColor = true;
            RandomBtn.Click += RandomBtn_Click;
            RandomBtn.KeyPress += RandomBtn_KeyPress;
            // 
            // ItemTextBox
            // 
            ItemTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ItemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ItemTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            ItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemTextBox.Location = new System.Drawing.Point(14, 14);
            ItemTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ItemTextBox.Multiline = true;
            ItemTextBox.Name = "ItemTextBox";
            ItemTextBox.ReadOnly = true;
            ItemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            ItemTextBox.Size = new System.Drawing.Size(905, 334);
            ItemTextBox.TabIndex = 2;
            ItemTextBox.KeyPress += RandomBtn_KeyPress;
            // 
            // TypesComboBox
            // 
            TypesComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TypesComboBox.FormattingEnabled = true;
            TypesComboBox.Location = new System.Drawing.Point(118, 354);
            TypesComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TypesComboBox.Name = "TypesComboBox";
            TypesComboBox.Size = new System.Drawing.Size(572, 23);
            TypesComboBox.TabIndex = 3;
            TypesComboBox.KeyPress += RandomBtn_KeyPress;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(TypesComboBox);
            Controls.Add(ItemTextBox);
            Controls.Add(RandomBtn);
            ForeColor = System.Drawing.SystemColors.InfoText;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainFrm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DnDHelper";
            KeyPress += RandomBtn_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.ComboBox TypesComboBox;
    }
}

