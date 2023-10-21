using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class TipoPersonaRepository : GenericRepo<TipoPersona>, ITipoPersona{
    protected readonly ApiContext _context;
    
    public TipoPersonaRepository(ApiContext context) : base (context){
        _context = context;
    }
}