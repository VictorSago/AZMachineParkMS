using System;

namespace AZMachineParkMS.Entities
{
    public class Machine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public MachineStatus Status { get; set; }
        public string LatestData { get; set; }

        public string StatusString => Status == MachineStatus.Online ? "Online" : "Offline";
    }
}
