using AutoMapper;
using FoodMartMongo.Dtos.CategoryDtos;
using FoodMartMongo.Dtos.CustomerDtos;
using FoodMartMongo.Dtos.ProductDtos;
using FoodMartMongo.Entities;

namespace FoodMartMongo.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, UpdateCategoryDto>();
            CreateMap<Category, GetCategoryByIdDto>();

            CreateMap<Product, ResultProductDto>();
            CreateMap<Product, UpdateProductDto>();
            CreateMap<Product, CreateProductDto>();
            CreateMap<Product, GetProductByIdDto>();

            CreateMap<Customer, ResultCustomerDto>();
            CreateMap<Customer, CreateCustomerDto>();
            CreateMap<Customer, UpdateCustomerDto>();
            CreateMap<Customer, GetCustomerByIdDto>();
        }
    }
}
