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
    public class BranchMapper:Profile
    {
        public BranchMapper()
        {

            CreateMap<BranchDTORequest, Branch>()
            .ForMember(pts => pts.BranchName, opt => opt.MapFrom(ps => ps.BranchName));
            ;

        }
    }
}
