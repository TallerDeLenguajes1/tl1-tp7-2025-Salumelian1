using System;
using EspacioEmpleado;


class Program
{
    static void Main()
    {
        Empleado Euno  = new Empleado();
        Empleado Edos = new Empleado();
        Empleado Etres = new Empleado();
        Euno.nombre = "Salustiano";
        Euno.apellido = "Melian";
        Euno.fecha_de_nacimiento = new DateTime(2003, 7, 20);
        Euno.estadoCivil = 'S';
        Euno.fechaIngresoALaEmpresa = new DateTime(2024, 6, 26);
        Euno.sueldoBase = 10000;
        Euno.cargo = Cargos.Ingeniero;

        Edos.nombre = "Juan Pablo";
        Edos.apellido = "Saa";
        Edos.fecha_de_nacimiento = new DateTime(2003, 7, 29);
        Edos.estadoCivil = 'C';
        Edos.fechaIngresoALaEmpresa = new DateTime(2025, 5, 25);
        Edos.sueldoBase = 1500;
        Edos.cargo = Cargos.Especialista;

        Etres.nombre = "Matias";
        Etres.apellido = "Marengo";
        Etres.fecha_de_nacimiento = new DateTime(2004, 6, 17);
        Etres.estadoCivil = 'C';
        Etres. fechaIngresoALaEmpresa = new DateTime(2020, 5, 25);
        Etres.sueldoBase = 2000;
        Etres.cargo = Cargos.Administracion;


        Console.WriteLine("--------------------------------------------------");
        double SueldoTotal = Euno.salario() + Edos.salario() + Etres.salario();
        Console.WriteLine("El monto total en salarios es de:$" + SueldoTotal);

        if (Euno.Jubilacion() < Edos.Jubilacion() && Euno.Jubilacion() < Etres.Jubilacion())
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Datos del empleado más proximo a jubilarse:");
            Console.WriteLine($"Empleado: {Euno.nombre} {Euno.apellido}");
            Console.WriteLine($"Edad: {Euno.Edad} años");
            Console.WriteLine($"Antigüedad: {Euno.antiguedad()} años");
            Console.WriteLine($"Años para jubilarse: {Euno.Jubilacion()}");
            Console.WriteLine($"Salario total: ${Euno.salario()}");
        }

        if (Edos.Jubilacion() < Euno.Jubilacion() && Edos.Jubilacion() <Etres.Jubilacion())
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Datos del empleado más proximo a jubilarse:");
            Console.WriteLine($"Empleado: {Edos.nombre} {Edos.apellido}");
            Console.WriteLine($"Edad: {Edos.Edad} años");
            Console.WriteLine($"Antigüedad: {Edos.antiguedad()} años");
            Console.WriteLine($"Años para jubilarse: {Edos.Jubilacion()}");
            Console.WriteLine($"Salario total: ${Edos.salario()}");
        }

        if (Etres.Jubilacion() < Edos.Jubilacion() && Etres.Jubilacion() < Euno.Jubilacion())
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Datos del empleado más proximo a jubilarse:");
            Console.WriteLine($"Empleado: {Etres.nombre} {Etres.apellido}");
            Console.WriteLine($"Edad: {Etres.Edad} años");
            Console.WriteLine($"Antigüedad: {Etres.antiguedad()} años");
            Console.WriteLine($"Años para jubilarse: {Etres.Jubilacion()}");
            Console.WriteLine($"Salario total: ${Etres.salario()}");
        }
    }
}
