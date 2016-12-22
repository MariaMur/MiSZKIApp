using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DES_1;
namespace MiSZKI
{
    public partial class MiSZKI : Form
    {
        public MiSZKI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DESLib des = new DESLib();
            ElGamalLib eg = new ElGamalLib();
            SHA1Lib sha = new SHA1Lib();
            RSASign rsa = new RSASign();

            Stream sourceData = new MemoryStream(Encoding.Default.GetBytes(textBoxString.Text));

            Stream DESEData = new MemoryStream();
            des.EncryptData(sourceData, DESEData);
            sourceData.Position = 0;
            byte[] bufRead1 = new byte[DESEData.Length];
            DESEData.Read(bufRead1, 0, Convert.ToInt32(DESEData.Length));
            DESEData.Position = 0;
            textBoxDESE.Text = BitConverter.ToString(bufRead1);

            Stream DESDData = new MemoryStream();
            des.DecryptData(DESEData, DESDData);
            DESDData.Position = 0;
            byte[] bufRead2 = new byte[DESDData.Length];
            DESDData.Read(bufRead2, 0, Convert.ToInt32(DESDData.Length));
            textBoxDESD.Text = Encoding.Default.GetString(bufRead2);

            Stream EGEData = new MemoryStream();
            eg.EncryptData(sourceData, EGEData);
            sourceData.Position = 0;
            EGEData.Position = 0;
            byte[] bufRead3 = new byte[EGEData.Length];
            EGEData.Read(bufRead3, 0, Convert.ToInt32(EGEData.Length));
            EGEData.Position = 0;
            textBoxEGE.Text = BitConverter.ToString(bufRead3);

            Stream EGDData = new MemoryStream();
            eg.DecryptData(EGEData, EGDData);
            EGEData.Position = 0;
            EGDData.Position = 0;
            byte[] bufRead4 = new byte[EGDData.Length];
            EGDData.Read(bufRead4, 0, Convert.ToInt32(EGDData.Length));
            textBoxEGD.Text = Encoding.Default.GetString(bufRead4);

            Stream SHAData = new MemoryStream();
            sha.Hash(sourceData, SHAData);
            sourceData.Position = 0;
            byte[] bufRead5 = new byte[SHAData.Length];
            SHAData.Read(bufRead5, 0, Convert.ToInt32(SHAData.Length));
            textBoxSHA.Text = BitConverter.ToString(bufRead5);

            Stream RSAData = new MemoryStream();
            rsa.Sign(sourceData, RSAData);
            sourceData.Position = 0;
            byte[] bufRead6 = new byte[RSAData.Length];
            RSAData.Read(bufRead6, 0, Convert.ToInt32(RSAData.Length));
            textBoxRSA.Text = BitConverter.ToString(bufRead6);

        }
    }
}
