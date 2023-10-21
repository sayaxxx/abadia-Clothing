using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class CargoRepository : GenericRepo<Cargo>, ICargo{
    protected readonly ApiContext _context;
    
    public CargoRepository(ApiContext context) : base (context){
        _context = context;
    }
}