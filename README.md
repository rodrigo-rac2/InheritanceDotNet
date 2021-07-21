Task
You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the properties of Person.

Complete the Student class by writing the following:

A Student class constructor, which has  parameters:
A string, firstName.
A string, lastName.
An integer, idNumber.
An integer array (or vector) of test scores, scores.
A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:

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
        else (avg <= 100 && avg >= 90)
            return 'O';

Input Format

The locked stub code in the editor reads the input and calls the Student class constructor with the necessary arguments. It also calls the calculate method which takes no arguments.

The first line contains firstName, lastName, and idNumber, separated by a space. The second line contains the number of test scores. The third line of space-separated integers describes scores.

Output Format

Output is handled by the locked stub code. Your output will be correct if your Student class constructor and calculate() method are properly implemented.

Sample Input

Heraldo Memelli 8135627
2
100 80

Sample Output

 Name: Memelli, Heraldo
 ID: 8135627
 Grade: O

Explanation

This student had 2 scores to average: 100 and 80. The student's average grade is 90. An average grade of 90 corresponds to the letter grade O, so the calculate() method should return the character 'O'.