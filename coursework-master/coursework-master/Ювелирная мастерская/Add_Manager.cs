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
    public partial class Add_Manager : Form
    {
        public Add_Manager()
        {
            InitializeComponent();
        }

        private void AddManager_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseWork.OpenCon();
                string add = String.Format("INSERT INTO customers (name, surname, dateofbirth, phonenumber, address, passport ) VALUES ('" + SurnameText.Text + "', '" +NameText.Text + "', '" + date_birth.Value.Date + "', '" + AddressText.Text + "', '" + PhoneText.Text + "', '" + SalaryText.Text + "')");
                SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
                sc.ExecuteNonQuery();
                DataBaseWork.CloseConnection();
                MessageBox.Show("Клиент успешно добавлен в базу.");
            }
            catch
            {
                MessageBox.Show("Ошибка добавления.\nПопробуйте ещё раз");
            }
        }
    }
}
