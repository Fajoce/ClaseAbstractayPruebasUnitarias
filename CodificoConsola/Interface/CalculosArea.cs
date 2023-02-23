namespace CodificoConsola.Repositories
{
    public abstract class CalculosArea
    {
        #region Properties
        protected double _radio;
        protected double _height;
        protected double _base;
        #endregion Properties

        #region Public Methods
        /// <summary>
        /// Area del Circulo
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public virtual double AreaCirculo(double r)
        {
            _radio = r;
            return Math.Round(Math.PI * Math.Pow(_radio,2),2);   
        }
        /// <summary>
        /// Area del Rectángulo
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public virtual double AreaRectangulo(double b, double a)
        {
            _height = a;
            _base = b;
            return _base * _height;

        }
        /// <summary>
        /// Area del triangulo
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns></returns>

        public virtual double AreaTriangulo(double b, double a)
        {
            _height = a;
            _base = b;
            return _base * _height/2;

        }
        #endregion Public Methods


    }
}
