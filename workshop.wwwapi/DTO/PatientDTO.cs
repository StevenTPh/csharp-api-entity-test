﻿namespace workshop.wwwapi.DTO
{
    public class PatientDTO
    {
        public string FullName { get; set; }
        public List<AppointmentPatientDTO> Appointments { get; set; } = new List<AppointmentPatientDTO>();

    }
}