using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Web.Script.Serialization;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicia uma nova Instancia do StreamReader leitura do arquivo com os dados a ser deserializado.
            StreamReader stream = new StreamReader(@"C:\Projetos\SerializarDeserializar\Arquivo\02_SerializarJSON.json");
            
            // A opção ReadToEnd lê todo arquivo sendo assim se tiver mais de uma linha se tem a certeza que todas as linhas do arquivo seram retornadas na leitura.
            string linhasDoArquivo = stream.ReadToEnd();
            
            // Instancia o deserializador.
            JavaScriptSerializer serializador = new JavaScriptSerializer();

            // Deserializa as linhas do arquivo e armazena no tipo de objeto Usuario.
            Usuario usuario = (Usuario)serializador.Deserialize(linhasDoArquivo, typeof(Usuario));

            // Exibe no console o Retorno do arquivo deserializado.
            Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            Console.ReadKey();
        }
    }
}
