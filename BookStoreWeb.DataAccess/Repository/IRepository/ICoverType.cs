using BooksStoreWeb.Models;
using BookStoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWeb.DataAccess.Repository.IRepository
{
    public interface ICoverType
    {
        void Update(CoverType obj);
        //void Save();
    }


}
