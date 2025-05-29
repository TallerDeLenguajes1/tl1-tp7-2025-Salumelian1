namespace EspacioEmpleado
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fecha_de_nacimiento;
        private char estadoCivil;
        private DateTime fechaIngresoALaEmpresa;
        private double sueldoBase;
        enum Cargos
        {
            Auxiliar,
            Administracion,
            Ingeniero,
            Especialista,
            Investigador
        }
        private Cargos cargo;

        public int Edad(DateTime hoy)
        {
            return (hoy.Subtract(fecha_de_nacimiento).Days / 365); // obtengo los años  
        }
        public int antiguedad(DateTime hoy)
        {
            return (hoy.Subtract(fechaIngresoALaEmpresa).Days / 30);
        }
        public int Jubilacion(DateTime hoy)
        {
            int edad = Edad(hoy);
            if (edad >= 65)
            {
                return 0;
            }
            else
            {
                return (65 - edad);
            }
        }
        public int salario(int sueldoBase)
        {
            int antiguedad = antiguedad(hoy);
            int  adicional = 0;
        }
    }
    
    
}