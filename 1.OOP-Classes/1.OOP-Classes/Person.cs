﻿using System;

public class Person
{
    private string name;
    private int age;
    private string email;



    public Person(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;

    }

    public Person(string name, int age)
        : this(name, age, null)
    {

    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The name must be not empty.");
            }
            this.name = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age", "Age must be in range [1...100]");
            }
            this.age = value;
        }
    }
    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value != null)
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email. A valid mail could be blank");
                }

            }
            this.email = value;
        }
    }


    public override string ToString()
    {
        string result = String.Format("Person name is {0}\nage:{1}\nemail:{2}", this.Name, this.Age, this.Email);
        return result;
    }


}

