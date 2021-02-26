using parlem.domain.Models.Product.Interfaces;
using Models = parlem.domain.Models.Product;

namespace parlem.application.UseCases.Product
{
    public class GetProductUseCase
    {
        private IProductRepository productRepository;

        public GetProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Models.Product Execute(int productId)
        {
            return productRepository.GetById(productId);
        }
    }
}
