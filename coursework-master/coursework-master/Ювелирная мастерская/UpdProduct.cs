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
    public partial class UpdProduct : Form
    {
        public static string id { get; set; }
        public static string appelation { get; set; }
        public static string type { get; set; }
        public static string time { get; set; }

        public UpdProduct()
        {
            InitializeComponent();
        }

        public UpdProduct(string ID, string Appelation, string Type, string Time)
        {
            InitializeComponent();
            id = ID;
            appelation = Appelation;
            type = Type;
            time = Time;
            LoadText();
            LoadType();
        }

        public void LoadText()
        {
            Appelation.Text = appelation;
            TimeProd.Text = time;
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

        private void UpdProductBut_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(TypeCombo.SelectedValue);

            DataBaseWork.OpenCon();
            string save = String.Format("UPDATE {0} SET APPELATION = '{1}', P_TYPE = {2},TIME_PROD = '{3}' WHERE ID = '{4}'", "PRODUCT", Appelation.Text, t, TimeProd.Text, id);
            SqlCommand com = new SqlCommand(save, DataBaseWork.Con);
            com.ExecuteNonQuery();
            MessageBox.Show("Данные об изделии успешно изменены");
        }
    }
}
