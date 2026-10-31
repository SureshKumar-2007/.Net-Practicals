using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;
using PlacementDashboard.Models;

namespace PlacementDashboard.Controllers
{
    public class PlacementController : Controller
    {
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();

            string cs = ConfigurationManager
                .ConnectionStrings["PlacementDBConnectionString"]
                .ConnectionString;

            int total = 0;
            int placed = 0;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query = "SELECT * FROM Students";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student();

                    s.StudentID = Convert.ToInt32(reader["StudentID"]);
                    s.StudentName = reader["StudentName"].ToString();
                    s.Department = reader["Department"].ToString();
                    s.Company = reader["Company"].ToString();
                    s.Package = Convert.ToDecimal(reader["Package"]);
                    s.Status = reader["Status"].ToString();

                    students.Add(s);
                }

                reader.Close();

                total = students.Count;

                foreach (Student s in students)
                {
                    if (s.Status == "Placed")
                    {
                        placed++;
                    }
                }
            }

            ViewBag.TotalStudents = total;
            ViewBag.PlacedStudents = placed;

            ViewBag.PlacementPercentage =
                total > 0 ? (placed * 100.0 / total) : 0;

            return View(students);
        }
    }
}