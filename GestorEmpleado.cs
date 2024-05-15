using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpleadoRepository;

namespace EmpleadoRepository
{
    public class GestorEmpleado
    {
        private IEmpleadoRepository _repository;

        public GestorEmpleado(IEmpleadoRepository repository)
        {
            _repository = repository;
        }

        public List<Empleado> ObtenerTodosLosEmpleados()
        {
            return _repository.ObtenerTodos();
        }

        public void AgregarEmpleados(Empleado empleado)
        {
            List<Empleado> empleados = _repository.ObtenerTodos();
            empleados.Add(empleado);
            _repository.GuardarTodos(empleados);
        }
    }
}
