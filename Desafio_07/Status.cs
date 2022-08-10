using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_07
{
    public class Status: IDaoBase
    {
        public Status(EStatus tipo)
        {
            this.Id = 0;
            this.Tipo = tipo;
        }

        public int Id { get; set; }
        public EStatus Tipo { get; set; }

        public bool Salvar()
        {
            try
            {

                var bdComn = new MySqlConnection("server = localhost; user = root; password = 123456; database = Desafio_07");
                
                    MySqlCommand command = bdComn.CreateCommand();
                    bdComn.Open();


                command.CommandText = "insert into status (Tipo) values (@tipo)";
                    command.Parameters.AddWithValue("@tipo", (int)this.Tipo);

                    command.ExecuteNonQuery();

                    bdComn.Close();
                    return true;
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }

        }
    }

    public enum EStatus
    {
        Andamento,
        Concluido,
        Fechado
    }
}
