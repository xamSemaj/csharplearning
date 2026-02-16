namespace CookieCookbook.DataAccess;

public interface IStringsRepository
{
    List<string> Read(string FilePath);
    void Write(string FilePath, List<string> strings);
}
