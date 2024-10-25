using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioplanar
{
    public class Passaro : IVoador, IPairador
    {
        public void Decolar()
        {
            Console.WriteLine("O passaro bate as asas e decola.");
        }

        public void Pairar()
        {
            Console.WriteLine("O passaro ");
        }

        public void Planar()
        {
            Console.WriteLine("O passaro bate as asas no ar e plana.");
        }

        public void Pousar()
        {
            Console.WriteLine("O passaro vai ate um galho e pousa.");
        }

        public void Cair()
        {
            Console.WriteLine("O passaro é atingido e cai.");
        }
    }
}
