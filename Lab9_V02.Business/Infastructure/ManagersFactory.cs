using Lab9_V02.Business.Managers;
using Lab9_V02.Domain.Interfaces;
using Lab9_V02.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.Business.Infastructure
{
    public class ManagersFactory
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly StudentManager studentManager;
        private readonly GroupManager groupManager;

        public ManagersFactory()
        {
            unitOfWork = new TestUnitOfWork();
        }
        public StudentManager GetSudentManager()
        {
            return studentManager
            ?? new StudentManager(unitOfWork);
        }
        public GroupManager GetGroupManager()
        {
            return groupManager
            ?? new GroupManager(unitOfWork);
        }
    }
}
