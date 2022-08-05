using AppointmentScheduler.Models.VIewModels;

namespace AppointmentScheduler.Services
{
    public interface IAppointmentService
    {
        List<DoctorVM> GetDoctorList();
        List<PatientVM> GetPatientList();
        public Task<int> AddUpdate(AppointmentVM model);
        public List<AppointmentVM> DoctorsEventsById(string doctorId);
        public List<AppointmentVM> PatientsEventsById(string patientId);
        public AppointmentVM? GetById(int id);
        public Task<int> Delete(int id);
        public Task<int> ConfirmEvent(int id);

    }
}
