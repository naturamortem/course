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
    public partial class UpdQual : Form
    {
        public static string id { get; set; }
        public static string appelation { get; set; }
        public static string q_power { get; set; }

        public UpdQual()
        {
            InitializeComponent();
        }

        public UpdQual(string ID, string Appelation, string Q_Power)
        {
            InitializeComponent();
            id = ID;
            appelation = Appelation;
            q_power = Q_Power;
            TextLoad();
        }

        public void TextLoad()
        {
            AText.Text = appelation;
            PText.Text = q_power;
        }

        private void AddButQual_Click(object sender, EventArgs e)
        {

            DataBaseWork.OpenCon();
            string upd = String.Format("UPDATE {0} SET APPELATION = '{1}', Q_POWER = '{2}' WHERE ID = '{3}'", "QUALIFICATION",AText.Text,PText.Text , id);
            SqlCommand sc = new SqlCommand(upd, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            MessageBox.Show("Данные о квалификации успешно изменены.");
            DataBaseWork.CloseConnection();

        }
    }
}
