namespace Domain;

public class Appointment
{
    public string Id {get;set;}
    public Patient Patient {get;set;}
    public Doctor Doctor {get;set;}
    public DateTime Date {get;set;}
    public AppointmentStatus Status {get;set;}
}