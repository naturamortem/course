using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Ювелирная_мастерская
{
    class Product
    {
        public static void AddProuct(string surname, string name, string patronimyc, string address, string phone)
        {
            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO CLIENTS (C_SURNAME,C_NAME,C_PATRONYMIC,C_ADDRESS,C_NUMBER) VALUES ('" + surname + "', '" + name + "', '" + patronimyc + "', '" + address + "', '" + phone + "')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
        }

        public static void DeleteProduct(DataGridView grid)
        {
            DataBaseWork.OpenCon();
            var num = (int)grid.CurrentRow.Cells["ID"].Value;
            SqlCommand sc = new SqlCommand(String.Format("DELETE FROM CLIENTS WHERE ID = {0}", num), DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
        }

        public static void UpdProduct(string surname, string name, string patronimyc, string address, string phone)
        {
            DataBaseWork.OpenCon();
            string add = String.Format("UPDATE {0} SET C_SURNAME = '{1}', C_NAME = '{2}', C_PATRONYMIC = '{3}', C_ADDRESS = '{4}', C_NUMBER = '{5}' WHERE ID = '{6}'", "CLIENTS", surname, name, patronimyc, address, phone);
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
        }
    }
}
