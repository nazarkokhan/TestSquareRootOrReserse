namespace TestSquareRootOrReverse.Controllers;

using DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("reverse")]
public class ReverseController : ControllerBase
{
    [HttpGet]
    public GetReverseResponse Get(string data)
    {
        var isNumber = double.TryParse(data, out var number);
        
        if (isNumber)
        {
            var sqrt = Math.Sqrt(number);
            return new GetReverseResponse(sqrt);
        }

        var reversedData = new string(data.Reverse().ToArray());

        return new GetReverseResponse(reversedData);
    }
}