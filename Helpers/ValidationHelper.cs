namespace PetsGo.Helpers;

public static class ValidationHelper
{
    public static bool IsNullOrWhiteSpace(string value)
    {
        return string.IsNullOrWhiteSpace(value);
    }
}