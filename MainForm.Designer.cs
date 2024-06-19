namespace EncryptorRevamp
{
    partial class MainForm
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
            keyInput = new TextBox();
            keyLabel = new Label();
            keySubmit = new Button();
            inputLabel = new Label();
            textInput = new TextBox();
            encryptButton = new Button();
            decryptButton = new Button();
            outputLabel = new Label();
            outputBox = new TextBox();
            menuStrip = new MenuStrip();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englisToolStripMenuItem = new ToolStripMenuItem();
            русскийToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // keyInput
            // 
            keyInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyInput.Location = new Point(72, 43);
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(287, 27);
            keyInput.TabIndex = 0;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(12, 46);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(36, 20);
            keyLabel.TabIndex = 1;
            keyLabel.Text = "Key:";
            // 
            // keySubmit
            // 
            keySubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keySubmit.Location = new Point(365, 43);
            keySubmit.Name = "keySubmit";
            keySubmit.Size = new Size(68, 27);
            keySubmit.TabIndex = 2;
            keySubmit.Text = "Submit";
            keySubmit.UseVisualStyleBackColor = true;
            keySubmit.Click += keySubmit_Click;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(12, 83);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(46, 20);
            inputLabel.TabIndex = 3;
            inputLabel.Text = "Input:";
            // 
            // textInput
            // 
            textInput.Anchor = AnchorStyles.Right;
            textInput.Location = new Point(72, 80);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new Size(361, 282);
            textInput.TabIndex = 4;
            // 
            // encryptButton
            // 
            encryptButton.Anchor = AnchorStyles.Right;
            encryptButton.Location = new Point(72, 368);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(178, 29);
            encryptButton.TabIndex = 5;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Anchor = AnchorStyles.Right;
            decryptButton.Location = new Point(256, 368);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(177, 29);
            decryptButton.TabIndex = 6;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(8, 409);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(58, 20);
            outputLabel.TabIndex = 7;
            outputLabel.Text = "Output:";
            // 
            // outputBox
            // 
            outputBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputBox.Location = new Point(72, 406);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(361, 406);
            outputBox.TabIndex = 8;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(446, 28);
            menuStrip.TabIndex = 9;
            menuStrip.Text = "menuStrip";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englisToolStripMenuItem, русскийToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(88, 24);
            languageToolStripMenuItem.Text = "Language";
            // 
            // englisToolStripMenuItem
            // 
            englisToolStripMenuItem.Name = "englisToolStripMenuItem";
            englisToolStripMenuItem.Size = new Size(146, 26);
            englisToolStripMenuItem.Text = "English";
            englisToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // русскийToolStripMenuItem
            // 
            русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            русскийToolStripMenuItem.Size = new Size(146, 26);
            русскийToolStripMenuItem.Text = "Русский";
            русскийToolStripMenuItem.Click += русскийToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(446, 826);
            Controls.Add(outputBox);
            Controls.Add(outputLabel);
            Controls.Add(decryptButton);
            Controls.Add(encryptButton);
            Controls.Add(textInput);
            Controls.Add(inputLabel);
            Controls.Add(keySubmit);
            Controls.Add(keyLabel);
            Controls.Add(keyInput);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Encryptor GUI";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox keyInput;
        private Label keyLabel;
        private Button keySubmit;
        private Label inputLabel;
        private TextBox textInput;
        private Button encryptButton;
        private Button decryptButton;
        private Label outputLabel;
        private TextBox outputBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englisToolStripMenuItem;
        private ToolStripMenuItem русскийToolStripMenuItem;
    }
}
