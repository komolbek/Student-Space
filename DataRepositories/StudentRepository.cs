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
                _context.Students.Add(student);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
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
                {
                    throw new Exception(ErrorType.UserNotFoundInDatabase.ToString());
                }
            }
            catch
            {
                throw;
            }
        }

        //public List<Student> GetStudentsBySupervisor(string supervisorId)
        //{
        //    return _context.Students.Where(s => s.SupervisorNumber == supervisorId).ToList();
        //}
    }
}

