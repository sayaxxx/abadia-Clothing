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
    public async Task<IEnumerable<object>> ObtenerProveedoresNaturales(){
        var Proveedores = await (
            from p in _context.Proveedores
            join t in _context.TipoPersonas on p.IdTipoPersona equals t.Id
            where t.Nombre.Contains("Natural")
            select new{
                Nombre = p.Nombre,
            }).Distinct()
            .ToListAsync();

        return Proveedores;
}
}