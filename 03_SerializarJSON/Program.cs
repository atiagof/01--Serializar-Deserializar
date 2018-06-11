using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nova Instancia da classe Usuario.
            Usuario usuario = new Usuario() { Nome = "Taisa Pinheiro", Cpf = "333.333.333-33", Email = "taisa@teste.com" };
            
            // Nova Instancia do Serializador.
            JavaScriptSerializer serializador = new JavaScriptSerializer();

            // Armazena dentro de uma variavel tipo string o objeto Usuario Serializado.
            string stringObjetoSerializado = serializador.Serialize(usuario);

            // Passa o arquivo onde vai escrever os dados serializados.
            StreamWriter sw = new StreamWriter(@"C:\Projetos\SerializarDeserializar\Arquivo\02_SerializarJSON.json");
            
            // Escreve dentro do arquivo os dados serializados.
            sw.WriteLine(stringObjetoSerializado);
            
            // Fecha e salva as informações no arquivo.
            sw.Close();
        }
    }
}
