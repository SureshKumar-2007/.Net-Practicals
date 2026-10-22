using System.Collections.Generic;
using System.Web.Mvc;

namespace Feedback_Management.Controllers
{
    public class FeedbackController : Controller
    {
        static List<FeedbackData> feedback = new List<FeedbackData>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(
            int enrollment,
            string name,
            string subject,
            int rating,
            string comment)
        {
            FeedbackData data = new FeedbackData();

            data.Enrollment = enrollment;
            data.Name = name;
            data.Subject = subject;
            data.Rating = rating;
            data.Comment = comment;

            feedback.Add(data);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(feedback);
        }
    }

    public class FeedbackData
    {
        public int Enrollment { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}