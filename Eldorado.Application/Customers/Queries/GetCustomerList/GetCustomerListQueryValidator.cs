﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldorado.Application.Customers.Queries.GetCustomerList
{
    public class GetCustomerListQueryValidator : AbstractValidator<GetCustomerListQuery>
    {
        public GetCustomerListQueryValidator()
        {
            
        }
    }
}