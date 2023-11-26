using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Application.DTO.Request;
using Application.DTO.Response;
using Domain.Entities;
using Application.BusinessLogic.ProductHandler;

namespace Application.Common.Mappings
{
    public class ProductMapper : AutoMapper.Profile
    {
        public ProductMapper()
        {

            CreateMap<ProductBranchDTORequest, Product>()
            ;

            CreateMap<CreateProductBranchRequestCommand, Product>()
                .ForMember(pts => pts.BranchId, opt => opt.MapFrom(ps => ps.BranchDTORequest.Id));
            ;

            CreateMap<Product, ProductBranchDTOResponse>()
           ;

            //CreateMap<ProductBranchDTORequest, Branch>()
            //.ForMember(pts => pts.BranchName, opt => opt.MapFrom(ps => ps.BranchDTORequest.BranchName));
            //;
        }
    }
}
