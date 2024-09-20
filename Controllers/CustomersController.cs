using Microsoft.AspNetCore.Mvc;

public class CustomersController : Controller
{
    private readonly CustomerRepository _repository;

    public CustomersController(CustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task<IActionResult> Index()
    {
        var customers = await _repository.GetAllCustomersAsync();
        return View(customers);
    }

    public async Task<IActionResult> Details(int id)
    {
        var customer = await _repository.GetCustomerByIdAsync(id);
        if (customer == null)
        {
            return NotFound();
        }

        return View(customer);
    }
}