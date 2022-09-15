using System;
using System.Collections.Generic;

namespace TaskPlacer
{
    public class MainController
    {
        private IList<MasterTask> _masterTasks;
        private IList<Person> _persons;

        public MainController(IList<MasterTask> masterTasks, IList<Person> persons)
        {
            _masterTasks = masterTasks;
            _persons = persons;
        }

        private int CalcMaxTheoryValue()
        {
            int maxDay = 0;
            
            foreach (var masterTask in _masterTasks)
            {
                // 開始可能日と締め切りあり
                if (masterTask.HasExecutable() && masterTask.HasDeadLine())
                {
                    maxDay += ((DateTime)masterTask.DeadLine).DayOfYear - ((DateTime)masterTask.Executable).DayOfYear;
                }
                // 開始日あり
                if (masterTask.HasExecutable())
                {
                    maxDay += masterTask.ProductionCost;
                }
                // 締め切りあり
                if (masterTask.HasDeadLine())
                {
                    maxDay += masterTask.ProductionCost;
                }
                // 自由
                maxDay += masterTask.ProductionCost;
            }

            return maxDay;
        }
    }
}