using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    //constractor
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatiscs()
    {
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      foreach (var number in grades)
      {
        highGrade = Math.Max(number, highGrade);
        lowGrade = Math.Min(number, lowGrade);
        result += number;
      }
      result /= grades.Count;
      Console.WriteLine($"The highGrade grade is {highGrade:N1}");
      Console.WriteLine($"The lowGrade grade is {lowGrade:N1}");
      Console.WriteLine($"The average grade is {result:N1}");
    }

    // fields
    private List<double> grades;
    private string name;
  }
}