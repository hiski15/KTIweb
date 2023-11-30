using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        { 
            new Student { StudentId = 1, Name = "Danang", Email = "danang@gmail.com",BirthDate = new DateOnly(1980, 1, 10)},
            new Student { StudentId = 1, Name = "Budi", Email = "budi@gmail.com",BirthDate = new DateOnly(1980, 1, 10)},
            new Student { StudentId = 1, Name = "Hadi", Email = "hadi@gmail.com",BirthDate = new DateOnly(1980, 1, 10)},
            new Student { StudentId = 1, Name = "Ucup", Email = "ucupskie@gmail.com",BirthDate = new DateOnly(1980, 1, 10)},
            new Student { StudentId = 1, Name = "Paimon", Email = "paimon@gmail.com",BirthDate = new DateOnly(1980, 1, 10)},

        };
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.First(s=> s.StudentId == id);
        }
    }
}