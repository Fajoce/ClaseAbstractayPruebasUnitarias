using CodificoConsola.Repositories;

namespace CodificoConsola
{
    public class Rectangulo: CalculosArea
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public virtual double AreaRectangulo(double b, double a)
        {
            return base.AreaRectangulo(b, a);
        }
    }
}
