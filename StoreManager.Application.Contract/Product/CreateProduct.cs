using Microsoft.AspNetCore.Http;


namespace StoreManager.Application.Contract.Product
{
    public class CreateProduct
    {
        public string Code { get; set; }
        public IFormFile Picture { get; set; }
        public string  PictureName { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
    }
}