using System.Security.Cryptography.X509Certificates;

namespace IssuesModule.Model
{
  public sealed class Issue
  {
    public Issue(int id = 0)
    {
      Id = id;
    }

    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsOpen { get; private set; } = true;

    public override bool Equals(object obj)
    {
      return obj is Issue issue && Id == issue.Id;
    }

    public void Open()
    {
      IsOpen = true;
    }

    public void Close()
    {
      IsOpen = false;
    }
    
    
  }
}
