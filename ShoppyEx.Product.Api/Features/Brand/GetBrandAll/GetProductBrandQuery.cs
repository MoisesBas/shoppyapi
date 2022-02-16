﻿
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Brand.GetBrandAll;

public record class GetProductBrandQuery : Query<IList<BrandResponseDto>>
{  
    
}


