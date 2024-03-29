﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldorado.Application.Couriers.Queries.GetCourierDetails
{
    public class GetCourierDetailsQuery : IRequest<CourierDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
