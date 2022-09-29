using System;
using System.Security.Cryptography.X509Certificates;
using cadastro.Models;
using Notificacoes.Models;
//ing conexao.Models;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace Bolsa;


class Program
{
    public static void Main(string[] args)
    {
        Cad cadastro = new Cad();
        cadastro.Cadastrar("Gustavo Marquez", "gugitia@gmail.com", "123456", "PETR4");
        Console.WriteLine(cadastro);
        //Console.WriteLine("teste");
        escrever t = new escrever();
     // t.escreve();
        conex�o c = new conex�o();
  //  string bugs = "";
  //    bugs = Console.ReadLine();

        c.Conexao();
    }
}

class escrever
{
    public void escreve()
    {
        Console.Write("escreva algo");
 var    bugs = "";
         bugs = Console.ReadLine();
        Console.WriteLine("voc� escreveu " + bugs);
    }
}



class conex�o  
{ 

    public void Conexao()
    {
        string connetionString = @"Data Source=DESKTOP-J40FSS9;Initial Catalog=appbolsa;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connetionString);

        sqlConn.Open();

        SqlCommand cmd = new SqlCommand(
                 "select * from acoes where acoes = @acoes ", sqlConn);

        // SqlCommand cmd = new SqlCommand(sql, sqlConn) ;

        // conex�o objMeuComando = new conex�o();

        SqlParameter param = new SqlParameter();
        param.ParameterName = "@acoes";
        param.Value = Console.ReadLine();
        cmd.Parameters.Add(param);
        SqlDataReader reader = cmd.ExecuteReader();




        Console.WriteLine("expectativa e atual para o investimento: ");
        while (reader.Read())
        {
            Console.WriteLine("{0}, {1},{2}",  
                reader["acoes"],
                reader["estimativa"],
                reader["atual"]);
        }
    }
}
  


