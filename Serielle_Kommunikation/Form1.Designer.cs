
namespace Serielle_Kommunikation
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cBox_COM_PORT = new System.Windows.Forms.ComboBox();
            this.cBox_BAUD = new System.Windows.Forms.ComboBox();
            this.COM_PORT = new System.Windows.Forms.Label();
            this.BAUD = new System.Windows.Forms.Label();
            this.button_OPEN = new System.Windows.Forms.Button();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox_SEND_DATA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1_DATA_IN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBox_COM_PORT
            // 
            this.cBox_COM_PORT.FormattingEnabled = true;
            this.cBox_COM_PORT.Location = new System.Drawing.Point(108, 12);
            this.cBox_COM_PORT.Name = "cBox_COM_PORT";
            this.cBox_COM_PORT.Size = new System.Drawing.Size(121, 21);
            this.cBox_COM_PORT.TabIndex = 1;
            // 
            // cBox_BAUD
            // 
            this.cBox_BAUD.FormattingEnabled = true;
            this.cBox_BAUD.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cBox_BAUD.Location = new System.Drawing.Point(322, 12);
            this.cBox_BAUD.Name = "cBox_BAUD";
            this.cBox_BAUD.Size = new System.Drawing.Size(121, 21);
            this.cBox_BAUD.TabIndex = 2;
            // 
            // COM_PORT
            // 
            this.COM_PORT.AutoSize = true;
            this.COM_PORT.Location = new System.Drawing.Point(35, 15);
            this.COM_PORT.Name = "COM_PORT";
            this.COM_PORT.Size = new System.Drawing.Size(67, 13);
            this.COM_PORT.TabIndex = 4;
            this.COM_PORT.Text = "COM_PORT";
            // 
            // BAUD
            // 
            this.BAUD.AutoSize = true;
            this.BAUD.Location = new System.Drawing.Point(263, 15);
            this.BAUD.Name = "BAUD";
            this.BAUD.Size = new System.Drawing.Size(37, 13);
            this.BAUD.TabIndex = 5;
            this.BAUD.Text = "BAUD";
            // 
            // button_OPEN
            // 
            this.button_OPEN.Location = new System.Drawing.Point(481, 15);
            this.button_OPEN.Name = "button_OPEN";
            this.button_OPEN.Size = new System.Drawing.Size(75, 23);
            this.button_OPEN.TabIndex = 6;
            this.button_OPEN.Text = "OPEN";
            this.button_OPEN.UseVisualStyleBackColor = true;
            this.button_OPEN.Click += new System.EventHandler(this.button_OPEN_Click);
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.Location = new System.Drawing.Point(562, 15);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(75, 23);
            this.button_CLOSE.TabIndex = 7;
            this.button_CLOSE.Text = "CLOSE";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "SEND";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox_SEND_DATA
            // 
            this.textBox_SEND_DATA.Location = new System.Drawing.Point(0, 33);
            this.textBox_SEND_DATA.Name = "textBox_SEND_DATA";
            this.textBox_SEND_DATA.Size = new System.Drawing.Size(107, 20);
            this.textBox_SEND_DATA.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_SEND_DATA);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(48, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 122);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1_DATA_IN
            // 
            this.textBox1_DATA_IN.Location = new System.Drawing.Point(28, 39);
            this.textBox1_DATA_IN.Name = "textBox1_DATA_IN";
            this.textBox1_DATA_IN.Size = new System.Drawing.Size(127, 20);
            this.textBox1_DATA_IN.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1_DATA_IN);
            this.groupBox1.Location = new System.Drawing.Point(356, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 122);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_CLOSE);
            this.Controls.Add(this.button_OPEN);
            this.Controls.Add(this.BAUD);
            this.Controls.Add(this.COM_PORT);
            this.Controls.Add(this.cBox_BAUD);
            this.Controls.Add(this.cBox_COM_PORT);
            this.Name = "Form1";
            this.Text = "Serielle Kommunikation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBox_COM_PORT;
        private System.Windows.Forms.ComboBox cBox_BAUD;
        private System.Windows.Forms.Label COM_PORT;
        private System.Windows.Forms.Label BAUD;
        private System.Windows.Forms.Button button_OPEN;
        private System.Windows.Forms.Button button_CLOSE;
        private System.Windows.Forms.Button button3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox_SEND_DATA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1_DATA_IN;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

