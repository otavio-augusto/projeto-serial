using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serial
{
    class Dados
    {
        private ArrayList cadastro;
        public Dados()
        {
            cadastro = new ArrayList();
        }
        public void inserir(Aluno aluno)
        {
            cadastro.Add(aluno);
        }
    }
}
