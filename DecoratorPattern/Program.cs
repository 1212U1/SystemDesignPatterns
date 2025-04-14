using DecoratorPattern;
//This pattern is especially powerful in scenarios where you need to add responsibilities
//to objects dynamically and transparently.
//In the Decorator pattern, decorators wrap original objects,
//adding new behavior or responsibilities without altering the original object's code.
ICoffee coffee = new SimpleCoffee();
Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost().ToString());

coffee = new MilkDecorator(coffee);
Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost().ToString());

coffee = new WhipDecorator(coffee);
Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost().ToString());