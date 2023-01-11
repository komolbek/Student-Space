using System;
using Student_plus.Db_Contexts;
using Student_plus.Domain_models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Student_plus.Interfaces;
using Student_plus.Enums;

namespace Student_plus.Data_Repositories
{
    public partial class StudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public void Save(Student user)
        {
            if (user is Student student)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
            }
        }

        public void Delete(int userId)
        {
            // todo: implement
        }

        public void Update(Student user)
        {
            if (user is Student student)
            {
                _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public Student GetStudentById(int userId)
        {
            try
            {
                var student = _context.Students.Find(userId);
                if (student != null)
                {
                    return _context.Students.Find(userId)!;
                }
                else
                {// TODO: fix duplication of exception
                    throw new Exception(ErrorType.UserNotFoundInDatabase.ToString());
                }
            }
            catch
            {
                throw new Exception(ErrorType.UserNotFoundInDatabase.ToString());
            }
        }

        public List<Student> GetStudentsBySupervisor(int supervisorId)
        {
            return _context.Students.Where(s => s.SupervisorId == supervisorId).ToList();
        }
    }
}

