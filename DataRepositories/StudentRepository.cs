using System;
using StudentPlus.DomainModels;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StudentPlus.Interfaces;
using StudentPlus.Enums;

namespace StudentPlus.DataRepositories
{
    public partial class StudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Save(Student student)
        {
            try
            {
                _context.Student.Add(student);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        public Student GetStudentById(string userId)
        {
            try
            {
                var student = _context.Student.FirstOrDefault(u => u.StudentId == userId);
                if (student != null)
                {
                    return student!;
                }
                else
                {
                    throw new Exception(ErrorType.UserNotFoundInDatabase.ToString());
                }
            }
            catch
            {
                throw;
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

        

        //public List<Student> GetStudentsBySupervisor(string supervisorId)
        //{
        //    return _context.Students.Where(s => s.SupervisorNumber == supervisorId).ToList();
        //}
    }
}

