namespace Names_SingleResponsibilityPrinciple.DataAccess;

public class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string FilePath)
    {
        var fileContents = File.ReadAllText(FilePath);
        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        return fileContents.Split(Environment.NewLine).ToList();
    }

    public void Write(string FilePath, List<string> strings) =>
        File.WriteAllText(FilePath, string.Join(Environment.NewLine, strings));

}
