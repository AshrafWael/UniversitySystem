using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UniversitySystem.Data.Entities;

namespace UniversitySystem.Core.Features.Students.Queries.Models
{
    // Requst (GetStudentListQuery) Response(List<Student>)
    public class GetStudentListQuery :IRequest<List<Student>>
    {

    }
}
