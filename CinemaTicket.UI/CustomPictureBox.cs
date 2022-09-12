using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicket.UI
{
    public partial class CustomPictureBox : Panel
    {
        public PictureBox filmPicture;
        public Label filmText;

        public CustomPictureBox()
        {
            InitializeComponent();
        }

        public CustomPictureBox(string image, string text, Result result)
        {
            filmPicture = new PictureBox();
            filmText = new Label();

            filmPicture.Size = new System.Drawing.Size(125, 200);
            filmPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            filmPicture.Dock = System.Windows.Forms.DockStyle.Top;
            filmPicture.Load("https://image.tmdb.org/t/p/original/" + image);
            filmPicture.Click += delegate (object sender, EventArgs e) { filmPicture_click(sender, e, result); };

            filmText.Dock = System.Windows.Forms.DockStyle.Bottom;
            filmText.AutoSize = true;
            filmText.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            filmText.ForeColor = System.Drawing.Color.DarkOrange;
            filmText.Size = new System.Drawing.Size(70, 20);
            if (text.Length > 17)
            {
                text = text.Replace(text.ElementAt(text.IndexOf(" ")).ToString(), Environment.NewLine);
            }
            filmText.Text = text;

            this.Controls.Add(filmPicture);
            this.Controls.Add(filmText);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void filmPicture_click(object sender, EventArgs e, Result message)
        {
            BuyTicketForm frm2 = new BuyTicketForm(message);
            frm2.ShowDialog();
        }
    }
}
