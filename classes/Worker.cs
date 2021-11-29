using System;
using DZ2.entities;

namespace DZ2.classes {
  class Worker : Person {
    string _position;

    public Worker(string name, string position) : base(name) {
      this._position = position;
    }

    public string GetPosition() {
      return $"Моя позиция: {this._position}";
    }
  }
}