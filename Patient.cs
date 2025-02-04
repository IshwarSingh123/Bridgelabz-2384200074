using System;
public class Patient
{
   //static variable to store hospital name
   private static string hospitalName = "City Hospital";

   //static variable to count the total number of patients admitted
   private static int totalPatients = 0;

   //instance variables for patient details
   private string name;
   private int age;
   private string ailment;
   private readonly string patientID;

   //to get hospital name
   public string GetHospitalName()
   {
       return hospitalName;
   }

   //to get patient name
   public string GetPatientName()
   {
       return name;
   }

   //to get patient age
   public int GetAge()
   {
       return age;
   }

   //to get ailment
   public string GetAilment()
   {
       return ailment;
   }

   //to get patient id
   public string GetPatientID()
   {
       return patientID;
   }

   //constructor to initialize patient details
   public Patient(string name, int age, string ailment, string patientID)
   {
       this.name = name;
       this.age = age;
       this.ailment = ailment;
       this.patientID = patientID;
       totalPatients++;
   }

   //method to get the total number of patients admitted
   public static int GetTotalPatients()
   {
       return totalPatients;
   }

   //method to display patient details
   public void DisplayPatientDetails()
   {
       if (this is Patient)
       {
           Console.WriteLine("Patient Details:\nName: {0}\nAge: {1}\nAilment: {2}\nPatient ID: {3}\n", GetPatientName(), GetAge(), GetAilment(), GetPatientID());
       }
       else Console.WriteLine("Invalid Patient Object!");
   }

   //method to display the hospital name
   public static void DisplayHospitalName()
   {
       Console.WriteLine("\nHospital: " + hospitalName + "\n");
   }
}

class Program7
{
   static void Main(string[] args)
   {
       //creating Patient objects and displaying patient details using 'DisplayPatientDetails()' method
       Patient patient1 = new Patient("Jay", 45, "Fever", "PZ120");
       patient1.DisplayPatientDetails();

       Patient patient2 = new Patient("Parineeti", 22, "Leg Fracture", "PH186");
       patient2.DisplayPatientDetails();

       //displaying total number of patients admitted
       Console.WriteLine("Total Patients Admitted: " + Patient.GetTotalPatients());

       //displaying the hospital name using 'DisplayHospitalName()' method
       Patient.DisplayHospitalName();

       //creating another patient
       Patient patient3 = new Patient("Shreya", 50, "Heart Attack", "PS867");
       patient3.DisplayPatientDetails();

       //displaying updated total number of patients admitted
       Console.WriteLine("Total Patients Admitted: " + Patient.GetTotalPatients());
   }
}