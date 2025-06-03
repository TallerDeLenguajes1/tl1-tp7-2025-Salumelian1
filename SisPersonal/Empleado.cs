using System;
namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar,
        Administracion,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        public string? nombre;
        public string? apellido;
        public DateTime fecha_de_nacimiento;
        public char estadoCivil;
        public DateTime fechaIngresoALaEmpresa;
        public double sueldoBase;
        
        public Cargos cargo;

        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            return (hoy.Subtract(fecha_de_nacimiento).Days / 365); // obtengo los años  
        }
        public int antiguedad()
        {
            DateTime hoy = DateTime.Now;
            return (hoy.Subtract(fechaIngresoALaEmpresa).Days / 30);
        }
        public int Jubilacion()
        {
            DateTime hoy = DateTime.Now;
            int edad = Edad();
            if (edad >= 65)
            {
                return 0;
            }
            else
            {
                return (65 - edad);
            }
        }
        public double salario()
        {
            int Antiguedad = antiguedad();
            double adicional;

            if (Antiguedad <= 20)
            {
                adicional = sueldoBase * (Antiguedad * 0.01);
            }
            else
            {
                adicional = sueldoBase * 0.25;
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional += sueldoBase * 0.5;
            }
            if (estadoCivil == 'C')
            {
                adicional += 150000;
            }
            return sueldoBase + adicional;
        }
    }


}