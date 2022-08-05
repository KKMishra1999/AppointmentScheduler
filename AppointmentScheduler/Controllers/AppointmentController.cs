using AppointmentScheduler.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppointmentScheduler.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        //[Authorize(Roles = Helper.Roles.Admin)]
        public IActionResult Index()
        {
            var doctors = _appointmentService.GetDoctorList();
            var patients = _appointmentService.GetPatientList();
            //ViewBag.DoctorList = doctors;
            ViewBag.DoctorList = new List<SelectListItem>();
            ViewBag.PatientList = new List<SelectListItem>();
            foreach (var doctor in doctors)
            {
                ViewBag.DoctorList.Add(new SelectListItem { Value = doctor.Id, Text = doctor.Name });
            }
            foreach (var patient in patients)
            {
                ViewBag.PatientList.Add(new SelectListItem { Value = patient.Id, Text = patient.Name });
            }
            return View();
        }
    }
}
