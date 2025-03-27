using WithoutCommandPattern;

TextEditor textEditor = new TextEditor();
BoldButton boldButton = new BoldButton(textEditor);
boldButton.Execute();
ItalicizeButton italicizeButton = new ItalicizeButton(textEditor);
italicizeButton.Execute();