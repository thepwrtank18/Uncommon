using System.Diagnostics;
// ReSharper disable FunctionRecursiveOnAllPaths

if (!File.Exists("legendary.exe"))
{
    throw new FileNotFoundException("Uncommon must be in the same directory as Legendary.");
}

Console.WriteLine("Welcome to Uncommon, a shell for Legendary!");
Console.WriteLine("Type \"-h\" for help. Type \"Uncommon.Exit\" to exit.");
Console.WriteLine("(Omit \"legendary\" from your commands, the shell does that for you.)");

Process process;
DoShit();

void DoShit() // I am very professional
{
    Console.Write("Legendary> ");
    string args = Console.ReadLine()!;
    if (string.IsNullOrEmpty(args)) DoShit();
    if (args == "Uncommon.Exit")
    {
        Environment.Exit(0);
    }
    process = Process.Start("legendary", args);
    process.WaitForExit();
    DoShit();
}