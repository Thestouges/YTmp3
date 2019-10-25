using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using RestSharp;
using System.Diagnostics;
using System.Net;
using NAudio;
using NAudio.Wave;
using NAudio.Lame;
using System.IO;
using System.Reflection;
using System.Threading;
using YTmp3.Properties;

namespace YTmp3
{
    public partial class Form1 : Form
    {
        string filename;
        YouTubeVideo video;
        AudioFileReader AudioReader;
        LameMP3FileWriter lfw;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.MaximizeBox = false;
            if (Settings.Default["UserFileDir"].ToString() == "FirstUse")
            {
                FilePathText.Text = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
                Settings.Default.Save();
            }
            else
            {
                FilePathText.Text = Settings.Default["UserFileDir"].ToString();
            }
            FilePathText.ReadOnly = true;
            URLTextBox.Text = "";
            convert.Enabled = false;
            
        }

        private void convert_Click(object sender, EventArgs e)
        {
            Thread instance;
            instance = new Thread(Converting);
            Invoke(new Action(() => Converting()));
            //instance.Start();
            
        }
        private void Converting()
        {
            convert.Enabled = false;
            textBox1.Text = "";
            try
            {
                textBox1.Text = "Begin Conversion..." + "\r\n";

                if (NameTextBox.Text == "")
                    filename = video.Title;
                else
                    filename = NameTextBox.Text;

                textBox1.Text += "Reading..." + "\r\n";

                if (mp3radio.Checked)
                {
                    textBox1.Text += "mp3 checked..." + "\r\n";
                    Convertmp3();
                }
                else if (wavradio.Checked)
                {
                    textBox1.Text += "wav checked..." + "\r\n";
                    Convertwav();
                }
                DisposeData();
                textBox1.Text += "Finished" + "\r\n";
            }
            catch(Exception ex)
            {
                textBox1.Text += "Error Occured..." + "\r\n";
                textBox1.Text += ex.Message + "\r\n";
                textBox1.Text += "Video is encrypted/protected";
            }
            convert.Enabled = true;
        }
        private void Convertmp3()
        {
            textBox1.Text += "Starting mp3..." + "\r\n";
            AudioReader = new AudioFileReader(video.Uri);
            textBox1.Text += "Writing mp3..." + "\r\n";
            lfw = new LameMP3FileWriter(FilePathText.Text + filename + ".mp3", AudioReader.WaveFormat, LAMEPreset.VBR_90);
            textBox1.Text += "Copying..." + "\r\n";
            AudioReader.CopyTo(lfw);
        }

        private void Convertwav()
        {
            textBox1.Text += "Starting wav..." + "\r\n";
            AudioReader = new AudioFileReader(video.Uri);
            textBox1.Text += "Writing wav..." + "\r\n";
            WaveFileWriter.CreateWaveFile(FilePathText.Text + filename + ".wav", AudioReader);
        }

        private void DisposeData()
        {
            textBox1.Text += "Disposing" + "\r\n";
            AudioReader.Dispose();
            lfw.Dispose();
        }

        private void FilePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dir = new FolderBrowserDialog();
            if (Dir.ShowDialog() == DialogResult.OK)
            {
                FilePathText.Text = Dir.SelectedPath + "\\";
            }
            Dir.Dispose();
        }

        private void URLTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                video = YouTube.Default.GetVideo(URLTextBox.Text);
                NameTextBox.Text = video.Title;
                if (video.IsEncrypted)
                {
                    throw new Exception("Video is encrypted");
                }
                convert.Enabled = true;
            }
            catch(Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void FilePathButton_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog Dir = new FolderBrowserDialog();
            if (Dir.ShowDialog() == DialogResult.OK)
            {
                FilePathText.Text = Dir.SelectedPath + "\\";
            }
            Settings.Default["UserFileDir"] = FilePathText.Text;
            Settings.Default.Save();
            Dir.Dispose();
        }
    }
}
