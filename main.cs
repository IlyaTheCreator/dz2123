using System;
using DZ2.classes;

class Program {
  public static void Main (string[] args) {
    Kadr kadr = new Kadr("Иванова Мария Ивановна", "очень хорошая должность");
    Student student = kadr.CreateStudent("Зубенко Михаил Петрович", "3-1П9");
    Teacher teacher = kadr.CreateTeacher("Петров Иван Иванович", "крутая должность");

    Console.WriteLine("Студент:");
    Console.WriteLine(student.GetName());
    Console.WriteLine(student.GetGroup());
    Console.WriteLine(student.DropOut());
    Console.WriteLine("");

    Console.WriteLine("Преподаватель:");
    Console.WriteLine(teacher.GetName());
    Console.WriteLine(teacher.GetPosition());
    Console.WriteLine(teacher.GiveLecture());

    Console.WriteLine("");

    Console.WriteLine("Кадровик:");
    Console.WriteLine(kadr.GetName());
    Console.WriteLine(kadr.GetPosition());
  }
}