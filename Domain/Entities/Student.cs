﻿namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string NewColumn { get; set; }  // Cột mới

    }
}