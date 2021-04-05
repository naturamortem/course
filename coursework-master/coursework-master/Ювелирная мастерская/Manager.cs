using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ювелирная_мастерская
{
    class Manager
    {
        public static int id;
        public static string surname;
        public static string name;
        public static string patronymic;
        public static string address;
        public static string phone;
        public static float salary;
        public static string login;
        public static string password;


        public Manager(int ID, string Surname, string Name, string Patronymic, string Address, string Phone, float Salary, string Login, string Password)
        {
            ID = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Address = address;
            Phone = phone;
            Salary = salary;
            Login = login;
            Password = password;
        }

        public static void AddManager(string surname, string name, string patronimyc, string address, string phone, string salary, string login, string password)
        {
            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO MANAGERS (MANAGER_SURNAME,MANAGER_NAME,MANAGER_PATRONYMIC,MANAGER_ADDRESS, MANAGER_PHONE, MANAGER_SALARY,MANAGER_LOGIN, MANAGER_PASSWORD) VALUES ('" + surname + "', '" + name + "', '" + patronimyc + "', '" + address + "', '" + phone + "', '"+salary+"', '"+login+"', '"+password+"')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
        }

        public static void DeleteManager(DataGridView grid)
        {
            DataBaseWork.OpenCon();
            var num = (int)grid.CurrentRow.Cells["ID"].Value;
            SqlCommand sc = new SqlCommand(String.Format("DELETE FROM MANAGERS WHERE ID = {0}", num), DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
        }
    }
}
