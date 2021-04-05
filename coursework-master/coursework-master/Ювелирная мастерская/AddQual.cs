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
    public partial class AddQual : Form
    {
        public AddQual()
        {
            InitializeComponent();
        }

        private void AddButQual_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseWork.OpenCon();
                string add = String.Format("INSERT INTO QUALIFICATION (APPELATION, Q_POWER) VALUES ('" + AText.Text + "', '" + PText.Text + "')");
                SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
                sc.ExecuteNonQuery();
                DataBaseWork.CloseConnection();
                MessageBox.Show("Квалификация успешно добавлена в базу.");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
