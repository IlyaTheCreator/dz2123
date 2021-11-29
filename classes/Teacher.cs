using System;
using DZ2.entities;

namespace DZ2.classes { 
  class Teacher : Worker, ITeacher {
    public Teacher(string name, string position) : base(name, position) {}

    public string GiveLecture() {
      return "Преподаю лекцию...";
    }
  }
}