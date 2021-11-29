using System;
using DZ2.entities;

namespace DZ2.classes {
  class Person : IPerson {
    string _name;

    public Person(string name) {
      this._name = name;
    }

    public string GetName() {
      return $"Мое имя: {this._name}";
    }
  } 
}