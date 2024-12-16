using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ASP_MVC_Slutuppgift.Services;

public class StateService(IHttpContextAccessor accessor,
    ITempDataDictionaryFactory tempFactory)
{
    const string TempKey = "Message";
    public string? TempDataCreateVehicleConfirmation
    {
        get
        {
            var tempDataValue = tempFactory.GetTempData(accessor.HttpContext)[TempKey];
           
            return tempDataValue == null ? null : Convert.ToString(tempDataValue);
        }
        set
        {
            tempFactory.GetTempData(accessor.HttpContext)[TempKey] = value;
        }
    }  
    public string? TempDataUserUpdateConfirmation
    {
        get
        {
            var tempDataValue = tempFactory.GetTempData(accessor.HttpContext)[TempKey];

            return tempDataValue == null ? null : Convert.ToString(tempDataValue);
        }
        set
        {
            tempFactory.GetTempData(accessor.HttpContext)[TempKey] = value;
        }
    }
}