
namespace CinemaTicket.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnFilms = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCinemafy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlTab = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnTickets);
            this.panel1.Controls.Add(this.btnFilms);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 553);
            this.panel1.TabIndex = 0;
            // 
            // btnTickets
            // 
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTickets.FlatAppearance.BorderSize = 0;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTickets.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnTickets.Location = new System.Drawing.Point(0, 188);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(200, 44);
            this.btnTickets.TabIndex = 2;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            this.btnTickets.Leave += new System.EventHandler(this.btnTickets_Leave);
            // 
            // btnFilms
            // 
            this.btnFilms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilms.FlatAppearance.BorderSize = 0;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilms.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilms.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnFilms.Location = new System.Drawing.Point(0, 144);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(200, 44);
            this.btnFilms.TabIndex = 1;
            this.btnFilms.Text = "Films";
            this.btnFilms.UseVisualStyleBackColor = true;
            this.btnFilms.Click += new System.EventHandler(this.btnFilms_Click);
            this.btnFilms.Leave += new System.EventHandler(this.btnFilms_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCinemafy);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 144);
            this.panel2.TabIndex = 0;
            // 
            // lblCinemafy
            // 
            this.lblCinemafy.AutoSize = true;
            this.lblCinemafy.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinemafy.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCinemafy.Location = new System.Drawing.Point(61, 104);
            this.lblCinemafy.Name = "lblCinemafy";
            this.lblCinemafy.Size = new System.Drawing.Size(70, 19);
            this.lblCinemafy.TabIndex = 1;
            this.lblCinemafy.Text = "Cinemafy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlNav.Location = new System.Drawing.Point(0, 158);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnClose.Location = new System.Drawing.Point(823, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("LG Display-Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeader.Location = new System.Drawing.Point(15, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(61, 25);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Home";
            // 
            // pnlTab
            // 
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTab.Location = new System.Drawing.Point(0, 73);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(861, 456);
            this.pnlTab.TabIndex = 7;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(864, 73);
            this.pnlHeader.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlTab);
            this.panel3.Controls.Add(this.pnlHeader);
            this.panel3.Location = new System.Drawing.Point(206, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 529);
            this.panel3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinemafy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnFilms;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCinemafy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlTab;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel3;
    }
}

