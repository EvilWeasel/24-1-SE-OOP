namespace Interfaces;

/// <summary>
/// Ein Interface ist wie ein Vertrag.
/// Wer ein Interface implementiert muss alle Member (Eigenschaften + Methoden)
/// des Interfaces implementieren.
/// Man könnte auch sagen ein Interface ist eine Blaupause für eine
/// Klasse / Struct, welche beschreibt welche Methoden/Eigenschaften
/// diese haben müssen, aber nicht wie diese sein müssen.
/// </summary>
public interface FileHandler
{
  public string FilePath { get; set; }
  public void DeleteFile();
}



/*
public abstract class AbstractOnly
{
  public void TestMethod()
  {
    return;
  }
  public abstract void DasHierMussImplementiertWerden();
}

public class Test
{
  public virtual void TestMethod1()
  {
    return;
  }
  public int TestMethod2()
  {
    // Hier passiert irgendwas...
    return 0;
  }
}

public class TestImplementers : Test
{
  public override void TestMethod1()
  {

  }
}
*/
