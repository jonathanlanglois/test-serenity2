
namespace test_serenity2;

public interface IDirectoryService
{
    AppServices.DirectoryEntry Validate(string username, string password);
}