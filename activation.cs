using System;
using System.IO;
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
        public bool Activated;
        private static int timeAllowedActivated = 1;

        public bool isTimeUp(string key)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string check = "SELECT time FROM activatedTable WHERE serialKey =@key";
            MySqlCommand cmd = new MySqlCommand(check, connection);
            cmd.Parameters.AddWithValue("@key", key);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            DateTime currentTime = DateTime.Now;
            int currTime = (int)(currentTime.Subtract(new DateTime(2000, 1, 1))).TotalMinutes;
            if (result + timeAllowedActivated > currTime)
            {
                return false;
            }
            return true;
        }

        public int timeLeft(string key)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string check = "SELECT time FROM activatedTable WHERE serialKey =@key";
            MySqlCommand cmd = new MySqlCommand(check, connection);
            cmd.Parameters.AddWithValue("@key", key);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            DateTime currentTime = DateTime.Now;
            int currTime = (int)(currentTime.Subtract(new DateTime(2000, 1, 1))).TotalMinutes;
            int left = result + timeAllowedActivated - currTime;
            return left;
        }
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
                MessageBox.Show("Key has expired");
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
            DateTime activationTime = DateTime.Now;
            int unixActivationTime = (int)(activationTime.Subtract(new DateTime(2000, 1, 1))).TotalMinutes;
            updateQuery = "UPDATE activatedTable SET time = @time WHERE serialKey =@key";
            MySqlCommand cmd2 = new MySqlCommand(updateQuery, connection);
            cmd2.Parameters.AddWithValue("@time",unixActivationTime);
            cmd2.Parameters.AddWithValue("@key", key);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Your Software has been activated");

            connection.Close();
        }
    }
}
