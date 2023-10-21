using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IProveedor : IGenericRepo<Proveedor>{
    Task<IEnumerable<object>> ObtenerProveedoresNaturales();
}