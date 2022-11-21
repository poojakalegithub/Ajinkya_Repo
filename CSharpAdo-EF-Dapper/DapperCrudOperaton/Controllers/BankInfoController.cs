

namespace DapperCrudOperaton.Controllers
{
    using Dapper;
    using DapperCrudOperaton.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Data.SqlClient;
    using System.Reflection.Metadata.Ecma335;

    [Route("api/[controller]")]
    [ApiController]
    public class BankInfoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public BankInfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<List<BankInfo>>> GetAllBankInfo()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("BankInfoConnection"));
            // SelectAllCustomers() = var Customers = await connection.QueryAsync<BankInfo>("SELECT * FROM BankInfo");
            IEnumerable<BankInfo> Customers = await SelectAllCustomers(connection);
            return Ok(Customers);
        }

        private static async Task<IEnumerable<BankInfo>> SelectAllCustomers(SqlConnection connection)
        {
            return await connection.QueryAsync<BankInfo>("SELECT * FROM BankInfo");
        }

        [HttpGet("{customerID}")]
        public async Task<ActionResult<BankInfo>> GetCustomerByID(int customerID)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("BankInfoConnection"));
            var Customer = await connection.QueryFirstAsync<BankInfo>("SELECT * FROM BankInfo WHERE customerID = @customerId",
                            new { customerId = customerID });
            return Ok(Customer);
        }

        [HttpPost]
        public async Task<ActionResult<List<BankInfo>>> AddCustomers(BankInfo bankInfo)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("BankInfoConnection"));
            await connection.ExecuteAsync("INSERT INTO BankInfo (customerName, customerAccountNumber, customerBranchName) values (@customerName, @customerAccountNumber, @customerBranchName)", bankInfo);
            return Ok(await SelectAllCustomers(connection));
        }

        [HttpPut]
        public async Task<ActionResult<List<BankInfo>>> UpdateCustomers(BankInfo bankInfo)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("BankInfoConnection"));
            await connection.ExecuteAsync("UPDATE BankInfo SET customerName = @customerName, customerAccountNumber = @customerAccountNumber, customerBranchName = @customerBranchName WHERE customerID = @customerID", bankInfo);
            return Ok(await SelectAllCustomers(connection));
        }


        [HttpDelete("{customerID}")]
        public async Task<ActionResult<List<BankInfo>>> UpdateByID(int customerID)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("BankInfoConnection"));
            await connection.ExecuteAsync("DELETE FROM BankInfo WHERE customerID = @customerId",
                new { customerId = customerID });
            return Ok(await SelectAllCustomers(connection));
        }

    }
}
