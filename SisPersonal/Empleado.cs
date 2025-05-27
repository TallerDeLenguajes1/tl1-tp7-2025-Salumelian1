using Microsoft.VisualBasic;

namespace EspacioEmpleado
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fecha_de_nacimiento;
        private char estadoCivil;
        private DateTime fechaIngresoALaEmpresa;
        private double sueldo;
        enum Cargos {
            Auxiliar,
            Administracion,
            Ingeniero, 
            Especialista, 
            Investigador
        }
        private Cargos cargo;
    }
    
}