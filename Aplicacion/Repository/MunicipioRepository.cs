using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class MunicipioRepository : GenericRepo<Municipio>, IMunicipio{
    protected readonly ApiContext _context;
    
    public MunicipioRepository(ApiContext context) : base (context){
        _context = context;
    }
}