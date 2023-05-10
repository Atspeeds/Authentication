using _01_Framework.Application;
using StoreManager.Application.Contract.Product;
using StoreManager.Domain.ProductAgg;
using System.Collections.Generic;

namespace StoreManager.Application
{
    public class ProductApplication : IProductApplication
    {

        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResponse Create(CreateProduct command)
        {

            ActionResponse response = new ActionResponse();

            if (_productRepository.Exists(x => x.Name == command.Name))
                return response.Failed(ServiceMessage.DuplicateRecord);

            var product = new Product(command.Name, command.Picture,
                command.Description, command.ShortDescription,
                 command.Code);


            _productRepository.Create(product);
            _productRepository.Save();

            return response.Success();

        }

        public ActionResponse Edit(EditProduct command)
        {
            ActionResponse response = new ActionResponse();

            var product = _productRepository.Get(command.Id);

            if (product == null) return response.Failed(ServiceMessage.NoRecordFound);

            if (_productRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                response.Failed(ServiceMessage.DuplicateRecord);

            product.Edit(command.Name, command.Picture, command.Description,
                command.ShortDescription, command.Code);

            _productRepository.Save();

            return response.Success();
        }

        public EditProduct GetDetails(long id)
        {
            return _productRepository.GetDetails(id);
        }

        public List<ProductViewModel> Search(SearchProduct search)
        {
            return _productRepository.Search(search);
        }
    }
}
