namespace QwantzRandom;

public static class ImageLoader
{
    private const int minMonth = 3;
    private const int maxMonth = 693;

    private const string baseUrl = "http://www.qwantz.com/comics/rand/";

    public static string GetBackgroundStyle(int index)
    {
        if (index is < 0 or > 2)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and 2.");
        }

        Random random = new();
        var month = random.Next(minMonth, maxMonth);
        var imgUrl = $"{baseUrl}{month}.png";

        var offsetX = index switch
        {
            1 => -243,
            2 => -492,
            _ => 0
        };
        var offsetY = index == 2 ? -243 : 0;

        return $"url({imgUrl}) {offsetX}px {offsetY}px";
    }
}
