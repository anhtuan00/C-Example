// // The Length property provides the number of array elements.
// // Console.WriteLine($"parameter count = {args.Length}");

// // for (int i = 0; i < args.Length; i++)
// // {
// //     Console.WriteLine($"Arg[{i}] = [{args[i]}]");
// // }

// /* Output (assumes 3 cmd line args):
//     parameter count = 3
//     Arg[0] = [a]
//     Arg[1] = [b]
//     Arg[2] = [c]
// */

// using Classes;

// var account = new BankAccount("<name>", 1000);
// Console.WriteLine(
//     $"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance."
// );

// account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
// Console.WriteLine($"This is the account Balance after MakeWithdrawal: {account.Balance}");
// account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
// Console.WriteLine($"This is the account Balance after MakeDeposit: {account.Balance}");

// // Test that the initial balances must be positive.
// // BankAccount invalidAccount;
// // try
// // {
// //     invalidAccount = new BankAccount("invalid", -55);
// // }
// // catch (ArgumentOutOfRangeException e)
// // {
// //     Console.WriteLine("Exception caught creating account with negative balance");
// //     Console.WriteLine(e.ToString());
// //     return;
// // }

// Console.WriteLine(account.GetAccountHistory());

var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();

// can make additional deposits:
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "save some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());
