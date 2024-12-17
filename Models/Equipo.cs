namespace BattleFight.Models
{
    public class Equipo
    {
        //Atributos
        private int id;
        private string nombreEquipo;
        private string nombreJugador;
        private int puntaje;
        private string categoria;
        private string usuarioResponsable;

        //Contructor
        public Equipo(int id, string nombreEquipo, string nombreJugador, int puntaje, string categoria, string usuarioResponsable)
        {
            this.Id = id;
            this.NombreEquipo = nombreEquipo;
            this.NombreJugador = nombreJugador;
            this.Puntaje = puntaje;
            this.Categoria = categoria;
            this.UsuarioResponsable = usuarioResponsable;
        }

        //Contructor vacio
        public Equipo()
        {
            this.Id = 0;
            this.NombreEquipo = " ";
            this.NombreJugador = " ";
            this.Puntaje = 0;
            this.Categoria = " ";
            this.UsuarioResponsable = " ";
        }

        //Propiedades

        public int Id { get => id; set => id = value; }
        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string UsuarioResponsable { get => usuarioResponsable; set => usuarioResponsable = value; }
    }
}
