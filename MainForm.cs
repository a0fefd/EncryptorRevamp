using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EncryptorRevamp
{
    public partial class MainForm : Form
    {
        [AllowNull]
        string key, output;
        Size defaultSize;
        readonly string[] langEN = {
            "Key:",
            "Submit",
            "Input:",
            "Encrypt",
            "Decrypt",
            "Output:",
            "Clear Output"
        };
        readonly string[] langRU = {
            "Код:", // Key
            "Выбрать", // Submit
            "Входной:", // Input
            "Кодировать", // Encode
            "Декодировать", // Decode
            "Результатов:", // Output
            "Удалять текст" // Remove Text
        };
        readonly string[] langNL = {
            "Sleutel:",
            "Voorleggen",
            "Invoer:",
            "Versleutelen",
            "Ontcijferen",
            "Uitvoer:",
            "Duidelijk Uitvoer"
        };

        public MainForm()
        {
            InitializeComponent();
            defaultSize = Size;
        }

        private void keySubmit_Click(object sender, EventArgs e)
        {
            key = keyInput.Text;
            keyInput.Text = "";
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string[] data = { textInput.Text, key };
            if (textInput.Text == "")
            {
                data[0] = outputBox.Text;
            }
            textInput.Text = "";
            Encryption enc = new Encryption(data);
            output = enc.GetOutput();
            outputBox.Text = output;
            Util.Copy(output, true);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string[] data = { textInput.Text, key };
            if (textInput.Text == "")
            {
                data[0] = outputBox.Text;
            }
            textInput.Text = "";
            Decryption enc = new Decryption(data);
            output = enc.GetOutput();
            outputBox.Text = output;
        }

        private void outputClear_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = defaultSize;

            keyLabel.Text = langEN[0];
            keySubmit.Text = langEN[1];
            inputLabel.Text = langEN[2];
            encryptButton.Text = langEN[3];
            decryptButton.Text = langEN[4];
            outputLabel.Text = langEN[5];
            outputClearBtn.Text = langEN[6];
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(defaultSize.Width + 30, defaultSize.Height);

            keyLabel.Text = langRU[0];
            keySubmit.Text = langRU[1];
            inputLabel.Text = langRU[2];
            encryptButton.Text = langRU[3];
            decryptButton.Text = langRU[4];
            outputLabel.Text = langRU[5];
            outputClearBtn.Text = langRU[6];
        }

        private void nederlandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = defaultSize;

            keyLabel.Text = langNL[0];
            keySubmit.Text = langNL[1];
            inputLabel.Text = langNL[2];
            encryptButton.Text = langNL[3];
            decryptButton.Text = langNL[4];
            outputLabel.Text = langNL[5];
            outputClearBtn.Text = langNL[6];
        }
    }
    public class Encryption
    {
        private string output;

        private static string Stage1(string str, string key)
        {
            return Util.XOR(str, key);
        }
        private static string Stage2(string str)
        {
            return Util.StringToHex(str);
        }
        private static string Stage3(string str)
        {
            return Util.Base64Encode(str);
        }
        public Encryption(string[] data)
        {
            output = Stage3(
                Stage2(
                    Stage1(data[0], data[1])
                )
            );
        }
        public string GetOutput()
        {
            return output;
        }
    }
    public class Decryption
    {
        private string output;

        private static string Stage1(string str)
        {
            return Util.Base64Decode(str);
        }
        private static string Stage2(string str)
        {
            return Util.HexToString(str);
        }
        private static string Stage3(string str, string key)
        {
            return Util.XOR(str, key);
        }
        public Decryption(string[] data)
        {
            this.output = Stage3(
                Stage2(
                    Stage1(data[0])
                ), data[1]
            );
        }
        public string GetOutput()
        {
            return output;
        }
    }
}
