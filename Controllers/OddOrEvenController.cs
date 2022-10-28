//Kent Tupas
//10/26/2022
//Odd Or Even using API
//Peer Review: Jeremy Lapham: Works great does exactly what it's sipposed to do

using Microsoft.AspNetCore.Mvc;

namespace TupasKOddOrEvenAPI6.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
[HttpGet]
[Route("OddOrEven/{number}")]

public string numbers(string number, bool num1 = false, int vaildNum = 0)
{
num1 = Int32.TryParse(number, out vaildNum);
if(num1 == true)
{
    if(vaildNum % 2 == 0)
    {
    return $"{vaildNum} that's an even number";
    }else{
    return $"{vaildNum} that's an odd number";
    }
}
 return "That's a not a number";
}
}
   


