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
    public partial class Admin : Form
    {
        public static DataTable res;
        string manager = "SELECT * FROM MANAGERS";
        string master = "SELECT * FROM MASTERS";
        string qual = "SELECT * FROM QUALIFICATION";
        string product = "SELECT * FROM PRODUCT";
        string material = "SELECT * FROM MATERIALS";
        string type = "SELECT * FROM PRODUCT_TYPE";

        public Admin()
        {
            InitializeComponent();
            Main.Loading(manager, ManagerList);
        }

        private void AdminPanel_Selected(object sender, TabControlEventArgs e)
        {
            if (AdminPanel.SelectedTab == Managers)
            {
                Main.Loading(manager, ManagerList);
            }
            else if (AdminPanel.SelectedTab == Masters)
            {
                Main.Loading(master, MasterList);
            }
            else if (AdminPanel.SelectedTab == Qualification)
            {
                Main.Loading(qual, QualList);
            }
            else if (AdminPanel.SelectedTab == Products)
            {
                Main.Loading(product, ProductList);
            }
            else if (AdminPanel.SelectedTab == Products_Type)
            {
                Main.Loading(type, TypeList);
            }
            else if (AdminPanel.SelectedTab == Materials)
            {
                Main.Loading(material, MaterialList);
            }
        }

        private void Add_Manager_Click(object sender, EventArgs e)
        {
            Add_Manager am = new Add_Manager();
            am.ShowDialog();
        }

        private void Update_Manager_Click(object sender, EventArgs e)
        {
            List<string> manager = new List<string>();
            var number = ManagerList.CurrentCell.RowIndex;
            DataGridViewRow row = ManagerList.Rows[number];
            UpdManager um = new UpdManager(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString(),
                row.Cells[7].Value.ToString(),
                row.Cells[8].Value.ToString());
            um.ShowDialog();
        }

        private void Delete_Manager_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Manager.DeleteManager(ManagerList);
                    MessageBox.Show("Данные менеджера удалены из базы");
                    Main.Loading("SELECT * FROM MANAGERS", ManagerList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
            
        }

        private void Add_Master_Click(object sender, EventArgs e)
        {
            AddMaster am = new AddMaster();
            am.ShowDialog();
        }

        private void Add_Qual_Click(object sender, EventArgs e)
        {
            AddQual aq = new AddQual();
            aq.ShowDialog();
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddMaterial am = new AddMaterial();
            am.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddType at = new AddType();
            at.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> qual = new List<string>();
            var number = QualList.CurrentCell.RowIndex;
            DataGridViewRow row = QualList.Rows[number];
            UpdQual uq = new UpdQual(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString());
            uq.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> material = new List<string>();
            var number = MaterialList.CurrentCell.RowIndex;
            DataGridViewRow row = MaterialList.Rows[number];
            UpdMaterial um = new UpdMaterial(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                 row.Cells[3].Value.ToString());
            um.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> type = new List<string>();
            var number = TypeList.CurrentCell.RowIndex;
            DataGridViewRow row = TypeList.Rows[number];
            UpdTP up = new UpdTP(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString());
            up.ShowDialog();
        }

        private void Delete_Qual_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataBaseWork.OpenCon();
                    var num = (int)QualList.CurrentRow.Cells["ID"].Value;
                    SqlCommand sc = new SqlCommand(String.Format("DELETE FROM QUALIFICATION WHERE ID = {0}", num), DataBaseWork.Con);
                    sc.ExecuteNonQuery();
                    DataBaseWork.CloseConnection();
                    MessageBox.Show("Квалификация удалена");
                    Main.Loading("SELECT * FROM QUALIFICATION", MasterList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataBaseWork.OpenCon();
                    var num = (int)MaterialList.CurrentRow.Cells["ID"].Value;
                    SqlCommand sc = new SqlCommand(String.Format("DELETE FROM MATERIALS WHERE ID = {0}", num), DataBaseWork.Con);
                    sc.ExecuteNonQuery();
                    DataBaseWork.CloseConnection();
                    MessageBox.Show("Материал удален");
                    Main.Loading("SELECT * FROM MATERIALS", MaterialList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataBaseWork.OpenCon();
                    var num = (int)TypeList.CurrentRow.Cells["ID"].Value;
                    SqlCommand sc = new SqlCommand(String.Format("DELETE FROM PRODUCT_TYPE WHERE ID = {0}", num), DataBaseWork.Con);
                    sc.ExecuteNonQuery();
                    DataBaseWork.CloseConnection();
                    MessageBox.Show("Тип изделий удален");
                    Main.Loading("SELECT * FROM PRODUCT_TYPE", TypeList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
            
        }

        private void Update_Master_Click(object sender, EventArgs e)
        {
            List<string> master = new List<string>();
            var number = MasterList.CurrentCell.RowIndex;
            DataGridViewRow row = MasterList.Rows[number];
            UpdMaster um = new UpdMaster(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString());
            um.ShowDialog();
        }

        private void Delete_Master_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataBaseWork.OpenCon();
                    var num = (int)MasterList.CurrentRow.Cells["ID"].Value;
                    SqlCommand sc = new SqlCommand(String.Format("DELETE FROM MASTERS WHERE ID = {0}", num), DataBaseWork.Con);
                    sc.ExecuteNonQuery();
                    DataBaseWork.CloseConnection();
                    MessageBox.Show("Данные о мастере успешно удалены");
                    Main.Loading("SELECT * FROM MASTERS", MasterList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void Update_Product_Click(object sender, EventArgs e)
        {
            List<string> product = new List<string>();
            var number = ProductList.CurrentCell.RowIndex;
            DataGridViewRow row = ProductList.Rows[number];
            UpdProduct um = new UpdProduct(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString());
            um.ShowDialog();
        }

        private void Delete_Product_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataBaseWork.OpenCon();
                    var num = (int)ProductList.CurrentRow.Cells["ID"].Value;
                    SqlCommand sc = new SqlCommand(String.Format("DELETE FROM PRODUCT WHERE ID = {0}", num), DataBaseWork.Con);
                    sc.ExecuteNonQuery();
                    DataBaseWork.CloseConnection();
                    MessageBox.Show("Изделие удалено.");
                    Main.Loading("SELECT * FROM PRODUCT", ProductList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void ManagerSearch_TextChanged(object sender, EventArgs e)
        {
            string manager = "SELECT * FROM MANAGERS WHERE CONCAT (MANAGER_SURNAME, MANAGER_NAME, MANAGER_PATRONYMIC, MANAGER_ADDRESS, MANAGER_PHONE) LIKE '%" + ManagerSearch.Text + "%' ";
            Main.Loading(manager, ManagerList);
        }

        private void MasterSearch_TextChanged(object sender, EventArgs e)
        {
            string master = "SELECT * FROM MASTERS WHERE CONCAT (MAS_SURNAME, MAS_NAME, MAS_PATRONYMIC, MAS_ADDRESS, MAS_NUMBER) LIKE '%" + MasterSearch.Text + "%' ";
            Main.Loading(master, MasterList);
        }

        private void QualSearch_TextChanged(object sender, EventArgs e)
        {
            string qual = "SELECT * FROM QUALIFICATION WHERE CONCAT (APPELATION, Q_POWER) LIKE '%" + QualSearch.Text + "%' ";
            Main.Loading(qual, QualList);
        }

        private void ProductSearch_TextChanged(object sender, EventArgs e)
        {
            string product = "SELECT * FROM PRODUCT WHERE CONCAT (APPELATION, P_TYPE,TIME_PROD ) LIKE '%" + ProductSearch.Text + "%' ";
            Main.Loading(product, ProductList);
        }

        private void MaterialSearch_TextChanged(object sender, EventArgs e)
        {
            string material = "SELECT * FROM MATERIALS WHERE CONCAT (APPELATION, PRICE_GRAM,QUANTITY ) LIKE '%" + MaterialSearch.Text + "%' ";
            Main.Loading(material, MaterialList);
        }

        private void TypeSearch_TextChanged(object sender, EventArgs e)
        {
            string type = "SELECT * FROM PRODUCT_TYPE WHERE NAME_TYPE LIKE '%" + TypeSearch.Text + "%' ";
            Main.Loading(type, TypeList);
        }
    }
}
