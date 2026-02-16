/*using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace CRabina 
{
    internal class Crud
    {
        public void CreateTable()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("create table crud (Name varchar(50),Roll int,Dept varchar(50))", conn);
                int row = cmd.ExecuteNonQuery();
                if (row == 0)
                {
                    Console.WriteLine("Table created successfully");
                }
                else
                {
                    Console.WriteLine("Table create failed");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Roll:");
                int Roll = int.Parse(Console.ReadLine());
                Console.WriteLine("Department:");
                string Dept = Console.ReadLine();
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into crud(Name,Roll,Dept) values(@name,@roll,@dept)", conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@roll", Roll);
                cmd.Parameters.AddWithValue("@dept", Dept);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Insert success");
                }
                else
                {
                    Console.WriteLine("Insert failed");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ListStudent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from crud", conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Console.WriteLine("Name \t\t Roll \t\t Department");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string name = dt.Rows[i]["Name"].ToString();
                        string roll = dt.Rows[i]["Roll"].ToString();
                        string dept = dt.Rows[i]["Dept"].ToString();
                        Console.WriteLine($"{name} \t\t  {roll} \t\t {dept}");

}
                }
                else
                {
                    Console.WriteLine("Data not found");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void UpdateStudent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update crud set Name='Asmita',Roll=20,Dept='CSIT'", conn);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Update success");
                }
                else
                {
                    Console.WriteLine("Update failed");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void DeleteStudent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Delete from crud", conn);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Delete success");
                }
                else
                {
                    Console.WriteLine("Delete failed");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Crud demo = new Crud();
            demo.CreateTable();
            Console.ReadKey();
            demo.AddStudent();
            Console.ReadKey();
            demo.ListStudent();
            Console.ReadKey();
            demo.UpdateStudent();
            Console.ReadKey();
            demo.DeleteStudent();
            Console.ReadLine();
        }
    }
}*/