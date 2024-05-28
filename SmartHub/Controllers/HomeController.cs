using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartHub.Services;


public class HomeController : Controller
{
    public IPzemService _pzemService;

    public HomeController(IPzemService pzemService)
    {
        _pzemService = pzemService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _pzemService.ListAsync(10);
        return await Task.Run(() => View(data));
    }

    [HttpGet("Top/{count?}")]
    public async Task<IActionResult> Top(int count = 10)
    {
        var data = await _pzemService.ListAsync(count);
        return await Task.Run(() => View("Index",data));
    }
}