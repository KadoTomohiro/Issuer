using System.Collections.Generic;
using IssuesModule.Model;
using IssuesModule.Repositories;

namespace IssuerApp
{
  public class IssueManager
  {
    private readonly IIssueRepository _issueRep;
    public IssueManager(IIssueRepository issueRepository)
    {
      _issueRep = issueRepository;
    }
    
    public void PostIssue (Issue issue)
    {
      _issueRep.Add(issue);
    }

    public void EditIssue(Issue issue)
    {
      _issueRep.Update(issue);
    }

    public void DeleteIssue(int id)
    {
      _issueRep.Delete(id);
    }

    public IEnumerable<Issue> GetIssueList()
    {
      return _issueRep.getList();
    }

    public Issue GetIssue(int id)
    {
      return _issueRep.get(id);
    }

    public void OpenIssue(int id)
    {
      GetIssue(id)?.Open();
    }

    public void CloseIssue(int id)
    {
      GetIssue(id)?.Close();
    }
  }
}
