using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Biblioteca
{
    // Projeto auxiliar não executavel que pode conter várias classes que vão ser utilizadas em outros projetos executaveis.
    // Classe Usuario classe que vai ser Serializada e Deserializada neste Modulo.
    public class Usuario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
