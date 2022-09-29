using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace cadastro.Models
{
    public class Cad
    {
        string? nome;
        string? email;
        string? senha;
        string? acoes;

        public void Cadastrar( string Nome, string Email, string Senha, string acoes)
        { this.nome = Nome;
          this.email = Email;
          this.senha = Senha;
          this.acoes = acoes;
           var X = acoes;
        }
    }
}
