using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_07
{
    public class Cursos : IDaoBase
    {
        public Cursos(string nome, int status)
        {
            this.Id = 0;
            this.StatusId = status;
            this.Nome = nome;
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Nome { get; set; }

        public bool Salvar()
        {
            try
            {
                var bdConn = new MySqlConnection("server = localhost; user = root; password = 123456; database = Desafio_07");
                

                    MySqlCommand command = bdConn.CreateCommand();
                    bdConn.Open();


                command.CommandText = "insert into curso (StatusId,Nome) values (@statusid,@nome)";
                    command.Parameters.AddWithValue("@statusid", this.StatusId);
                    command.Parameters.AddWithValue("@nome", this.Nome);

                    command.ExecuteNonQuery();

                    bdConn.Close();
                    return true;
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }
    }
}

