using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoRepository
{
    public class EmpleadoRepositoryArchivo : IEmpleadoRepository
    {
        private string _nombreArchivo;

        public EmpleadoRepositoryArchivo(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }

        public void GuardarTodos(List<Empleado> empleados)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_nombreArchivo))
                {
                    foreach (Empleado empleado in empleados)
                    {
                        sw.WriteLine($"{empleado.Nombre},{empleado.Edad},{empleado.Puesto}");
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine($"Error al escribir el archivo: {e.Message}");
            }

        }

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (StreamReader sr = new StreamReader(_nombreArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(",");
                        Empleado empleado = new Empleado
                        {
                            Nombre = datos[0],
                            Edad = Convert.ToDecimal(datos[1]),
                            Puesto = datos[2]
                           

                        };
                        empleados.Add(empleado);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine($"Error al leer el archivo: {e.Message}");
            }
            return empleados;
        }
    }
}
