using CompositePattern;

Folder folderOne = new CompositePattern.Folder("FolderOne");
FileSystemComponent fileOne = new CompositePattern.File("FileOne");

Folder folderTwo = new CompositePattern.Folder("folderTwo");
FileSystemComponent fileTwo = new CompositePattern.File("FileTwo");
FileSystemComponent fileThree = new CompositePattern.File("fileThree");

folderOne.AddComponents(fileOne);
folderTwo.AddComponents(fileTwo);
folderTwo.AddComponents(fileThree);
folderOne.AddComponents(folderTwo);

folderOne.Details();