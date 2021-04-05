using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Excel;

namespace Ювелирная_мастерская
{
    public partial class Main : Form
    {
        public static DataTable res;
        string i;
        public Main()
        {
            InitializeComponent();
            
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = DataBaseWork.Load(query);
            grid.DataSource = res;     
        }

        private void Menu_Selected(object sender, TabControlEventArgs e)
        {
            if(Menu.SelectedTab == ClientPage)
            {
                string client = "SELECT * FROM brunches";
                Loading(client, brunch_list);

            }
            else if(Menu.SelectedTab == ProductPage)
            {
                string product = "SELECT * FROM cars";
                Loading(product, ProductList);
                
            }
            else if (Menu.SelectedTab == MaterialPage)
            {
                string product = "SELECT * FROM contracts";
                Loading(product, MaterialList);
            }
            else if (Menu.SelectedTab == TypePage)
            {
                string type = "SELECT * FROM customers";
                Loading(type, customer_list);
            }
            else if (Menu.SelectedTab == OrdersPage)
            {
                string order = "SELECT * FROM managers";
                Loading(order, manager_list);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Add_Client_Click(object sender, EventArgs e)
        {
            add_brunch ac = new add_brunch();
            ac.ShowDialog();
        }

        private void Delete_Client_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataBaseWork.OpenCon();
                    var num = (int)brunch_list.CurrentRow.Cells["brunchid"].Value;
                    SqlCommand sc = new SqlCommand(String.Format("DELETE FROM brunches WHERE brunchid = {0}", num), DataBaseWork.Con);
                    sc.ExecuteNonQuery();
                    DataBaseWork.CloseConnection();
                    MessageBox.Show("Данные о филиале удалены");
                    Loading("SELECT * FROM brunches", brunch_list);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void All_Client_Click(object sender, EventArgs e)
        {
            string client = "SELECT * FROM CLIENTS";
            Loading(client, brunch_list);
        }

        private void Upd_Client_Click(object sender, EventArgs e)
        {
            List<string> client = new List<string>();
            var number = brunch_list.CurrentCell.RowIndex;
            DataGridViewRow row = brunch_list.Rows[number];
            Upd_Client uc = new Upd_Client(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString());
            uc.ShowDialog();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            string client = "SELECT * FROM CLIENTS WHERE CONCAT (C_SURNAME, C_NAME, C_PATRONYMIC, C_ADDRESS, C_NUMBER) LIKE '%" + SearchText.Text +"%' ";
            Loading(client, brunch_list);

        }

        private void ProductList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void surname_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (surname_sort.Checked == true)
            {
                string client = "SELECT * FROM CLIENTS ORDER BY C_SURNAME ASC";
                Loading(client, brunch_list);
                name_sort.Enabled = false;
                patronymic_sort.Enabled = false;
            }
            else if (surname_sort.Checked == false)
            {
                string client = "SELECT * FROM CLIENTS";
                Loading(client, brunch_list);
                name_sort.Enabled = true;
                patronymic_sort.Enabled = true;
            }
        }

        private void name_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (name_sort.Checked == true)
            {
                string client = "SELECT * FROM CLIENTS ORDER BY C_NAME ASC";
                Loading(client, brunch_list);
                surname_sort.Enabled = false;
                patronymic_sort.Enabled = false;
            }
            else if (name_sort.Checked == false)
            {
                string client = "SELECT * FROM CLIENTS";
                Loading(client, brunch_list);
                surname_sort.Enabled = true;
                patronymic_sort.Enabled = true;
            }
        }

        private void patronymic_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (patronymic_sort.Checked == true)
            {
                string client = "SELECT * FROM CLIENTS ORDER BY C_PATRONYMIC ASC";
                Loading(client, brunch_list);
                name_sort.Enabled = false;
                surname_sort.Enabled = false;
            }
            else if (patronymic_sort.Checked == false)
            {
                string client = "SELECT * FROM CLIENTS";
                Loading(client, brunch_list);
                name_sort.Enabled = true;
                surname_sort.Enabled = true;
            }
        }

        private void spt_TextChanged(object sender, EventArgs e)
        {
            string product = "SELECT * FROM PRODUCT WHERE CONCAT (APPELATION, P_TYPE, TIME_PROD) LIKE '%" + spt.Text + "%' ";
            Loading(product, ProductList);
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
            TypeCombo.SelectedIndex = 0;
        }

        private void SelectType_Click(object sender, EventArgs e)
        {
            string FilterProduct = "SELECT * FROM PRODUCT WHERE P_TYPE = '"+i+"'";
            Loading(FilterProduct, ProductList);
        }

