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
            d4TextBox = new System.Windows.Forms.TextBox();
            d6TextBox = new System.Windows.Forms.TextBox();
            d8TextBox = new System.Windows.Forms.TextBox();
            d10TextBox = new System.Windows.Forms.TextBox();
            d12TextBox = new System.Windows.Forms.TextBox();
            d20TextBox = new System.Windows.Forms.TextBox();
            d100TextBox = new System.Windows.Forms.TextBox();
            d4Label = new System.Windows.Forms.Label();
            d6Label = new System.Windows.Forms.Label();
            D8Label = new System.Windows.Forms.Label();
            d10Label = new System.Windows.Forms.Label();
            d12Label = new System.Windows.Forms.Label();
            d20Label = new System.Windows.Forms.Label();
            d100Label = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // RandomBtn
            // 
            RandomBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RandomBtn.Location = new System.Drawing.Point(785, 354);
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
            TypesComboBox.Location = new System.Drawing.Point(205, 354);
            TypesComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TypesComboBox.Name = "TypesComboBox";
            TypesComboBox.Size = new System.Drawing.Size(572, 23);
            TypesComboBox.TabIndex = 3;
            TypesComboBox.KeyPress += RandomBtn_KeyPress;
            // 
            // d4TextBox
            // 
            d4TextBox.Location = new System.Drawing.Point(12, 409);
            d4TextBox.Name = "d4TextBox";
            d4TextBox.Size = new System.Drawing.Size(100, 23);
            d4TextBox.TabIndex = 4;
            // 
            // d6TextBox
            // 
            d6TextBox.Location = new System.Drawing.Point(120, 409);
            d6TextBox.Name = "d6TextBox";
            d6TextBox.Size = new System.Drawing.Size(100, 23);
            d6TextBox.TabIndex = 5;
            // 
            // d8TextBox
            // 
            d8TextBox.Location = new System.Drawing.Point(226, 409);
            d8TextBox.Name = "d8TextBox";
            d8TextBox.Size = new System.Drawing.Size(100, 23);
            d8TextBox.TabIndex = 6;
            // 
            // d10TextBox
            // 
            d10TextBox.Location = new System.Drawing.Point(332, 409);
            d10TextBox.Name = "d10TextBox";
            d10TextBox.Size = new System.Drawing.Size(100, 23);
            d10TextBox.TabIndex = 7;
            // 
            // d12TextBox
            // 
            d12TextBox.Location = new System.Drawing.Point(438, 409);
            d12TextBox.Name = "d12TextBox";
            d12TextBox.Size = new System.Drawing.Size(100, 23);
            d12TextBox.TabIndex = 8;
            // 
            // d20TextBox
            // 
            d20TextBox.Location = new System.Drawing.Point(544, 409);
            d20TextBox.Name = "d20TextBox";
            d20TextBox.Size = new System.Drawing.Size(100, 23);
            d20TextBox.TabIndex = 9;
            // 
            // d100TextBox
            // 
            d100TextBox.Location = new System.Drawing.Point(650, 409);
            d100TextBox.Name = "d100TextBox";
            d100TextBox.Size = new System.Drawing.Size(100, 23);
            d100TextBox.TabIndex = 10;
            // 
            // d4Label
            // 
            d4Label.AutoSize = true;
            d4Label.Location = new System.Drawing.Point(52, 391);
            d4Label.Name = "d4Label";
            d4Label.Size = new System.Drawing.Size(20, 15);
            d4Label.TabIndex = 11;
            d4Label.Text = "d4";
            // 
            // d6Label
            // 
            d6Label.AutoSize = true;
            d6Label.Location = new System.Drawing.Point(160, 391);
            d6Label.Name = "d6Label";
            d6Label.Size = new System.Drawing.Size(20, 15);
            d6Label.TabIndex = 12;
            d6Label.Text = "d6";
            // 
            // D8Label
            // 
            D8Label.AutoSize = true;
            D8Label.Location = new System.Drawing.Point(266, 391);
            D8Label.Name = "D8Label";
            D8Label.Size = new System.Drawing.Size(20, 15);
            D8Label.TabIndex = 13;
            D8Label.Text = "d8";
            // 
            // d10Label
            // 
            d10Label.AutoSize = true;
            d10Label.Location = new System.Drawing.Point(369, 391);
            d10Label.Name = "d10Label";
            d10Label.Size = new System.Drawing.Size(26, 15);
            d10Label.TabIndex = 14;
            d10Label.Text = "d10";
            // 
            // d12Label
            // 
            d12Label.AutoSize = true;
            d12Label.Location = new System.Drawing.Point(475, 391);
            d12Label.Name = "d12Label";
            d12Label.Size = new System.Drawing.Size(26, 15);
            d12Label.TabIndex = 15;
            d12Label.Text = "d12";
            // 
            // d20Label
            // 
            d20Label.AutoSize = true;
            d20Label.Location = new System.Drawing.Point(581, 391);
            d20Label.Name = "d20Label";
            d20Label.Size = new System.Drawing.Size(26, 15);
            d20Label.TabIndex = 16;
            d20Label.Text = "d20";
            // 
            // d100Label
            // 
            d100Label.AutoSize = true;
            d100Label.Location = new System.Drawing.Point(684, 391);
            d100Label.Name = "d100Label";
            d100Label.Size = new System.Drawing.Size(32, 15);
            d100Label.TabIndex = 17;
            d100Label.Text = "d100";
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(d100Label);
            Controls.Add(d20Label);
            Controls.Add(d12Label);
            Controls.Add(d10Label);
            Controls.Add(D8Label);
            Controls.Add(d6Label);
            Controls.Add(d4Label);
            Controls.Add(d100TextBox);
            Controls.Add(d20TextBox);
            Controls.Add(d12TextBox);
            Controls.Add(d10TextBox);
            Controls.Add(d8TextBox);
            Controls.Add(d6TextBox);
            Controls.Add(d4TextBox);
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
        private System.Windows.Forms.TextBox d4TextBox;
        private System.Windows.Forms.TextBox d6TextBox;
        private System.Windows.Forms.TextBox d8TextBox;
        private System.Windows.Forms.TextBox d10TextBox;
        private System.Windows.Forms.TextBox d12TextBox;
        private System.Windows.Forms.TextBox d20TextBox;
        private System.Windows.Forms.TextBox d100TextBox;
        private System.Windows.Forms.Label d4Label;
        private System.Windows.Forms.Label d6Label;
        private System.Windows.Forms.Label D8Label;
        private System.Windows.Forms.Label d10Label;
        private System.Windows.Forms.Label d12Label;
        private System.Windows.Forms.Label d20Label;
        private System.Windows.Forms.Label d100Label;
    }
}

