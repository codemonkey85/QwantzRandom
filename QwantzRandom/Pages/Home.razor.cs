namespace QwantzRandom.Pages;

public partial class Home
{
    const string AppTitle = "qwantz randomizer";

    private readonly string[] backgroundStyles = new string[3];

    private readonly bool[] lockedImages = new bool[3];

    private const int imageHeight = 242;

    private bool ButtonIsDisabled => lockedImages.All(li => li);

    private void GetRandomComic()
    {
        for (var i = 0; i < 3; i++)
        {
            if (lockedImages[i])
            {
                continue;
            }
            backgroundStyles[i] = $"background: {ImageLoader.GetBackgroundStyle(i)}";
        }
    }
}
