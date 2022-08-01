namespace Maximas
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.movePanel = new Bunifu.UI.WinForms.BunifuFormDock();
            this.panel_top = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_projects = new System.Windows.Forms.Button();
            this.btn_operations = new System.Windows.Forms.Button();
            this.panel_main = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel_top.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // movePanel
            // 
            this.movePanel.AllowFormDragging = true;
            this.movePanel.AllowFormDropShadow = true;
            this.movePanel.AllowFormResizing = true;
            this.movePanel.AllowHidingBottomRegion = true;
            this.movePanel.AllowOpacityChangesWhileDragging = true;
            this.movePanel.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.movePanel.BorderOptions.BottomBorder.BorderThickness = 1;
            this.movePanel.BorderOptions.BottomBorder.ShowBorder = true;
            this.movePanel.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.movePanel.BorderOptions.LeftBorder.BorderThickness = 1;
            this.movePanel.BorderOptions.LeftBorder.ShowBorder = true;
            this.movePanel.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.movePanel.BorderOptions.RightBorder.BorderThickness = 1;
            this.movePanel.BorderOptions.RightBorder.ShowBorder = true;
            this.movePanel.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.movePanel.BorderOptions.TopBorder.BorderThickness = 1;
            this.movePanel.BorderOptions.TopBorder.ShowBorder = true;
            this.movePanel.ContainerControl = this;
            this.movePanel.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.movePanel.DockingIndicatorsOpacity = 0.5D;
            this.movePanel.DockingOptions.DockAll = true;
            this.movePanel.DockingOptions.DockBottomLeft = true;
            this.movePanel.DockingOptions.DockBottomRight = true;
            this.movePanel.DockingOptions.DockFullScreen = true;
            this.movePanel.DockingOptions.DockLeft = true;
            this.movePanel.DockingOptions.DockRight = true;
            this.movePanel.DockingOptions.DockTopLeft = true;
            this.movePanel.DockingOptions.DockTopRight = true;
            this.movePanel.FormDraggingOpacity = 0.9D;
            this.movePanel.ParentForm = this;
            this.movePanel.ShowCursorChanges = true;
            this.movePanel.ShowDockingIndicators = true;
            this.movePanel.TitleBarOptions.AllowFormDragging = true;
            this.movePanel.TitleBarOptions.BunifuFormDock = this.movePanel;
            this.movePanel.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.movePanel.TitleBarOptions.TitleBarControl = this.panel_top;
            this.movePanel.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // panel_top
            // 
            this.panel_top.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel_top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_top.BackgroundImage")));
            this.panel_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_top.BorderColor = System.Drawing.Color.Transparent;
            this.panel_top.BorderRadius = 0;
            this.panel_top.BorderThickness = 0;
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.ShowBorders = false;
            this.panel_top.Size = new System.Drawing.Size(792, 40);
            this.panel_top.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btn_operations);
            this.bunifuPanel1.Controls.Add(this.btn_projects);
            this.bunifuPanel1.Controls.Add(this.btn_clients);
            this.bunifuPanel1.Controls.Add(this.btn_home);
            this.bunifuPanel1.Controls.Add(this.btn_menu);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(200, 489);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(749, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 34);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAXIMAS CONTROL";
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.ForeColor = System.Drawing.Color.Black;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(11, 39);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(35, 34);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.UseVisualStyleBackColor = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(3, 91);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(194, 40);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.BackColor = System.Drawing.Color.Transparent;
            this.btn_clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clients.FlatAppearance.BorderSize = 0;
            this.btn_clients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btn_clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clients.ForeColor = System.Drawing.Color.White;
            this.btn_clients.Location = new System.Drawing.Point(3, 137);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(194, 40);
            this.btn_clients.TabIndex = 1;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = false;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_projects
            // 
            this.btn_projects.BackColor = System.Drawing.Color.Transparent;
            this.btn_projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_projects.FlatAppearance.BorderSize = 0;
            this.btn_projects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btn_projects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_projects.ForeColor = System.Drawing.Color.White;
            this.btn_projects.Location = new System.Drawing.Point(3, 229);
            this.btn_projects.Name = "btn_projects";
            this.btn_projects.Size = new System.Drawing.Size(194, 40);
            this.btn_projects.TabIndex = 1;
            this.btn_projects.Text = "Projects";
            this.btn_projects.UseVisualStyleBackColor = false;
            this.btn_projects.Click += new System.EventHandler(this.btn_projects_Click);
            // 
            // btn_operations
            // 
            this.btn_operations.BackColor = System.Drawing.Color.Transparent;
            this.btn_operations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_operations.FlatAppearance.BorderSize = 0;
            this.btn_operations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btn_operations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_operations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_operations.ForeColor = System.Drawing.Color.White;
            this.btn_operations.Location = new System.Drawing.Point(3, 183);
            this.btn_operations.Name = "btn_operations";
            this.btn_operations.Size = new System.Drawing.Size(194, 40);
            this.btn_operations.TabIndex = 1;
            this.btn_operations.Text = "Operations";
            this.btn_operations.UseVisualStyleBackColor = false;
            this.btn_operations.Click += new System.EventHandler(this.btn_operations_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.BorderColor = System.Drawing.Color.Transparent;
            this.panel_main.BorderRadius = 0;
            this.panel_main.BorderThickness = 0;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(200, 40);
            this.panel_main.Name = "panel_main";
            this.panel_main.ShowBorders = true;
            this.panel_main.Size = new System.Drawing.Size(792, 449);
            this.panel_main.TabIndex = 2;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(992, 489);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App";
            this.Text = "Maximas Mission Control";
            this.panel_top.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock movePanel;
        private Bunifu.UI.WinForms.BunifuPanel panel_top;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_operations;
        private System.Windows.Forms.Button btn_projects;
        private System.Windows.Forms.Button btn_clients;
        private Bunifu.UI.WinForms.BunifuPanel panel_main;
    }
}

