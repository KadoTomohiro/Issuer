using System.Collections.Generic;
using System.Linq;

namespace IssuesModule.Model
{
  public class IssueCollection
  {
    private readonly List<Issue> _issues;

    public IssueCollection(IEnumerable<Issue> list = null)
    {
      _issues = new List<Issue>(list ?? new Issue[]{});
    }

    public Issue findIssue(int id)
    {
      return _issues.Find(issue => issue.Id == id);
    }

    public IEnumerable<Issue> toList()
    {
      return _issues.ToList();
    }

    public void Add(Issue issue)
    {
      _issues.Add(issue);
    }

    public void Update(Issue issue)
    {
      var index = FindIndex(issue);
      _issues[index] = issue;
    }

    private int FindIndex(Issue issue)
    {
      return _issues.FindIndex(searchIssue => issue.Id == searchIssue.Id);
    }

    public void Remove(int id)
    {
      var issue = findIssue(id);
      _issues.Remove(issue);
    }

  }
}
