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
            outputClearBtn = new Button();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // keyInput
            // 
            keyInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyInput.Location = new Point(48, 32);
            keyInput.Margin = new Padding(3, 2, 3, 2);
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(252, 23);
            keyInput.TabIndex = 0;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(0, 35);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(29, 15);
            keyLabel.TabIndex = 1;
            keyLabel.Text = "Key:";
            // 
            // keySubmit
            // 
            keySubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keySubmit.Location = new Point(304, 32);
            keySubmit.Margin = new Padding(3, 2, 3, 2);
            keySubmit.Name = "keySubmit";
            keySubmit.Size = new Size(60, 24);
            keySubmit.TabIndex = 2;
            keySubmit.Text = "Submit";
            keySubmit.UseVisualStyleBackColor = true;
            keySubmit.Click += keySubmit_Click;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(0, 63);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(38, 15);
            inputLabel.TabIndex = 3;
            inputLabel.Text = "Input:";
            // 
            // textInput
            // 
            textInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textInput.Location = new Point(48, 60);
            textInput.Margin = new Padding(3, 2, 3, 2);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new Size(316, 212);
            textInput.TabIndex = 4;
            // 
            // encryptButton
            // 
            encryptButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            encryptButton.Location = new Point(48, 276);
            encryptButton.Margin = new Padding(3, 2, 3, 2);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(156, 22);
            encryptButton.TabIndex = 5;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            decryptButton.Location = new Point(209, 276);
            decryptButton.Margin = new Padding(3, 2, 3, 2);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(155, 22);
            decryptButton.TabIndex = 6;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(0, 307);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(48, 15);
            outputLabel.TabIndex = 7;
            outputLabel.Text = "Output:";
            // 
            // outputBox
            // 
            outputBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputBox.Location = new Point(48, 304);
            outputBox.Margin = new Padding(3, 2, 3, 2);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(316, 306);
            outputBox.TabIndex = 8;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(375, 24);
            menuStrip.TabIndex = 9;
            menuStrip.Text = "menuStrip";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englisToolStripMenuItem, русскийToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(71, 20);
            languageToolStripMenuItem.Text = "Language";
            // 
            // englisToolStripMenuItem
            // 
            englisToolStripMenuItem.Name = "englisToolStripMenuItem";
            englisToolStripMenuItem.Size = new Size(119, 22);
            englisToolStripMenuItem.Text = "English";
            englisToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // русскийToolStripMenuItem
            // 
            русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            русскийToolStripMenuItem.Size = new Size(119, 22);
            русскийToolStripMenuItem.Text = "Русский";
            русскийToolStripMenuItem.Click += русскийToolStripMenuItem_Click;
            // 
            // outputClearBtn
            // 
            outputClearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputClearBtn.Location = new Point(48, 615);
            outputClearBtn.Name = "outputClearBtn";
            outputClearBtn.Size = new Size(316, 23);
            outputClearBtn.TabIndex = 10;
            outputClearBtn.Text = "Clear Output";
            outputClearBtn.UseVisualStyleBackColor = true;
            outputClearBtn.Click += outputClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(375, 642);
            Controls.Add(outputClearBtn);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button outputClearBtn;
    }
}
