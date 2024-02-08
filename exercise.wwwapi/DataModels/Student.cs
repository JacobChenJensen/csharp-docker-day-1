﻿using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.wwwapi.DataModels
{
    [Table("students")]
    public class Student
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("date_of_birth")]
        public string DateOfBirth { get; set; }
        [Column("course_title")]
        public string CourseTitle { get; set; }
        [Column("start_date")]
        public DateTime StartDate { get; set; }
        [Column("grade")]
        public float Grade { get; set; }

    }
}
