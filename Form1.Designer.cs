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
            panel1 = new System.Windows.Forms.Panel();
            d100ModNumUpDn = new System.Windows.Forms.NumericUpDown();
            d100NumUpDn = new System.Windows.Forms.NumericUpDown();
            d20ModNumUpDn = new System.Windows.Forms.NumericUpDown();
            d20NumUpDn = new System.Windows.Forms.NumericUpDown();
            d12ModNumUpDn = new System.Windows.Forms.NumericUpDown();
            d12NumUpDn = new System.Windows.Forms.NumericUpDown();
            d10ModNumUpDn = new System.Windows.Forms.NumericUpDown();
            d10NumUpDn = new System.Windows.Forms.NumericUpDown();
            d8ModNumUpDn = new System.Windows.Forms.NumericUpDown();
            d8NumUpDn = new System.Windows.Forms.NumericUpDown();
            d6ModNumUpDn = new System.Windows.Forms.NumericUpDown();
            d6NumUpDn = new System.Windows.Forms.NumericUpDown();
            d4ModNumUpDn = new System.Windows.Forms.NumericUpDown();
            d4NumUpDn = new System.Windows.Forms.NumericUpDown();
            ResultTextBox = new System.Windows.Forms.TextBox();
            RollBtn = new System.Windows.Forms.Button();
            d100Label = new System.Windows.Forms.Label();
            d20Label = new System.Windows.Forms.Label();
            d12Label = new System.Windows.Forms.Label();
            d10Label = new System.Windows.Forms.Label();
            d8Label = new System.Windows.Forms.Label();
            d6Label = new System.Windows.Forms.Label();
            d4Label = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)d100ModNumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d100NumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d20ModNumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d20NumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d12ModNumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d12NumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d10ModNumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d10NumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d8ModNumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d8NumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d6ModNumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d6NumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d4ModNumUpDn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)d4NumUpDn).BeginInit();
            SuspendLayout();
            // 
            // RandomBtn
            // 
            RandomBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RandomBtn.Location = new System.Drawing.Point(785, 352);
            RandomBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            RandomBtn.Size = new System.Drawing.Size(117, 27);
            RandomBtn.TabIndex = 2;
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
            ItemTextBox.TabIndex = 0;
            ItemTextBox.TabStop = false;
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
            TypesComboBox.TabIndex = 1;
            TypesComboBox.KeyPress += RandomBtn_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(d100ModNumUpDn);
            panel1.Controls.Add(d100NumUpDn);
            panel1.Controls.Add(d20ModNumUpDn);
            panel1.Controls.Add(d20NumUpDn);
            panel1.Controls.Add(d12ModNumUpDn);
            panel1.Controls.Add(d12NumUpDn);
            panel1.Controls.Add(d10ModNumUpDn);
            panel1.Controls.Add(d10NumUpDn);
            panel1.Controls.Add(d8ModNumUpDn);
            panel1.Controls.Add(d8NumUpDn);
            panel1.Controls.Add(d6ModNumUpDn);
            panel1.Controls.Add(d6NumUpDn);
            panel1.Controls.Add(d4ModNumUpDn);
            panel1.Controls.Add(d4NumUpDn);
            panel1.Controls.Add(ResultTextBox);
            panel1.Controls.Add(RollBtn);
            panel1.Controls.Add(d100Label);
            panel1.Controls.Add(d20Label);
            panel1.Controls.Add(d12Label);
            panel1.Controls.Add(d10Label);
            panel1.Controls.Add(d8Label);
            panel1.Controls.Add(d6Label);
            panel1.Controls.Add(d4Label);
            panel1.Location = new System.Drawing.Point(14, 383);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(888, 128);
            panel1.TabIndex = 3;
            // 
            // d100ModNumUpDn
            // 
            d100ModNumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d100ModNumUpDn.Location = new System.Drawing.Point(740, 28);
            d100ModNumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d100ModNumUpDn.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            d100ModNumUpDn.Name = "d100ModNumUpDn";
            d100ModNumUpDn.Size = new System.Drawing.Size(36, 19);
            d100ModNumUpDn.TabIndex = 46;
            d100ModNumUpDn.ValueChanged += D100NumUpDn_ValueChanged;
            // 
            // d100NumUpDn
            // 
            d100NumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d100NumUpDn.Location = new System.Drawing.Point(701, 28);
            d100NumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d100NumUpDn.Name = "d100NumUpDn";
            d100NumUpDn.Size = new System.Drawing.Size(36, 19);
            d100NumUpDn.TabIndex = 45;
            d100NumUpDn.ValueChanged += D100NumUpDn_ValueChanged;
            // 
            // d20ModNumUpDn
            // 
            d20ModNumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d20ModNumUpDn.Location = new System.Drawing.Point(631, 28);
            d20ModNumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d20ModNumUpDn.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            d20ModNumUpDn.Name = "d20ModNumUpDn";
            d20ModNumUpDn.Size = new System.Drawing.Size(36, 19);
            d20ModNumUpDn.TabIndex = 44;
            d20ModNumUpDn.ValueChanged += D20NumUpDn_ValueChanged;
            // 
            // d20NumUpDn
            // 
            d20NumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d20NumUpDn.Location = new System.Drawing.Point(592, 28);
            d20NumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d20NumUpDn.Name = "d20NumUpDn";
            d20NumUpDn.Size = new System.Drawing.Size(36, 19);
            d20NumUpDn.TabIndex = 43;
            d20NumUpDn.ValueChanged += D20NumUpDn_ValueChanged;
            // 
            // d12ModNumUpDn
            // 
            d12ModNumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d12ModNumUpDn.Location = new System.Drawing.Point(523, 28);
            d12ModNumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d12ModNumUpDn.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            d12ModNumUpDn.Name = "d12ModNumUpDn";
            d12ModNumUpDn.Size = new System.Drawing.Size(36, 19);
            d12ModNumUpDn.TabIndex = 42;
            d12ModNumUpDn.ValueChanged += D12NumUpDn_ValueChanged;
            // 
            // d12NumUpDn
            // 
            d12NumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d12NumUpDn.Location = new System.Drawing.Point(484, 28);
            d12NumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d12NumUpDn.Name = "d12NumUpDn";
            d12NumUpDn.Size = new System.Drawing.Size(36, 19);
            d12NumUpDn.TabIndex = 41;
            d12NumUpDn.ValueChanged += D12NumUpDn_ValueChanged;
            // 
            // d10ModNumUpDn
            // 
            d10ModNumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d10ModNumUpDn.Location = new System.Drawing.Point(414, 28);
            d10ModNumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d10ModNumUpDn.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            d10ModNumUpDn.Name = "d10ModNumUpDn";
            d10ModNumUpDn.Size = new System.Drawing.Size(36, 19);
            d10ModNumUpDn.TabIndex = 40;
            d10ModNumUpDn.ValueChanged += D10NumUpDn_ValueChanged;
            // 
            // d10NumUpDn
            // 
            d10NumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d10NumUpDn.Location = new System.Drawing.Point(375, 28);
            d10NumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d10NumUpDn.Name = "d10NumUpDn";
            d10NumUpDn.Size = new System.Drawing.Size(36, 19);
            d10NumUpDn.TabIndex = 39;
            d10NumUpDn.ValueChanged += D10NumUpDn_ValueChanged;
            // 
            // d8ModNumUpDn
            // 
            d8ModNumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d8ModNumUpDn.Location = new System.Drawing.Point(312, 28);
            d8ModNumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d8ModNumUpDn.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            d8ModNumUpDn.Name = "d8ModNumUpDn";
            d8ModNumUpDn.Size = new System.Drawing.Size(36, 19);
            d8ModNumUpDn.TabIndex = 38;
            d8ModNumUpDn.ValueChanged += D8NumUpDn_VisibleChanged;
            // 
            // d8NumUpDn
            // 
            d8NumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d8NumUpDn.Location = new System.Drawing.Point(273, 28);
            d8NumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d8NumUpDn.Name = "d8NumUpDn";
            d8NumUpDn.Size = new System.Drawing.Size(36, 19);
            d8NumUpDn.TabIndex = 37;
            d8NumUpDn.ValueChanged += D8NumUpDn_VisibleChanged;
            d8NumUpDn.VisibleChanged += D8NumUpDn_VisibleChanged;
            // 
            // d6ModNumUpDn
            // 
            d6ModNumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d6ModNumUpDn.Location = new System.Drawing.Point(211, 28);
            d6ModNumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d6ModNumUpDn.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            d6ModNumUpDn.Name = "d6ModNumUpDn";
            d6ModNumUpDn.Size = new System.Drawing.Size(36, 19);
            d6ModNumUpDn.TabIndex = 36;
            d6ModNumUpDn.ValueChanged += D6NumUpDn_ValueChanged;
            // 
            // d6NumUpDn
            // 
            d6NumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d6NumUpDn.Location = new System.Drawing.Point(172, 28);
            d6NumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d6NumUpDn.Name = "d6NumUpDn";
            d6NumUpDn.Size = new System.Drawing.Size(36, 19);
            d6NumUpDn.TabIndex = 35;
            d6NumUpDn.ValueChanged += D6NumUpDn_ValueChanged;
            // 
            // d4ModNumUpDn
            // 
            d4ModNumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d4ModNumUpDn.Location = new System.Drawing.Point(109, 28);
            d4ModNumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d4ModNumUpDn.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            d4ModNumUpDn.Name = "d4ModNumUpDn";
            d4ModNumUpDn.Size = new System.Drawing.Size(36, 19);
            d4ModNumUpDn.TabIndex = 34;
            d4ModNumUpDn.ValueChanged += D4NumUpDn_ValueChanged;
            // 
            // d4NumUpDn
            // 
            d4NumUpDn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            d4NumUpDn.Location = new System.Drawing.Point(70, 28);
            d4NumUpDn.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            d4NumUpDn.Name = "d4NumUpDn";
            d4NumUpDn.Size = new System.Drawing.Size(36, 19);
            d4NumUpDn.TabIndex = 33;
            d4NumUpDn.ValueChanged += D4NumUpDn_ValueChanged;
            // 
            // ResultTextBox
            // 
            ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ResultTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ResultTextBox.Location = new System.Drawing.Point(70, 66);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new System.Drawing.Size(706, 29);
            ResultTextBox.TabIndex = 32;
            ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RollBtn
            // 
            RollBtn.Location = new System.Drawing.Point(802, 28);
            RollBtn.Name = "RollBtn";
            RollBtn.Size = new System.Drawing.Size(75, 23);
            RollBtn.TabIndex = 31;
            RollBtn.Text = "Roll";
            RollBtn.UseVisualStyleBackColor = true;
            RollBtn.Click += RollBtn_Click;
            // 
            // d100Label
            // 
            d100Label.AutoSize = true;
            d100Label.Location = new System.Drawing.Point(727, 10);
            d100Label.Name = "d100Label";
            d100Label.Size = new System.Drawing.Size(32, 15);
            d100Label.TabIndex = 24;
            d100Label.Text = "d100";
            // 
            // d20Label
            // 
            d20Label.AutoSize = true;
            d20Label.Location = new System.Drawing.Point(619, 10);
            d20Label.Name = "d20Label";
            d20Label.Size = new System.Drawing.Size(26, 15);
            d20Label.TabIndex = 23;
            d20Label.Text = "d20";
            // 
            // d12Label
            // 
            d12Label.AutoSize = true;
            d12Label.Location = new System.Drawing.Point(511, 10);
            d12Label.Name = "d12Label";
            d12Label.Size = new System.Drawing.Size(26, 15);
            d12Label.TabIndex = 22;
            d12Label.Text = "d12";
            // 
            // d10Label
            // 
            d10Label.AutoSize = true;
            d10Label.Location = new System.Drawing.Point(403, 10);
            d10Label.Name = "d10Label";
            d10Label.Size = new System.Drawing.Size(26, 15);
            d10Label.TabIndex = 21;
            d10Label.Text = "d10";
            // 
            // d8Label
            // 
            d8Label.AutoSize = true;
            d8Label.Location = new System.Drawing.Point(301, 10);
            d8Label.Name = "d8Label";
            d8Label.Size = new System.Drawing.Size(20, 15);
            d8Label.TabIndex = 20;
            d8Label.Text = "d8";
            // 
            // d6Label
            // 
            d6Label.AutoSize = true;
            d6Label.Location = new System.Drawing.Point(199, 10);
            d6Label.Name = "d6Label";
            d6Label.Size = new System.Drawing.Size(20, 15);
            d6Label.TabIndex = 19;
            d6Label.Text = "d6";
            // 
            // d4Label
            // 
            d4Label.AutoSize = true;
            d4Label.Location = new System.Drawing.Point(97, 10);
            d4Label.Name = "d4Label";
            d4Label.Size = new System.Drawing.Size(20, 15);
            d4Label.TabIndex = 18;
            d4Label.Text = "d4";
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(panel1);
            Controls.Add(TypesComboBox);
            Controls.Add(ItemTextBox);
            Controls.Add(RandomBtn);
            ForeColor = System.Drawing.SystemColors.InfoText;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainFrm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DnDHelper";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)d100ModNumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d100NumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d20ModNumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d20NumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d12ModNumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d12NumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d10ModNumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d10NumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d8ModNumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d8NumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d6ModNumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d6NumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d4ModNumUpDn).EndInit();
            ((System.ComponentModel.ISupportInitialize)d4NumUpDn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.ComboBox TypesComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label d100Label;
        private System.Windows.Forms.Label d20Label;
        private System.Windows.Forms.Label d12Label;
        private System.Windows.Forms.Label d10Label;
        private System.Windows.Forms.Label d8Label;
        private System.Windows.Forms.Label d6Label;
        private System.Windows.Forms.Label d4Label;
        private System.Windows.Forms.Button RollBtn;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.NumericUpDown d4NumUpDn;
        private System.Windows.Forms.NumericUpDown d4ModNumUpDn;
        private System.Windows.Forms.NumericUpDown d6ModNumUpDn;
        private System.Windows.Forms.NumericUpDown d6NumUpDn;
        private System.Windows.Forms.NumericUpDown d100ModNumUpDn;
        private System.Windows.Forms.NumericUpDown d100NumUpDn;
        private System.Windows.Forms.NumericUpDown d20ModNumUpDn;
        private System.Windows.Forms.NumericUpDown d20NumUpDn;
        private System.Windows.Forms.NumericUpDown d12ModNumUpDn;
        private System.Windows.Forms.NumericUpDown d12NumUpDn;
        private System.Windows.Forms.NumericUpDown d10ModNumUpDn;
        private System.Windows.Forms.NumericUpDown d10NumUpDn;
        private System.Windows.Forms.NumericUpDown d8ModNumUpDn;
        private System.Windows.Forms.NumericUpDown d8NumUpDn;
    }
}

