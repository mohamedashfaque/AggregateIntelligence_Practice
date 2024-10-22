using System.Diagnostics;
using System.Numerics;
using DependInj2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DependInj2.Controllers;

[ApiController]
[Route("[controller]")]
public class NumberController : Controller
{
    private readonly INumberService _numberservice;
    private readonly IPostNumberCheck _numbercheck;
    //private readonly IConfiguration _configuration;
   // private readonly GetDbString _dbstring;
   public readonly DB_info db_Info;
    public NumberController(INumberService num,IPostNumberCheck check,IConfiguration iconfig,/*GetDbString dbstr*/IOptions<DB_info> dboption){
        _numberservice=num;
        _numbercheck=check;
        //_configuration=iconfig;
        //_dbstring=dbstr;
        db_Info=dboption.Value;

    }
    [HttpGet("GetDB")]
    public IActionResult GetDbString()
    {
        return Ok(new
        {db_Info.Db_SecretKey,db_Info.DB_String,db_Info.userinfo.User_Name,db_Info.userinfo.User_Password});
    }
    [HttpGet]
    public IActionResult Number()
    {
        var guess = _numberservice.GenerateNumber();
        return Ok(guess);
    }
    [HttpPost("UserInput{number}")]
    public IActionResult post_Number(int number)
    {
        var guess = _numberservice.GenerateNumber();
        return Ok(_numbercheck.PostNumber(number, guess));
    }

}