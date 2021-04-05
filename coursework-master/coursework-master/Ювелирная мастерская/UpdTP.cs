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
    public partial class UpdTP : Form
    {
        public static string id { get; set; }
        public static string name { get; set; }
        public static string surname { get; set; }
        public static string dateofbirth { get; set; }
        public static string phonenumber { get; set; }
        public static string salary { get; set; }
        public static string brunch { get; set; }


        public UpdTP()
        {
            InitializeComponent();
        }

        public UpdTP(string ID, string Name, string Surname, string DateBirth, string Phone, string Salary, string Brunch)
        {
            InitializeComponent();
            id = ID;
            name = Name;
            surname = Surname;
            dateofbirth = DateBirth;
            phonenumber = Phone;
            salary = Salary;
            brunch = Brunch;
            TextLoad();
            LoadQual();
        }

        public void TextLoad()
        {
            SurnameText.Text = name;
            NameText.Text = surname;
            dateTimePicker1.Text = dateofbirth;
            AddressText.Text = phonenumber;
            PhoneText.Text = salary;
            QualList.Text = brunch;
        }

        private void LoadQual()
        {
            SqlCommand sc = new SqlCommand("SELECT * FROM brunches", DataBaseWork.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            QualList.DataSource = dt;
            QualList.DisplayMember = "address";
            QualList.ValueMember = "brunchid";
        }

        private void UpdTypeBut_Click(object sender, EventArgs e)
        {
            
        }

        private void AddMasterBut_Click(object sender, EventArgs e)
        {
            DataBaseWork.OpenCon();
            string upd = String.Format("UPDATE {0} SET name = '{1}', surname = '{2}', dateofbirth = '{3}', phonenumber = '{4}', salary = '{5}', brunchid = '{6}' WHERE managerid = '{7}'", "managers", SurnameText.Text, NameText.Text, dateTimePicker1.Value.Date, AddressText.Text, PhoneText.Text, QualList.ValueMember);
            SqlCommand sc = new SqlCommand(upd, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            MessageBox.Show("Данные о менеджере успешно изменены.");
            DataBaseWork.CloseConnection();
        }
    }
}
