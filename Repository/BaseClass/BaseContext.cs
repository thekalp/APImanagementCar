using Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BaseClass
{
    public class BaseContext
    {
        protected readonly TestContext _context;

        public BaseContext(TestContext context)
        {
            _context = context;
        }
    }
}
