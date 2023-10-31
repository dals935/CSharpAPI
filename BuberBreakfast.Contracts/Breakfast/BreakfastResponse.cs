namespace BuberBreakfast.Contracts.BuberBreakfast;

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDataeTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
);