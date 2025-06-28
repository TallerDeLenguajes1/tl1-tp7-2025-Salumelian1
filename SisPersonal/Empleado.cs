namespace EspacioEmpleado
{

    public class Empleado
    {
        public string? nombre;
        public string? Apellido;
        public DateTime fechaDeNacimiento;
        public char estadoCivil;
        public DateTime FechaDeIngreso;
        public double sueldoBase;
        public Cargos Cargo;
        public double Antiguedad()
        {
            DateTime hoy = DateTime.Now;
            return (hoy.Subtract(FechaDeIngreso).Days / 30);
        }
        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            return (hoy.Subtract(fechaDeNacimiento).Days / 365);
        }
        public int Jubilacion()
        {
            return (65 - Edad());
        }
        public double salario()
        {
            double adicional = 0;
            float porcentaje = 0.001F;
            if (Antiguedad() <= 20)
            {
                adicional = sueldoBase * (porcentaje * Antiguedad());
            }
            else
            {
                adicional = sueldoBase * 0.25;
            }
            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional += sueldoBase * 0.50; 
            }
            if (estadoCivil == 'C')
            {
                adicional += 150000;
            }
            return sueldoBase + adicional;
        }
    }
    public enum Cargos
    {
        Auxiliar,
        Administrador,
        Ingeniero,
        Especialista,
        Investigador
    }


}
