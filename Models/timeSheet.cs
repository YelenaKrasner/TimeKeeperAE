using System;

namespace TimeKeeper.Models
{
    public class timeSheet
    {
        public string name { get; set; }
        public string department { get; set; }
        public string projectName { get; set; }
        public DateTime timeIn { get; set; }
        public DateTime timeOut { get; set; }
    }
}
