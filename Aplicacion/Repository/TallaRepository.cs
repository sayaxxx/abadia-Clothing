using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class TallaRepository : GenericRepo<Talla>, ITalla{
    protected readonly ApiContext _context;
    
    public TallaRepository(ApiContext context) : base (context){
        _context = context;
    }
}