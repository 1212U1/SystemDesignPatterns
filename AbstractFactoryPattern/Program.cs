using AbstractFactoryPattern;

ClientApplication clientApplication = new ClientApplication(new WindowsFactory());
clientApplication.RenderUI();
clientApplication.ChangeFactory(new MacFactory());
clientApplication.RenderUI();