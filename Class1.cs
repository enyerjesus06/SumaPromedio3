



    public class Proced
    {
        public void Produc()
        {
            //Declarar las variables: Num1, Num2, Num3, Num4, Suma, promedio, constante...

            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            int Num4 = 0;
            int suma = 0;
            int promedio = 0;
            int constante = 4;
            string linea = string.Empty;

          try
          {

            Console.WriteLine("Ingrese el primer Numero: ");
            linea = Console.ReadLine();
            Num1 = Convert.ToInt32(linea);


            Console.WriteLine("Ingrese el segundo Numero: ");
            linea = Console.ReadLine();
            Num2 = Convert.ToInt32(linea);


            Console.WriteLine("Ingrese el tercer Numero: ");
            linea = Console.ReadLine();
            Num3 = Convert.ToInt32(linea);


            Console.WriteLine("Ingrese el cuarto Numero: ");
            linea = Console.ReadLine();
            Num4 = Convert.ToInt32(linea);

            suma = (Num1 + Num2 + Num3 + Num4);

            promedio = (suma / constante);

            Console.WriteLine($"La suma de los Numeros es: {suma} ");

            Console.WriteLine($"El promedio de los Numeros ingresados es: {promedio} ");


          }
          catch (Exception ex)
          {
            Console.WriteLine($"Ocurrio el siguiente error: {ex.Message} ");




          }



        }
    
    }

