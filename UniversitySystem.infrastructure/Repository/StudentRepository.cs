using Microsoft.EntityFrameworkCore;
using UniversitySystem.Data.Entities;
using UniversitySystem.infrastructure.Data;
using UniversitySystem.infrastructure.Abstracts;

namespace UniversitySystem.infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        #region Fields
        private readonly ApplicationDBContext _dBContext;
        #endregion

        #region Constractor
        public StudentRepository(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        #endregion

        #region Interface Implimentation  
        public async Task<List<Student>> GetStudentListAsync()
        {
            return await _dBContext.students.ToListAsync();
        }

        #endregion
    }
}
