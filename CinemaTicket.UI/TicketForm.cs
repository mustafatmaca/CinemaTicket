using CinemaTicket.Business.Abstract;
using CinemaTicket.Business.DependencyResolvers.Ninject;
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
    public partial class TicketForm : Form
    {
        private ITicketService _ticketService;

        public TicketForm()
        {
            InitializeComponent();
            _ticketService = InstanceFactory.GetInstance<ITicketService>();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dgwTickets.AutoGenerateColumns = false;
            dgwTickets.ColumnCount = 4;

            dgwTickets.Columns[0].Name = "No";
            dgwTickets.Columns[0].DataPropertyName = "Id";
            dgwTickets.Columns[0].Width = 175;
            dgwTickets.Columns[1].Name = "FilmName";
            dgwTickets.Columns[1].DataPropertyName = "FilmName";
            dgwTickets.Columns[1].Width = 175;
            dgwTickets.Columns[2].Name = "TicketUnit";
            dgwTickets.Columns[2].DataPropertyName = "TicketUnit";
            dgwTickets.Columns[2].Width = 175;
            dgwTickets.Columns[3].Name = "Price";
            dgwTickets.Columns[3].DataPropertyName = "Price";
            dgwTickets.Columns[3].Width = 175;

            LoadTickets(bindingSource1);
            

            //dgwTickets.DataSource = _ticketService.GetAll();
        }

        private void LoadTickets(BindingSource bindingSource1)
        {
            bindingSource1.DataSource = _ticketService.GetAll();
            dgwTickets.DataSource = bindingSource1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            _ticketService.Delete(new Ticket { Id = Convert.ToInt32(dgwTickets.CurrentRow.Cells[0].Value) });
            MessageBox.Show("Deleted");
            LoadTickets(bindingSource1);
        }
    }
}
