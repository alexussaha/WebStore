﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domian;
using WebStore.Domian.DTO.Products;
using WebStore.Domian.Entities;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{
    [Route(WebAPI.Products)]
    [ApiController]
    public class ProductsApiController : ControllerBase, IProductData
    {
        private readonly IProductData _ProductData;

        public ProductsApiController(IProductData ProductData) => _ProductData = ProductData;

        [HttpGet("sections")]
        public IEnumerable<Section> GetSections() => _ProductData.GetSections();

        [HttpGet("sections/{id}")]
        public SectionDTO GetSectionById(int id) => _ProductData.GetSectionById(id);

        [HttpGet("brands")]
        public IEnumerable<Brand> GetBrands() => _ProductData.GetBrands();

        [HttpGet("brands/{id}")]
        public BrandDTO GetBrandById(int id) => _ProductData.GetBrandById(id);

        [HttpPost]
        public PagedProductsDTO GetProducts([FromBody] ProductFilter Filter = null) => _ProductData.GetProducts(Filter);

        [HttpGet("{id}")]
        public ProductDTO GetProductById(int id) => _ProductData.GetProductById(id);
    }
}