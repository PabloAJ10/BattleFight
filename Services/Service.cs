using BattleFight.Models;
using System.Data.Entity;

namespace BattleFight.Services
{
    public class Service : DbContext
    {
        public DbSet<Equipo> equipos { get; set; }

        public DbSet<Torneo> torneos { get; set; }

        public DbSet<Usuario> usuarios { get; set; }

        public Service() : base("BattleFight") { }

        #region Métodos de Equipo

        //Método de agregar
        public void agregarEquipo(Equipo equipo)
        {
            equipos.Add(equipo);
            SaveChanges();
        }

        public List<Equipo> filtroUsuario2(string UsuarioResponsable)
        {
            var productosFiltrados =
                equipos.Where(x => x.UsuarioResponsable == UsuarioResponsable).ToList();
            if (productosFiltrados != null)
                return (List<Equipo>)productosFiltrados;
            else throw new Exception("No existen productos con ese usuario responsable");
        }

        //Método de mostrar
        public List<Equipo> mostrarEquipo()
        {
            return equipos.ToList();
        }

        //Método de buscar
        public List<Equipo> buscarEquipo(string categoria)
        {
            var equiposBuscados = equipos.Where(x => x.Categoria == categoria).ToList();
            if (equiposBuscados.Any())
                return equiposBuscados;
            else
                throw new Exception("No hay equipos registrados en esta categoría");
        }

        //Método de eliminar
        public void eliminarEquipo(Equipo equipo)
        {
            equipos.Remove(equipo);
            SaveChanges();
        }

        //Método de actualizar
        public void actualizarEquipo(Equipo equipoActualizado)
        {
            var equipoAntiguo = equipos.FirstOrDefault(x => x.Categoria == equipoActualizado.Categoria);
            if (equipoAntiguo != null)
            {
                equipoAntiguo.NombreEquipo = equipoActualizado.NombreEquipo;
                equipoAntiguo.NombreJugador = equipoActualizado.NombreJugador;
                equipoAntiguo.Puntaje = equipoActualizado.Puntaje;
                equipoAntiguo.Categoria = equipoActualizado.Categoria;

                SaveChanges();
            }
            else throw new Exception("Este equipo no está registrado");
        }

        #endregion

        #region Métodos de Torneo

        //Método de agregar
        public void agregarTorneo(Torneo torneo)
        {
            torneos.Add(torneo);
            SaveChanges();
        }

        public List<Torneo> filtroUsuario(string UsuarioResponsable)
        {
            var torneosFiltrados = torneos.Where(x => x.UsuarioResponsable == UsuarioResponsable).ToList();
            if (torneosFiltrados != null)
                return (List<Torneo>)torneosFiltrados;
            else throw new Exception("No existen productos con ese usuario responsable");
        }

        //Método de mostrar
        public List<Torneo> mostrarTorneo()
        {
            return torneos.ToList();
        }

        public Torneo buscarTorneo(int id)
        {
            var  torneoBuscado = torneos.FirstOrDefault(x => x.Id == id);
            if (torneoBuscado != null)
                return torneoBuscado;
            else throw new Exception("Este producto no está registrado");
        }

        //Método de eliminar
        public void eliminarTorneo(Torneo torneo)
        {
            torneos.Remove(torneo);
            SaveChanges();
        }

        //Método de actualizar
        public void actualizarTorneo(Torneo torneoActualizado)
        {
            var torneoAntiguo = torneos.FirstOrDefault(x => x.CategoriaEnfrentar == torneoActualizado.CategoriaEnfrentar);
            if (torneoAntiguo != null)
            {
                torneoAntiguo.CodigoNumerico = torneoActualizado.CodigoNumerico;
                torneoAntiguo.FechaTorneo = torneoActualizado.FechaTorneo;
                torneoAntiguo.PremioDolar = torneoActualizado.PremioDolar;
                torneoAntiguo.CategoriaEnfrentar = torneoActualizado.CategoriaEnfrentar;
                SaveChanges();
            }
            else throw new Exception("Este torneo no está registrado");
        }

        #endregion

        #region Métodos de Usuario


        //Método de mostrar
        public List<Usuario> mostrarUsuarios()
        {
            return usuarios.ToList();
        }

        //Método de agregar
        public void agregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
            SaveChanges();
        }

        //Método de eliminar
        public void eliminarUsuario(Usuario usuario)
        {
            usuarios.Remove(usuario);
            SaveChanges();
        }

        //Método de actualizar
        public void actualizarProducto(Usuario usuarioActualizado)
        {
            var usuarioAntiguo = usuarios.FirstOrDefault(x => x.User == usuarioActualizado.User);
            if (usuarioAntiguo != null)
            {
                usuarioAntiguo.Nombre = usuarioActualizado.Nombre;
                usuarioAntiguo.Genero = usuarioActualizado.Genero;
                usuarioAntiguo.FechaRegistro = usuarioActualizado.FechaRegistro;
                usuarioAntiguo.Estado = usuarioActualizado.Estado;
                usuarioAntiguo.User = usuarioActualizado.User;
                usuarioAntiguo.Pass = usuarioActualizado.Genero;
                SaveChanges();
            }
            else throw new Exception("Este usuario no está registrado");
        }


        //Método de validación de usuario
        public Usuario validarLogin(string user, string pass)
        {
            var usuarioLogueado = usuarios.FirstOrDefault(u => u.User == user
            && u.Pass == pass);
            if (usuarioLogueado != null)
                return usuarioLogueado;
            else throw new Exception("Datos de inicio de sesión incorrectos");
        }

        #endregion

    }
}
