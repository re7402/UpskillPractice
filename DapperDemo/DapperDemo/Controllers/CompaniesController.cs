using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DapperDemo;
using DapperDemo.Models;
using DapperDemo.Repository;

namespace DapperDemo.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompaniesController(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }

        // GET: Companies
        public async Task<IActionResult> Index()
        {
            //using dbcontext
              //return _context.Companies != null ? 
              //            View(await _context.Companies.ToListAsync()) :
              //            Problem("Entity set 'ApplicationDBContext.Companies'  is null.");

            //using repo
            return View(_companyRepository.GetCompanies());
        }

        // GET: Companies/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    //using dbcontext
        //    //if (id == null || _context.Companies == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //var company = await _context.Companies
        //    //    .FirstOrDefaultAsync(m => m.CompanyId == id);
        //    //if (company == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //return View(company);

        //    //using repo
        //    return _companyRepository.FindCompany(id.GetValueOrDefault());
        //}

        // GET: Companies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName,Address,City,State,PostalCode")] Company company)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(company);
                //await _context.SaveChangesAsync();
                _companyRepository.AddCompany(company);
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Companies/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var company = await _context.Companies.FindAsync(id);
            var company = _companyRepository.FindCompany(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,CompanyName,Address,City,State,PostalCode")] Company company)
        {
            if (id != company.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                    //_context.Update(company);
                    //await _context.SaveChangesAsync();
                    _companyRepository.UpdateCompany(company);
               
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null || _context.Companies == null)
            //{
            //    return NotFound();
            //}

            //var company = await _context.Companies
            //    .FirstOrDefaultAsync(m => m.CompanyId == id);
            //if (company == null)
            //{
            //    return NotFound();
            //}
            _companyRepository.RemoveCompany(id.GetValueOrDefault());
            return RedirectToAction(nameof(Index));
        }

    }
}
