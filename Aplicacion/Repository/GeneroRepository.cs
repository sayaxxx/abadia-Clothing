using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class GeneroRepository : GenericRepo<Genero>, IGenero{
    protected readonly ApiContext _context;
    
    public GeneroRepository(ApiContext context) : base (context){
        _context = context;
    }
}