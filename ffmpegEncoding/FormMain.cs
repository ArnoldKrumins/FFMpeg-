using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Transcoder;
using Transcoder.commands;

namespace ffmpegEncoding
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnEncode_Click(object sender, EventArgs e)
        {
            //comes from the UI.
            var commandsType = cmbCreative.SelectedItem + "|" + cmbEncoding.SelectedItem; // The start and end result determines the chain of commands required.
            var commands = FfMpegFactory.Create(commandsType);


            // Constructed from UI 
            var valueList = new List<FfmpegValue>
            {
                new FfmpegValue {Id = Commands.Resolution,Value = cmbResolution.SelectedItem.ToString()},
                new FfmpegValue {Id = Commands.AspectRatio,Value = cmbAspectRatio.SelectedItem.ToString()},
                new FfmpegValue {Id = Commands.Scanning, Value = cmbScanning.SelectedItem.ToString()}
            };

            //Let the commands have access to the value list as they may need to make decisions based on these values.
            FfmpegCommand.ValueList = valueList;

            // Iterate over commands
            foreach (var value in valueList)
            {
                commands.HandleRequest(value);
            }


            var sb = new StringBuilder();
            //Display results
            foreach (var value in valueList)
            {
                sb.AppendFormat("{0} ", value.Result);
            }
            lblOutput.Text = sb.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbAspectRatio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
