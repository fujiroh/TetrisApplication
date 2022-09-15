using System.Collections.Generic;

namespace TaskPlacer
{
    public class Person
    {
        public string Name { get; set; }
        public int[] Schedule { get; set; }

        public Person(string name, int maxDay)
        {
            Name = name;
            Schedule = new int[maxDay];
        }

        private int CalcMaxSchedule()
        {
            return 0;
        }
    }
}