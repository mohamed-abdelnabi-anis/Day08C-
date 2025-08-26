﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

       
        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
                
        public Student(Student other)
        {
            Id = other.Id;
            Name = string.Copy(other.Name); 
            Grade = other.Grade;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
        }
    }

}

