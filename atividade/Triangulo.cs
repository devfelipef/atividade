using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Triangulo : Figura
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;

    }
}
