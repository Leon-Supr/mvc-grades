namespace mvc_grades.Models
{
    public class Act
    {
        public int id { get; set; }
        public int subjectId { get; set; } // Relación con la materia
        public string type { get; set; }  // Tarea, Actividad, Prueba, etc.
        public decimal grade { get; set; } // Nota de la actividad
        public DateTime date { get; set; } // Fecha en que se realizó la actividad

        public virtual Subject Subject { get; set; } // Relación con el modelo Subject
    }
}
