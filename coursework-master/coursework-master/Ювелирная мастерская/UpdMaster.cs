using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ювелирная_мастерская
{
    public partial class UpdMaster : Form
    {
        public static string id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }
        public static string qual { get; set; }

        public UpdMaster()
        {
            InitializeComponent();
        }

        public UpdMaster(string ID, string Surname, string Name, string Patronymic, string Address, string Phone, string Qual)
        {
            InitializeComponent();
            id = ID;
            surname = Surname;
            name = Name;
            patronymic = Patronymic;
            address = Address;
            phone = Phone;
            qual = Qual;
            LoadText();
        }

        public void LoadText()
        {
            SurnameText.Text = surname;
            NameText.Text = name;
            dateTimePicker1.Text = patronymic;
            AddressText.Text = address;
            PhoneText.Text = phone;
            SalaryText.Text = qual;
        }

        private void UpdMasterBut_Click(object sender, EventArgs e)
        {

            DataBaseWork.OpenCon();
            string save = String.Format("UPDATE {0} SET name = '{1}', surname = '{2}', dateofbirth  = '{3}', phonenumber = '{4}',address = '{5}', passport = '{6}'  WHERE customerid = '{7}'", "customers", SurnameText.Text, NameText.Text, dateTimePicker1.Value.Date, AddressText.Text, PhoneText.Text,SalaryText.Text, id);
            SqlCommand com = new SqlCommand(save, DataBaseWork.Con);
            com.ExecuteNonQuery();
            MessageBox.Show("Данные о клиенте успешно изменены");
        }
    }
}
