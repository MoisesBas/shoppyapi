using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Order.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Order.Api.Features.Basket.GetCurrentBasket;

public class GetCurrentBasketCommandQueryHandler : QueryHandler<GetCurrentBasketCommand, IEnumerable<GetBasketReponse>>
{
    private readonly IOrderUnitOfWork _orderUnitOfWork;
    private readonly IMapper _mapper;

    public GetCurrentBasketCommandQueryHandler(IOrderUnitOfWork orderUnitOfWork, IMapper mapper)
    {
        _orderUnitOfWork = orderUnitOfWork;
        _mapper = mapper;
    }

    public override async Task<IEnumerable<GetBasketReponse>> ExecuteQuery(GetCurrentBasketCommand query, CancellationToken cancellationToken)
    {
        var baskets = await _orderUnitOfWork.Set<Core.Domain.Basket.Basket>()
                            .Include(x=>x.BasketItems)
                            .Where(x => x.CustomerId == query.CustomerId)
                            .ProjectTo<GetBasketReponse>(_mapper.ConfigurationProvider)
                            .ToListAsync(cancellationToken);
        return baskets;
    }
   
}