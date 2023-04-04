using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutPlanner
{
    internal class Exercise
    {
        public Exercise() 
        {
            _name = "";
            _sets = 0;
            _reps = 0;
            _muscleGroup = "";
        }

        protected string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int _sets;
        public int sets
        {
            get { return _sets; }
            set { _sets = value; }
        }

        protected int _reps;
        public int reps
        {
            get { return _reps; }
            set { _reps = value; }
        }

        protected string _muscleGroup;
        public string muscleGroup
        {
            get { return _muscleGroup; }
            set { _muscleGroup = value; }
        }
    }
}
