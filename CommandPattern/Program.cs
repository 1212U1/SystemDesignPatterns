using CommandPattern;
TextEditor textEditor = new TextEditor();
Button button = new Button();
button.SetCommand(new BoldCommand(textEditor));
button.Click();
button.SetCommand(new ChangeColorCommand(textEditor));
button.Click();
