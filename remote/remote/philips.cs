using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote
{
    public partial class philipsremote : Form
    {
        public philipsremote()
        {
            InitializeComponent();
        }

        private void postData(string url, string jsonstr)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json";
                request.Method = "POST";
                request.Timeout = 100;

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = jsonstr;

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/audio/volume", "{" + "\"current\":" + trackBar1.Value + "}");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"Stop\" }");
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"Pause\" }");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"PlayPause\" }");
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"VolumeDown\" }");
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"VolumeUp\" }");
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"RedColour\" }");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"GreenColour\" }");
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"YellowColour\" }");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"BlueColour\" }");
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"CursorUp\" }");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"CursorRight\" }");
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"CursorDown\" }");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"CursorLeft\" }");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"Confirm\" }");
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            postData("http://" + ipadr.Text + ":1925/1/input/key", "{\"key\":\"Source\" }");
        }
    }
}