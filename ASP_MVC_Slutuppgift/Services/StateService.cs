using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Caching.Memory;

namespace ASP_MVC_Slutuppgift.Services;

public class StateService(IHttpContextAccessor accessor, IMemoryCache memoryCache,
    ITempDataDictionaryFactory tempFactory)
{
    const string TempKey = "Message";
    public string? TempDataConfirmation
    {
        get
        {
            // Läs värdet från temp-data
            var tempDataValue = tempFactory.GetTempData(accessor.HttpContext)[TempKey];

            // Returnera ett konvertera värdet
            return tempDataValue == null ? null : Convert.ToString(tempDataValue);
        }
        set
        {
            // Skriv värdet till temp-data
            tempFactory.GetTempData(accessor.HttpContext)[TempKey] = value;
        }
    }
}