using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feedback_Management.Models
{
    public class Feedback
    {
        public int Enrollment { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

    }
}