using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class TipoEstadoRepository : GenericRepo<TipoEstado>, ITipoEstado{
    protected readonly ApiContext _context;
    
    public TipoEstadoRepository(ApiContext context) : base (context){
        _context = context;
    }
}