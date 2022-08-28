

using Dependency_Injection;



IButton button1 = new Engine();
IButton button = new Break();
Car car = new Car(button,button1);
car.print();

Propeerty_InjectionCar propertyCar=new Propeerty_InjectionCar();
propertyCar.MyProperty = new Break();
propertyCar.getProperty();

Method__Injection_Car method_ = new Method__Injection_Car();
method_.Add(button1);
