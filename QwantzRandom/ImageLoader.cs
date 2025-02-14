namespace QwantzRandom;

public static class ImageLoader
{
    private const int MinMonth = 3;
    private const int MaxMonth = 693;

    private const string BaseUrl = "https://www.qwantz.com/comics/rand/";

    public static string GetBackgroundStyle(int index)
    {
        if (index is < 0 or > 2)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and 2.");
        }

        Random random = new();
        var month = random.Next(MinMonth, MaxMonth);
        var imgUrl = $"{BaseUrl}{month}.png";

        var offsetX = index switch
        {
            1 => -243,
            2 => -492,
            _ => 0
        };
        var offsetY = index == 2
            ? -243
            : 0;

        return $"url({imgUrl}) {offsetX}px {offsetY}px";
    }
}
