namespace AppointmentScheduler.Helper
{
    public static class StatusCodes
    {
        public static string appointmentAdded = "Appointment added successfully";
        public static string appointmentUpdated = "Appointment updated successfully";
        public static string appointmentDeleted = "Appointment deleted successfully";
        public static string appointmentExists = "Appointment for selected date and time already exists";
        public static string appointmentNotExists = "Appointment not exists";
        public static string meetingConfirm = "Meeting confirm successfully.";
        public static string meetingConfirmError = "Error while confirming meeting.";
        public static string appointmentAddError = "Something went wrong, Please try again";
        public static string appointmentUpdateError = "Something went wrong, Please try again";
        public static string somethingWentWrong = "Something went wrong, Please try again";
        public static int success_code = 1;
        public static int failure_code = 0;
    }
}
