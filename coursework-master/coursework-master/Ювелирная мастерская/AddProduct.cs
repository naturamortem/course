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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            LoadType();
        }

        private void LoadType()
        {
            SqlCommand sc = new SqlCommand("SELECT * FROM PRODUCT_TYPE", DataBaseWork.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            TypeCombo.DataSource = dt;
            TypeCombo.DisplayMember = "NAME_TYPE";
            TypeCombo.ValueMember = "ID";
        }

        private void AddProductBut_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(TypeCombo.SelectedValue);

            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO PRODUCT (APPELATION,P_TYPE,TIME_PROD ) VALUES ('" + Appelation.Text + "', "+t+", '"+TimeProd.Text+"')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Изделие успешно добавлено");
        }
    }
}
