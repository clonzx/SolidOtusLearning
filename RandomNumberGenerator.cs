namespace Solid;

/// <summary>
/// Случайный генератор чисел
/// </summary>
public class RandomNumberGenerator : INumberGenerator
{
    private readonly (int Min, int Max) _range;
    private readonly Random _random;

    public RandomNumberGenerator(IGameSettings settings)
    {
        _range = settings.Range;
        _random = new Random();
    }

    public int GenerateNumber()
    {
        return _random.Next(_range.Min, _range.Max);
    }
}
