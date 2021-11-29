using System;
using DZ2.classes;

namespace DZ2.behaviors {
  interface ICreateStudent {
    Student CreateStudent(string name, string workerGroup);
  }
}