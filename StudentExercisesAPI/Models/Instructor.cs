using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class CreateInstructor : NSSPerson
    {
        public int Id { get; set; }
        public CreateCohort CreateCohort { get; set; }
        public string Speciality { get; set; }
        public int CohortId { get; set; }

        public void AssignExercise(CreateExercise exercise, CreateStudent student)
        {
            student.AddExercise(exercise);
        }

        // constructor
        //public CreateInstructor(string _firstName, string _lastName, string _slackHandle, CreateCohort Cohort, string _instructorSpecialty)
        //{
        //    FirstName = _firstName;
        //    LastName = _lastName;
        //    SlackHandle = _slackHandle;
        //    InstructorCohort = Cohort;
        //    InstructorSpecialty = _instructorSpecialty;
        //}
    }
}