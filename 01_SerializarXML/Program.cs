using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nova Instancia da classe Usuario
            Usuario usuario = new Usuario() { Nome="Alex Tiago",Cpf="157.157.157-57", Email="alex@teste.com" };
            
            // Serializador
            XmlSerializer serializador1 = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador2 = new XmlSerializer(usuario.GetType());

            //Escritor
            // Como o caracter \ barra invertida é um caracter especial que indica "ignorar" é necessário adicionar o @ ou uma nova \ barra invertida para anular o efeito de negação e o código interpretar toda linha como literal.
            StreamWriter stream1 = new StreamWriter(@"C:\Projetos\SerializarDeserializar\Arquivo\01_SerializarXML.xml");
            //StreamWriter stream2 = new StreamWriter("C:\\Projetos\\SerializarDeserializar\\Arquivo");
            
            // Usa o serializador para armazenar os dados do objeto no arquivo.
            serializador1.Serialize(stream1, usuario);
        }
    }
}
