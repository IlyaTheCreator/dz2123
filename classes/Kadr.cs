using System;
using DZ2.entities;

namespace DZ2.classes {
  class Kadr : Worker, IKadr {
    public Kadr(string name, string position) : base(name, position) {}

    public Student CreateStudent(string name, string workerGroup) {
      return new Student(name, workerGroup);
    }

    public Teacher CreateTeacher(string name, string position) {
      return new Teacher(name, position);
    }
  }
}