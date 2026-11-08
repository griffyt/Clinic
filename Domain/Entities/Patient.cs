namespace Domain;

public class Patient : Person
{
    public BloodType BloodType {get;set;}
    public List<MedicalRecord> MedicalHistory {get;set;}
    public List<Appointment> Appointments {get;set;}
    
    public Patient(BloodType bloodType,string _name, int _age):base(_name, _age)
    {
        BloodType = bloodType;
        MedicalHistory = new List<MedicalRecord>();
        Appointments = new List<Appointment>();
    }
    public override string GetInfo()//информация о пациенте
    {
        string result = $"Name: {Name}, Age: {Age}\nHas these medical records:\n";
        foreach (var medical_history in MedicalHistory)
        {
            result += $"Medical Diagnosis :{medical_history.Diagnosis}, Medical Treatment: {medical_history.Treatment}\n";
        }
        foreach (var appointments in Appointments)
        {
            result += $"Date: {appointments.Date}, Medical Status: {appointments.Status}\n";
        }
        return result;
    }
    public void AddAppointment(Appointment appointment)//добавление приема пациента
    {
        Appointments.Add(appointment);
        System.Console.WriteLine("Appointment Added!");
    }
}