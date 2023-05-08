using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    internal class activation
    {
        const string connectionString = "server=sql9.freesqldatabase.com;port=3306;database=sql9616884;uid=sql9616884;pwd=B1gICdR3Xv;";
        private static bool Activated { get; set; }
        public static bool isActivated(string key)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string check = "SELECT activated FROM activatedTable WHERE serialKey =@key";
            MySqlCommand cmd = new MySqlCommand(check, connection);
            cmd.Parameters.AddWithValue("@key", key);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public void activateSoftware(string key)
        {
            if(!isActivated(key))
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string checkForKey = "SELECT COUNT(*) FROM activatedTable WHERE serialKey =@key";
                MySqlCommand command = new MySqlCommand(checkForKey,connection);
                command.Parameters.AddWithValue("@key", key);
                int result = Convert.ToInt32(command.ExecuteScalar());
                if(result > 0)
                {
                    updateActivation(key);
                    using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                    {
                        using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("settings.txt", System.IO.FileMode.CreateNew, isolatedStorageFile))
                        {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(isolatedStorageFileStream))
                            {
                                sw.WriteLine(key);
                            }
                        }
                    }
                    Activated = true;
                }
                else
                {
                    MessageBox.Show("Your key was incorrect");
                    Activated = false;
                }
                

                

                connection.Close();

            }
            else
            {
                MessageBox.Show("Your software is already activated");
            }
        }
        public void updateActivation(string key)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string updateQuery = "UPDATE activatedTable SET activated = 1 WHERE serialKey =@key";
            MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
            cmd.Parameters.AddWithValue("@key", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Software has been activated");

            connection.Close();
        }
    }
}
