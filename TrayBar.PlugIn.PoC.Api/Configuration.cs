using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayBar.PlugIn.PoC.Api
{
    public partial class Configuration : Form
    {
        private readonly Main _mainMenuForm;

        public Configuration()
        {
            InitializeComponent();
        }

        public Configuration(Main mainMenuForm)
        {
            InitializeComponent();
            this._mainMenuForm = mainMenuForm;
        }

        private void btnSubmitPort_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPortNumber.Text, out var portNumber))
            {
                _mainMenuForm.StartWebApi(portNumber);
                this.Hide();
            }
            else
            {
                this.lblInvalidPortNumber.Show();
            }
        }
    }
}
