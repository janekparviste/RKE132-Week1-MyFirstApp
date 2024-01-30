// This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");//output ehk väljund
//string - sõne
string userName = Console.ReadLine();//input ehk sisend

Console.WriteLine("Hello, " + userName + " !");//output ehk väljund

//string interpolation
Console.WriteLine($"Hello, {userName} !");//output ehk väljund