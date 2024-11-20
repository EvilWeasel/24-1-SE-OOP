namespace Interfaces;

public interface FileHandler
{
  public string FilePath { get; set; }

  public void DeleteFile();
}
