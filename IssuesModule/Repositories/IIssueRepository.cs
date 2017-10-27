using System.Collections.Generic;
using IssuesModule.Model;

namespace IssuesModule.Repositories
{
    public interface IIssueRepository
    {
        IEnumerable<Issue> getList();
        Issue get(int Id);
        void Add(Issue issue);
        void Update(Issue issue);
        void Delete(int Id);
    }
}