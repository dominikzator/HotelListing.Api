using HotelListing.Api.Application.Contracts;
using HotelListing.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Application.Services;

//Inject the DB Context
public class ApiKeyValidatorService(HotelListingDbContext db) : IApiKeyValidatorService
{
    public async Task<bool> IsValidAsync(string apiKey, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            return false;
        }

        var apiKeyEntity = await db.ApiKeys.AsNoTracking().FirstOrDefaultAsync(k => k.Key == apiKey, cancellationToken);


        return apiKeyEntity!.IsActive;
    }
}
