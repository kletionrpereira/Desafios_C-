using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_07
{
    public class Alunos : IDaoBase
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public decimal Nota { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }

        public bool Salvar()
        {
            try
            {
                var bdConn = new MySqlConnection("server = localhost; user = root; password = 123456; database = Desafio_07");


                MySqlCommand command = bdConn.CreateCommand();
                bdConn.Open();

                //server = localhost; user = postgres; password = 123456; database = Desafio_07
                command.CommandText = "insert into alunos (Nome,Idade,CursoId,Nota) values (@nome,@idade,@curso,@nota)";
                    command.Parameters.AddWithValue("@nome", this.Nome);
                    command.Parameters.AddWithValue("@idade", this.Idade);
                    command.Parameters.AddWithValue("@curso", this.CursoId);
                    command.Parameters.AddWithValue("@nota", this.Nota);

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
