using CardGameManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data;


namespace CardGameInterface
{
    static class Program
    {
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbConnector connDB = new DbConnector();

            try
            {
                //init of the connection    
                connDB.OpenConnection();
            }
            catch (Exception exc)
            {
                //we display the error message.
                MessageBox.Show(exc.Message);
            }
            finally
            {
                try
                {
                    //init of the connection    
                    connDB.CreateDatabase();
                    connDB.CloseConnection();
                }
                catch (Exception exc)
                {
                    //we display the error message.
                    Console.WriteLine(exc.Message);
                    connDB.CloseConnection();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
