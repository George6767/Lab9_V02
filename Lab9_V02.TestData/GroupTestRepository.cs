using Lab9_V02.Domain.Etities;
using Lab9_V02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.TestData
{
    public class GroupTestRepository : IRepository<Group>
    {
        private readonly List<Group> groups;

        public GroupTestRepository(List<Group> groups)
        {
            this.groups = groups;
        }
        private void SetupData()
        {

          }
        public void Create(Group entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Group> Find(Expression<Func<Group, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Group Get(int id, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Group entity)
        {
            throw new NotImplementedException();
        }
    }
}
