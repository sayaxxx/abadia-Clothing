using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class EmpleadoRepository : GenericRepo<Empleado>, IEmpleado{
    protected readonly ApiContext _context;
    
    public EmpleadoRepository(ApiContext context) : base (context){
        _context = context;
    }
}