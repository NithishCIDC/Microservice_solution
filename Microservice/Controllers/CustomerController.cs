using AutoMapper;
using Microservice.Data;
using Microservice.Domain.DTO;
using Microservice.Domain.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(ApplicationDbContext _dbContext,IMapper mapper) : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerDTO entity)
        {
            var CustomerData = mapper.Map<Customer>(entity);
            await _dbContext.Customer.AddAsync(CustomerData);
            await _dbContext.SaveChangesAsync();
            return Ok(await _dbContext.Customer.FindAsync(CustomerData.Id));
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            var customer = await _dbContext.Customer.ToListAsync();
            return Ok(customer);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerByID(int id)
        {
            var customer = await _dbContext.Customer.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(customer);
        }

        [HttpPut]
        public async Task<IActionResult> EditCustomer([FromBody] Customer entity)
        {
            _dbContext.Customer.Update(entity);
            await _dbContext.SaveChangesAsync();
            return Ok(await _dbContext.Customer.FindAsync(entity.Id));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var entity = await _dbContext.Customer.FindAsync(id);
            if (entity == null)
            {
                return NotFound(new { message = "Customer not found" });
            }

            _dbContext.Customer.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return Ok(new { message = "Customer deleted successfully" });
        }

    }
}
