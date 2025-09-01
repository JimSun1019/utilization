namespace ExtensionSys;

public static class ListExtension
{
    // Get the first element of a list or a default value
    public static T FirstOrDefault<T>(this List<T> list, T defaultValue)
    {
        if (list == null || list.Count == 0) return defaultValue;
        return list[0];
    }

    // Get the last element of a list or a default value
    public static T LastOrDefault<T>(this List<T> list, T defaultValue)
    {
        if (list == null || list.Count == 0) return defaultValue;
        return list[^1];
    }

    // Check if a list is null or empty
    public static bool IsNullOrEmpty<T>(this List<T> list) => list == null || list.Count == 0;
}
