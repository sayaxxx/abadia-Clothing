namespace Dominio.Entities;
public class Usuario: BaseEntity
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }  

    public ICollection<Rol> Rols { get; set; } = new HashSet<Rol>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<RolUsuario> RolUsuarios { get; set; }
}

//TABLA USUARIO, INTERACTUA POR DEFECTO CON ROL
//Y TIENE TABLA INTERMEDIA ROLUSUARIO
//PORQUE ES UNA RELACION MUCHOS A MUCHOS
//UN USUARIO TIENE MUCHOS ROLES Y MUCHOS ROLES TIENEN MUCHOS USUARIOS
