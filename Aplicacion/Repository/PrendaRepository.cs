using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class PrendaRepository : GenericRepo<Prenda>, IPrenda{
    protected readonly ApiContext _context;
    
    public PrendaRepository(ApiContext context) : base (context){
        _context = context;
    }
}