namespace HotelListing.Api.Application.Contracts
{
    public interface IApiKeyValidatorService
    {
        Task<bool> IsValidAsync(string apiKey, CancellationToken cancellationToken);
    }
}