namespace Encoders
{
    public partial class Form1 : Form
    {
        seguridad encode = new seguridad();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                switch (comboBox1.Text)
                {
                    case "MD5":
                        if (comboBox2.Text == "Text")
                        {
                            Salida.Text = encode.getHashMD5(Entrada.Text).ToLower();
                        }
                        else if (comboBox2.Text == "Archive")
                        {
                            Salida.Text = encode.HashMd5(File.ReadAllBytes(Entrada.Text)).ToLower();
                        }
                        break;
                    case "SHA1":
                        if (comboBox2.Text == "Text")
                        {
                            Salida.Text = encode.getHashSha1(Entrada.Text).ToLower();
                        }
                        else if (comboBox2.Text == "Archive")
                        {
                            Salida.Text = encode.HashSha1(File.ReadAllBytes(Entrada.Text)).ToLower();
                        }
                        break;
                    case "SHA256":
                        Salida.Text = encode.getHashSha256(Entrada.Text).ToLower();
                        if (comboBox2.Text == "Text")
                        {
                            Salida.Text = encode.getHashSha256(Entrada.Text).ToLower();
                        }
                        else if (comboBox2.Text == "Archive")
                        {
                            Salida.Text = encode.HashSha256(File.ReadAllBytes(Entrada.Text)).ToLower();
                        }
                        break;
                    case "SHA384":
                        if (comboBox2.Text == "Text")
                        {
                            Salida.Text = encode.getHashSha384(Entrada.Text).ToLower();
                        }
                        else if (comboBox2.Text == "Archive")
                        {
                            Salida.Text = encode.HashSha384(File.ReadAllBytes(Entrada.Text)).ToLower();
                        }
                        break;
                    case "SHA512":
                        if (comboBox2.Text == "Text")
                        {
                            Salida.Text = encode.getHashSha512(Entrada.Text).ToLower();
                        }
                        else if (comboBox2.Text == "Archive")
                        {
                            Salida.Text = encode.HashSha512(File.ReadAllBytes(Entrada.Text)).ToLower();
                        }
                        break;
                    case "Base64":
                        Salida.Text = encode.Base64String(Entrada.Text);
                        break;
                    case "Unicode":
                        Salida.Text = encode.UnicodeString(Entrada.Text);
                        break;
                    case "UTF7":
                        Salida.Text = encode.UTF7String(Entrada.Text);
                        break;
                    case "UTF8":
                        Salida.Text = encode.UTF8String(Entrada.Text);
                        break;
                    case "UTF32":
                        Salida.Text = encode.UTF32String(Entrada.Text);
                        break;
                    case "TDES":
                        Salida.Text = encode.encriptar(Entrada.Text, Clave.Text);
                        break;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "MD5":
                    ishash(true);
;                    break;
                case "SHA1":
                    ishash(true);
                    break;
                case "SHA256":
                    ishash(true);
                    break;
                case "SHA384":
                    ishash(true);
                    break;
                case "SHA512":
                    ishash(true);
                    break;
                case "Base64":
                    ishash(false);
                    break;
                case "Unicode":
                    ishash(false);
                    break;
                case "UTF7":
                    ishash(false);
                    break;
                case "UTF8":
                    ishash(false);
                    break;
                case "UTF32":
                    ishash(false);
                    break;
                case "TDES":
                    button2.Enabled = true;
                    button1.Enabled = true;
                    Clave.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void ishash(bool bol)
        {
            if (bol)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                Clave.Enabled = false;
                comboBox2.Enabled = true;
                button1.Text = "Hash";
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                Clave.Enabled = false;
                comboBox2.Text = "Text";
                comboBox2.Enabled = false;
                button1.Text = "Encode";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Base64":
                    Salida.Text = encode.getBase64String(Entrada.Text);
                    break;
                case "Unicode":
                    Salida.Text = encode.getUnicodeString(Entrada.Text);
                    break;
                case "UTF7":
                    Salida.Text = encode.getUTF7String(Entrada.Text);
                    break;
                case "UTF8":
                    Salida.Text = encode.getUTF8String(Entrada.Text);
                    break;
                case "UTF32":
                    Salida.Text = encode.getUTF32String(Entrada.Text);
                    break;
                case "TDES":
                    Salida.Text = encode.desencriptar(Entrada.Text, Clave.Text);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (comboBox2.Text == "Text")
                {
                    Entrada.Text = File.ReadAllText(openFileDialog1.FileName);
                }
                else if (comboBox2.Text == "Archive")
                {
                    Entrada.Text = openFileDialog1.FileName;
                }
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Entrada.Text);
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrada.Text += Clipboard.GetText();
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Salida.Text);
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Salida.Text += Clipboard.GetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tmp = Entrada.Text;
            Entrada.Text = Salida.Text;
            Salida.Text = tmp;
        }
    }
}