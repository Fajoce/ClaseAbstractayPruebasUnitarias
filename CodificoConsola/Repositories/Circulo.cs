using CodificoConsola.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodificoConsola
{
    public class Circulo : CalculosArea
    {
        /// <summary>
        /// Implementacion Area del circulo
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public virtual double AreaCirculo(double r)
        {
            return base.AreaCirculo(r);
        }

        
    }
}
