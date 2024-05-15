using EmpleadoRepository;

string ArchivoEmpleado = "Empleado.txt";

IEmpleadoRepository empleadoRepository = new EmpleadoRepositoryArchivo(ArchivoEmpleado);

GestorEmpleado gestorEmpleado = new GestorEmpleado(empleadoRepository);

gestorEmpleado.AgregarEmpleados(
    new Empleado { Nombre = "Pedro Martinez", Edad = 34m, Puesto = "Supervisor" });
gestorEmpleado.AgregarEmpleados(
    new Empleado { Nombre = "Luis Sanchez", Edad = 55m, Puesto = "Gerente General" });
gestorEmpleado.AgregarEmpleados(
    new Empleado { Nombre = "Alexander Diaz", Edad = 26m, Puesto = "Auxiliar de Administracion" });
gestorEmpleado.AgregarEmpleados(
    new Empleado { Nombre = "Felipe Castellon", Edad = 45m, Puesto = "Jefe de Produccion" });

Console.WriteLine("Todos los empleados:");
foreach (var empleado in gestorEmpleado.ObtenerTodosLosEmpleados())
{
    Console.WriteLine($"Nombre: {empleado.Nombre}, Edad: {empleado.Edad}, Puesto: {empleado.Puesto}");
}
