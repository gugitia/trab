using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cadastro.Models;
using Bolsa;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

namespace Notificacoes.Models
{
    public partial class Notificacoes 
    {
       
        private void notificacoes(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    cnn.ConnectionString = "server=localhost;database=aula;uid=root;pwd=root;port=3336";
                    cnn.Open();
                    Console.WriteLine("Conexão com MySQL com sucesso!");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        public class msg
        {
            //acao = 
        }
    }
}

