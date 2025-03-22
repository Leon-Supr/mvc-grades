namespace mvc_grades.Models
{
    public class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Act> Activities { get; set; }
    }
}
