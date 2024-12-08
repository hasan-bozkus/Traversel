﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public void ChangeToFalseByGuide(int id)
        {
            using(var context = new Context())
            {
                var values = context.Guides.Find(id);
                values.Status = false;
                context.Update(values);
                context.SaveChanges();
            }
        }

        public void ChangeToTrueByGuide(int id)
        {
            using (var context = new Context())
            {
                var values = context.Guides.Find(id);
                values.Status = true;
                context.Update(values);
                context.SaveChanges();
            }
        }
    }
}
