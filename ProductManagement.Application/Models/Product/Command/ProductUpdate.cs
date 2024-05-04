﻿using MediatR;

namespace ProductManagement.Application.Models.Product.Command
{
    public class ProductUpdate : IRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}