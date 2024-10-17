﻿using AllBirds.Application.Contracts;
using AllBirds.DTOs.ProductDTOs;
using AllBirds.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBirds.Application.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productrepoistory;
        //private readonly ICategoryProductService categoryProductService;
        public IMapper mapper { get; }

        public ProductService(IProductRepository _productRepository, IMapper _mapper)
        {
            productrepoistory = _productRepository;
            mapper = _mapper;
        }
        public async Task<CUProductDTO> CreateAsync(CUProductDTO cUProductDTO)
        {
            Product mappedProduct = mapper.Map<Product>(cUProductDTO);
            Product createdProduct = await productrepoistory.CreateAsync(mappedProduct);
            if (createdProduct != null)
            {
                //await productrepoistory.SaveChangesAsync();
                CUProductDTO mappedCUProductDTO = mapper.Map<CUProductDTO>(createdProduct);
                return mappedCUProductDTO;
            }
            return null;
        }

        public async Task<List<GetAllProductDTO>> GetAllAsync()
        {
            List<Product> productsList = [.. (await productrepoistory.GetAllAsync())];
            List<GetAllProductDTO> result = mapper.Map<List<GetAllProductDTO>>(productsList);
            return result;
        }

        public async Task<CUProductDTO> GetByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<CUProductDTO> HardDeleteAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<CUProductDTO> SoftDeleteAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<CUProductDTO> UpdateAsync(CUProductDTO cUProductDTO)
        {
            throw new NotImplementedException();
        }
    }
}
