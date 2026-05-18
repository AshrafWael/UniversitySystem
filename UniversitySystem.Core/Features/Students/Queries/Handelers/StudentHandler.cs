using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UniversitySystem.Core.Features.Students.Queries.Models;
using UniversitySystem.Data.Entities;
using UniversitySystem.infrastructure.Abstracts;
using UniversitySystem.Service.Abstracts;

namespace UniversitySystem.Core.Features.Students.Queries.Handelers
{
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<Student>>

    {
        #region Fields
        private readonly IStudentService _studentService;


        #endregion

        #region Constractor

        public StudentHandler(IStudentService studentService)
        {
          _studentService = studentService;
        }
        #endregion

        #region Hndel Function


        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
         return await _studentService.GetStudentsAsync();
        }


        #endregion
    }
}
