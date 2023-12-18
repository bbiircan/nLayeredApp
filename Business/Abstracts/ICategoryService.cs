using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

public interface ICategoryService
{
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
}
