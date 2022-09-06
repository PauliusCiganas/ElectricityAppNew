using CsvHelper;
using ElectricityApp.Contracts;
using ElectricityApp.Data;
using ElectricityApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net;

namespace ElectricityApp.Controllers
{
    [ApiController]
    [Route("DomesticUser")]
    public class DomesticUserController : Controller
    {
        private readonly Database _dbContext;
        private readonly ILoggerService _logger;

        public DomesticUserController(Database dbContext, ILoggerService logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }


        [HttpGet]
        [Route("GetFilteredUsers")]
        public List<DomesticUser> Get()
        {
            _logger.LogInfo("Accessed Get Domestic User API Method");
            var FilteredUsers = new List<DomesticUser>();
            var response = _dbContext.DomesticUsers.ToList();
            foreach (var user in response)
            {
                if (user.ObjName == "Namas" && user.UsedElectricity < 1)
                {
                    FilteredUsers.Add(user);
                }
            }
            return FilteredUsers;
        }


        [HttpPost]
        [Route("ReadCsv")]
        public async Task<IActionResult> ReadCsvFile()
        {
            using(var streamReader = new StreamReader("Data.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<DomesticUser>();
                    foreach (var user in records)
                    {
                        var userExist = _dbContext.DomesticUsers.Any(x => x.ObjIdNum == user.ObjIdNum);
                        if (!userExist)
                        {
                            await _dbContext.DomesticUsers.AddAsync(user);
                            await _dbContext.SaveChangesAsync();
                        }
                    }
                }
            }
            return Ok();
        }
    }
}
