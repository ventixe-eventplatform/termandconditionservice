using WebApi.Data.Entities;
using WebApi.Models;

namespace WebApi.Services;

public interface ITermAndConditionService
{
    Task<IEnumerable<TermModel>> GetTermsAsync();
}
