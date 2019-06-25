using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    //constractor
    public Book()
    {
      grades = new List<double>();
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    // fields
    List<double> grades;
  }
}