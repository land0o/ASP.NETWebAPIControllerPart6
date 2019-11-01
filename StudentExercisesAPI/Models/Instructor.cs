using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Speciality { get; set; }
        public int CohortId { get; set; }

        public void AssignExercise(Exercise exercise, Student student)
        {
            student.AddExercise(exercise);
        }

    }
}