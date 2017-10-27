using System;
using System.Linq;
using IssuesModule.Model;
using IssuesModule.Repositories;
using Xunit;

namespace IssuesTest
{
  public class IssueRepositoryInMemoryTest
  {
    [Fact]
    public void AddTest()
    {
      var repos = new IssueRepositoryInMemory();
      Equals(repos.getList().Count(), 0);
      repos.Add(new Issue {Title = "hoge", Description = "fuga"});
      repos.Add(new Issue {Title = "hogehoge", Description = "fugafuga"});
      Equals(repos.getList().Count(), 2);
    }

    [Fact]
    public void getTest()
    {
      var repos = new IssueRepositoryInMemory();
      repos.Add(new Issue {Title = "hoge", Description = "fuga"});

      var firstItem = repos.get(1);

      Equals(firstItem.Id, 1);
      Equals(firstItem.Title, "hoge");
      Equals(firstItem.Description, "fuga");
      Equals(firstItem.IsOpen, true);
    }
  }
}
