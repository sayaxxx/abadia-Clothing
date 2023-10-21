using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class DetalleOrdenRepository : GenericRepo<DetalleOrden>, IDetalleOrden{
    protected readonly ApiContext _context;
    
    public DetalleOrdenRepository(ApiContext context) : base (context){
        _context = context;
    }
}