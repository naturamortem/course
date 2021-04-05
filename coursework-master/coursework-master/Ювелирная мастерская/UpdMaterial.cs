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
    public partial class UpdMaterial : Form
    {
        public static string id { get; set; }
        public static string appelation { get; set; }
        public static string price { get; set; }
        public static string quantity { get; set; }

        public UpdMaterial()
        {
            InitializeComponent();
        }

        public UpdMaterial(string ID, string Appelation, string Price, string Quantity)
        {
            InitializeComponent();
            id = ID;
            appelation = Appelation;
            price = Price;
            quantity = Quantity;
            TextLoad();
        }

        public void TextLoad()
        {
            ApText.Text = appelation;
            PrText.Text = price;
            QuaText.Text = quantity;
        }

        private void UpdMaterialBut_Click(object sender, EventArgs e)
        {
            decimal p = Convert.ToDecimal(price);
            decimal q = Convert.ToDecimal(QuaText.Text);
            DataBaseWork.OpenCon();
            string upd = String.Format("UPDATE {0} SET APPELATION = '{1}', PRICE_GRAM = {2}, QUANTITY = {3} WHERE ID = '{4}'", "MATERIALS", ApText.Text,p,q,id);
            SqlCommand sc = new SqlCommand(upd, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            MessageBox.Show("Данные о материале успешно изменены.");
            DataBaseWork.CloseConnection();
        }
    }
}
