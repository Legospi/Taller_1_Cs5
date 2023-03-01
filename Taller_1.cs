/* Los tramos para la declaración de la renta de un país son los siguientes:

Renta % de impuesto a pagar
Menos de 10000$	5%
Entre 10000$ y 20000$	10%
Entre 20000$ y 35000$	15%
Entre 35000$ y 45000$	20%
Mayor a 45000$	30%

Realizar un programa donde el usuario ingrese los valores trimestrales del año
y muestre en pantalla su renta anual, el total de renta a pagar y el % de impuesto agregado */

/* using System; 

class Program
{
    static void Main(string[] args)
    {
        double[] quarterlyIncomes = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Ingrese el ingreso del trimestre {(i + 1)}: ");
            quarterlyIncomes[i] = double.Parse(Console.ReadLine());
        }

        double annualIncome = quarterlyIncomes[0] + quarterlyIncomes[1] + quarterlyIncomes[2] + quarterlyIncomes[3];
        Console.WriteLine($"La renta anual es: {annualIncome}");

        double taxRate;
        if (annualIncome < 10000)
        {
            taxRate = 0.05;
        }
        else if (annualIncome < 20000)
        {
            taxRate = 0.1;
        }
        else if (annualIncome < 35000)
        {
            taxRate = 0.15;
        }
        else if (annualIncome < 45000)
        {
            taxRate = 0.2;
        }
        else
        {
            taxRate = 0.3;
        }

        double taxToPay = annualIncome * taxRate;
        Console.WriteLine($"El impuesto a pagar es: {taxToPay}");
        Console.WriteLine($"El % de impuesto agregado es: {taxRate * 100}%");
    }
}
 */

/* Escribir un programa para una sala de juegos que quiere calcular de forma automática el precio que debe cobrar 
a sus clientes por ingresar. El software solicita al usuario el nombre completo y la edad del cliente para que 
muestra al final el nombre completo, el precio de la entrada y su descuento si lo tiene. Si el cliente es menor de 4 años 
puede entrar gratis, si tiene entre 4 y 18 años debe pagar la entrada y tendrá un descuento del 5% y si es mayor de 18 años
 debe pagar la entrada y tendrá un descuento del 3%. La entrada tiene un valor de 15000$. */


/* using System; 

class Program1
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese su nombre completo: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        double precio = 15000;

        if (edad < 4)
        {
            precio = 0;
        }
        else if (edad <= 18)
        {
            precio *= 0.95;
        }
        else
        {
            precio *= 0.97;
        }

        Console.WriteLine($"Bienvenido/a {nombre}!");
        Console.WriteLine($"El precio de su entrada es: {precio} pesos");
    }
}

 */

/* Una pizzería llamada Pizzas el Fercho tiene pizzas vegetarianas y no vegetarianas. 
Los ingredientes para cada una de las pizzas aparecen a continuación.

Ingredientes pizza vegetariana: Pimiento y champiñones.
Ingredientes pizza no vegetarianos: Pepperoni, Salami y Pollo.

Codificar un programa que solicite al usuario qué tipo de pizza desea, y en función de su respuesta 
le muestre un menú con los ingredientes disponibles para que elija uno de ellos, además todas las pizzas 
llevan mozzarella y tomate. Al final se debe mostrar por pantalla si la pizza es vegetariana o no y todos 
los ingredientes que lleva. 

using System; 

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido/a a Pizzas el Fercho!");

        Console.Write("¿Desea una pizza vegetariana? (S/N): ");
        string respuesta = Console.ReadLine();

        string tipoPizza, ingredientes;

        if (respuesta.ToUpper() == "S")
        {
            tipoPizza = "Vegetariana";
            Console.WriteLine("Los ingredientes disponibles son:");
            Console.WriteLine("1. Pimiento");
            Console.WriteLine("2. Champiñones");

            Console.Write("Ingrese el número del ingrediente que desea: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ingredientes = "mozzarella, tomate, pimiento";
                    break;
                case 2:
                    ingredientes = "mozzarella, tomate, champiñones";
                    break;
                default:
                    Console.WriteLine("Opción inválida. Seleccionando pimiento por defecto.");
                    ingredientes = "mozzarella, tomate, pimiento";
                    break;
            }
        }
        else
        {


            
            tipoPizza = "No Vegetariana";
            Console.WriteLine("Los ingredientes disponibles son:");
            Console.WriteLine("1. Pepperoni");
            Console.WriteLine("2. Salami");
            Console.WriteLine("3. Pollo");

            Console.Write("Ingrese el número del ingrediente que desea: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ingredientes = "mozzarella, tomate, pepperoni";
                    break;
                case 2:
                    ingredientes = "mozzarella, tomate, salami";
                    break;
                case 3:
                    ingredientes = "mozzarella, tomate, pollo";
                    break;
                default:
                    Console.WriteLine("Opción inválida. Seleccionando pepperoni por defecto.");
                    ingredientes = "mozzarella, tomate, pepperoni";
                    break;
            }
        }

        Console.WriteLine($"Su pizza {tipoPizza} lleva los siguientes ingredientes: {ingredientes}.");
    }
}*/



/* En una empresa, los empleados son premiados al final de cada año por su rendimiento. 
Los puntos que pueden tener en la evaluación son: 0.0, 0.4 y 0.6. pero no pueden tener 
valores intermedios entre las cifras mencionadas. A continuación se muestra una tabla 
con los niveles correspondientes a cada puntuación. La bonificación de dinero de cada 
nivel es de 50000$ multiplicada por la puntuación del nivel. Al final del programa se debe 
imprimir el nivel de evaluación y la bonificación ganada.


Nivel	Puntuación
Inaceptable	0.0
Aceptable	0.4
Meritorio	0.6
 

 using System; 

    class Program3
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese la puntuación del empleado
            Console.WriteLine("Ingrese la puntuación del empleado (0.0, 0.4, 0.6):");
            double puntuacion = Convert.ToDouble(Console.ReadLine());

            // Determinar el nivel de evaluación y la bonificación ganada
            string nivel;
            double bonificacion;
            switch (puntuacion)
            {
                case 0.0:
                    nivel = "Inaceptable";
                    bonificacion = 0;
                    break;
                case 0.4:
                    nivel = "Aceptable";
                    bonificacion = 50000 * 0.4;
                    break;
                case 0.6:
                    nivel = "Meritorio";
                    bonificacion = 50000 * 0.6;
                    break;
                default:
                    Console.WriteLine("La puntuación ingresada no es válida");
                    return;
            }

            // Mostrar el nivel de evaluación y la bonificación ganada
            Console.WriteLine("El nivel de evaluación del empleado es: {0}", nivel);
            Console.WriteLine("La bonificación ganada es de: {0:C}", bonificacion);
        }
    }

*/