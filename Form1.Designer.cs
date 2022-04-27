namespace TwilioApp
{
    partial class Send
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send));
            this.load = new System.Windows.Forms.Button();
            this.sendSMS = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.responseTXT = new System.Windows.Forms.TextBox();
            this.responseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(339, 710);
            this.load.Margin = new System.Windows.Forms.Padding(4);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(170, 55);
            this.load.TabIndex = 0;
            this.load.Text = "Cargar Lista JSON";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // sendSMS
            // 
            this.sendSMS.Location = new System.Drawing.Point(990, 710);
            this.sendSMS.Margin = new System.Windows.Forms.Padding(4);
            this.sendSMS.Name = "sendSMS";
            this.sendSMS.Size = new System.Drawing.Size(170, 55);
            this.sendSMS.TabIndex = 1;
            this.sendSMS.Text = "Enviar SMS";
            this.sendSMS.UseVisualStyleBackColor = true;
            this.sendSMS.Click += new System.EventHandler(this.sendSMS_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.White;
            this.message.ForeColor = System.Drawing.Color.Black;
            this.message.Location = new System.Drawing.Point(533, 454);
            this.message.Margin = new System.Windows.Forms.Padding(4);
            this.message.MaxLength = 500;
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(627, 248);
            this.message.TabIndex = 2;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.list.Location = new System.Drawing.Point(46, 192);
            this.list.Margin = new System.Windows.Forms.Padding(4);
            this.list.Multiline = true;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.list.Size = new System.Drawing.Size(463, 510);
            this.list.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(533, 192);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(627, 202);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "[\r\n    {\r\n      \"Phone\": \"+5804126927187\",\r\n      \"Name\": \"Carlos Vilchez\"\r\n    }" +
    ",\r\n    {\r\n      \"Phone\": \"+5804126927187\",\r\n      \"Name\": \"Carlos Vilchez\"\r\n    " +
    "}\r\n]\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listado de números:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ejemplo del formato JSON esperado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mensaje:";
            // 
            // loading
            // 
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(1108, 13);
            this.loading.Margin = new System.Windows.Forms.Padding(4);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(64, 64);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loading.TabIndex = 9;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // responseTXT
            // 
            this.responseTXT.BackColor = System.Drawing.Color.Black;
            this.responseTXT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.responseTXT.ForeColor = System.Drawing.Color.White;
            this.responseTXT.Location = new System.Drawing.Point(473, 13);
            this.responseTXT.Margin = new System.Windows.Forms.Padding(4);
            this.responseTXT.MaxLength = 500;
            this.responseTXT.Multiline = true;
            this.responseTXT.Name = "responseTXT";
            this.responseTXT.ReadOnly = true;
            this.responseTXT.Size = new System.Drawing.Size(627, 64);
            this.responseTXT.TabIndex = 10;
            this.responseTXT.Visible = false;
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.responseLabel.Location = new System.Drawing.Point(385, 36);
            this.responseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(90, 19);
            this.responseLabel.TabIndex = 11;
            this.responseLabel.Text = "Response:";
            this.responseLabel.Visible = false;
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 796);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.responseTXT);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.message);
            this.Controls.Add(this.sendSMS);
            this.Controls.Add(this.load);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Send";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS with TWILIO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button load;
        private Button sendSMS;
        private TextBox message;
        private TextBox list;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog;
        private PictureBox loading;
        private TextBox responseTXT;
        private Label responseLabel;
    }
}