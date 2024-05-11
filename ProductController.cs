public class ProductController : Controller {
    private List<Product> products = new List<Product>(
        new Product { Id = 1, Name = "Product 1", Price = 10 },
        new Product { Id = 2, Name = "Product 2", Price = 20 },
    );

    public IActionResult Index(){
        return View(products);
    }
    public IActionResult AddToCart(int productId){
        return RedirectToAction("Index");
    }
}

public class Product{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}