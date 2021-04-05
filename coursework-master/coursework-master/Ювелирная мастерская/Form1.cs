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
    public partial class UpdManager : Form
    {
        public static string id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }
        public static string salary { get; set; }
        public static string login { get; set; }
        public static string password { get; set; }

        public UpdManager()
        {
            InitializeComponent();
        }

        public UpdManager(string ID, string Surname, string Name, string Patronymic, string Address, string Phone, string Salary, string Login, string Password)
        {
            InitializeComponent();
            id = ID;
            surname = Surname;
            name = Name;
            patronymic = Patronymic;
            address = Address;
            phone = Phone;
            salary = Salary;
            login = Login;
            password = Password;
            TextLoad();
        }

        public void TextLoad()
        {
            SurnameText.Text = surname;
            NameText.Text = name;
            PatronymicText.Text = patronymic;
            AddressText.Text = address;
            PhoneText.Text = phone;
            SalaryText.Text = salary;
            LoginText.Text = login;
            PasswordText.Text = password;
        }

        private void UpdManagerBut_Click(object sender, EventArgs e)
        {
            DataBaseWork.OpenCon();
            string upd = String.Format("UPDATE {0} SET MANAGER_SURNAME = '{1}', MANAGER_NAME = '{2}', MANAGER_PATRONYMIC = '{3}',MANAGER_ADDRESS = '{4}',MANAGER_PHONE = '{5}',MANAGER_SALARY = '{6}',MANAGER_LOGIN = '{7}', MANAGER_PASSWORD = '{8}' WHERE ID = '{9}'", "MANAGERS", SurnameText.Text, NameText.Text, PatronymicText.Text, AddressText.Text, PhoneText.Text, SalaryText.Text, LoginText.Text, PasswordText.Text, id);
            SqlCommand sc = new SqlCommand(upd, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            MessageBox.Show("Данные менеджера успешно изменены.");
            DataBaseWork.CloseConnection();
            
        }
    }
}
