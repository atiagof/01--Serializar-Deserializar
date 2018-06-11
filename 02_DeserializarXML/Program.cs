using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using _00_Biblioteca;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicia uma nova Instancia do StreamReader leitura do arquivo com os dados a ser deserializado.
            StreamReader stream = new StreamReader(@"C:\Projetos\SerializarDeserializar\Arquivo\01_SerializarXML.xml");

            // Instacia deserializadora é necessário passar o tipo do objeto caso seja arquivo XML
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            // Deserializa as linhas do arquivo e armazena no tipo de objeto Usuario.
            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            // Exibe no console o Retorno do arquivo deserializado.
            Console.WriteLine("Usuario(Nome): {0} ,CPF: {1} e Email: {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            Console.ReadKey();
        }
    }
}
