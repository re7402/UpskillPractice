using Dapper;
using DapperDemo.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperDemo.Repository
{
    public class CompanyRepositoryDapper : ICompanyRepository
    {
        private readonly IConfiguration configuration;
        private IDbConnection db;

        public CompanyRepositoryDapper(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            this.configuration = configuration;
        }
        public Company AddCompany(Company company)
        {
            var sql = "INSERT INTO Companies(CompanyName,Address,City,State,PostalCode) VALUES(@CompanyName,@Address,@City,@State,@PostalCode);"
                 + "SELECT CAST(SCOPE_IDENTITY()as int);";
            var id = db.Execute(sql, new
            {
                company.CompanyName,
                company.Address,
                company.City,
                company.State,
                company.PostalCode
            });
            company.CompanyId = id;
            return company;
        }

        public Company FindCompany(int id)
        {
            var sqlQuery = "SELECT Name FROM Companies WHERE Id = @CompanyId";
            return db.Query<Company>(sqlQuery, new { @CompanyId = id }).Single();
        }

        public List<Company> GetCompanies()
        {
           return db.Query<Company>("SELECT * FROM Companies").ToList();
        }

        public void RemoveCompany(int id)
        {
           
        }

        public Company UpdateCompany(Company company)
        {
            var sql = "UPDATE Companies SET CompanyName = @CompanyName, Address = @Address , City = @City , State = @State , PostalCode =@PostalCode WHERE CompanyId = @CompanyId";

            db.Execute(sql, company);
            return company;
                ;
        }
    }
}
