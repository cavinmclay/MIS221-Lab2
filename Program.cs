
const double SWEATSHIRT_COST = 25.99;
const double PERSONALIZE_COST = 4.00;
const double TRANSACTION_FEE = .30;
const double SHIPPING_COST = 6.20;

System.Console.WriteLine("Please enter the number of sweatshirts you would like");
int numberOfSweatshirts = int.Parse(Console.ReadLine());
System.Console.WriteLine("Please enter the number of personalizations you would like");
int numItems = int.Parse(Console.ReadLine());

double totalOrderCost = numberOfSweatshirts*SWEATSHIRT_COST + numItems*PERSONALIZE_COST + numberOfSweatshirts*TRANSACTION_FEE + SHIPPING_COST;

System.Console.WriteLine("Total order cost: " + Math.Round(totalOrderCost,2));
