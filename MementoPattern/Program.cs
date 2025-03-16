//Client code
using MementoPattern;

TextEditor textEditor = new TextEditor("ValueOne");
TrackChange trackChange = new TrackChange();
trackChange.SaveChanges(textEditor);
textEditor.Content = "ValueTwo";
trackChange.SaveChanges(textEditor);
textEditor.Content = "ValueThree";
trackChange.SaveChanges(textEditor);
trackChange.RestoreChanges(textEditor);
Console.WriteLine(textEditor.Content);