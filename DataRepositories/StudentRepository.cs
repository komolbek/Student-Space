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

        public async Task InsertAsync(Student student)
        {
            try
            {
                await _context.Student.AddAsync(student);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        public async Task<Student> RetrieveAsync(string studentNum, string password)
        {
            try
            {
                return await _context.Student
                    .Where(x => x.StudentNumber == studentNum && x.Password == password)
                    .FirstOrDefaultAsync();
            }
            catch
            {
                throw new Exception(ErrorType.UserNotFoundInDatabase.ToString());
            }
        }

        public async Task<bool> DeleteAsync(string studentId)
        {
            var user = await _context.Student.FirstOrDefaultAsync(student => student.StudentId == studentId);

            if (user != null)
            {
                _context.Student.Remove(user);
                await _context.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Student> UpdateAsync(Student student)
        {
            var stud = await _context.Student.FirstOrDefaultAsync(student => student.StudentId == student.StudentId);

            if (stud != null)
            {
                _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();

                return await _context.Student.FirstOrDefaultAsync(student => student.StudentId == student.StudentId);
            }
            else
            {
                throw new Exception("Student not found");
            }
        }

        //public List<Student> GetStudentsBySupervisor(string supervisorId)
        //{
        //    return _context.Students.Where(s => s.SupervisorNumber == supervisorId).ToList();
        //}
    }
}

