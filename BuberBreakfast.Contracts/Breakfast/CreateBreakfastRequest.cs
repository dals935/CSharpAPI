namespace BuberBreakfast.Contracts.BuberBreakfast;

public record CreateBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDataeTime,
    List<string> Savory,
    List<string> Sweet
);