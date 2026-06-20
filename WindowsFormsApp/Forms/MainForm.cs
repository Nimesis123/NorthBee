using NorthBee.Models;
using NorthBee.CustomControl;
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
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
            ShowListGuest();
        }
        private void ShowListGuest()
        {
            List<Guest> guests = Program.context.Guest.OrderByDescending(g=>g.IdGuest).ToList();
            foreach (Guest guest in guests)
            {
                flowLayoutPanel1.Controls.Add(new GuestUserControl(guest));
            }
        }
        private void ClearListGuest()
        {
            flowLayoutPanel1.Controls.Clear();
        }
        public void UpdateListGuest()
        {
            ClearListGuest();
            ShowListGuest();
        }

        private void AddGuestBtn_Click(object sender, EventArgs e)
        {
            AddUpdateForm addUpdateForm = new AddUpdateForm();
            DialogResult update = addUpdateForm.ShowDialog();
            if(update == DialogResult.OK)
            {
                UpdateListGuest();
            }
        }
    }
}
