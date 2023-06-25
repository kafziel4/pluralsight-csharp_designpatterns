using Proxy;

Console.Title = "Proxy";

// Without proxy
Console.WriteLine("Constructing document.");
var myDocument = new Document("MyDocument.pdf");
Console.WriteLine("Document constructed");
myDocument.DisplayDocument();

Console.WriteLine();

// With proxy
Console.WriteLine("Constructing document proxy.");
var myDocumentProxy = new DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed");
myDocumentProxy.DisplayDocument();

Console.WriteLine();

// With chained proxy
Console.WriteLine("Constructing protected document proxy.");
var myProtectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
Console.WriteLine("Protected document proxy constructed");
myProtectedDocumentProxy.DisplayDocument();

Console.WriteLine();

// With chained proxy, no access
Console.WriteLine("Constructing protected document proxy.");
myProtectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "AnotherRole");
Console.WriteLine("Protected document proxy constructed");
myProtectedDocumentProxy.DisplayDocument();
