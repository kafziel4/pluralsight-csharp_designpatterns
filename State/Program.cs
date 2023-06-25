using State;

Console.Title = "State";

BankAccount bankAccount = new();
bankAccount.Deposit(100);
bankAccount.Withdraw(500);
bankAccount.Withdraw(100);
// Deposit enough to go to gold
bankAccount.Deposit(2000);
// Should be in gold now
bankAccount.Deposit(100);
// Back to overdrawn
bankAccount.Withdraw(3000);
// Should transition to regular
bankAccount.Deposit(3000);
// Should still be in regular
bankAccount.Deposit(100);
