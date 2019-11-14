using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;


namespace ListOfObjects
{

    class Person
    {
        public static int Count = 0;
        
        public string firstname;
        public string lastname;
        public int age;
        
        public Person(string _firstname, string _lastname, int _age)
        {
            firstname = _firstname;
            lastname = _lastname;
            age = _age;

            Count++;

        }
        
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            string filePath = @"/Users/katlinpaju/Demo/people.rtf";
            List<string> listOfPeople = File.ReadAllLines(filePath).ToList();
            List<Person> listOfPersonObjects= new List<Person>();

            foreach (string Line in listOfPeople)
            {
                string[]tempArray=Line.Split(new char[] {',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                //Person newPerson=new Person(tempArray[0],tempArray[1],int.Parse(tempArray[2]));
                //listOfPersonObjects.Add(newPerson);


            }

            /*foreach (Person person in listOfPersonObjects)
            {
                Console.WriteLine($"{person.firstname} {person.lastname} age {person.age} is on your list.");
            }*/
            
        }
    }
}