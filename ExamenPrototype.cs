using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExamen

{
    public abstract class ExamenPrototype
    {
        protected string _materia;
        protected string _docente;
        protected string _grupo;
        protected string _salon;
        protected string _estudiante;
        protected int _preguntas;
        protected int _rubrica;

        public string Materia { set => _materia = value; }
        public string Docente { set => _docente = value; }
        public string Grupo { set => _grupo = value; }
        public string Salon { set => _salon = value; }
        public string Estudiante { set => _estudiante = value; }
        public int Preguntas { set => _preguntas = value; }
        public int Rubrica { set => _rubrica = value; }

        public abstract ExamenPrototype Clone();

        public abstract string MostrarExamen();

        public abstract string Modalidad();
        public abstract string Revision();
        public abstract double Promediar();
    }
}
