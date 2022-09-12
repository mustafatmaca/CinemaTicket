using CinemaTicket.Business.Abstract;
using CinemaTicket.Business.DependencyResolvers.Ninject;
using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicket.UI
{
    public partial class BuyTicketForm : Form
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

        public int ticketUnit { get; set; } = 1;
        public int ticketPrice { get; set; } = 25;
        public Result film { get; set; }

        private ISalonService _salonService;
        private ISessionService _sessionService;
        private ITicketService _ticketService;

        public List<int> salonId { get; set; }


        public BuyTicketForm(Result result)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            _salonService = InstanceFactory.GetInstance<ISalonService>();
            _sessionService = InstanceFactory.GetInstance<ISessionService>();
            _ticketService = InstanceFactory.GetInstance<ITicketService>();
            this.tbTicketFilm.Text = result.title;
            film = result;
            salonId = new List<int>();
            UpdateTicketPrice();
            UpdateTicketUnit();
            LoadSalon();
        }

        private void UpdateTicketUnit()
        {
            this.tbTicketUnit.Text = ticketUnit.ToString();
        }

        private void UpdateTicketPrice()
        {
            this.lblPrice.Text = String.Format("Price : {0}₺", ticketPrice);
        }

        private void LoadSalon()
        {

            foreach (var session in _sessionService.GetListByFilmName(film.title))
            {
                salonId.Add(session.SalonId);
            }

            cbTicketSalon.DataSource = _salonService.GetSalonsById(salonId);
            cbTicketSalon.SelectedIndex = 0;
            cbTicketSalon.DisplayMember = "Id";
            cbTicketSalon.ValueMember = "Id";
            cbTicketSalon.SelectedItem = null;
        }

        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDecr_Click(object sender, EventArgs e)
        {
            if (ticketUnit == 1)
            {
                MessageBox.Show("Ticket Unit must be at least 1");
            }
            else
            {
                ticketUnit--;
                ticketPrice -= 25;
                UpdateTicketPrice();
                UpdateTicketUnit();
            }
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            // to-do capacity control
            ticketUnit++;
            ticketPrice += 25;
            UpdateTicketPrice();
            UpdateTicketUnit();
        }

        private void cbTicketSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_sessionService.GetListByFilmNameAndSalonId(film.title, Convert.ToInt32(cbTicketSalon.SelectedValue)).Count == 0)
                {
                    cbTicketSession.SelectedItem = null;
                    cbTicketSession.DataSource = _sessionService.GetListByFilmNameAndSalonId(film.title, Convert.ToInt32(cbTicketSalon.SelectedValue));
                    cbTicketSession.DisplayMember = "SessionTime";
                    cbTicketSession.ValueMember = "Id";
                }
                else
                {
                    cbTicketSession.DataSource = _sessionService.GetListByFilmNameAndSalonId(film.title, Convert.ToInt32(cbTicketSalon.SelectedValue));
                    cbTicketSession.DisplayMember = "SessionTime";
                    cbTicketSession.ValueMember = "Id";
                }

            }
            catch
            {

            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int totalTicketUnit = 0;
            foreach (var ticket in _ticketService.GetTicketsBySalonId(Convert.ToInt32(cbTicketSalon.SelectedValue)))
            {
                totalTicketUnit += ticket.TicketUnit;
            };

            if (totalTicketUnit >= _salonService.GetById(Convert.ToInt32(cbTicketSalon.SelectedValue)).Capacity)
            {
                MessageBox.Show("This session is full. Please try other session", "Buy Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _ticketService.Add(new Ticket
                {
                    SalonId = Convert.ToInt32(cbTicketSalon.SelectedValue),
                    SessionId = Convert.ToInt32(cbTicketSession.SelectedValue),
                    FilmId = film.id,
                    FilmName = film.title,
                    TicketUnit = ticketUnit,
                    Price = Convert.ToDecimal(ticketPrice)
                });

                MessageBox.Show("Confirmed", "Buy Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

        }
    }
}
