using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioplanar
{
    public class Ovni : IVoador, IMaquina
    {
        public void Planar()
        {
            Console.WriteLine("ele planaaaaa");
        }

        public void Decolar()
        {
            Console.WriteLine("ele decolaaaaaaaaaaaaaaaaaaaa");
        }

        public void Pousar ()
        {
            Console.WriteLine("ele pousaaaaaaaaaaaaaaa");
        }

        public void Cair()
        {
            Console.WriteLine("ele caiiiiiiiiiiiiiiii");
        }

        public void Ligar()
        {
            Console.WriteLine("ele ligaaaaaaaaaaa");
        }

        public void Desligar()
        {
            Console.WriteLine("desligaaaaaaaaaaaaaaaaaaaa");
        }

        public void Abastecer()
        {
            Console.WriteLine("ele abasteceeeeeeeeeeeeeeeeeeee");
        }

        public void Alerta()
        {
            Console.WriteLine("ele alertaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
}
