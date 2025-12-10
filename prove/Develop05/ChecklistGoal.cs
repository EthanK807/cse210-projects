using System.Runtime.CompilerServices;

class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, string points, int target, int bonus) 
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }
        public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountComplete) 
            : base(name, description, points)
        {
            _amountCompleted = amountComplete;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            string checkbox = IsComplete() ? "[X]" : "[ ]";
            return $"{checkbox} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
        }

        public int GetBonus() => _bonus;
        
        public void SetCurrentAmount(int amount)
        {
            _amountCompleted = amount;
        }
    }