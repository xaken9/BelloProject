using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Mappings;
using Domain.Entities;
using MediatR;
using Utility;
using Application.DTO.Request;
using Application.Interface.Repository.Core;
using AutoMapper;
using Application.DTO.Response;

namespace Application.BusinessLogic.ProductHandler
{
    public class CreateProductBranchRequestCommand : ProductBranchDTORequest, IRequest<Result<ProductBranchDTOResponse>>
    {
    }

    public class ProductHandler : IRequestHandler<CreateProductBranchRequestCommand, Result<ProductBranchDTOResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<ProductBranchDTOResponse>> Handle(CreateProductBranchRequestCommand command, CancellationToken cancellationToken)
        {
            var branchResult = await _unitOfWork.Repository<Branch>().AddAsync(_mapper.Map<Branch>(command.BranchDTORequest));
            await _unitOfWork.Save(cancellationToken);
            command.BranchDTORequest.Id = branchResult.Id;
            var result = await _unitOfWork.Repository<Product>().AddAsync(_mapper.Map<Product>(command));
            await _unitOfWork.Save(cancellationToken);
            var response = _mapper.Map<ProductBranchDTOResponse>(result);
            return await Result<ProductBranchDTOResponse>.SuccessAsync(response);
        }
    }
}
