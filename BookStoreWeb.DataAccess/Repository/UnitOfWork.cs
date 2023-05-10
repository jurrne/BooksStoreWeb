using BooksStoreWeb.DataAccess;
using BooksStoreWeb.Models;
using BookStoreWeb.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWeb.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository Category { get; private set; }
        private readonly ApplicationDBContext _context;

            public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
