abstract class Goal
    {
        private string _shortName;
        private string _description;
        private string _points;

        public Goal(string name, string description, string points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public string GetName() => _shortName;
        public string GetDescription() => _description;
        public int GetPoints() => int.Parse(_points);

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStringRepresentation();

        public virtual string GetDetailsString()
        {
            string checkbox = IsComplete() ? "[X]" : "[ ]";
            return $"{checkbox} {_shortName} ({_description})";
        }
    }