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
    public partial class add_brunch : Form
    {
        public add_brunch()
        {
            InitializeComponent();
        }

        private void Save_Client_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseWork.OpenCon();
                string add = String.Format("INSERT INTO brunches (address, contactphone) VALUES ('" + address_brunch.Text + "', '" + conphone_brunch.Text + "')");
                SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
                sc.ExecuteNonQuery();
                DataBaseWork.CloseConnection();
                MessageBox.Show("Филиал успешно добавлен в базу.");
            }
            catch
            {
                MessageBox.Show("Ошибка добавления.\nПопробуйте ещё раз");
            }
        }
    }
}
