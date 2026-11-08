namespace Domain;
public class Doctor : Person
{
    public List<Patient> Patients {get;set;}
    public Specialization Specialization {get;set;}
    public Doctor(Specialization _specialization, string _name, int _age) :base(_name, _age)
    {
        Patients = new List<Patient>();
        Specialization = _specialization;
    }
    public override string GetInfo()//информация о докторе и пациента
    {
        string result = $"Name: {Name}, Age: {Age}, Specialization: {Specialization}\nPatient Info:\n";
        foreach (var patients in Patients)
        {
            result += $"Name:{patients.Name}, Age: {patients.Age}, BloodType: {patients.BloodType},/n";
        }
        return result;
    }
    public void AddPatient(Patient patient)//добавление пациента
    {
        Patients.Add(patient);
        System.Console.WriteLine("Patient Added!");
    }
}