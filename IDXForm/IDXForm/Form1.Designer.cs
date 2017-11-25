namespace IDXForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Main = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.progressLabel1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.encryptImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.formatComboEncrypt = new System.Windows.Forms.ComboBox();
            this.protectionGB = new System.Windows.Forms.GroupBox();
            this.protectionRB = new System.Windows.Forms.RadioButton();
            this.normalRB = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rgbEncryptRB = new System.Windows.Forms.RadioButton();
            this.grayEncryptRB = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.widthTextBoxEncrypt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.heightTextBoxEncrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.destFolderButtonEncrypt = new System.Windows.Forms.Button();
            this.destTextBox2 = new System.Windows.Forms.TextBox();
            this.openImageBtn = new System.Windows.Forms.Button();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.decryptImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.formatTextBox = new System.Windows.Forms.TextBox();
            this.magicTextBox = new System.Windows.Forms.TextBox();
            this.magicLabel = new System.Windows.Forms.Label();
            this.quantTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.grayRadio = new System.Windows.Forms.RadioButton();
            this.rgbRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.OFDbutton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.destFolderButton = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.extButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.aboutRichBox = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.encryptRichBox = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.decryptRichBox = new System.Windows.Forms.RichTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.finalLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.infoRichBox = new System.Windows.Forms.RichTextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.protectionGB.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decryptImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.infoGroup.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabPage2);
            this.Main.Controls.Add(this.tabPage1);
            this.Main.Controls.Add(this.tabPage3);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(564, 593);
            this.Main.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.cancelBtn);
            this.tabPage2.Controls.Add(this.encryptButton);
            this.tabPage2.Controls.Add(this.progressLabel1);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.destFolderButtonEncrypt);
            this.tabPage2.Controls.Add(this.destTextBox2);
            this.tabPage2.Controls.Add(this.openImageBtn);
            this.tabPage2.Controls.Add(this.imageTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encrypt";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(405, 522);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(71, 522);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 26;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // progressLabel1
            // 
            this.progressLabel1.AutoSize = true;
            this.progressLabel1.Location = new System.Drawing.Point(69, 491);
            this.progressLabel1.Name = "progressLabel1";
            this.progressLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressLabel1.Size = new System.Drawing.Size(0, 13);
            this.progressLabel1.TabIndex = 25;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 455);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(443, 22);
            this.progressBar1.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.encryptImage);
            this.groupBox2.Location = new System.Drawing.Point(224, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 274);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // encryptImage
            // 
            this.encryptImage.Image = ((System.Drawing.Image)(resources.GetObject("encryptImage.Image")));
            this.encryptImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("encryptImage.InitialImage")));
            this.encryptImage.Location = new System.Drawing.Point(6, 11);
            this.encryptImage.Name = "encryptImage";
            this.encryptImage.Size = new System.Drawing.Size(312, 257);
            this.encryptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.encryptImage.TabIndex = 22;
            this.encryptImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.formatComboEncrypt);
            this.groupBox1.Controls.Add(this.protectionGB);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.widthTextBoxEncrypt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.heightTextBoxEncrypt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 274);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // formatComboEncrypt
            // 
            this.formatComboEncrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboEncrypt.FormattingEnabled = true;
            this.formatComboEncrypt.Items.AddRange(new object[] {
            "Dotcode File(*.code)",
            "Other Binary File(*.*)"});
            this.formatComboEncrypt.Location = new System.Drawing.Point(59, 27);
            this.formatComboEncrypt.Name = "formatComboEncrypt";
            this.formatComboEncrypt.Size = new System.Drawing.Size(122, 21);
            this.formatComboEncrypt.TabIndex = 25;
            this.formatComboEncrypt.SelectedIndexChanged += new System.EventHandler(this.formatComboEncrypt_SelectedIndexChanged);
            // 
            // protectionGB
            // 
            this.protectionGB.Controls.Add(this.protectionRB);
            this.protectionGB.Controls.Add(this.normalRB);
            this.protectionGB.Location = new System.Drawing.Point(59, 196);
            this.protectionGB.Name = "protectionGB";
            this.protectionGB.Size = new System.Drawing.Size(94, 60);
            this.protectionGB.TabIndex = 24;
            this.protectionGB.TabStop = false;
            // 
            // protectionRB
            // 
            this.protectionRB.AutoSize = true;
            this.protectionRB.Checked = true;
            this.protectionRB.Location = new System.Drawing.Point(11, 10);
            this.protectionRB.Name = "protectionRB";
            this.protectionRB.Size = new System.Drawing.Size(61, 17);
            this.protectionRB.TabIndex = 16;
            this.protectionRB.TabStop = true;
            this.protectionRB.Text = "Encrypt";
            this.protectionRB.UseVisualStyleBackColor = true;
            // 
            // normalRB
            // 
            this.normalRB.AutoSize = true;
            this.normalRB.Location = new System.Drawing.Point(11, 37);
            this.normalRB.Name = "normalRB";
            this.normalRB.Size = new System.Drawing.Size(58, 17);
            this.normalRB.TabIndex = 17;
            this.normalRB.Text = "Normal";
            this.normalRB.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rgbEncryptRB);
            this.groupBox5.Controls.Add(this.grayEncryptRB);
            this.groupBox5.Location = new System.Drawing.Point(59, 127);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(94, 60);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // rgbEncryptRB
            // 
            this.rgbEncryptRB.AutoSize = true;
            this.rgbEncryptRB.Checked = true;
            this.rgbEncryptRB.Location = new System.Drawing.Point(11, 10);
            this.rgbEncryptRB.Name = "rgbEncryptRB";
            this.rgbEncryptRB.Size = new System.Drawing.Size(48, 17);
            this.rgbEncryptRB.TabIndex = 16;
            this.rgbEncryptRB.TabStop = true;
            this.rgbEncryptRB.Text = "RGB";
            this.rgbEncryptRB.UseVisualStyleBackColor = true;
            // 
            // grayEncryptRB
            // 
            this.grayEncryptRB.AutoSize = true;
            this.grayEncryptRB.Location = new System.Drawing.Point(11, 37);
            this.grayEncryptRB.Name = "grayEncryptRB";
            this.grayEncryptRB.Size = new System.Drawing.Size(72, 17);
            this.grayEncryptRB.TabIndex = 17;
            this.grayEncryptRB.Text = "Grayscale";
            this.grayEncryptRB.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Protection";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Width";
            // 
            // widthTextBoxEncrypt
            // 
            this.widthTextBoxEncrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.widthTextBoxEncrypt.Location = new System.Drawing.Point(59, 101);
            this.widthTextBoxEncrypt.Name = "widthTextBoxEncrypt";
            this.widthTextBoxEncrypt.Size = new System.Drawing.Size(122, 20);
            this.widthTextBoxEncrypt.TabIndex = 13;
            this.widthTextBoxEncrypt.Tag = "in pix";
            this.widthTextBoxEncrypt.Text = "in pix";
            this.widthTextBoxEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Height:";
            // 
            // heightTextBoxEncrypt
            // 
            this.heightTextBoxEncrypt.Location = new System.Drawing.Point(59, 66);
            this.heightTextBoxEncrypt.Name = "heightTextBoxEncrypt";
            this.heightTextBoxEncrypt.Size = new System.Drawing.Size(122, 20);
            this.heightTextBoxEncrypt.TabIndex = 11;
            this.heightTextBoxEncrypt.Tag = "in pix";
            this.heightTextBoxEncrypt.Text = "in pix";
            this.heightTextBoxEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Format";
            // 
            // destFolderButtonEncrypt
            // 
            this.destFolderButtonEncrypt.Location = new System.Drawing.Point(6, 84);
            this.destFolderButtonEncrypt.Name = "destFolderButtonEncrypt";
            this.destFolderButtonEncrypt.Size = new System.Drawing.Size(96, 23);
            this.destFolderButtonEncrypt.TabIndex = 19;
            this.destFolderButtonEncrypt.Text = "Destination";
            this.destFolderButtonEncrypt.UseVisualStyleBackColor = true;
            this.destFolderButtonEncrypt.Click += new System.EventHandler(this.destFolderButtonEncrypt_Click);
            // 
            // destTextBox2
            // 
            this.destTextBox2.Location = new System.Drawing.Point(134, 86);
            this.destTextBox2.Name = "destTextBox2";
            this.destTextBox2.Size = new System.Drawing.Size(408, 20);
            this.destTextBox2.TabIndex = 20;
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(6, 30);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(96, 23);
            this.openImageBtn.TabIndex = 17;
            this.openImageBtn.Text = "Open Image";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(134, 33);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(408, 20);
            this.imageTextBox.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.infoGroup);
            this.tabPage1.Controls.Add(this.OFDbutton);
            this.tabPage1.Controls.Add(this.progressLabel);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.destFolderButton);
            this.tabPage1.Controls.Add(this.fileBox);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.destTextBox);
            this.tabPage1.Controls.Add(this.extButton);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decrypt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.decryptImage);
            this.groupBox4.Location = new System.Drawing.Point(225, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 273);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preview";
            // 
            // decryptImage
            // 
            this.decryptImage.Image = ((System.Drawing.Image)(resources.GetObject("decryptImage.Image")));
            this.decryptImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("decryptImage.InitialImage")));
            this.decryptImage.Location = new System.Drawing.Point(6, 12);
            this.decryptImage.Name = "decryptImage";
            this.decryptImage.Size = new System.Drawing.Size(311, 255);
            this.decryptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.decryptImage.TabIndex = 22;
            this.decryptImage.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.formatTextBox);
            this.groupBox3.Controls.Add(this.magicTextBox);
            this.groupBox3.Controls.Add(this.magicLabel);
            this.groupBox3.Controls.Add(this.quantTextBox);
            this.groupBox3.Controls.Add(this.quantityLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 122);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Format";
            // 
            // formatTextBox
            // 
            this.formatTextBox.Location = new System.Drawing.Point(67, 25);
            this.formatTextBox.Name = "formatTextBox";
            this.formatTextBox.Size = new System.Drawing.Size(113, 20);
            this.formatTextBox.TabIndex = 6;
            // 
            // magicTextBox
            // 
            this.magicTextBox.Location = new System.Drawing.Point(66, 88);
            this.magicTextBox.Name = "magicTextBox";
            this.magicTextBox.Size = new System.Drawing.Size(114, 20);
            this.magicTextBox.TabIndex = 5;
            this.magicTextBox.Text = "1";
            this.magicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // magicLabel
            // 
            this.magicLabel.AutoSize = true;
            this.magicLabel.Location = new System.Drawing.Point(7, 90);
            this.magicLabel.Name = "magicLabel";
            this.magicLabel.Size = new System.Drawing.Size(53, 13);
            this.magicLabel.TabIndex = 4;
            this.magicLabel.Text = "Magic No";
            // 
            // quantTextBox
            // 
            this.quantTextBox.Location = new System.Drawing.Point(68, 55);
            this.quantTextBox.Name = "quantTextBox";
            this.quantTextBox.Size = new System.Drawing.Size(112, 20);
            this.quantTextBox.TabIndex = 3;
            this.quantTextBox.Tag = "1";
            this.quantTextBox.Text = "1";
            this.quantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(14, 59);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Format";
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.grayRadio);
            this.infoGroup.Controls.Add(this.rgbRadio);
            this.infoGroup.Controls.Add(this.label3);
            this.infoGroup.Controls.Add(this.label2);
            this.infoGroup.Controls.Add(this.widthTextBox);
            this.infoGroup.Controls.Add(this.label1);
            this.infoGroup.Controls.Add(this.heightTextBox);
            this.infoGroup.Location = new System.Drawing.Point(8, 272);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(195, 143);
            this.infoGroup.TabIndex = 23;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Image Info";
            // 
            // grayRadio
            // 
            this.grayRadio.AutoSize = true;
            this.grayRadio.Checked = true;
            this.grayRadio.Location = new System.Drawing.Point(66, 120);
            this.grayRadio.Name = "grayRadio";
            this.grayRadio.Size = new System.Drawing.Size(72, 17);
            this.grayRadio.TabIndex = 15;
            this.grayRadio.TabStop = true;
            this.grayRadio.Text = "Grayscale";
            this.grayRadio.UseVisualStyleBackColor = true;
            // 
            // rgbRadio
            // 
            this.rgbRadio.AutoSize = true;
            this.rgbRadio.Location = new System.Drawing.Point(66, 94);
            this.rgbRadio.Name = "rgbRadio";
            this.rgbRadio.Size = new System.Drawing.Size(48, 17);
            this.rgbRadio.TabIndex = 14;
            this.rgbRadio.Text = "RGB";
            this.rgbRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.widthTextBox.Location = new System.Drawing.Point(64, 60);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(114, 20);
            this.widthTextBox.TabIndex = 11;
            this.widthTextBox.Tag = "in pix";
            this.widthTextBox.Text = "in pix";
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(64, 27);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(114, 20);
            this.heightTextBox.TabIndex = 9;
            this.heightTextBox.Tag = "in pix";
            this.heightTextBox.Text = "in pix";
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OFDbutton
            // 
            this.OFDbutton.Location = new System.Drawing.Point(6, 30);
            this.OFDbutton.Name = "OFDbutton";
            this.OFDbutton.Size = new System.Drawing.Size(96, 23);
            this.OFDbutton.TabIndex = 15;
            this.OFDbutton.Text = "Open File";
            this.OFDbutton.UseVisualStyleBackColor = true;
            this.OFDbutton.Click += new System.EventHandler(this.OFDbutton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(69, 491);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 21;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(405, 522);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // destFolderButton
            // 
            this.destFolderButton.Location = new System.Drawing.Point(6, 84);
            this.destFolderButton.Name = "destFolderButton";
            this.destFolderButton.Size = new System.Drawing.Size(96, 23);
            this.destFolderButton.TabIndex = 17;
            this.destFolderButton.Text = "Extract To";
            this.destFolderButton.UseVisualStyleBackColor = true;
            this.destFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(134, 33);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(408, 20);
            this.fileBox.TabIndex = 16;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(50, 455);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(443, 22);
            this.progressBar.TabIndex = 20;
            // 
            // destTextBox
            // 
            this.destTextBox.Location = new System.Drawing.Point(134, 86);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(408, 20);
            this.destTextBox.TabIndex = 18;
            // 
            // extButton
            // 
            this.extButton.Location = new System.Drawing.Point(71, 522);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(75, 23);
            this.extButton.TabIndex = 19;
            this.extButton.Text = "Extract";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Font = new System.Drawing.Font("abeatbyKai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(556, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Glegoo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 385);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.aboutRichBox);
            this.tabPage4.Font = new System.Drawing.Font("Glegoo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(542, 351);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // aboutRichBox
            // 
            this.aboutRichBox.Font = new System.Drawing.Font("Glegoo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutRichBox.Location = new System.Drawing.Point(0, 1);
            this.aboutRichBox.Name = "aboutRichBox";
            this.aboutRichBox.ReadOnly = true;
            this.aboutRichBox.Size = new System.Drawing.Size(542, 341);
            this.aboutRichBox.TabIndex = 1;
            this.aboutRichBox.Text = resources.GetString("aboutRichBox.Text");
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.encryptRichBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(542, 351);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Encrypt";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // encryptRichBox
            // 
            this.encryptRichBox.Location = new System.Drawing.Point(0, 1);
            this.encryptRichBox.Name = "encryptRichBox";
            this.encryptRichBox.ReadOnly = true;
            this.encryptRichBox.Size = new System.Drawing.Size(542, 341);
            this.encryptRichBox.TabIndex = 2;
            this.encryptRichBox.Text = resources.GetString("encryptRichBox.Text");
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.decryptRichBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(542, 351);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Decrypt";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // decryptRichBox
            // 
            this.decryptRichBox.Location = new System.Drawing.Point(0, 1);
            this.decryptRichBox.Name = "decryptRichBox";
            this.decryptRichBox.ReadOnly = true;
            this.decryptRichBox.Size = new System.Drawing.Size(542, 341);
            this.decryptRichBox.TabIndex = 3;
            this.decryptRichBox.Text = resources.GetString("decryptRichBox.Text");
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.infoGroupBox);
            this.tabPage7.Controls.Add(this.groupBox6);
            this.tabPage7.Controls.Add(this.infoLabel);
            this.tabPage7.Location = new System.Drawing.Point(4, 30);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(542, 351);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "DotCode";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.finalLabel);
            this.infoGroupBox.Controls.Add(this.label10);
            this.infoGroupBox.Font = new System.Drawing.Font("Glegoo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(47, 251);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(452, 74);
            this.infoGroupBox.TabIndex = 7;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Remember Folks";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Glegoo", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(125, 30);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(209, 28);
            this.finalLabel.TabIndex = 1;
            this.finalLabel.Text = "Everything Starts From A .";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.infoRichBox);
            this.groupBox6.Location = new System.Drawing.Point(22, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(500, 156);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Info";
            // 
            // infoRichBox
            // 
            this.infoRichBox.BackColor = System.Drawing.SystemColors.Control;
            this.infoRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRichBox.Font = new System.Drawing.Font("Glegoo", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoRichBox.Location = new System.Drawing.Point(102, 26);
            this.infoRichBox.Name = "infoRichBox";
            this.infoRichBox.ReadOnly = true;
            this.infoRichBox.Size = new System.Drawing.Size(365, 117);
            this.infoRichBox.TabIndex = 0;
            this.infoRichBox.Text = "     Version:  1.0.2\n  Company:  DotCode\nWritten By:  Himanshu Singh\n        Emai" +
    "l:  himanshuspykid96@gmail.com\nContact us:  https://www.facebook.com/Dot0Code/";
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.infoLabel.Font = new System.Drawing.Font("Glegoo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(43, 181);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(456, 58);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "We are open to any suggestions and advises.  Drop us a message if you want to sha" +
    "re your opinion or have any query.\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(564, 593);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = ".Dot DeCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.encryptImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.protectionGB.ResumeLayout(false);
            this.protectionGB.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.decryptImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox formatTextBox;
        private System.Windows.Forms.TextBox magicTextBox;
        private System.Windows.Forms.Label magicLabel;
        private System.Windows.Forms.TextBox quantTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.RadioButton grayRadio;
        private System.Windows.Forms.RadioButton rgbRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button OFDbutton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button destFolderButton;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox destTextBox;
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button destFolderButtonEncrypt;
        private System.Windows.Forms.TextBox destTextBox2;
        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox heightTextBoxEncrypt;
        private System.Windows.Forms.RadioButton grayEncryptRB;
        private System.Windows.Forms.RadioButton rgbEncryptRB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox widthTextBoxEncrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox protectionGB;
        private System.Windows.Forms.RadioButton protectionRB;
        private System.Windows.Forms.RadioButton normalRB;
        private System.Windows.Forms.Label progressLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox formatComboEncrypt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.PictureBox decryptImage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox aboutRichBox;
        private System.Windows.Forms.RichTextBox encryptRichBox;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox decryptRichBox;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox infoRichBox;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.PictureBox encryptImage;
    }
}

