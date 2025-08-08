using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03
{
    public class Aluno
    {

        public Aluno(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
        public int Codigo { get; set; } // Atributos
        public string? Nome { get; set; }
    }
}