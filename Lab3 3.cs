/*using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace CRabina 
{
    internal class DbInsertSelect
    {
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
                MySqlCommand cmd = new MySqlCommand("insert into demotable(Name,Roll,Dept) values(@name,@roll,@dept)", conn);
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
                MySqlCommand cmd = new MySqlCommand("select * from demotable", conn);
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
        static void Main(string[] args)
        {
            
            DbInsertSelect demo = new DbInsertSelect();
            demo.AddStudent();
            Console.ReadKey();
            demo.ListStudent();
            
            Console.ReadLine();
        }
    }
}*/