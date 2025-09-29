using StrategyPattern.Animal;

Duck mallard = new MallardDuck();
Duck rubberDuckie = new RubberDuck();
Duck decoy = new DecoyDuck();

mallard.Display();
mallard.Fly();
mallard.Quack();

rubberDuckie.Display();
rubberDuckie.Fly();
rubberDuckie.Quack();

rubberDuckie.Display();
decoy.Fly();
decoy.Quack();