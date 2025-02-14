namespace QwantzRandom.Pages;

public partial class Home
{
    private const string AppTitle = "qwantz randomizer";

    private readonly string[] backgroundStyles = new string[3];

    private readonly int[] imageWidths = [243, 130, 241];

    private readonly bool[] lockedImages = new bool[3];

    private const int imageHeight = 242;

    private bool isLoading;

    private bool isLoaded;

    private bool ButtonIsDisabled => lockedImages.All(li => li);

    private string GetDimensionsFormat(int index) => index is < 0 or > 2
            ? throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and 2.")
            : $"height: {imageHeight}px; width: {imageWidths[index]}px; border: 1px solid black;";

    private void GetRandomComic()
    {
        isLoading = true;
        for (var i = 0; i < 3; i++)
        {
            if (lockedImages[i])
            {
                continue;
            }
            backgroundStyles[i] = $"background: {ImageLoader.GetBackgroundStyle(i)}; {GetDimensionsFormat(i)}";
        }
        isLoading = false;
        isLoaded = true;
    }
}
