using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HourManager.Models
{
    public class TimeEntry
    {
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}