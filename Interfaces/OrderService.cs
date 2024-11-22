namespace Interfaces;

public class OrderService
{
  private IBaseLogger logger;

  /* Das hier ist ein konkretes Beispiel für das Designpattern "Dependency-Injection"
  Mit DI lassen sich Abhängigkeiten aus einer Klasse heraus extrahieren und auf den Caller / Nutzer der Klasse übertragen. */
  public OrderService(IBaseLogger logger)
  {
    this.logger = logger;
  }

  public void ProcessOrder(string orderID)
  {
    /* Hier den Logger zu instanziieren macht diese Klasse abhängig von der spezifischen Logger-Implementation.
    Wenn die Logger-Implementation ausgetauscht werden soll, kann dies zu viel
    Arbeit führen, je nach größe der Klasse. */
    /* var logger = new Logger(); !Abhängigkeit! */

    logger.Log($"Order {orderID} is being processed...");
    Thread.Sleep(1000);
    logger.Log($"Order {orderID} processed successfully");
    Thread.Sleep(1000);
    logger.Log($"Order {orderID} proccessing complete!");
  }
}
