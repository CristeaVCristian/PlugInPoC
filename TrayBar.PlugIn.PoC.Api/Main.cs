using System;
using System.Windows.Forms;
using Microsoft.Owin.Hosting;

namespace TrayBar.PlugIn.PoC.Api
{
    public partial class Main : Form
    {
        private IDisposable _server;
        public Main()
        {
            InitializeComponent();
        }

        private void btnOpenConfiguration_Click(object sender, System.EventArgs e)
        {
            var configuration = new Configuration(this) { Left = this.Left, Top = this.Top };

            configuration.Show();
        }

        public void StartWebApi(int portNumber)
        {
            var baseUrl = $"http://localhost:{portNumber}";
            if (_server == null)
            {
                _server = WebApp.Start<Startup>(baseUrl);
                this.lblStatusDispaly.Text = $@"Web API running on {baseUrl}";
            }
            else
            {
                _server.Dispose();
                _server = WebApp.Start<Startup>(baseUrl);
                this.lblStatusDispaly.Text = $@"Web API running on {baseUrl}";
            }
        }
    }
}
