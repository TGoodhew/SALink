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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsOnLoad(object sender, EventArgs e)
        {
            settingsTxtAddress.Text = Properties.Settings.Default.DeviceAddress;
        }
    }
}
