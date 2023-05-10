using BooksStoreWeb.DataAccess;
using BooksStoreWeb.Models;
using BookStoreWeb.DataAccess.Repository.IRepository;
using BookStoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWeb.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverType
    {
        private ApplicationDBContext _context;
        public CoverTypeRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        //public void Save()
        //{
        //    _context.SaveChanges();
        //}

        public void Update(CoverType obj)
        {
            _context.Update(obj);
        }

    } 
}

