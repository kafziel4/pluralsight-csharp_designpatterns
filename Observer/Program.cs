using Observer;

Console.Title = "Observer";

TicketStockService ticketStockService = new();
TicketResellerService ticketResellerService = new();
OrderService orderService = new();

// Add two observers
orderService.AddObserver(ticketStockService);
orderService.AddObserver(ticketResellerService);

// Notify
orderService.CompleteTicketSale(1, 2);

Console.WriteLine();

// Remove one observer
orderService.RemoveObserver(ticketResellerService);

// Notify
orderService.CompleteTicketSale(2, 4);
