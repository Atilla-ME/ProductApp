using MediatR;
using ProductApp.Application.Dtos;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public partial class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdVM>>
    {
        public Guid Id { get; set; }
    }
}
