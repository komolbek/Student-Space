using System;
using StudentPlus.DomainModels;
using StudentPlus;
using Microsoft.EntityFrameworkCore;

namespace StudentPlus.DataRepositories
{
	public class SuperviseeRepository
	{
        private readonly AppDbContext _context;

        public SuperviseeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Supervisee> GetSuperviseeByStudentNumberAsync(string studentNumber)
        {
            try
            {
                var supervisee = await _context.Supervisee.SingleOrDefaultAsync(s => s.StudentNumber == studentNumber);
                return supervisee;
            }
            catch
            {
                throw;
            }
        }

        public async Task AddSuperviseeAsync(Supervisee supervisee)
        {
            try
            {
                await _context.Supervisee.AddAsync(supervisee);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

