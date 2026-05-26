// See https://aka.ms/new-console-template for more information

using Lesson05;


Player p = new Player();
Player p2 = new Player();
Button b = new Button(234);
Button b2 = new Button(700);
b.Subscribe(p.OnButtonClicked);
b.Subscribe(p2.OnButtonClicked);

b2.Subscribe(p.OnButtonClicked);

b2.Click();
b.Click();

b.Unsubscribe(p.OnButtonClicked);
b.Click();

//Calculator.CalcFunc f = Calculator.Pow;
//Console.WriteLine(f(1,2,3));

