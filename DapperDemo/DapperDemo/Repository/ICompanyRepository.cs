using DapperDemo.Models;

namespace DapperDemo.Repository
{
    public interface ICompanyRepository
    {
        Company FindCompany(int id);

        List<Company> GetCompanies();
        
        Company AddCompany(Company company);

        Company UpdateCompany(Company company);

        void RemoveCompany(int id);
    }
}
