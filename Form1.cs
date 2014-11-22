using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using ThoughtWorks.QRCode.Codec;


namespace qrcode
{
    public partial class Form1 : Form
    {
        int PosX, PosY;
        public Form1()
        {
            InitializeComponent();
            PosX = QrcodePanel.Location.X;
            PosY = QrcodePanel.Location.Y;
            QrcodePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateQrcode();
        }

        private void GenerateQrcode()
        {
            int ImageSize = 400;

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 10;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            
            QrcodePanel.SetBounds(PosX, PosY, ImageSize, ImageSize);
            QrcodePanel.BackgroundImage = qrCodeEncoder.Encode(GenerateText.Text);
        }

        private void renderQRCode()
        {
            int ImageSize = 400;
            int version = 30;
            int SizeMax = 410;
            int SizeInit = 400;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode("HELLO WORLD" + "\r\n" + "Thank you,GoodLuck! \r\n", QRCodeGenerator.ECCLevel.Q);
            QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(GenerateText.Text, QRCodeGenerator.ECCLevel.H);

            if (version * qrCode.ModuleMatrix.Count <= SizeMax
                && version * qrCode.ModuleMatrix.Count > SizeInit)
            {
                ImageSize = version * qrCode.ModuleMatrix.Count;
            }
            else
            {
                version = ImageSize / qrCode.ModuleMatrix.Count + 1;
                ImageSize = version * qrCode.ModuleMatrix.Count;
            }
            //Display.Text = "vesion = "+version.ToString() +" size = "
            //    + ImageSize.ToString() + " length = " + qrCode.ModuleMatrix.Count.ToString();
            QrcodePanel.SetBounds(PosX, PosY, ImageSize, ImageSize);
            QrcodePanel.BackgroundImage = qrCode.GetGraphic(version);
        }
    }
}
