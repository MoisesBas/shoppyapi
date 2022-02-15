using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Core.Domain.Category;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Category.GetCategoryById;


    public sealed class GetProductByIdQueryHandler : QueryHandler<GetCategoryByIdQuery, CategoryModel>
    {
        private readonly IProductUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetProductByIdQueryHandler(
            IProductUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<CategoryModel> ExecuteQuery(GetCategoryByIdQuery query, CancellationToken cancellationToken)
        {
            var categoryId = new CategoryId(query.Id);
            var item = await _unitOfWork.Set<Core.Domain.Category.Category>()
                
                .FirstOrDefaultAsync(x=>x.Id == categoryId, cancellationToken).ConfigureAwait(false); ;
            if(item == null) return default;            
            return _mapper.Map<CategoryModel>(item);
        }
    }

 