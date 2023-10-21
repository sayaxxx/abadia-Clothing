using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class DetalleVentaRepository : GenericRepo<DetalleVenta>, IDetalleVenta{
    protected readonly ApiContext _context;
    
    public DetalleVentaRepository(ApiContext context) : base (context){
        _context = context;
    }
}