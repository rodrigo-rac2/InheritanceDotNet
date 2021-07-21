﻿using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
    {
        this.testScores = scores;
    }

    public char Calculate()
    {
        double avg = calculateAverage(this.testScores);
        if (avg < 40)
            return 'T';
        else if (avg < 55 && avg >= 40)
            return 'D';
        else if (avg < 70 && avg >= 55)
            return 'P';
        else if (avg < 80 && avg >= 70)
            return 'A';
        else if (avg < 90 && avg >= 80)
            return 'E';
        else
            return 'O';
    }

    private double calculateAverage(int[] marks)
    {
        if (marks == null || marks.Count() == 0)
            return 0;

        double sum = 0;
        foreach (int mark in marks)
            sum += mark;

        return sum / marks.Count();
    }
}

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}