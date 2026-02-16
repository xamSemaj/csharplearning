namespace CookieCookbook.DataAccess;

public abstract class StringsRepository : IStringsRepository
{


    public List<string> Read(string FilePath)
    {
        if (File.Exists(FilePath))
        {
            var fileContents = File.ReadAllText(FilePath);
            return TextToStrings(fileContents);
        }
        return new List<string>();
        //  var fileContents = File.ReadAllText(FilePath);
        //  var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        // return fileContents.Split(Environment.NewLine).ToList();
    }

    protected abstract List<string> TextToStrings(string fileContents);
    public void Write(string FilePath, List<string> strings) =>
        File.WriteAllText(FilePath, stringsToText(strings));

    protected abstract string stringsToText(List<string> strings);
}


public interface Icompressable
{
    void Compress();
}

public class AudioFile : Icompressable
{
    public void Compress() => Console.WriteLine("Compressing the file");
}