using System.ComponentModel;

class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, string points) : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            //Nothing since it is eternal
        }

        public override bool IsComplete()
        {
            return false; 
            // never finished so always false
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
        }
    }