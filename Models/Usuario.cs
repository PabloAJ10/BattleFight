namespace BattleFight.Models
{
    public class Usuario
    {
        //Atributos
        private int id;
        private string nombre;
        private int cedula;
        private string genero;
        private DateOnly fechaRegistro;
        private string estado;
        private string user;
        private string pass;



        //Contructor
        public Usuario(int id, string nombre, int cedula, string genero, DateOnly fechaRegistro, string estado, string user, string pass)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Genero = genero;
            this.FechaRegistro = fechaRegistro;
            this.Estado = estado;
            this.User = user;
            this.Pass = pass;
        }


        //Contructor vacio

        public Usuario()
        {
            this.Id = 0;
            this.Nombre = " ";
            this.Cedula = 0;
            this.Genero = " ";
            this.FechaRegistro = DateOnly.FromDateTime(DateTime.Now);
            this.Estado = " ";
            this.User = " ";
            this.Pass = " ";
        }


        //Propiedades

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateOnly FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public string Estado { get => estado; set => estado = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

    }
}
