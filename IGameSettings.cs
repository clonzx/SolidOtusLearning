namespace Solid;

/// <summary>
/// Интерфейс для настроек
/// </summary>
public interface IGameSettings
{
    int MaxAttempts { get; }
    (int Min, int Max) Range { get; }
}
