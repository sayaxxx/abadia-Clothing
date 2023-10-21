using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class InsumoRepository : GenericRepo<Insumo>, IInsumo{
    protected readonly ApiContext _context;
    
    public InsumoRepository(ApiContext context) : base (context){
        _context = context;
    }
}