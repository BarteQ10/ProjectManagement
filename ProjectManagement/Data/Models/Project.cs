﻿namespace ProjectManagement.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Sprint> Sprints { get; set; }
        public List<Task> Backlog { get; set; }
    }
}