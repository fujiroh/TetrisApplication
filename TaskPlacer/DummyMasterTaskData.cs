using System;
using System.Collections.Generic;

namespace TaskPlacer
{
    public static class DummyMasterTaskData
    {
        private static int _taskId = 0; 
        
        public static IEnumerable<MasterTask> Create()
        {
            IEnumerable<MasterTask> tasList = new List<MasterTask>()
            {
                new MasterTask(AssignId(),10,NullDateTime.Null,NullDateTime.Null),
                new MasterTask(AssignId(),10,NullDateTime.Null,new DateTime(2022,8,25)),
                new MasterTask(AssignId(),10,new DateTime(2022,8,21),NullDateTime.Null),
                new MasterTask(AssignId(),10,new DateTime(2022,8,21),new DateTime(2022,8,25)),
                new MasterTask(AssignId(),10,new DateTime(2022,9,1),new DateTime(2022,9,5)),
                new MasterTask(AssignId(),10,new DateTime(2022,9,3),new DateTime(2022,9,9)),
            };
            return tasList;
        }

        private static int AssignId()
        {
            return ++_taskId;
        }
    }
}