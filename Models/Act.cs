namespace mvc_grades.Models
{
    public class Act
    {
        public int id { get; set; }
        public int subjectId { get; set; }
        public string type { get; set; } 
        public decimal grade { get; set; }
        public DateTime date { get; set; } 
        public virtual Subject Subject { get; set; } // Relación con el modelo Subject
    }
}
