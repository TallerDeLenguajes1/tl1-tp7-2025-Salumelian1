using System;
using EspacioEmpleado;

partial class Program
{
    static void Main()
    {
        Empleado[] empleado = new Empleado[3];
        empleado[0] = new Empleado
        {
            nombre = "Ana",
            Apellido = "Pérez",
            fechaDeNacimiento = new DateTime(1985, 3, 12),
            estadoCivil = 'C',
            FechaDeIngreso = new DateTime(2010, 5, 10),
            sueldoBase = 250000,
            Cargo = Cargos.Ingeniero
        };

        empleado[1] = new Empleado
        {
            nombre = "Carlos",
            Apellido = "López",
            fechaDeNacimiento = new DateTime(1990, 8, 20),
            estadoCivil = 'S',
            FechaDeIngreso = new DateTime(2022, 9, 1),
            sueldoBase = 180000,
            Cargo = Cargos.Auxiliar
        };

        empleado[2] = new Empleado
        {
            nombre = "María",
            Apellido = "Sosa",
            fechaDeNacimiento = new DateTime(1978, 12, 5),
            estadoCivil = 'C',
            FechaDeIngreso = new DateTime(2000, 1, 15),
            sueldoBase = 300000,
            Cargo = Cargos.Especialista
        };

        double GastoSalarios = 0;
        for (int i = 0; i <= 2; i++)
        {
            GastoSalarios += empleado[i].salario();
        }
        Console.WriteLine("El gasto final de los salarios para los empleados es: " + GastoSalarios);

        int Vejes = 0, numDeEmpleado = 0;
        for (int i = 0; i <= 2; i++)
        {
            if (empleado[i].Edad() >= Vejes)
            {
                Vejes = empleado[i].Edad();
                numDeEmpleado = i;
            }
        }
        Console.WriteLine($"Empleado {numDeEmpleado + 1}");
        Console.WriteLine($"Nombre: {empleado[numDeEmpleado].nombre} {empleado[numDeEmpleado].Apellido}");
        Console.WriteLine($"Edad: {empleado[numDeEmpleado].Edad()} años");
        Console.WriteLine($"Antigüedad: {empleado[numDeEmpleado].Antiguedad():0} meses");
        Console.WriteLine($"Años para jubilación: {empleado[numDeEmpleado].Jubilacion()}");
        Console.WriteLine($"Cargo: {empleado[numDeEmpleado].Cargo}");
        Console.WriteLine($"Sueldo total: ${empleado[numDeEmpleado].salario():N2}");
    }
}