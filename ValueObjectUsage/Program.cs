// See https://aka.ms/new-console-template for more information

using ValueObjectPractice;

var initialDeposit = Money.Create(100.78m);
var laterDeposit = Money.Create(200m);

var total = initialDeposit + laterDeposit;

Console.WriteLine(total.ToString());
