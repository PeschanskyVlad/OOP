using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Lab1
{
    class Program
    {

        

        static void Main(string[] args)
        {

            ClassVotes Votes = new ClassVotes();

          



          
            Citizen Tom = new Citizen("Tom",22, 60, "M");
            Employee Bill = new Employee("Bill",22, 60, "M");

            Votes.rightWay(Tom,Votes);
            Votes.rightWay(Bill,Votes);

           

            Votes.IsItTime();

            Employee Joe = new Employee("Joe",23, 100, "M");
            //Joe.learnMatan();

            FSBAgent<Employee> Dimon = new FSBAgent<Employee>(Joe);

            /*
            try
            {
                Tom.setAge(-1);
            }
            catch (MyException exeption)
            {
                Console.WriteLine("Error : " + exeption.Message + "(" + exeption.AgeV + ")");
            }

            Joe.writeLabs();*/

            VerchovnaRada goverment = new VerchovnaRada("Ukraine",6);

            Oligharks oligharks = new Oligharks();
            oligharks.AddOligarch(new Employee("Poroshenko", 52, 100, "M"));
            oligharks.AddOligarch(new Employee("Kolomoysky", 54, 100, "M"));
            oligharks.AddOligarch(new Employee("Achmetov", 50, 100, "M"));

            foreach (Employee oligarch in oligharks)
            {
                oligarch.showPersonalData();
            }

            // Employee Test = oligharks.GetOligharchByName("Poroshenko");
            // Test.showPersonalData();
           




             Employee Lyashcko = new Employee("Lyashcko", 52, 60, "M");
            Employee Senya = new Employee("Senya", 39, 60, "M");
            Employee Oleg = new Employee("Oleg", 44, 60, "M");


            goverment.addServant(Lyashcko);
            goverment.addServant(Senya);
            goverment.addServant(Oleg);

            Console.WriteLine(" ");
            Console.WriteLine("All servants:");
            goverment.showServants();
            Console.WriteLine(" ");
            Console.WriteLine("Sort servants by age:");

            goverment.sortServantsByAge();

            goverment.showServants();

            goverment.AddFSBAgent(Dimon);

            /*goverment.AddOligarch(new Employee("Poroshenko", 52, 100, "M"));
            goverment.AddOligarch(new Employee("Kolomoysky", 54, 100, "M"));
            goverment.AddOligarch(new Employee("Achmetov", 50, 100, "M"));

            Console.WriteLine(" ");
            Console.WriteLine("All oligarchs:");

            foreach (Employee oligarch in goverment)
            {
                oligarch.showPersonalData();
            }*/

            goverment.work();
            goverment.showDay();

            Console.WriteLine(" ");
            Console.WriteLine("Object for binary serialization");



           // Employee Volunteer1 = new Employee("Pavlik", 36, 67, "M");
            Citizen Volunteer2 = new Citizen("Mazai", 25, 50, "M");

            BinaryFormatter formatter = new BinaryFormatter();

            XmlSerializer formatter1 = new XmlSerializer(typeof(Citizen));


            using (FileStream fs = new FileStream("Goverment.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, goverment);

                Console.WriteLine("Object serialized.");
            }



            using (FileStream fs = new FileStream("Volunteers.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Volunteer2);

                Console.WriteLine("Object serialized");
            }





            

           /* using (FileStream fs = new FileStream("Volunteers.dat", FileMode.OpenOrCreate))
            {
                Employee surviver1 = (Employee)formatter.Deserialize(fs);

                Console.WriteLine("Object 1 deserialized");

                surviver1.showPersonalData();
            }*/

            using (FileStream fs = new FileStream("Volunteers.xml", FileMode.OpenOrCreate))
            {
                Citizen surviver2 = (Citizen)formatter.Deserialize(fs);

                Console.WriteLine("Object 2 deserialized");           
                surviver2.showPersonalData();

            }

            using (FileStream fs = new FileStream("Goverment.dat", FileMode.OpenOrCreate))
            {
               
               VerchovnaRada lastOfUs = (VerchovnaRada)formatter.Deserialize(fs);
                Console.WriteLine(" ");
                Console.WriteLine("Last servants:");
                lastOfUs.showServants();

                
            }


           // int t = goverment.someCount("M");

            //Console.WriteLine("In goverment are "+t);

            Console.WriteLine("End...");
            Console.ReadKey();

            

        }

        
    }
}
