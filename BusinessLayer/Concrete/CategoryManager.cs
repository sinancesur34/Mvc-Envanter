﻿using BusinessLayer.Concrete;
using DataAccessLayer.concrete.Repositories;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBl()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName=="" ||p.CategoryName.Length<=3 ||
                p.categoryDescription=="" ||p.CategoryName.Length>=51 )
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
