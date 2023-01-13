using System;
using Microsoft.EntityFrameworkCore;
using StudentPlus.DomainModels;
using StudentPlus.Enums;

namespace StudentPlus.DataRepositories
{
    public partial class SupervisorRepository
    {
        private readonly AppDbContext _context;

        public SupervisorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Supervisor supervisor)
        {
            try
            {
                await _context.Supervisor.AddAsync(supervisor);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        public async Task<Supervisor> RetrieveAsync(string supervisorNum, string password)
        {
            try
            {
                return await _context.Supervisor
                    .Where(x => x.SupervisorNumber == supervisorNum && x.Password == password)
                    .FirstOrDefaultAsync();
            }
            catch
            {
                throw new Exception(ErrorType.UserNotFoundInDatabase.ToString());
            }
        }

        public async Task<bool> DeleteAsync(string supervisorId)
        {
            var user = await _context.Supervisor.FirstOrDefaultAsync(supervisor => supervisor.SupervisorId == supervisorId);

            if (user != null)
            {
                _context.Supervisor.Remove(user);
                await _context.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Supervisor> UpdateAsync(Supervisor supervisor)
        {
            var sup = await _context.Supervisor.FirstOrDefaultAsync(supervisor => supervisor.SupervisorId == supervisor.SupervisorId);

            if (sup != null)
            {
                _context.Entry(supervisor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();

                return await _context.Supervisor.FirstOrDefaultAsync(supervisor => supervisor.SupervisorId == supervisor.SupervisorId);
            }
            else
            {
                throw new Exception("Supervisor not found");
            }
        }

        //public List<Supervisor> GetSupervisorsByStudent(string studentId)
        //{
        //    return _context.Supervisor.Where(s => s.SupervisorId == studentId).ToList();
        //}
    }
}

