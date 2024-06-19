using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EncryptorRevamp
{
    public partial class MainForm : Form
    {
        string key, output;
        string[] langEN = {
            "Key:",
            "Submit",
            "Input:",
            "Encrypt",
            "Decrypt",
            "Output:"
        };
        string[] langRU = {
            "Код:", // Key
            "Выбрать", // Submit
            "Входной:", // Input
            "Кодировать", // Encode
            "Декодировать", // Decode
            "Результатов:" // Output
        };


        public MainForm()
        {
            InitializeComponent();
        }

        private void keySubmit_Click(object sender, EventArgs e)
        {
            key = keyInput.Text;
            keyInput.Text = "";
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string[] data = { textInput.Text, key };
            textInput.Text = "";
            Encryption enc = new Encryption(data);
            output = enc.GetOutput();
            outputBox.Text = output;
            Util.Copy(output, true);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string[] data = { textInput.Text, key };
            textInput.Text = "";
            Decryption enc = new Decryption(data);
            output = enc.GetOutput();
            outputBox.Text = output;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keyLabel.Text = langEN[0];
            keySubmit.Text = langEN[1];
            inputLabel.Text = langEN[2];
            encryptButton.Text = langEN[3];
            decryptButton.Text = langEN[4];
            outputLabel.Text = langEN[5];
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keyLabel.Text = langRU[0];
            keySubmit.Text = langRU[1];
            inputLabel.Text = langRU[2];
            encryptButton.Text = langRU[3];
            decryptButton.Text = langRU[4];
            outputLabel.Text = langRU[5];
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
