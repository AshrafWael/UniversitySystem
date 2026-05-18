
using UniversitySystem.Data.Entities;
namespace UniversitySystem.infrastructure.Abstracts
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentListAsync();
    }
}
