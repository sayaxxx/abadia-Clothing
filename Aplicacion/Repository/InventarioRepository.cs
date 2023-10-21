using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class InventarioRepository : GenericRepo<Inventario>, IInventario{
    protected readonly ApiContext _context;
    
    public InventarioRepository(ApiContext context) : base (context){
        _context = context;
    }
}