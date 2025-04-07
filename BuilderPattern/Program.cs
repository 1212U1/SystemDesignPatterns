using BuilderPattern;

//Helps to create complex objects with method chaining and nested class Build method
//Immutable after creation using private set property
//The private constructor in the House class takes all the parameters.
//It is only accessible from within the Builder class, ensuring that House objects are always created via the builder.
House house = new House.HouseBuilder("KanthaHome", "Apartment").SetGardenStatus(true)
                        .SetSwimmingPoolStatus(true).Build();
Console.WriteLine(house.GetHouseDescription());
