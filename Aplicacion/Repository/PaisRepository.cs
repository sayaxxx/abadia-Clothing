using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class PaisRepository : GenericRepo<Pais>, IPais{
    protected readonly ApiContext _context;
    
    public PaisRepository(ApiContext context) : base (context){
        _context = context;
    }
}