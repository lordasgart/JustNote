using System.Text;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Just, Note!");
var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var justNoteUserDirectory = Path.Combine(myDocuments, "JustNote");
Directory.CreateDirectory(justNoteUserDirectory);

loop:
var ticks = DateTime.UtcNow.Ticks;
var currentNoteFileName = $"Utc{ticks}.txt";
var currentNoteFullPath = Path.Combine(justNoteUserDirectory, currentNoteFileName);
Console.WriteLine();
var text = Console.ReadLine();
File.WriteAllText(currentNoteFullPath, text, Encoding.UTF8);
Console.WriteLine($">> {currentNoteFullPath}");
goto loop;
