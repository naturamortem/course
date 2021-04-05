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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void AddTypeBut_Click(object sender, EventArgs e)
        {

            try
            {
                DataBaseWork.OpenCon();
                string add = String.Format("INSERT INTO PRODUCT_TYPE (NAME_TYPE) VALUES ('" + ApText.Text + "')");
                SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
                sc.ExecuteNonQuery();
                DataBaseWork.CloseConnection();
                MessageBox.Show("Тип успешно добавлен в базу.");
            }
            catch
            {
                MessageBox.Show("При доавлении типа изделий произошла ошибка.\nПопробуйте ещё раз.");
            }
        }
    }
}