        private void TypeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            i = TypeCombo.SelectedValue.ToString();
        }

        private void TimeProdSort_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeProdSort.Checked == true)
            {
                string prodtime = "SELECT * FROM PRODUCT ORDER BY TIME_PROD ASC";
                Loading(prodtime, ProductList);
                AlphaSort.Enabled = false;
            }
            else if (TimeProdSort.Checked == false)
            {
                string products = "SELECT * FROM PRODUCT";
                Loading(products, ProductList);
                AlphaSort.Enabled = true;
            }
        }

        private void AlphaSort_CheckedChanged(object sender, EventArgs e)
        {
            if (AlphaSort.Checked == true)
            {
                string prodalpha = "SELECT * FROM PRODUCT ORDER BY APPELATION ASC";
                Loading(prodalpha, ProductList);
                TimeProdSort.Enabled = false;
            }
            else if (AlphaSort.Checked == false)
            {
                string products = "SELECT * FROM PRODUCT";
                Loading(products, ProductList);
                TimeProdSort.Enabled = true;
            }
        }

        private void ExitAccount_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void LoadCombo()
        {
            //DataBaseWork.OpenCon();

            //SqlCommand sc = new SqlCommand("SELECT * FROM PRODUCT", DataBaseWork.Con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(sc);
            //da.Fill(dt);
            //ProdList.DataSource = dt;
            //ProdList.DisplayMember = "APPELATION";
            //ProdList.ValueMember = "ID";
            //ProdList.SelectedIndex = 0;
        }

        private void OrderBut_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(ProdList.SelectedValue);
            int mat = Convert.ToInt32(MatList.SelectedValue);
            int mas = Convert.ToInt32(MasList.SelectedValue);
            decimal pr = Convert.ToDecimal(PriceEnd.Text);
            string time = TimeProd.Text;
            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO ORDERS (ID_PRODUCT,ID_MATERIAL, ID_MASTER, PRICE, TIME_PROD ) VALUES (" + p + ", " + mat + ", " + mas + ", " + pr + ", '" + time + "')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Заказ успешно добавлен");
        }

        private void ContrBut_Click(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(OrderNum.SelectedValue);
            int client = Convert.ToInt32(CliList.SelectedValue);
            
            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO CONTRACTS (ID_ORDER,ID_CLIENT, ID_MANAGER, DATE_CONTR) VALUES (" + o + ", " + client + ", " + Manager.id + ", '"+ DateContr.Value.Date + "')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Договор успешно добавлен");
        }

        private void ImportToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < ProductList.Rows.Count; i++)
            {
                for (int j = 0; j < ProductList.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = ProductList.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ReportStart_Click(object sender, EventArgs e)
        {
            string report = "SELECT COUNT (*) AS [Общее количество договоров] FROM CONTRACTS WHERE ID_MANAGER = '" + Manager.id + "'";
            string report1 = "SELECT * FROM CONTRACTS WHERE ID_ORDER = (SELECT * FROM ORDERS) AND ID_MANAGER = '" + Manager.id + "'";
            res = DataBaseWork.Load(report1);
            ReportView.DataSource = res;
        }

        private void add_customers_Click(object sender, EventArgs e)
        {
            Add_Manager ac = new Add_Manager();
            ac.Show();
        }

        private void upd_customers_Click(object sender, EventArgs e)
        {
            List<string> customers = new List<string>();
            var number = customer_list.CurrentCell.RowIndex;
            DataGridViewRow row = customer_list.Rows[number];
            UpdMaster ac = new UpdMaster(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString());
            ac.ShowDialog();
        }

        private void delete_customer_Click(object sender, EventArgs e)
        {
            DataBaseWork.OpenCon();
            var num = (int)customer_list.CurrentRow.Cells["customerid"].Value;
            SqlCommand sc = new SqlCommand(String.Format("DELETE FROM customers WHERE customerid = {0}", num), DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Данные о клиенте успешно удалены");
        }

        private void delete_manager_Click(object sender, EventArgs e)
        {
            DataBaseWork.OpenCon();
            var num = (int)manager_list.CurrentRow.Cells["managerid"].Value;
            SqlCommand sc = new SqlCommand(String.Format("DELETE FROM managers WHERE managerid = {0}", num), DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Данные о менеджере успешно удалены");
        }

        private void add_manager_Click(object sender, EventArgs e)
        {
            AddMaster am = new AddMaster();
            am.Show();
        }

        private void upd_manager_Click(object sender, EventArgs e)
        {
            List<string> type = new List<string>();
            var number = manager_list.CurrentCell.RowIndex;
            DataGridViewRow row = manager_list.Rows[number];
            UpdTP up = new UpdTP(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString());
            up.ShowDialog();
        }
    }
}
