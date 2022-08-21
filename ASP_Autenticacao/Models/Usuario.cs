using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ASP_Autenticacao.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(100)]
        public string Senha { get; set; }

        MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        MySqlCommand command = new MySqlCommand();

        public void InsertUsuario(Usuario usuario)
        {
            connection.Open();
            command.CommandText = "CALL spInsertUsuario(@Nome, @login, @Senha);";
                command.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = usuario.Nome;
                command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usuario.Login;
                command.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usuario.Senha;
                command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}