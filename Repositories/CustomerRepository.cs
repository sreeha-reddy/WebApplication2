using Dapper;
using WebApplication2.Data;
using WebApplication2.Models;

public class CustomerRepository
{
    private readonly DapperContext _context;

    public CustomerRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        try
        {
            var query = "SELECT * FROM Customers";
            using (var connection = _context.CreateConnection())
            {
                var customers = await connection.QueryAsync<Customer>(query);
                return customers;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;
        }
        
    }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        var query = "SELECT * FROM Customers WHERE Id = @Id";
        using (var connection = _context.CreateConnection())
        {
            var customer = await connection.QueryFirstOrDefaultAsync<Customer>(query, new { Id = id });
            return customer;
        }
    }
}