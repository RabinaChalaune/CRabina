/*using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace CRabina 
{
    internal class DbUpdateDelete
    {
        public void UpdateStudent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update demotable set Name='Alisha',Roll=28,Dept='CSIT'", conn);
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
                MySqlCommand cmd = new MySqlCommand("Delete from demotable", conn);
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
            DbUpdateDelete demo = new DbUpdateDelete();
            demo.UpdateStudent();
            Console.ReadKey();
            demo.DeleteStudent();
            Console.ReadLine();
        }
    }
}*/