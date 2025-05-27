using EspcacioCalculadora;

Calculadora calc = new Calculadora();
Console.WriteLine("--------Calculadora----------");
int   opcion = 0, num1 = 0, num2= 0;
do
{
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Divicion");
    Console.WriteLine("4- Producot");
    Console.WriteLine("0- Salir");
    opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion != 0)
    {
        Console.WriteLine("Ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                int suma = num1 + num2;
                calc.sumar(suma);
                Console.WriteLine("La suma de los dos numero ingresados es: " + calc.resultado);
                break;
            case 2:
                calc.sumar(num1);
                calc.resta(num2);
                Console.WriteLine("La resta entre los numero ingresados es: " + calc.resultado);
                break;
            case 3:
                int Divicion = num1 / num2;
                calc.sumar(num1);
                calc.dividir(num2);
                Console.WriteLine("La divicion entre los dos numero ingresados es: " + calc.resultado);
                break;
            case 4:
                calc.sumar(num1);
                calc.multiplicar(num2);
                Console.WriteLine("El producto de los dos numero ingresados es: " + calc.resultado);
                break;
            default:
                break;
        }
    }
    calc.limpiar();
} while (opcion != 0);