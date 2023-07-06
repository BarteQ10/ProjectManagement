namespace ProjectManagement.Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User AssignedTo { get; set; }
        public TaskStatus Status { get; set; }
        public Sprint Sprint { get; set; }
        public Project Project { get; set; } // Referencja do projektu, gdy zadanie jest w backlogu
    }
}
