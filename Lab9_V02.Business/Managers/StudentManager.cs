﻿using Lab9_V02.Domain.Etities;
using Lab9_V02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.Business.Managers
{
    public class StudentManager : BaseManager
    {
        public StudentManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
            #region basic CRUD operations 
            public bool DeleteStudent(int id)
            {
                var result = studentRepository.Delete(id);
                if (!result)
                    return false;
                unitOfWork.SaveChanges();
                return true;
            }
            public IEnumerable<Student> FindStudent(Expression<Func<Student, bool>> predicate) =>
            studentRepository.Find(predicate);
            public Student GetStudentById(int id) => studentRepository.Get(id);
            public IEnumerable<Student> GetAllStudents() => studentRepository.GetAll();
            public void UpdateStudent(Student student)
            {
                studentRepository.Update(student);
                unitOfWork.SaveChanges();
            }
            #endregion
    }

}

