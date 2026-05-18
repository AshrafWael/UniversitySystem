
using UniversitySystem.Data.Entities;
using UniversitySystem.infrastructure.Abstracts;
using UniversitySystem.Service.Abstracts;
namespace UniversitySystem.Service.Implimentation
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;

        #endregion

        #region Constractor
        public StudentService(IStudentRepository studentRepository)
        {
           _studentRepository = studentRepository;
        }

        #endregion

        #region Interface Implimentation  

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentRepository.GetStudentListAsync();
        }


        #endregion
    }
}
