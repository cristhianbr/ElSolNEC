﻿using ElSolNEC.Application.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Products.Command
{
    public record UpdateProductCommand(
        [Required] int ProductId,
        [Required] string ProductName,
        [Required] int Inventory,
        [Required] int Price
    ) : IRequest<ProductDto>;
}
