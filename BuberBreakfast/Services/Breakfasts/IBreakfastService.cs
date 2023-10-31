using BuberBreakfast.Contracts.BuberBreakfast;
using ErrorOr;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfast); 
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast);
    ErrorOr<Deleted> DeleteBreakfast(Guid id);

    // BreakfastResponse GetBreakfast(Guid id);

    // BreakfastResponse UpdateBreakfast (Guid id, UpsertBreakfastRequest request);

    // BreakfastResponse DeleteBreakfast(Guid id);
}
