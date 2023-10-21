using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class EmpresaRepository : GenericRepo<Empresa>, IEmpresa{
    protected readonly ApiContext _context;
    
    public EmpresaRepository(ApiContext context) : base (context){
        _context = context;
    }
}