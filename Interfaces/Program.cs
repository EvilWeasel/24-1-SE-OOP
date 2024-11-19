/*
  var orderService = new OrderService();
  orderService.ProcessOrder("123456");
*/

using Interfaces;

var consoleLogger = new ConsoleLogger();
var orderService = new OrderService(consoleLogger);
orderService.ProcessOrder("123456");
orderService.ProcessOrder("42069");

var fileLogger = new FileLogger();
var orderServiceWithFileLogging = new OrderService(fileLogger);
orderServiceWithFileLogging.ProcessOrder("421024");
orderServiceWithFileLogging.ProcessOrder("133769");











/*
  var myBaseLogger = new BaseLogger();
  myBaseLogger.Log("buxtehude");
*/
