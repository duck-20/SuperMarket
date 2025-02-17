﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.ProductsUseCases
{
	public class ViewProductsUseCase : IViewProductsUseCase
	{
		private readonly IProductRepository productRepository;

		public ViewProductsUseCase(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}
		public IEnumerable<Product> Execute(bool loadCategory = false)
		{
			return productRepository.GetProducts(loadCategory);
		}
	}
}
