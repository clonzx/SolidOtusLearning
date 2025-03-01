namespace Solid;

/// <summary>
/// Статическая реализация настроек
/// </summary>
public class StaticGameSettings  : IGameSettings
{
    public int MaxAttempts { get; protected set; } = 10;
    public (int Min, int Max) Range { get; protected set; } = (1, 100);
}
