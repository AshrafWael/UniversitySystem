
using UniversitySystem.Data.Entities;

namespace UniversitySystem.Service.Abstracts
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsAsync();
    }
}
