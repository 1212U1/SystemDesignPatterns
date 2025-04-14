using ProxyPattern;

//The Proxy Pattern is a structural design pattern that provides a surrogate or placeholder for
//another object to control access to it.
//In C#, proxies are commonly used for lazy loading, access control, logging, and remote service calls.
IImage image = new HighImageResolution("Kantha.jpg");
image.Display();