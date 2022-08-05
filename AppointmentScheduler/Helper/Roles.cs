using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppointmentScheduler.Helper
{
    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Doctor = "Doctor";
        public const string Patient = "Patient";

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            if (isAdmin)
            {
                return new List<SelectListItem>
            {
                new SelectListItem{ Value = Roles.Admin, Text = Roles.Admin }
            };
            }
            else
            {
                return new List<SelectListItem>
            {
                new SelectListItem{ Value = Roles.Doctor, Text = Roles.Doctor },
                new SelectListItem{ Value = Roles.Patient, Text = Roles.Patient }
            };
            }
            
        }
    }
}
