
using System.Text.Json;

namespace CookieCookbook.DataAccess;

public class StringsJsonRepository : StringsRepository
{

    private static readonly string Separator = Environment.NewLine;
    //public List<string> Read(string FilePath)
    //{
    //    if (File.Exists(FilePath))
    //    {
    //        var fileContents = File.ReadAllText(FilePath);
    //        return JsonSerializer.Deserialize<List<string>>(fileContents);
    //    }
    //    return new List<string>();
    //    //  var fileContents = File.ReadAllText(FilePath);
    //    //  var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
    //    // return fileContents.Split(Environment.NewLine).ToList();
    //}

    //public void Write(string FilePath, List<string> strings) =>
    //    File.WriteAllText(FilePath, JsonSerializer.Serialize(strings));

    protected override string stringsToText(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }

    protected override List<string> TextToStrings(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents);
    }
}
