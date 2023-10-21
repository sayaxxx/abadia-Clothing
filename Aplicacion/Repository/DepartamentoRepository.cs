using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class DepartamentoRepository : GenericRepo<Departamento>, IDepartamento{
    protected readonly ApiContext _context;
    
    public DepartamentoRepository(ApiContext context) : base (context){
        _context = context;
    }
}