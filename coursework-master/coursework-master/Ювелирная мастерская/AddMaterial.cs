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
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void AddMaterialBut_Click(object sender, EventArgs e)
        {
            try
            {
                decimal pr = Convert.ToDecimal(PrText.Text);
                decimal q = Convert.ToDecimal(QuaText.Text);
                DataBaseWork.OpenCon();
                string add = String.Format("INSERT INTO MATERIALS (APPELATION, PRICE_GRAM,QUANTITY ) VALUES ('" + ApText.Text + "', " + pr + ", "+q+")");
                SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
                sc.ExecuteNonQuery();
                DataBaseWork.CloseConnection();
                MessageBox.Show("Материал успешно добавлен в базу.");
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении материала.\nПопробуйте ещё раз.");
            }
        }
    }
}
