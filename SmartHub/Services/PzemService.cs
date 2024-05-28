using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
using SmartHub.Models;

namespace SmartHub.Services;

public class PzemService : IPzemService
{
    private readonly SmartHubContext _context;

    public PzemService(SmartHubContext context)
    {
        _context = context;
    }

    public async Task<List<PzemEntiy>> ListAsync(int takeCount = 10)
    {
        List<PzemEntiy> result = new List<PzemEntiy>();
        try
        {
            var fromDB = (from q in _context.Pzems
                orderby q.CreateAt descending
                select q).Take(takeCount);

            if (await fromDB.AnyAsync())
            {
                result = await fromDB.ToListAsync();
            }
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }


        return result;
    }

    public async Task<PzemEntiy> CreateAsync(PzemEntiy enity)
    {
        PzemEntiy result = null;
        try
        {
            //update create
            enity.CreateAt = DateTime.Now;
            
            _context.Pzems.Add(enity);
            if (await _context.SaveChangesAsync() > 0)
            {
                result = enity;
            }
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }


        return result;
    }
}

public interface IPzemService
{
    Task<List<PzemEntiy>> ListAsync(int takeCount = 10);

    Task<PzemEntiy> CreateAsync(PzemEntiy enity);
}