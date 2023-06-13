

namespace IwantApp.Controllers.Endpoint.Teste
{
    public partial class TesteGetId
    {
        public class NomeTeste
        {
            public int Idteste { get; set; }
            public string NomeCompleto { get; set; }

            public NomeTeste() { }

            public NomeTeste(int idteste, string nomeCompleto)
            {
                Idteste = idteste;
                NomeCompleto = nomeCompleto;
            }


            public static List<NomeTeste> NomesListaTeste = new()
            {
            new NomeTeste { Idteste = 1, NomeCompleto = "Vinicius" },
            new NomeTeste { Idteste = 2, NomeCompleto = "Claudio" },
            new NomeTeste { Idteste = 3, NomeCompleto = "Lucas" }
        };

            public static void AddList(string idTeste, string nomeCompleto)
            {
                NomesListaTeste.Add(new NomeTeste { });
            }


        }
    }
}
