using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class OrdenRepository : GenericRepo<Orden>, IOrden{
    protected readonly ApiContext _context;
    
    public OrdenRepository(ApiContext context) : base (context){
        _context = context;
    }
}