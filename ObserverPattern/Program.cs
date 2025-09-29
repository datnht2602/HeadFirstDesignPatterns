using ObserverPattern.Concrete;
using ObserverPattern.WeatherObservable;
using CurrentConditionDisplay = ObserverPattern.WeatherObservable.CurrentConditionDisplay;
using ForecastDisplay = ObserverPattern.WeatherObservable.ForecastDisplay;

// WeatherData weatherData = new();
//
// CurrentConditionDisplay currentConditionDisplay = new(weatherData);
//
// weatherData.SetMeasurements(80, 65, 30.4f);
// weatherData.SetMeasurements(82, 70, 29.2f);
// weatherData.SetMeasurements(78, 90, 29.2f);

WeatherDataTracker weatherDataTracker = new();
ForecastDisplay forecastDisplay = new(weatherDataTracker);
CurrentConditionDisplay currentConditionDisplay = new(weatherDataTracker);
weatherDataTracker.UpdateData(new WeatherDataReport(80, 65, 30.4f));
forecastDisplay.OnCompleted();
weatherDataTracker.UpdateData(new WeatherDataReport(82, 70, 29.2f));
weatherDataTracker.UpdateData(new WeatherDataReport(78, 90, 29.2f));