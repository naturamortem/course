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
    public partial class Upd_Client : Form
    {
        public static string id { get; set; }
        public static string address { get; set; }
        public static string contactphone { get; set; }


        public Upd_Client()
        {
            InitializeComponent();
        }

        public Upd_Client(string ID, string Address, string ConPhone)
        {
            InitializeComponent();
            id = ID;
            address = Address;
            contactphone = ConPhone;
            TextLoad();
        }

        public void TextLoad()
        {
            Surname_Client.Text = address;
            Name_Client.Text = contactphone;
        }

        private void Save_Client_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseWork.OpenCon();
                string save = String.Format("UPDATE {0} SET address = '{1}', contactphone = '{2}' WHERE brunchid = '{3}'", "brunches", Surname_Client.Text, Name_Client.Text, id);
                SqlCommand com = new SqlCommand(save, DataBaseWork.Con);
                com.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
