namespace QwantzRandom;

public class ImageLoader
{
    private const int minMonth = 3;
    private const int maxMonth = 693;

    public static string GetBackgroundStyle(int index)
    {
        if (index is < 0 or > 2)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and 2.");
        }

        Random random = new();
        var month = random.Next(minMonth, maxMonth);
        var imgUrl = $"http://www.qwantz.com/comics/rand/{month}.png";

        var offsetX = index == 1 ? -243 : index == 2 ? -492 : 0;
        var offsetY = index == 2 ? -243 : 0;

        return $"url({imgUrl}) {offsetX}px {offsetY}px";
    }
}
