using NorthBee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace NorthBee.Forms
{
    public partial class HistoryForm : ParentForm
    {
        private Guest _guest;
        public HistoryForm(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
            this.Text = $"История остановок гостя \"{_guest.FullName}\"";
            TitleLab.Text = $"История остановок гостя \"{_guest.FullName}\"";
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            historyBindingSource.DataSource = Program.context.History.Where(h=>h.GuestId == _guest.IdGuest).Select(h=> new {HotelName = h.Room.Hotel.HotelName, RoomNumber = h.Room.Number, h.CheckIn, h.CheckOut, h.Comment}).ToList();
        }
    }
}
