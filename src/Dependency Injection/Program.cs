

using Dependency_Injection;



IButton button1 = new Engine();
IButton button = new Break();
Car car = new Car(button,button1);
car.print();