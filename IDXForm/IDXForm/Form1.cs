using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;


namespace IDXForm
{
    public partial class Form1 : Form
    {
        //DECRYPTER
        string mainFile;
        string mainFolder;
        string extension;
        int totalImages;
        int width;
        int height;
        int magicNumber;
        int extractIndex = 0;
        bool invalidData = false;
        Bitmap cloneDecrypt;
        BinaryReader binReader;
        string fileName;
        bool rgbDecryptBool;
        byte[] pixBytesHeader;
        byte[] pixBytesDecrypt;
        byte[] pixBytesDecrypt2;
        int protectionDecrypt;

        //ENCRYPTER
        Bitmap mainImageEncrypt;
        string mainFolderEncrypt;
        int widthEncrypt;
        int heightEncrypt;
        int totalImagesEncrypt;
        byte[] pixBytes;
        byte[] pixBytesTester;
        string imageName;
        bool rgbEncryptBool;
        bool invalidDataEncrypt = false;
        int encryptIndex = 0;
        string keyEncrypt;
        bool codeFormatEncrypt = false;

        string IV;
        Cryptography.Generic crypt;


        /*
         * Function     - InitializeFonts
         *                Called from Form1() and Form1(string s) constructors.
         *                
         * The Fonts(Glegoo) used in Help tab are not True Fonts, and hence are needed to
         * be accessed from the Resources Folder. 
         */
        Font myFont;
        Font myFont2;
        Font myFont3;
        Font myFont4;

        private PrivateFontCollection fonts = new PrivateFontCollection();
        private PrivateFontCollection fonts2 = new PrivateFontCollection();

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
    IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private void InitializeFonts()
        {
            byte[] fontData = Properties.Resources.Glegoo_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Glegoo_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Glegoo_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 12.0F);
            myFont2 = new Font(fonts.Families[0], 10.0F);
            myFont3 = new Font(fonts.Families[0], 12.0F, FontStyle.Bold);
            myFont4 = new Font(fonts.Families[0], 12.0F, FontStyle.Bold | FontStyle.Italic);
        }


        /*
         * Contructor     - Form1
         *                  Called when Form1 Class is initialized.
         *                  Called when clicked on Main Icon (Without Parameter).  
         */
        public Form1()
        {
            InitializeComponent();
            InitializeFonts();
        }


        /*
         * Constructor      - Form1
         *                    Called when Form1 Class is intialized.
         *                    Called when clicked on Encrypted File (With File Name as Parameter).
         *            
         * fileName         - (string) Stores the name of the Main File Without Extension that needs to be Decoded/Decrypted.
         * mainFile         - (string) Stores the address of the Main File that needs to be Decoded/Decrypted.
         */
        public Form1(string s)
        {
            InitializeComponent();
            InitializeFonts();

            string[] temp = s.Split('.');
            fileName = s.Split('\\')[s.Split('\\').Length - 1].Split('.')[0];
            ExtensionInfo(temp, s);

            progressBar.Value = 0;
            progressLabel.ResetText();
            computePixBytesDecrypt();
        }


        /*
         * Function                 - Form1_Load
         *                            Occurs before a form is displayed for the first time.
         * 
         * totalImageEncrypt        - (int) Stores the Number of Images to Encrypt, Used while Encryption.
         * IV                       - (string) Intialization Vector, Used in both Encryption and Decryption.
         * crypt                    - (Cryptography.Generic) Instant of Cryptography Class. 
         */
        private void Form1_Load(object sender, EventArgs e)
        {         
            tabControl1.Font = myFont;
            aboutRichBox.Font = myFont;
            encryptRichBox.Font = myFont;
            decryptRichBox.Font = myFont;
            infoRichBox.Font = myFont2;
            infoLabel.Font = myFont2;
            infoGroupBox.Font = myFont3;
            finalLabel.Font = myFont4;
          
            totalImagesEncrypt = 1;
            IV = ".DoTCoDEDoTCoDE.";
            crypt = new Cryptography.Generic();
            formatComboEncrypt.SelectedIndex = 0;
        }


        /*
         * Function     - OFDbutton_Click
         *                Called when Clicked on Open File Button(OFDButton) in Decrypt tab.
         */
        private void OFDbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "DotCode File (*.code)|*.code|IDX File (*.idx3-ubyte)|*.idx3-ubyte|Binary File (*.bin)|*.bin|All Files (*.*)|*.*";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                string[] temp = OFD.FileName.Split('.');
                fileName = OFD.FileName.Split('\\')[OFD.FileName.Split('\\').Length - 1].Split('.')[0];
                string fileNameTemp = OFD.FileName;
                ExtensionInfo(temp, fileNameTemp);
                
