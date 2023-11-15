Areas of improvements:

Testing hasn't been implemented as well as benchmarks which would be useful to establish a baseline, 
A project specifically for Stress, Spike, Load, Soak testing should be implemented. 
Naming conventions in project could be done better and more consistent, seperate out the OpenWeather part from this actual API


Note for any users, in order to use it you need to right click OpenWeather.Cs and click Manage User Secrets and input
{
  "OpenWeatherApiKey": "your API key"
}


Additionally, rate limiting has not yet been implemented from 
"Service should prevent being exploited by automated tools"

Which can be done using https://www.nuget.org/packages/AspNetCoreRateLimit nuget package and which might be revisited tomorrow