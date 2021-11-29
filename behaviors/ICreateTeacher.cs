using System;
using DZ2.classes;

namespace DZ2.behaviors {
  interface ICreateTeacher {
    Teacher CreateTeacher(string name, string workerGroup);
  }
}