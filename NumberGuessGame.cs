namespace Solid;

/// <summary>
/// Игра «Угадай число»
/// </summary>
public class NumberGuessGame : IGame
{
    private readonly INumberGenerator _numberGenerator;
    private readonly IGameIO _gameIO;
    private readonly IGameSettings _settings;

    public NumberGuessGame(INumberGenerator numberGenerator, IGameIO gameIO, IGameSettings settings)
    {
        _numberGenerator = numberGenerator;
        _gameIO = gameIO;
        _settings = settings;
    }

    public void Play()
    {
        int targetNumber = _numberGenerator.GenerateNumber();
        int attemptsLeft = _settings.MaxAttempts;

        _gameIO.WriteMessage($"Угадайте число от {_settings.Range.Min} до {_settings.Range.Max}. " +
                           $"У вас {attemptsLeft} попыток.");

        while (attemptsLeft > 0)
        {
            int guess = _gameIO.ReadNumber();
            attemptsLeft--;

            if (guess == targetNumber)
            {
                _gameIO.WriteMessage("Поздравляем! Вы угадали число!");
                return;
            }

            string hint = guess < targetNumber ? "больше" : "меньше";
            _gameIO.WriteMessage($"Число {hint}. Осталось попыток: {attemptsLeft}");
        }

        _gameIO.WriteMessage($"Игра окончена. Загаданное число было: {targetNumber}");
    }
}