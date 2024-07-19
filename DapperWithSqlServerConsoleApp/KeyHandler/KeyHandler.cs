namespace DapperWithSqlServerConsoleApp.KeyHandler;

internal static class KeyHandler
{
    internal static void WaitForAnyKey()
    {
        WriteLine("\n\nPress any key to exit...");
        ReadKey();
    }
}
