using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maximas
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            this.panel_main.Controls.Clear();
            home home = new home();
            home.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(home);
            home.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // home page
        private void btn_home_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            home home = new home();
            home.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(home);
            home.Show();
        }
        // clients page
        private void btn_clients_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            clients clients = new clients();
            clients.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(clients);
            clients.Show();
        }

        private void btn_operations_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            operations operations = new operations();
            operations.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(operations);
            operations.Show();
        }

        private void btn_projects_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            projects projects = new projects();
            projects.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(projects);
            projects.Show();
        }
    }
}
