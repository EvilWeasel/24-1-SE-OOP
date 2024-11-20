namespace Interfaces;

// Um das Austauschen der Logger in Zukunft angenehmer zu gestalten, designen wir eine
// Abstrakte Klasse, von der alle Logger Erben.
// Abstrakte Klassen verhindern die Instanziierung dieser -> Absicherung deiner Schnittstellen
public interface BaseLogger // für morgen: Austauschen mit Interface
{
  // Bitte nicht nutzen, nur für Vererbung!!!!
  public void Log(string message);
}

public class ConsoleLogger : BaseLogger
{
  public void Log(string message)
  {
    Console.WriteLine(message);
  }
}

/* FileHandler muss ein Interface sein, da ich immer nur von maximal
einer Klasse erben darf! */
public class FileLogger : BaseLogger, FileHandler
{
  public string FilePath { get; set; }
  public FileLogger(string filePath)
  {
    FilePath = filePath;
  }
  public void Log(string message)
  {
    File.AppendAllText(FilePath, $"{DateTime.Now}: {message}\n");
  }

  public void DeleteFile()
  {
    File.Delete(FilePath);
  }
}

public class JsonLogger : BaseLogger
{
  public void Log(string message)
  {
    // irgendwas anderes passiert hier
    File.AppendAllText("./log.json", $"{DateTime.Now}: {message}\n");
  }
}
