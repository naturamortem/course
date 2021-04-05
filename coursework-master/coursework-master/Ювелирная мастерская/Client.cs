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
    class Client
    {
        public static int id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }

        public Client(int ID, string Surname, string Name, string Patronymic, string Address, string Phone)
        {
            ID = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Address = address;
            Phone = phone;
        }

        public static void AddClient(string surname, string name, string patronimyc, string address, string phone)
        {
            
        }

        public static void DeleteClient(DataGridView grid)
        {
            
        }

        public static void UpdClient(string surname, string name, string patronimyc, string address, string phone)
        {
            DataBaseWork.OpenCon();
            string add = String.Format("UPDATE {0} SET C_SURNAME = '{1}', C_NAME = '{2}', C_PATRONYMIC = '{3}', C_ADDRESS = '{4}', C_NUMBER = '{5}' WHERE ID = '{6}'", "CLIENTS", surname, name, patronimyc, address, phone);
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
        }

    }
}
