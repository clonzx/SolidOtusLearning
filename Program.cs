namespace Solid;

internal class Program
{
    static void Main(string[] args)
    {
        var settings = new ArgsGameSettings();
        if (settings is IArgsParser parser)
            parser.Parse(args);
        var game = new NumberGuessGame(
            new RandomNumberGenerator(settings),
            new ConsoleGameIO(),
            settings
        );
        game.Play();
    }
}
