# Проект: Медицинская Информационная Система

### Структура проекта
- **Domain** - classlib для сущностей
- **Infrastructure** - classlib для сервисов
- **MainApp** - console для работы с системой

### Описание классов

**`abstract class Person`**
- **`Свойства:`**
    - *`Id`* (string) - идентификатор
    - *`Name`* (string) - имя
    - *`Age`* (int) - возраст
- **`Абстрактные методы:`**
    - *`abstract string GetInfo()`* - информация о человеке

**`class Patient : Person`**
- **`Свойства:`**
    - *`MedicalHistory`* (List<MedicalRecord>) - история болезни
    - *`BloodType`* (enum BloodType) - группа крови
    - *`Appointments`* (List<Appointment>) - записи к врачу
- **`Методы:`**
    - *`override string GetInfo()`*
    - *`void AddAppointment(Appointment appointment)`*

**`class Doctor : Person`**
- **`Свойства:`**
    - *`Specialization`* (enum Specialization) - специализация
    - *`Patients`* (List<Patient>) - список пациентов
- **`Методы:`**
    - *`override string GetInfo()`*
    - *`void AddPatient(Patient patient)`*

**`class MedicalRecord`**
- **`Свойства:`**
    - *`Id`* (string) - идентификатор
    - *`Date`* (DateTime) - дата
    - *`Diagnosis`* (string) - диагноз
    - *`Treatment`* (string) - лечение
- **`Методы:`**
    - *`string GetSummary()`*

**`class Clinic`**
- **`Свойства:`**
    - *`Doctors`* (List<Doctor>)
    - *`Patients`* (List<Patient>)
    - *`Appointments`* (List<Appointment>)
- **`Методы:`**
    - *`void RegisterPatient(Patient patient)`*
    - *`void AddDoctor(Doctor doctor)`*
    - *`void CreateAppointment(Patient patient, Doctor doctor)`*
    - *`List<Doctor> FindDoctorsBySpecialization(Specialization spec)`*
    - *`List<Appointment> GetPatientAppointments(string patientId)`*
    - *`List<Patient> GetDoctorPatients(string doctorId)`*
    - *`void CancelAppointment(string appointmentId)`*
    - *`List<MedicalRecord> GetPatientHistory(string patientId)`*

**`class Appointment`**
- **`Свойства:`**
    - *`Id`* (string) - идентификатор
    - *`Patient`* (Patient) - пациент
    - *`Doctor`* (Doctor) - врач
    - *`DateTime`* (DateTime) - дата и время приёма
    - *`Status`* (enum AppointmentStatus) - статус приёма
- **`Методы:`**
    - *`void Cancel()`*
    - *`void Reschedule(DateTime newDateTime)`*
    - *`string GetAppointmentInfo()`*

### Перечисления

**`enum Specialization`**
- *`GeneralPractitioner`*
- *`Surgeon`*
- *`Pediatrician`*

**`enum BloodType`**
- *`APositive`*
- *`ANegative`*
- *`BPositive`*
- *`BNegative`*

**`enum AppointmentStatus`**
- *`Scheduled`*
- *`Completed`*
- *`Cancelled`*
- *`NoShow`*