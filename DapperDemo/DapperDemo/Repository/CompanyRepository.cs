using DapperDemo.Models;

namespace DapperDemo.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDBContext db;

        public CompanyRepository(ApplicationDBContext db)
        {
            this.db = db;
        }
        public Company AddCompany(Company company)
        {
            db.Companies.Add(company);
            db.SaveChanges();
            return company;
        }

        public Company FindCompany(int id)
        {
           return db.Companies.Find(id);

        }

        public List<Company> GetCompanies()
        {
            return db.Companies.ToList();
        }

        public void RemoveCompany(int id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
            db.SaveChanges();
        }

        public Company UpdateCompany(Company company)
        {
            db.Companies.Update(company);
            db.SaveChanges();
            return company;
        }
    }
}