                progressBar.Value = 0;
                progressLabel.ResetText();
                computePixBytesDecrypt();
            }
        }


        /*
         * Function     - ExtensionInfo
         *                Called from OFDbutton_Click or Form1, After the knowing the
         *                the Main File(fileName).
         * This Function Initializes the fields after knowing the File Address and File Extension.
         *       
         * extension    - (string) Stores the Extension of the Main File(mainFile).
         * mainFile     - (string) Stores the Address of the Main File that needs to be Decoded/Decrypted.
         * temp         - (string []) Array of String splitted by ".", temp[temp.Length -1] contains extension.
         */
        private void ExtensionInfo(string[] temp,string FileName)
        {
            if (temp.Length > 1)
            {
                extension = temp[temp.Length - 1];
                switch (extension)
                {
                    case "idx3-ubyte":
                        fileBox.Text = FileName;
                        mainFile = FileName;
                        formatTextBox.Text = "IDX File (*.idx3-ubyte)";
                        formatTextBox.ReadOnly = true;
                        break;
                    case "code":
                        fileBox.Text = FileName;
                        mainFile = FileName;
                        formatTextBox.Text = "DotCode File(*.code)";
                        formatTextBox.ReadOnly = true;
                        break;
                    case "bin":
                        extension = "other binary";
                        fileBox.Text = FileName;
                        mainFile = FileName;
                        formatTextBox.Text = "Binary File (*.bin*)";
                        formatTextBox.ReadOnly = true;
                        break;
                    default:
                        MessageBox.Show("Invalid File Format", "Invalid Format");
                        break;
                }
            }
            else
            {
                extension = "other binary";
                fileBox.Text = FileName;
                mainFile = FileName;
                formatTextBox.Text = "Other Binary File (*.*)";
                formatTextBox.ReadOnly = true;
            }
        }


        /*
         * Function         - button1_Click
         *                    Called when Clicked on Extract To Button(destFolderButton) in Decrypt tab.
         * 
         * mainFolder       - (string) Stores the Address of the Destination Folder.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            
            if(FBD.ShowDialog() == DialogResult.OK)
            {
                destTextBox.Text = FBD.SelectedPath;
                mainFolder = FBD.SelectedPath;
            }
        }


        /*
         * Function       - extButton_Click
         *                  Called when Clicked on Extract Button(extButton).
         * 
         * binReader      - (BinaryReader) Reads the Main File, takes File Address(mainFile) as an input.
         * invalidData    - (Bool) Check if all fields are properly initialized with proper values before Extracting.
         * rgbDecryptBool - (Bool) Stores if the Encoded File is in RGB Format or not.
         * totalImages    - (Int) Stores the Number of Images in the Encoded File. (1: For .CODE,??: For .IDX3-UBYTE)
         */
        private void extButton_Click(object sender, EventArgs e)
        {
            if (extension == "code" )       //If file is of .CODE Format, Check if Password is needed.
            {
                passwordVerification();
            }
            try
                {
                    binReader = new BinaryReader(File.Open(mainFile, FileMode.Open));       //Try Reading the File.
                }
                catch
                {
                    MessageBox.Show("Error: Can't Open File !!!", "Error");
                    binReader.Close();
                }  

            if (formatTextBox.Text == "Binary File (*.bin*)")
            {
                /*
                 * For Binary Files, there are no Header bytes that contains the initial
                 * properties(RGB, Size) of Image, Hence all details must be filled manually
                 * before Extracting.
                 */
                if (string.IsNullOrWhiteSpace(quantTextBox.Text))
                {
                    MessageBox.Show("Fill the quantity of images in given file", "Empty Field");
                    invalidData = true;
                }
                else
                {
                    try
                    {
                        totalImages = Convert.ToInt32(quantTextBox.Text);                       
                    }
                    catch
                    {
                        MessageBox.Show("Set proper Quantity", "Invalid Format");
                        invalidData = true;
                    }
                 }

                try
                {
                    height = Convert.ToInt32(heightTextBox.Text);
                    width = Convert.ToInt32(widthTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Fill the Image Dimensions", "Empty Field");
                    invalidData = true;
                }
            }

            if(mainFolder == null)      //Checks if Destination Folder is mentioned.
            {
                invalidData = true;
                MessageBox.Show("Fill the destination Folder", "Empty Field");
            }

            if(rgbRadio.Checked == true && formatTextBox.Text != "DOTCODE File (*.code)")
            {
                rgbDecryptBool = true;
            }
            else if(rgbRadio.Checked == false && grayRadio.Checked == true && formatTextBox.Text != "DOTCODE File (*.code)")
            {
                rgbDecryptBool = false;
            }
            else
            {
               MessageBox.Show("Type of Image not specified","Empty Field");
               invalidData = true;
            }

            if (!backgroundWorker1.IsBusy && !invalidData){ 
                backgroundWorker1.RunWorkerAsync();
            }
            else if(invalidData == true)
            {
                binReader.Close();
                invalidData = false;
            }  
        }


        /*
         * Function         - passwordVerification
         *                    Called from extButton_Click.
         *                    
         * This Function gets called when Format is .CODE and Protection is Encrypt.
         * It invokes Dialog Box(form3), and asks user to enter password.
         * It is a Recursive Function, and continues execution until the password is 
         * right or the process is aborted.
         * 
         * pixBytesDecrypt2        - (byte[]) Contains pixel bytes before Decryption.
         * pixBytesDecrypt         - (byte[]) Contains pixel bytes after Decryption.
         */
        private void passwordVerification()
        {
            if (extension == "code" && protectionDecrypt == 1)      //Checks if Format is .CODE and Protection is Encrypt.
            {
                using (Form3 form3 = new Form3())
                {
                    if (form3.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string key = form3.keyD;
                            byte[] temp = (byte[])crypt.Crypt(Cryptography.Generic.CryptMethod.DECRYPT, Cryptography.Generic.CryptClass.AEC, pixBytesDecrypt2, key, IV);
                            pixBytesDecrypt = temp;
                            invalidData = false;
                        }
                        catch
                        {
                            MessageBox.Show("Error !!!: Invalid Password", "Invaid Password");
                            invalidData = true;
                            passwordVerification();
                        }
                    }
                    else
                    {
                        invalidData = true;
                    }
                }
            }
            else
            {
                pixBytesDecrypt = pixBytesDecrypt2;
            }
        }


        /*
         * Function         - backgroundWorker1_DoWork
         *                    Called from extButton_Click(function), Carries out the main task.
         * 
         * For Binary Files and IDX Files:-
         * -> Binary Reader(binReader) is used to access the Pixel Bytes.
         * For CODE Files:- 
         * -> Byte Array(pixBytesDecrypt) is used to access the Pixel Bytes.
         * 
         * cloneDecrypt     - (Bitmap) Used to Preview decrypted Image(decryptImage).
         */
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int index = extractIndex;
            for(int i = 0;i<extractIndex;i++)
            {
                byte temp = binReader.ReadByte();
            }

            for (int h = 0; h < totalImages; h++)
            {
                Bitmap tempImage = new Bitmap(width, height);
                switch (rgbDecryptBool)
                {
                    case true:
                        if (extension == "code" )
                        {
                            for (int i = 0; i < height; i++)
                            {
                                for (int j = 0; j < width; j++)
                                {
                                    byte x1 = pixBytesDecrypt[index];
                                    int r = Convert.ToInt32(x1);
                                    index += 1;
                                    byte x2 = pixBytesDecrypt[index];
                                    int g = Convert.ToInt32(x2);
                                    index += 1;
                                    byte x3 = binReader.ReadByte();
                                    int b = pixBytesDecrypt[index];
                                    index += 1;
                                    Color color = Color.FromArgb(r, g, b);
                                    tempImage.SetPixel(j, i, color);
                                }
                                backgroundWorker1.ReportProgress(((i + 1) * 100 / height));
                            }
                        }
                        else
                        { 
                            for (int i = 0; i < height; i++)
                            {
                                for (int j = 0; j < width; j++)
                                {
                                    byte x1 = binReader.ReadByte();
                                    int r = Convert.ToInt32(x1);
                                    byte x2 = binReader.ReadByte();
                                    int g = Convert.ToInt32(x2);
                                    byte x3 = binReader.ReadByte();
                                    int b = Convert.ToInt32(x3);
                                    Color color = Color.FromArgb(r, g, b);
                                    tempImage.SetPixel(j, i, color);
                                }
                                backgroundWorker1.ReportProgress(((i + 1) * 100 / height));
                            }
                        }
                        break;

                    case false:
                        if(extension == "code" )
                        {
                            for (int i = 0; i < height; i++)
                            {
                                for (int j = 0; j < width; j++)
                                {
                                    byte x = pixBytesDecrypt[index];
                                    int val = Convert.ToInt32(x);
                                    index += 1;
                                    Color color = Color.FromArgb(val, val, val);
                                    tempImage.SetPixel(j, i, color);
                                }
                                backgroundWorker1.ReportProgress(((i + 1) * 100 / height));
                            }
                        }
                        else
                        {
                            for (int i = 0; i < height; i++)
                            {
                                for (int j = 0; j < width; j++)
                                {
                                    byte x = binReader.ReadByte();
                                    int val = Convert.ToInt32(x);
                                    Color color = Color.FromArgb(val, val, val);
                                    tempImage.SetPixel(j, i, color);
                                }  
                            }
                            backgroundWorker1.ReportProgress(((h + 1) * 100 / totalImages));
                        }
                        break;
                }

                string add = mainFolder + "/" + fileName + h + ".jpeg";
                cloneDecrypt = new Bitmap(tempImage);
                tempImage.Save(add, System.Drawing.Imaging.ImageFormat.Jpeg);

                /*
                 * .CancellationPending = true 
                 * when cancel button(cancelBtn) in Encrypt Tab is pressed. 
                 */
                if (backgroundWorker1.CancellationPending == true)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            return;
        }


        /*
         * Function         - backgroundWorker1_ProgressChanged
         *                    part of BackgroundWorker1. 
         *                    Called from backgroundWorker1_DoWork through backgroundWorker1.ReportProgress.
         * 
         * Handles the ProgressBar(progressBar).
         */
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressLabel.Text = e.ProgressPercentage.ToString() + "%";
        }


        /*
         * Function         - backgroundWorker1_RunWorkerCompleted
         *                    Called when backgroundWorker1_DoWork completes its task or is aborted.
         */
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                progressLabel.Text = "Extraction Cancelled";
            }
            else if(e.Error != null)
            {
                progressLabel.Text = e.Error.Message;
            }
            else
            {
                progressLabel.Text = "Extraction Completed";
                decryptImage.Image = cloneDecrypt;  
            }
            binReader.Close();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }


        /*
         * Function         - BigToLittle
         *                    Called From computePixBytesDecrypt
         *                    
         * In IDX Format, All the integers in the files are stored in the MSB first (high endian) format
         * used by most non-Intel processors. Users of Intel processors and other low-endian machines must
         * flip the bytes of the header.
         */
        public int BigToLittle(byte[] x)
        {
            List<byte> temp = new List<byte>(x);
            temp.Reverse();
            byte[] temp2 = new byte[32];
            temp2 = temp.ToArray();
            return BitConverter.ToInt32(temp2, 0);
        }


        /*
         * Function         - computePixBytesDecrypt
         *                    Called from OFDbutton_Click function or Form1 Constructor.
         *                    
         * This Function seperates the Header bytes(incase of .code and .idx3-ubyte) and the pixel bytes.
         * There are no Header Bytes for Binary Files(.bin).
         * For IDX Files(.idx3-ubyte) pixels bytes are not Encrypted. 
         * More About IDX File Format is available at http://yann.lecun.com/exdb/mnist/ .
         * For CODE File Format encoded data is First stored in Byte Arrays, whereas in
         * IDX File Format encoded data is accessed using BinaryReader.
         * 
         * pixBytesHeader       - (byte[]) Stores the Header Bytes (.code).
         * pixBytesDecrypt2     - (byte[]) Stores the Pixel Bytes (.code).
         * extractIndex         - (int) Index at which the First pixel data is stored (IDX:- 16; CODE:- 0).
         */
        private void computePixBytesDecrypt()
        {
            if (formatTextBox.Text == "Binary File (*.bin*)")
            {
                binReader = new BinaryReader(File.Open(mainFile, FileMode.Open));
                infoGroup.Enabled = true;
                heightTextBox.Enabled = true;
                heightTextBox.Text = heightTextBox.Tag.ToString();
                widthTextBox.Enabled = true;
                widthTextBox.Text = widthTextBox.Tag.ToString();
                quantityLabel.Enabled = true;
                quantTextBox.Enabled = true;
                quantTextBox.Text = quantTextBox.Tag.ToString();
                magicTextBox.Enabled = false;
                magicLabel.Enabled = false;
                rgbRadio.Enabled = true;
                grayRadio.Enabled = true;
                rgbRadio.Checked = false;
                grayRadio.Checked = false;
                binReader.Close();
            }
            else if (formatTextBox.Text == "IDX File (*.idx3-ubyte)")
            {
                binReader = new BinaryReader(File.Open(mainFile, FileMode.Open));
                byte[] magicBytes = binReader.ReadBytes(4);
                byte thirdByte = magicBytes[2];
                byte fourthByte = magicBytes[3];
                magicNumber = BigToLittle(magicBytes);      //Check the link for more details.
                magicTextBox.Text = magicNumber.ToString();     
                magicTextBox.BackColor = SystemColors.Window;
                magicTextBox.Enabled = false;
                extractIndex = 0;

                switch (Convert.ToInt32(fourthByte))
                {
                    case 3:
                        byte[] numberBytes = binReader.ReadBytes(4);
                        totalImages = BigToLittle(numberBytes);     //Convert High Endian(MSB First) To Low Endian(LSB First). 
                        quantTextBox.Text = totalImages.ToString();

                        byte[] heightBytes = binReader.ReadBytes(4);
                        height = BigToLittle(heightBytes);       
                        heightTextBox.Text = height.ToString();

                        byte[] widthBytes = binReader.ReadBytes(4);
                        width = BigToLittle(widthBytes);
                        widthTextBox.Text = width.ToString();
                        extractIndex = 16;
                        break;

                    case 1:
                        byte[] numberBytes2 = binReader.ReadBytes(4);
                        totalImages = BigToLittle(numberBytes2);
                        quantTextBox.Text = totalImages.ToString();
                        break;
                }

                binReader.Close();
                infoGroup.Enabled = true;
                heightTextBox.Enabled = false;
                widthTextBox.Enabled = false;
                quantTextBox.Enabled = false;
            }
            else if (formatTextBox.Text == "DotCode File(*.code)")
            {
                byte[] tempX = File.ReadAllBytes(mainFile);
                pixBytesHeader = new byte[7];

                for (int i = 0; i < 7; i++)
                {
                    pixBytesHeader[i] = tempX[i];       //Seperating Header Bytes from Pixel Bytes.
                }

                pixBytesDecrypt2 = new byte[tempX.Length - 7];
                int ind = 0;
                for (int i = 7; i < tempX.Length; i++)
                {
                    pixBytesDecrypt2[ind] = tempX[i];
                    ind += 1;
                }

                int tempRGB = (int)pixBytesHeader[0];
                rgbRadio.Enabled = true;
                grayRadio.Enabled = true;
                if (tempRGB == 1)
                {
                    rgbRadio.Checked = true;
                    grayRadio.Checked = false;
                    rgbDecryptBool = true;
                }
                else
                {
                    rgbRadio.Checked = false;
                    grayRadio.Checked = true;
                    rgbDecryptBool = false;
                }
                rgbRadio.Enabled = false;
                grayRadio.Enabled = false;
                protectionDecrypt = (int)pixBytesHeader[1];
                totalImages = (int)pixBytesHeader[2];
                height = BitConverter.ToInt16(pixBytesHeader, 3);
                heightTextBox.Text = height.ToString();
                width = BitConverter.ToInt16(pixBytesHeader, 5);
                widthTextBox.Text = width.ToString();
                extractIndex = 0;

                infoGroup.Enabled = true;
                heightTextBox.Enabled = false;
                widthTextBox.Enabled = false;
                quantTextBox.Enabled = false;
            }
        }


        /*
         *       ENCRYPTION 
         *       STARTS
         *       FROM
         *       HERE
         */


        /*
         * Function         - openImageBtn_Click
         *                    Called when openImageBtn(Button) in Encrypt Tab is Clicked.
         * 
         * imageName        - (string) Stores image's name without, used later while storing Encrypted File.
         * mainImageEncrypt - (Bitmap) The image that needs to be Encrypted, used to access pixels while Encrypting.
         * heightEncrypt    - (int) Stores the height of Image.
         * widthEncrypt     - (int) Stores the width of Image.
         */
        private void openImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD2 = new OpenFileDialog();
            OFD2.Filter = "JPEG (*.jpeg,*.jpg)|*.jpg;*.jpeg|PNG (*.png)|*.png";     //Image Formats that are acceptable. 

            if (OFD2.ShowDialog() == DialogResult.OK)
            {
                imageTextBox.Text = OFD2.FileName;
                imageName = OFD2.FileName.Split('\\')[OFD2.FileName.Split('\\').Length - 1].Split('.')[0];      //Gets the Image name without extension.  
                mainImageEncrypt = new Bitmap(OFD2.FileName);
                encryptImage.Image = new Bitmap(OFD2.FileName);     //Preview Image in Encrypt Tab     
                heightTextBoxEncrypt.Text = mainImageEncrypt.Height.ToString();     //Height TextBox in Encrypt Tab
                heightTextBoxEncrypt.ReadOnly = true;
                heightEncrypt = mainImageEncrypt.Height;
                widthTextBoxEncrypt.Text = mainImageEncrypt.Width.ToString();       //Width TextBox in Encrypt Tab
                widthTextBoxEncrypt.ReadOnly = true;
                widthEncrypt = mainImageEncrypt.Width;
            }
        }


       /*
        * Function          - destFolderButtonEncrypt_Click
        *                     Called when destFolderButtonEncrypt(Button) in Encrypt Tab is Clicked.
        * 
        * mainFolderEncrypt - (string) Stores the Address for the Destination Folder, where the Encrypted Image gets stored.
        */
        private void destFolderButtonEncrypt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD2 = new FolderBrowserDialog();

            if (FBD2.ShowDialog() == DialogResult.OK)
            {
                destTextBox2.Text = FBD2.SelectedPath;      //Destination TextBox in Encrypt Tab
                mainFolderEncrypt = FBD2.SelectedPath;
            }
        }


       /*
        * Function            - encryptButton_Click
        *                       Called when encryptButton(Button) in Encrypt Tab is Clicked.
        * 
        * invalidDataEncrypt -  (bool) Checks if all data is present and is in the correct format before Encrypting. 
        */
        private void encryptButton_Click(object sender, EventArgs e)
        {
            if(mainImageEncrypt == null)        //Image to be Encoded is not selected.           
            {
                invalidDataEncrypt = true;      
                MessageBox.Show("Empty Field: Image", "Empty Field");
            }
            else if(mainFolderEncrypt == null)      //Destination Folder not selected.
            {
                invalidDataEncrypt = true;
                MessageBox.Show("Empty Field: Destination", "Empty Field");
            }

            if (!backgroundWorker2.IsBusy && !invalidDataEncrypt)
            {
                computePixBytes();
                if (!invalidDataEncrypt)
                {
                    backgroundWorker2.RunWorkerAsync();
                }
            }

            if(invalidDataEncrypt)      
            {
                invalidDataEncrypt = false;
            }
        }


        /*
         * Function         - backgroundWorker2_DoWork
         *                    part of BackgroundWorker2  
         *                    Called from encryptButton_Click(function), Carries out the main task.
         * 
         * pixBytes(byte[]) is used if -
         * -> encoded into .bin format. 
         * -> encoded into .code format and protection is set to Normal.
         * 
         * pixBytesTester(byte[]) is used if -
         * -> encoded into .code format and protection is set to Encrypt.
         * 
         * Gray Scale is Calculated as 
         * Gray = (R + G + B)/3 
         * where R,G,B are from original image(mainImageEncrypt).
         * 
         */
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int index;
            if(protectionRB.Checked && codeFormatEncrypt)
            {
                 index = 0;
            }
            else
            {
                index = encryptIndex;
            }
            for (int h = 0; h < totalImagesEncrypt; h++)
            {  
                switch (rgbEncryptBool)
                {
                    case true:
                        for (int i = 0; i < heightEncrypt; i++)
                        {
                            for (int j = 0; j < widthEncrypt; j++)
                            {
                                Color color = mainImageEncrypt.GetPixel(j, i);
                                int r = color.R;
                                int g = color.G;
                                int b = color.B;
                                if (protectionRB.Checked && codeFormatEncrypt)
                                {
                                    pixBytesTester[index] = (byte)r;
                                    index += 1;
                                    pixBytesTester[index] = (byte)g;
                                    index += 1;
                                    pixBytesTester[index] = (byte)b;
                                    index += 1;
                                }
                                else
                                {
                                    pixBytes[index] = (byte)(r);
                                    index += 1;
                                    pixBytes[index] = (byte)(g);
                                    index += 1;
                                    pixBytes[index] = (byte)(b);
                                    index += 1;
                                }
                            }
                            backgroundWorker2.ReportProgress((index + 1) * 100 / (heightEncrypt * widthEncrypt * 3));
                        }
                        break;

                    case false:  
                        for (int i = 0; i < heightEncrypt; i++)
                        {
                            for (int j = 0; j < widthEncrypt; j++)
                            {
                                Color color = mainImageEncrypt.GetPixel(j, i);
                                int r = color.R;
                                int g = color.G;
                                int b = color.B;
                                if (protectionRB.Checked && codeFormatEncrypt)
                                {
                                    byte x = (byte)((r + g + b) / 3);
                                    pixBytesTester[index] = x;
                                    index += 1;
                                }
                                else
                                {
                                    pixBytes[index] = (byte)((r + g + b) / 3);
                                    index += 1;
                                }
                            }
                            backgroundWorker2.ReportProgress((index + 1) * 100 / (heightEncrypt * widthEncrypt));
                        }
                        break;    
                }

                /*
                 * .CancellationPending = true 
                 * when cancel button(cancelBtn) in Encrypt Tab is pressed. 
                 */
                if (backgroundWorker2.CancellationPending == true)
                {
                    e.Cancel = true;
                    backgroundWorker2.ReportProgress(0);
                    return;
                }               
            }
            return;
        }


        /*
         * Function         - backgroundWorker2_ProgressChanged
         *                    part of BackgroundWorker2. 
         *                    Called from backgroundWorker2_DoWork through backgroundWorker2.ReportProgress.
         * 
         * Handles the ProgressBar(progressBar1).
         */
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressLabel1.Text = e.ProgressPercentage.ToString() + "%";
        }


        /*
         * Function         - backgroundWorker2_RunWorkerCompleted
         *                    Called when backgroundWorker2_DoWork completes its task or is aborted.
         */
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressLabel1.Text = "Encryption Cancelled";
            }
            else if (e.Error != null)
            {
                progressLabel1.Text = e.Error.Message;
            }
            else
            {
                progressLabel1.Text = "Encryption Completed";
                if (formatComboEncrypt.SelectedIndex == 1)
                {
                    string name = nameFile(".bin", 0);
                    File.WriteAllBytes(name, pixBytes);
                   
                }
                else if(formatComboEncrypt.SelectedIndex == 0)
                {
                    /*
                     * When encoding format is .CODE and protection is set to Encrypt :-
                     * -> Array containg pixel data(pixBytesTester) is Encrypted.
                     * -> Encryption Algorithm - AES
                     * -> Encrypting IV        - ".DoTCoDEDoTCoDE." 
                     * 
                     * After Encrypting :- 
                     * The Encrypted Bytes(temp) and the Header Bytes(pixBytes) are combined together and 
                     * stored in a new array(newTemp).
                     * The new array is then stored in a file.
                     */
                    if (protectionRB.Checked && codeFormatEncrypt)
                    {
                        byte[] temp = (byte[])crypt.Crypt(Cryptography.Generic.CryptMethod.ENCRYPT, Cryptography.Generic.CryptClass.AEC, pixBytesTester, keyEncrypt, IV);
                        byte[] newTemp = new byte[7 + temp.Length];
                        int indexX = 0;
                        for (int i = 0; i < 7;i++)
                        {
                            newTemp[indexX] = pixBytes[i];
                            indexX += 1;
                        }
                        for(int i = 0; i < temp.Length;i++)
                        {
                            newTemp[indexX] = temp[i];
                            indexX += 1;
                        }
                        string name = nameFile(".code", 0);
                        File.WriteAllBytes(name,newTemp);
                    }
                    else
                    {
                        string name = nameFile(".code", 0);
                        File.WriteAllBytes(name, pixBytes);
                    }
                }
            }
        }


        /*
         * Function     - nameFile
         *                Called From backgroundWorker2_RunWorkerCompleted
         *               
         * This Function checks the Dstination folder(mainFolderEncrypt) if it contains 
         * any File with same name as the Image file(imageName).
         * If the folder contains a file with the same name it checks for a File
         * with the old name + integer(starts from 0) until it gets a unique name.
         */
        private string nameFile(string ext,int num)
        {
            switch(ext)
            {
                case ".code":
                    if (File.Exists(mainFolderEncrypt + "/" + imageName +num+".code"))
                    {
                       return nameFile(ext, num + 1);
                    }
                    else
                    {
                        return mainFolderEncrypt + "/" + imageName + num + ".code";
                    }
                    break;

                case ".bin":
                    if (File.Exists(mainFolderEncrypt + "/" + imageName + num + ".bin"))
                    {
                        return nameFile(ext, num + 1);
                    }
                    else
                    {
                        return mainFolderEncrypt + "/" + imageName + num + ".bin";
                    }
                    break;
            }
            return null;
        }


        /*
         * Function     - int2bytes
         *                Called from computePixBytes
         * 
         * This Function converts integer greater than 255(1 Byte) into 2 Bytes(65,536).
         * Whenever the Height or Width of the Image is greater than 255(1 byte), 
         * it must be broken into 2 bytes. This function performs the following task.
         */
        public byte[] int2bytes(int x)
        {
            int[] binary = new int[16];
            byte[] bytes = new byte[2];
            byte LSB, MSB;
            int val = x;

            /*
             * Converts into binary
             */
            for (int i = 15; i >= 0; i--)
            {
                if (Math.Pow(2, i) > x)
                {
                    binary[i] = 0;
                }
                else
                {
                    binary[i] = 1;
                    x = x - (int)Math.Pow(2, i);
                }
            }

            int temp = 0;
            /*
             * Gets int from Binary
             */ 
            for (int i = 7; i >= 0; i--)
            {
                temp += binary[i + 8] * (int)Math.Pow(2, i);
            }
            MSB = (byte)temp;       //Upper 8 bits
            temp = 0;
            for (int i = 7; i >= 0; i--)
            {
                temp += binary[i] * (int)Math.Pow(2, i);
            }
            LSB = (byte)temp;       //Lower 8 bits

            bytes[1] = MSB;
            bytes[0] = LSB;

            return bytes;
        }


        /*
         *Function           - computePixBytes
         *                     called from encryptButton_Click (function). 
         * 
         * encryptIndex      -(int) Index at which the First pixel data must be stored in Main File(pixBytes/pixBytesTester).
         * pixBytes          -(byte[]) Stores the pixel data in byte format, used when data Encryption is not needed(Protection = Normal).
         * pixBytesTester    -(byte[]) Stores the pixel data in byte format, used when data Encryption is needed(Protection = Encrypt).
         * rgbEncryptBool    -(bool) Stores if the encoded image must be in RGB or not.
         * codeFormatEncrypt -(bool) Stores if the encoded image is Encrypted or not.
         * keyEncrypt        -(string) Stored the Password, which is later used as the Key while Encryption.
         */
        private void computePixBytes()
        {
            if(formatComboEncrypt.SelectedIndex == 1)
            {
                encryptIndex = 0;
                if(rgbEncryptRB.Checked)
                {
                    rgbEncryptBool = true;
                    pixBytes = new byte[(heightEncrypt * widthEncrypt * 3)];        //Total Bytes Required(RGB) = Height * Width * 3 (3 bytes for Each Pixel).
                }
                else
                {
                    rgbEncryptBool = false;
                    pixBytes = new byte[(heightEncrypt * widthEncrypt)];            //Total Bytes Required(GRAY) = Height * Width  (1 byte for Each Pixel).
                }
            }
            else
            {
                /*
                 *                      .CODE FILE FORMAT
                 * 
                 * [OFFSET]         [TYPE]          [VALUE]         [DESCRIPTION]
                 *   
                 *   0000       unsigned Byte          1/0            1 = FOR RGB; 0 = FOR GRAYSCALE;  (IMAGE TYPE) 
                 *   0001       unsigned Byte          1/0            1 = FOR ENCRYPTION; 0 = FOR NORMAL; (PROTECTION MODE)          
                 *   0002       unsigned Byte          ??             Number Of Images;  (Default 1)
                 *   0003       16 bit Integer         ??             Height Of Encoded Image;
                 *   0005       16 bit Integer         ??             Width Of Encoded Image;
                 *   0007       unsigned Byte          ??             Pixel
                 *   0008       unsigned Byte          ??             Pixel
                 *   ....       ....                   ..             ....
                 *   xxxx       unsigned Byte          ??             Pixel
                 *   
                 */  
                codeFormatEncrypt = true;
                if (rgbEncryptRB.Checked)
                {
                    rgbEncryptBool = true;
                    pixBytes = new byte[7 + (heightEncrypt * widthEncrypt * 3)];        //Total Bytes Required(RGB) = 7 + (Height * Width * 3) [7 Bytes are the initial Header Bytes + 3 bytes for each pixel (RGB)].
                    pixBytes[0] = (byte)1;      // RGB
                }
                else
                {
                    rgbEncryptBool = false;
                    pixBytes = new byte[7 + (heightEncrypt * widthEncrypt)];           //Total Bytes Required(GRAY) = 7 + (Height * Width) [7 Bytes are the initial Header Bytes + 1 bytes for each pixel (GRAY)].
                    pixBytes[0] = (byte)0;      // Gray
                }

                if (protectionRB.Checked)
                {     
                    pixBytes[1] = (byte)1;      // Encrypt
                } 
                else
                {
                    pixBytes[1] = (byte)0;      // Normal
                }

                pixBytes[2] = (byte)totalImagesEncrypt;

                byte[] heightBytes = new byte[2];
                if(heightEncrypt <= 255)
                {
                    heightBytes[1] = 0;
                    heightBytes[0] = (byte)heightEncrypt;
                }
                else        //If Height is Greater than 255, it must be stored in 2 bytes.
                {
                    heightBytes = int2bytes(heightEncrypt);
                }

                byte[] widthBytes = new byte[2];
                if(widthEncrypt <= 255)
                {
                    widthBytes[1] = 0;
                    widthBytes[0] = (byte)widthEncrypt;
                }
                else       //If Width is Greater than 255, it must be stored in 2 bytes.
                {
                    widthBytes = int2bytes(widthEncrypt);
                }

                pixBytes[3] = heightBytes[0];
                pixBytes[4] = heightBytes[1];

                pixBytes[5] = widthBytes[0];
                pixBytes[6] = widthBytes[1];
                
                if(protectionRB.Checked)
                {
                    /*
                     * If Protection is set to Encrypt.
                     * Form2 form2 is a Dialog Box that takes in 16 byte Password.
                     */ 
                    using (Form2 form2 = new Form2())
                    {
                        if(form2.ShowDialog() == DialogResult.OK)
                        {
                            keyEncrypt =  form2.keyText;
                        }
                        else
                        {
                            invalidDataEncrypt = true;
                        }
                    }
                }
 
                if (protectionRB.Checked)
                {
                    /*
                     * If Protection is set to Encrypt.
                     * Encrypt Bytes are stored seperately from the header bytes(pixBytes) in new byte[](pixBytesTester).
                     * They are finally combined together after the Encryption is done.
                     */
                    pixBytesTester = new byte[heightEncrypt * widthEncrypt * 3];   
                }
                encryptIndex = 7;       //The offset index from where the pixels must be stored in pixBytes. 
            }
        }


        /*
         * Function     - formatComboEncrypt_SelectedIndexChanged
         *                Called when formatComboEncrypt(ComboBox) of Encoded image is changed in Form. 
         */
        private void formatComboEncrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(formatComboEncrypt.SelectedIndex == 1)
            {
                protectionRB.Checked = false;
                normalRB.Checked = true;
                protectionGB.Enabled = false;
                
            }
            if (formatComboEncrypt.SelectedIndex == 0)
            {
                protectionRB.Checked = true;
                protectionGB.Enabled = true;
            }
        }
    }
}
