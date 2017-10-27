using System.Collections.Generic;
using IssuesModule.Model;

namespace IssuesModule.Repositories
{
  public class IssueRepositoryInMemory : IIssueRepository
  {
    private int idCounter = 0;
    private readonly IssueCollection _issues;

    public IssueRepositoryInMemory()
    {
      _issues = new IssueCollection();
    }

    public IEnumerable<Issue> getList()
    {
      return _issues.toList();
    }

    public Issue get(int id)
    {
      return _issues.findIssue(id);
    }

    public void Add(Issue issue)
    {
      var newIssue = new Issue(++idCounter) { Title = issue.Title, Description = issue.Description}; 
      
      _issues.Add(newIssue);
    }

    public void Update(Issue issue)
    {
      _issues.Update(issue);
    }

    public void Delete(int id)
    {
      _issues.Remove(id);
    }
  }
}
