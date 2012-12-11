using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

namespace ConnectCsharpToMysql
{
   public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }
      
        //Initialize values
        private void Initialize()
        {
            server = "sql.doe.pl";
            database = "kasprzakleonard9";
            uid = "kasprzakleonard9";
            password = "krasnoludki123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        public List<string>[] Login(string user, string pass) 
        {
            string query = "SELECT * FROM Klienci where login='"+user+"' && haslo ='"+pass+"'";

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
           


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["id_klient"] + "");
                    list[1].Add(dataReader["login"] + "");
                    list[2].Add(dataReader["haslo"] + "");
                    list[3].Add(dataReader["Pesel"] + "");
                    list[4].Add(dataReader["imie"] + "");
                    list[5].Add(dataReader["nazwisko"] + "");
                    list[6].Add(dataReader["id_authority"] + "");
               

                }

                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {

                return list;
            }
        }







        //Insert statement
        public void Insert(int id_kind, string title, string name, string av, string res)
        {
        string query = "INSERT INTO RESOURCES (Id_Kind, Title, Author_Name, Is_Available, Is_Reserve) VALUES("+id_kind+",'"+title+"','"+name+"','"+av+"','"+res+"')";
        
            //open connection
        if (this.OpenConnection() == true)
            {
                 //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string title, string name, string title_ed, string name_ed)
        {
            string query = "UPDATE RESOURCES SET Title='"+title+"', Author_Name='"+name+"' WHERE Title='"+title_ed+"' AND Author_Name='"+name_ed+"'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Rezerwuj(string res, string title_ed, string name_ed)
        {
            string query = "UPDATE Auta SET Is_Reserve='"+res+"' WHERE nazwa_marka='"+title_ed+"' AND nazwa_model='"+name_ed+"'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
       

        //Delete statement
        //public void Delete()
        //{
        //    string query = "DELETE FROM tableinfo WHERE name='John Smith'";

        //    if (this.OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.ExecuteNonQuery();
        //        this.CloseConnection();
        //    }
        //}

        //Select statement
        public List<string>[] Select(string paramnasze, string tekst) // paramnasze- nazwa kolumny; tekst- podany autor/tytul
        {
            string param=paramnasze;
            string tekst1 = "'%" + tekst + "%'";
            string query = "SELECT `Id_auto` , `Nazwa_marka` , `Nazwa_model` , `nazwa_koloru` , `rodzaj_silnika` , `Is_Available` , `Is_Reserve` FROM `Auta` INNER JOIN `Marka` ON Marka.Id_marka = Auta.Id_marka INNER JOIN `Model` ON Model.Id_model = Auta.Id_model INNER JOIN `Kolor` ON Kolor.Id_kolor = Auta.Id_kolor WHERE  "+param+" like "+tekst1;
            
            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();



            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                //Read the data and store them in the list
               while (dataReader.Read())
               {
                  
                    list[0].Add(dataReader["id_auto"] + "");
                    list[1].Add(dataReader["nazwa_marka"] + "");
                    list[2].Add(dataReader["nazwa_model"] + "");
                    list[3].Add(dataReader["nazwa_koloru"] + "");
                    list[4].Add(dataReader["rodzaj_silnika"] + "");
                    list[5].Add(dataReader["is_available"] + "");
                    list[6].Add(dataReader["is_reserve"] + "");
                 
               }
//
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        ////Count statement
        //public int Count()
        //{
        //    string query = "SELECT Count(*) FROM tableinfo";
        //    int Count = -1;

        //    //Open Connection
        //    if (this.OpenConnection() == true)
        //    {
        //        //Create Mysql Command
        //        MySqlCommand cmd = new MySqlCommand(query, connection);

        //        //ExecuteScalar will return one value
        //        Count = int.Parse(cmd.ExecuteScalar()+"");
                
        //        //close Connection
        //        this.CloseConnection();

        //        return Count;
        //    }
        //    else
        //    {
        //        return Count;
        //    }
        //}

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\Backup\\" + year + "-" + month + "-" + day + "-" + hour +".sql";
                StreamWriter file = new StreamWriter(path);

                
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                
                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}
