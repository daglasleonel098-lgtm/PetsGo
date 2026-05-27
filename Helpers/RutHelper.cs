namespace PetsGo.Helpers;

public static class RutHelper
{
    public static string FormatRut(
        string rut)
    {
        if (string.IsNullOrWhiteSpace(rut))
            return "";

        rut = rut.Replace(".", "")
                 .Replace("-", "");

        if (rut.Length < 2)
            return rut;

        return rut.Insert(
            rut.Length - 1,
            "-");
    }
}