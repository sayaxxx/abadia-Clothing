using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class ProveedorRepository : GenericRepo<Proveedor>, IProveedor{
    protected readonly ApiContext _context;
    
    public ProveedorRepository(ApiContext context) : base (context){
        _context = context;
    }
}