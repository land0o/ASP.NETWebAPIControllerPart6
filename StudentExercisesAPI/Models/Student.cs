using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class CreateStudent : NSSPerson
    {
        public int Id { get; set; }
        public int CohortId { get; set; }
        public CreateCohort CreateCohort { get; set; }

        public List<CreateExercise> StudentCurrentExercise = new List<CreateExercise>();

        public void AddExercise(CreateExercise exercise)
        {
            StudentCurrentExercise.Add(exercise);
        }
        // constructor
        //public CreateStudent(string _firstName, string _lastName, string _slackHandle, CreateCohort Cohort)
        //{
        //    FirstName = _firstName;
        //    LastName = _lastName;
        //    SlackHandle = _slackHandle;
        //    StudentCohort = Cohort;
        //}

    }
}