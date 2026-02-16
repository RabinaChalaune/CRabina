/*using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using System.Data;

using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace CRabina

{
    internal class Tourism
    {
        public void CreateTable()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("create table tourdestination (Id int auto_increment primary key,Title varchar(50),Description varchar(100),Duration varchar(40),CreatedDate date)", conn);
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
                Console.WriteLine("Title:");
                string Title = Console.ReadLine();
                Console.WriteLine("Description:");
                string Description = Console.ReadLine();
                Console.WriteLine("Duration:");
                string Duration = Console.ReadLine();
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into tourdestination(Title,Description,Duration,CreatedDate) values(@title,@desc,@dur,current_date)", conn);
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@desc", Description);
                cmd.Parameters.AddWithValue("@dur", Duration);
                int row = cmd.ExecuteNonQuery();
                //Console.WriteLine(row);
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
                MySqlCommand cmd = new MySqlCommand("select * from tourdestination", conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Console.WriteLine("SN \t\t Title \t\t\t Duration \t\t Description");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["Id"].ToString();
                        string title = dt.Rows[i]["Title"].ToString();
                        string dur = dt.Rows[i]["Duration"].ToString();
                        string desc = dt.Rows[i]["Description"].ToString();
                        Console.WriteLine($"{id} \t\t {title} \t\t  {dur} \t\t {desc}");

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
            Tourism demo = new Tourism();
            demo.CreateTable();
            Console.ReadKey();
            demo.AddStudent();
            Console.ReadKey();
            demo.ListStudent();
            Console.ReadLine();
        }
    }
}*/