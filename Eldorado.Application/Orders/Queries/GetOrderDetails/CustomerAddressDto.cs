﻿using AutoMapper;
using Eldorado.Application.Common.Mappings;
using Eldorado.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldorado.Application.Orders.Queries.GetOrderDetails
{
    public class CustomerAddressDto : IMapWith<CustomerAddress>
    {
        public Guid Id { get; set; }
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int House { get; set; }
        public int Apartment { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CustomerAddress, CustomerAddressDto>()
                .ForMember(customerAddressDto => customerAddressDto.Id,
                opt => 
                    opt.MapFrom(customerAddress => customerAddress.Id))
                .ForMember(customerAddressDto => customerAddressDto.City,
                opt => 
                    opt.MapFrom(customerAddress => customerAddress.City))
                .ForMember(customerAddressDto => customerAddressDto.Street,
                opt => 
                    opt.MapFrom(customerAddress => customerAddress.Street))
                .ForMember(customerAddressDto => customerAddressDto.House,
                opt =>
                    opt.MapFrom(customerAddress => customerAddress.House))
                .ForMember(customerAddressDto => customerAddressDto.Apartment,
                opt => 
                    opt.MapFrom(customerAddress => customerAddress.Apartment));
        }
    }
}
