using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALink
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ImageMouseHover(object sender, EventArgs e)
        {
            statusLeftLabel.Text = "Image Menu";
        }

        private void CaptureMouseHover(object sender, EventArgs e)
        {
            statusLeftLabel.Text = "Capture New Image";
        }

        private void StatusMouseLeave(object sender, EventArgs e)
        {
            statusLeftLabel.Text = "";
        }

        private void SettingsMouseHover(object sender, EventArgs e)
        {
            statusLeftLabel.Text = "Applications settings";
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Consider convert this into a dialog
            bool bFormNameOpen = false;

            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "SettingsForm")
                {
                    bFormNameOpen = true;
                    frm.BringToFront();
                }
            }

            if (!bFormNameOpen)
            {
                SettingsForm newSettingsForm = new SettingsForm();
                newSettingsForm.MdiParent = this;
                newSettingsForm.Show();
            }
        }

        private void captureToolStripMenuItem_Click(object sender, EventArgs e)
        {
                CaptureForm newCaptureForm = new CaptureForm();
                newCaptureForm.MdiParent = this;
                newCaptureForm.Show();
        }
    }
}
