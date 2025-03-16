using ObserverPattern;

IObserver observerOne = new Observer("Kantha");
IObserver observerTwo = new Observer("Challa");

IObservable observable = new WeatherStation();
observable.AddObservers(observerOne);
observable.AddObservers(observerTwo);

observable.SetValue("10");