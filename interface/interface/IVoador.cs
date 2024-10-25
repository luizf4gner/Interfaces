using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioplanar
{
    public interface IVoador
    {
        public void Decolar();

        public void Planar();

        public void Pousar();

        public void Cair();
    }
}
