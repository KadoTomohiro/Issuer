using System.Collections.Generic;
using Issues.Model;

namespace Issues.Repositories
{
    public interface IIssueRepository
    {
        IEnumerable<Issue> getAll();
        Issue get(string Id);
        void Add(Issue issue);
        void Update(Issue issue);
        void Delete(string Id);
    }
}