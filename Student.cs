using System;
namespace newToCsharp
{
    public class Student
    {
        //CLASS ATTRIBUTES
        public string name;
        public string major;
        public string university;
        public double gpa;

        //CONSTRUCTOR
        public Student(string aName, string aMajor, string aUniversity, double aGpa)
        {
            name = aName;
            major = aMajor;
            university = aUniversity;
            gpa = aGpa;
        }


        //METHOD
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
