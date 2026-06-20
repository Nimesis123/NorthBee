using NorthBee.Models;
using NorthBee.Forms;
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

namespace NorthBee.CustomControl
{
    public partial class GuestUserControl : UserControl
    {
        private Guest _guest;
        public GuestUserControl(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
            SetInfo();
        }
        private void SetInfo()
        {
            FioLab.Text = $"ФИО: {_guest.FullName}";
            List<Gender> genders = Program.context.Gender.Where(g=>g.IdGender == _guest.GenderId).ToList();
            foreach (Gender gender in genders)
            {
                GenderLab.Text = $"Пол: {gender.GenderName}";
                break;
            }
            DateBirthdayLab.Text = $"Дата рождения: {_guest.Birthday.ToShortDateString()}";
            List<History> histories = Program.context.History.Where(h => h.GuestId == _guest.IdGuest).ToList();
            int count = 0;
            foreach (History history in histories)
            {
                count++;
            }
            CountLab.Text = $"Сколько раз останавливался: {count}";
            List<Status> statuses = Program.context.Status.Where(s=>s.IdStatus == _guest.StatusId).ToList();
            foreach(Status status in statuses)
            {
                StatusLab.Text = $"Статус: {status.StatusName}";
                break;
            }
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(_guest);
            historyForm.ShowDialog();
        }

        private void FioLab_Click(object sender, EventArgs e)
        {
            AddUpdateForm addUpdateForm = new AddUpdateForm(_guest);
            DialogResult update = addUpdateForm.ShowDialog();
            if (update == DialogResult.OK)
            {
                MainForm mainForm = (MainForm)this.Parent.Parent.Parent.Parent;
                mainForm.UpdateListGuest();
            }
        }
    }
}
