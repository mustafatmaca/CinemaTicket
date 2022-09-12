using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CinemaTicket.Entities.Concrete;

namespace CinemaTicket.UI
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        static readonly HttpClient client = new HttpClient();
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnFilms.Height;
            pnlNav.Top = btnFilms.Top;
            pnlNav.Left = btnFilms.Left;
            btnFilms.BackColor = Color.DarkSlateGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FilmForm(), sender, btnFilms.Text);
        }
        


        private void OpenChildForm(Form childForm, object btnSender, string header)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlTab.Controls.Add(childForm);
            this.pnlTab.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHeader.Text = header;
        }

        private void btnFilms_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFilms.Height;
            pnlNav.Top = btnFilms.Top;
            pnlNav.Left = btnFilms.Left;
            btnFilms.BackColor = Color.DarkSlateGray;
            OpenChildForm(new FilmForm(), sender, btnFilms.Text);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTickets.Height;
            pnlNav.Top = btnTickets.Top;
            pnlNav.Left = btnTickets.Left;
            btnTickets.BackColor = Color.DarkSlateGray;
            OpenChildForm(new TicketForm(), sender, btnTickets.Text);
        }

        private void btnFilms_Leave(object sender, EventArgs e)
        {
            btnFilms.BackColor = Color.Teal;
        }

        private void btnTickets_Leave(object sender, EventArgs e)
        {
            btnTickets.BackColor = Color.Teal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
