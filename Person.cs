﻿using System;
using System.Xml.Linq;

namespace c_sharp_crash
{
	public class Person
	{
        // Fields (private member variables)
        private string name;
        private int age;

        // Constructor (initialize fields)
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Properties (accessors for private fields)
        public string Name
        {
            get { return name; } // get triggers when you read a property
            set { name = value; } // set triggers when you write to a property
        }

        public int Age
        {
            get { return age; } //get triggers when you read a property
            set { age = value; } // set triggers when you write a property
        }

        // ALTERNATIVE: If you don't want to initialize the fields via constructor arguments, you can also
        // directly set property values. Just set person.Age or person.Name in the calling class / function
        // public string? Name { get; set; }
		// public int? Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}. I am {Age} years old.");
        }
    }
}

