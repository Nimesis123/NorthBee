using NorthBee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace NorthBee.Forms
{
    public partial class AddUpdateForm : ParentForm
    {
        private Guest _guest;
        private bool create = true;
        public AddUpdateForm()
        {
            InitializeComponent();
            _guest = new Guest();
            this.Text = $"Добавление гостя";
            TitleLab.Text = $"Добавление гостя";
            ShowInfo();
            create = true;
        }
        public AddUpdateForm(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
            this.Text = $"Редактирование гостя \"{_guest.FullName}\"";
            TitleLab.Text = $"Редактирование гостя \"{_guest.FullName}\"";
            guestBindingSource.DataSource = _guest;
            create = false;
        }
        private void ShowInfo()
        {
            fullNameTextBox.Text = "";
            DateTime date = DateTime.Now.AddYears(-18);
            birthdayDateTimePicker.Value = date;
        }
        private void GetInfo()
        {
            _guest.FullName = fullNameTextBox.Text;
            _guest.Birthday = birthdayDateTimePicker.Value;
            _guest.GenderId = (int)genderIdComboBox.SelectedValue;
            _guest.StatusId = (int)statusIdComboBox.SelectedValue;
        }
        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            statusBindingSource.DataSource = Program.context.Status.ToList();
            genderBindingSource.DataSource = Program.context.Gender.ToList();
            if (!create)
            {
                statusIdComboBox.SelectedValue = _guest.StatusId;
                genderIdComboBox.SelectedValue = _guest.GenderId;
            }
            else
            {
                genderIdComboBox.SelectedIndex = 0;
                statusIdComboBox.SelectedIndex = 0;
            }
        }
        private bool ValidateFullName()
        {
            if(fullNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Поле ФИО не может быть пустым!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidateDateBirthday()
        {
            if (birthdayDateTimePicker.Value>DateTime.Now)
            {
                MessageBox.Show("Значение дня рождения не может быть позже текущей даты", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool Validate()
        {
            if (!ValidateFullName() || !ValidateDateBirthday())
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }
            GetInfo();
            DialogResult ToSave = MessageBox.Show("Сохранить?", "Запрос подтверждения", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ToSave == DialogResult.Cancel)
            {
                return;
            }
            if(_guest.IsNew())
            {
                Program.context.Guest.Add(_guest);
            }
            Program.context.SaveChanges();
            MessageBox.Show("Успешное сохранение данных", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
