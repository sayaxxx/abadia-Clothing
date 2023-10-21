using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class ColorRepository : GenericRepo<Color>, IColor{
    protected readonly ApiContext _context;
    
    public ColorRepository(ApiContext context) : base (context){
        _context = context;
    }
}