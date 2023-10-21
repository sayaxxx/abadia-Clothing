using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;
public class FormaPagoRepository : GenericRepo<FormaPago>, IFormaPago{
    protected readonly ApiContext _context;
    
    public FormaPagoRepository(ApiContext context) : base (context){
        _context = context;
    }
}