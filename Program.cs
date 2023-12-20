namespace edu.PR.Ejercicio8._2012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cerrarMenu = false;
            int opcionSeleccionada;

            while(!cerrarMenu)
            {
                opcionSeleccionada = menuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {


                    case 0:
                        Console.WriteLine("Cerrar aplicacion");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Ejercicio String");
                        ejercicioString();
                        break;
                    case 2:
                        Console.WriteLine("Ejercicio Int");
                        ejercicioInt();
                        break;
                    default:
                        Console.WriteLine("opcion no existe");
                        break;
                }
            
            }

            void ejercicioString()
            {
                string[] palabras = new string[] { "Hola", "Adiós", "Nuevo", "Viejo", "Vamos" };
                string pedirPalabra;
                Console.WriteLine("Introduzca una palabra");
                pedirPalabra = Console.ReadLine();

                int posicionPalabra = Array.IndexOf(palabras, pedirPalabra);

                if (posicionPalabra != -1)
                {

                    Console.WriteLine("la palabra  " + pedirPalabra + " Está en la posición " + posicionPalabra);
                }
                else
                {
                    Console.WriteLine("La palabra no coincide");
                }
            }





            void ejercicioInt()
            {

                int[] numeros = new int[] { 1, 5, 7, 8, 4, 3, 9 };
               
                var mayorQueTres = numeros.Where(numeros => numeros > 3).ToArray();

                Console.WriteLine("Numeros mayores que 3");

                foreach (int numero in mayorQueTres )
                {
                    Console.WriteLine(numero);
                }
            }








                int menuYSeleccion()
                 {
                    int opcionSeleccionada;
                    Console.WriteLine("0. Cerrar aplicacion");
                    Console.WriteLine("1. Ejercicio String");
                    Console.WriteLine("2. Ejercicio Int");
                    opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
                    return opcionSeleccionada;

                }
            
        }
        

    }

    
}