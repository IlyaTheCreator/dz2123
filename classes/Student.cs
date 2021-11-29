using System;
using DZ2.entities;

namespace DZ2.classes {
  class Student : Person, IStudent {
    string _workerGroup;

    public Student(string name, string workerGroup) : base(name) {
      this._workerGroup = workerGroup;
    }

    public string GetGroup() {
      return $"Моя группа: {this._workerGroup}";
    }

    public string DropOut() {
      return "Я тикаю!";
    }
  }
}