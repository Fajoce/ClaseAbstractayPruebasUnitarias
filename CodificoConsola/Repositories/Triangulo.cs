using CodificoConsola.Repositories;

namespace CodificoConsola
{
    public class Triangulo: CalculosArea
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public virtual double AreaTriangulo(double b, double a)
        {
            return base.AreaTriangulo(b, a);
        }
    }
}
