﻿namespace BattleFight.Models
{
    public class Torneo
    {
        //Atributos
        private int id;
        private int codigoNumerico;
        private DateOnly fechaTorneo;
        private double premioDolar;
        private string categoriaEnfrentar;


        //Contructor 
        public Torneo(int id, int codigoNumerico, DateOnly fechaTorneo, double premioDolar, string categoriaEnfrentar)
        {
            this.Id = id;
            this.CodigoNumerico = codigoNumerico;
            this.FechaTorneo = fechaTorneo;
            this.PremioDolar = premioDolar;
            this.CategoriaEnfrentar = categoriaEnfrentar;
        }

        //Contructor vacio
        public Torneo()
        {
            this.Id = 0;
            this.CodigoNumerico = 0;
            this.FechaTorneo = DateOnly.FromDateTime(DateTime.Now);
            this.PremioDolar = 0;
            this.CategoriaEnfrentar = " ";
        }

        //Propiedades

        public int Id { get => id; set => id = value; }
        public int CodigoNumerico { get => codigoNumerico; set => codigoNumerico = value; }
        public DateOnly FechaTorneo { get => fechaTorneo; set => fechaTorneo = value; }
        public double PremioDolar { get => premioDolar; set => premioDolar = value; }
        public string CategoriaEnfrentar { get => categoriaEnfrentar; set => categoriaEnfrentar = value; }

    }
}
