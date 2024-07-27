using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;
using MediaToolkit;
using System.Net;

namespace Youtube_mp3_mp4_downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Format = true;

        private async void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description= "Lütfen Kaydetmek İstediğiniz Klasörü Seçiniz" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    label8.Text = "İndirme İşlemi Başladı. Lütfen Bekleyin.";
                    label8.ForeColor = Color.Red;

                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(textBox2.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var inputFile = new MediaToolkit.Model.MediaFile { Filename = fdb.SelectedPath + @"\" + video.FullName };
                    var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3" };
                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(inputFile);
                        enging.Convert(inputFile,outputFile);
                    }
                    if (Format == true)
                    {
                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fdb.SelectedPath + @"\" + video.FullName}.mp3");
                    }
                    label8.Text = "İndirme İşlemi Tamamlandı.";
                    label8.ForeColor = Color.Green;

                }
                else
                {
                    MessageBox.Show("Lütfen Dosya Yolunu Seçiniz","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Format = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Format = true;
        }
    }
}
