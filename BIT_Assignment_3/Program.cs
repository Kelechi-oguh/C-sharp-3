using System.Numerics;

namespace BIT_Assignment_3
{
    class BIT
    {
        public static void Main(string[] args)
        {
            Hospital hospital_1 = new Hospital("King General Hospital", "Festac, Lagos");

            //Create a Doctor
            Doctor doctor_1 = new Doctor("Okereke Micheal", "Surgeon");
            Doctor doctor_2 = new Doctor("Steven Fisher", "Cardiologist");

            //Create a Patient
            Patient patient_1 = new Patient("Dami Salako", "2nd Ave, A close, house 30, Festac, Lagos");
            Patient patient_2 = new Patient("Ike Racheal", "1st Ave, C close, house 4, Festac, Lagos");

            // Add the doctor
            hospital_1.AddDoctor(doctor_1);
            hospital_1.AddDoctor(doctor_2);
            hospital_1.AddPatient(patient_1);
            hospital_1.AddPatient(patient_2);


            //Print the hospital, doctors and patients
            Console.WriteLine("Hospital: " + hospital_1.Name);

            Console.WriteLine("\nDoctors: ");
            int count = 0;
            foreach (Doctor doctor in hospital_1.Doctors)
            {
                count++;
                Console.WriteLine("{0}.  Name: {1}.     Specialization: {2}", count, doctor.Name, doctor.Specialization);
            }

            Console.WriteLine("\nPatients: ");
            count = 0;
            foreach (Patient patient in hospital_1.Patients)
            {
                count ++;
                Console.WriteLine("{0}.  Name: {1}.     Address: {2}", count, patient.Name, patient.Address);
            }
        }
    }

    public class Hospital
    {
        // class properties
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }

        // constructors
        public Hospital (string name, string location)
        {
            Name = name;
            Location = location;
            Doctors = new List<Doctor> ();
            Patients = new List<Patient> ();
        }

        // methods
        public void AddDoctor (Doctor doctor)
        {
            Doctors.Add (doctor);
        }

        public void AddPatient (Patient patient)
        {
            Patients.Add (patient);
        }

    }

    public class Doctor
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Doctor(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }
    }

    public class Patient
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Patient(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}