namespace CookieCookbook.DataAccess;

public class StringsTextualRepository : StringsRepository
{

    private static readonly string Separator = Environment.NewLine;
    //public List<string> Read(string FilePath)
    //{
    //    if(File.Exists(FilePath))
    //    {
    //        var fileContents = File.ReadAllText(FilePath);
    //        return fileContents.Split(Separator).ToList();
    //    }
    //    return new List<string>();
    //  //  var fileContents = File.ReadAllText(FilePath);
    //  //  var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
    //    // return fileContents.Split(Environment.NewLine).ToList();
    //}

    //public void Write(string FilePath, List<string> strings) =>
    //    File.WriteAllText(FilePath, string.Join(Environment.NewLine, strings));

    protected override string stringsToText(List<string> strings)
    {
        return string.Join(Separator, strings);
    }

    protected override List<string> TextToStrings(string fileContents)
    {
        return fileContents.Split(Separator).ToList();
    }
}
