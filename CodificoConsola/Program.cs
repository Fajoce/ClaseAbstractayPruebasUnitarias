namespace CodificoConsola
{
    public class Program
    {
        static void Main(string[] Args)
        {
            
            Circulo circulo = new Circulo();
            Rectangulo rectangulo = new Rectangulo();
            Triangulo triangulo = new Triangulo();
            int opcion = 0;
            double _base;
            double altura;
            string msg = "Escoja opcion:";
            try
            {
                while (opcion != 4)
                {
                    Program.Menu(opcion);
                    Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);
                    Console.Write(msg);
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            double radio;
                            Console.SetCursorPosition(55, 10);
                            Console.Write("Digite Radio: ");
                            radio = double.Parse(Console.ReadLine());
                            if (radio <= 0)
                            {
                                Program.Validaciones();
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.SetCursorPosition(50, 12);
                                Console.WriteLine("Area Circulo {0}", circulo.AreaCirculo(radio));
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        case 2:
                            
                            Console.SetCursorPosition(55, 10);
                            Console.Write("Digite Base: ");
                            _base = double.Parse(Console.ReadLine());
                            Console.SetCursorPosition(55, 12);
                            Console.Write("Digite Altura: ");
                            altura = double.Parse(Console.ReadLine());
                            if (_base <= 0 || altura <= 0)
                            {
                                Program.Validaciones();
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.SetCursorPosition(55, 14);
                                Console.WriteLine("Area Rectángulo {0}", rectangulo.AreaRectangulo(_base, altura));
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        case 3:
                          
                            Console.SetCursorPosition(55, 10);
                            Console.Write("Digite Base: ");
                            _base = double.Parse(Console.ReadLine());
                            Console.SetCursorPosition(55, 12);
                            Console.Write("Digite Altura: ");
                            altura = double.Parse(Console.ReadLine());
                            if (_base <= 0 || altura <= 0)
                            {
                                Program.Validaciones();
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.SetCursorPosition(55, 14);
                                Console.WriteLine("Area Triangulo {0}", triangulo.AreaTriangulo(_base, altura));
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        case 4:
                            Console.SetCursorPosition(50, 10);
                            Console.Write("¿ Realmente quieres salir ? y/n ");
                            char res;
                            res = Convert.ToChar(Console.ReadLine());
                            if (res == 'y' || res == 'Y')
                            {
                                Console.WriteLine("Gracias por utilizar este sistema! ");
                                opcion = 4;
                               
                            }
                            else
                            {
                                opcion = 1;
                            }
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Opción Inexistente!");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
  
           
          static void Menu(int opc)
        {
            string lines = "************************************************";
            string title = "CODIFICO PRIMER PUNTO PRUEBA TECNICA - CONSOLA";
            string opc1 = "1. Area del Círculo";
            string opc2 = "2. Area del Rectángulo";
            string opc3 = "3. Area del Triángulo";
            string opc4 = "4. Salir";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((Console.WindowWidth - lines.Length) / 2, Console.CursorTop);
            Console.WriteLine(lines);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            Console.SetCursorPosition((Console.WindowWidth - opc1.Length) / 2, Console.CursorTop);
            Console.WriteLine(opc1);
            Console.SetCursorPosition((Console.WindowWidth - opc2.Length) / 2, Console.CursorTop);
            Console.WriteLine(opc2);
            Console.SetCursorPosition((Console.WindowWidth - opc3.Length) / 2, Console.CursorTop);
            Console.WriteLine(opc3);
            Console.SetCursorPosition((Console.WindowWidth - opc4.Length) / 2, Console.CursorTop);
            Console.WriteLine(opc4);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((Console.WindowWidth - lines.Length) / 2, Console.CursorTop);            Console.WriteLine(lines);


        }

        static void Validaciones()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Debe digitar un numero mayor que cero");
        }
    }
}
