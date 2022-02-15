﻿using FluentValidation.Results;
using MediatR;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Query
{
    public interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult>
     where TQuery : IQuery<TResult>
    { }
}
