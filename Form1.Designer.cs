namespace Encoders
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Salida = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Entrada = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salida
            // 
            this.Salida.ContextMenuStrip = this.contextMenuStrip2;
            this.Salida.Location = new System.Drawing.Point(12, 281);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(776, 161);
            this.Salida.TabIndex = 0;
            this.Salida.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem1,
            this.pegarToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(110, 48);
            // 
            // copiarToolStripMenuItem1
            // 
            this.copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            this.copiarToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.copiarToolStripMenuItem1.Text = "Copiar";
            this.copiarToolStripMenuItem1.Click += new System.EventHandler(this.copiarToolStripMenuItem1_Click);
            // 
            // pegarToolStripMenuItem1
            // 
            this.pegarToolStripMenuItem1.Name = "pegarToolStripMenuItem1";
            this.pegarToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.pegarToolStripMenuItem1.Text = "Pegar";
            this.pegarToolStripMenuItem1.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click);
            // 
            // Entrada
            // 
            this.Entrada.ContextMenuStrip = this.contextMenuStrip1;
            this.Entrada.Location = new System.Drawing.Point(12, 85);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(776, 141);
            this.Entrada.TabIndex = 0;
            this.Entrada.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "SHA256",
            "SHA384",
            "MD5"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "Base64",
            "Unicode",
            "UTF7",
            "UTF8",
            "UTF32",
            "TDES"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "MD5";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(350, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Decode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clave
            // 
            this.Clave.Location = new System.Drawing.Point(12, 56);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(776, 23);
            this.Clave.TabIndex = 4;
            this.Clave.Text = "escribe tu clave aca!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clave";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(688, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "SHA256",
            "SHA384",
            "MD5"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Text",
            "Archive"});
            this.comboBox2.Location = new System.Drawing.Point(431, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Text";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(776, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "<-\r\n->";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Salida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox Salida;
        private RichTextBox Entrada;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox Clave;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem copiarToolStripMenuItem1;
        private ToolStripMenuItem pegarToolStripMenuItem1;
        private ComboBox comboBox2;
        private Button button4;
    }
}