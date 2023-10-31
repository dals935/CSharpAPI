namespace BuberBreakfast.Contracts.BuberBreakfast;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDataeTime,
    List<string> Savory,
    List<string> Sweet
);