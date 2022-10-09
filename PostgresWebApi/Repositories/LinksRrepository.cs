using PostgresWebApi.data;
using PostgresWebApi.Models;
using PostgresWebApi.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresWebApi.Repositories
{
    public class LinksRrepository : ILinksrepositories<Links, string>
    {
        private readonly SampleContext _context;

        public LinksRrepository(SampleContext context)
        {
            _context = context;
        }


        public async Task Insert(Links entity)
        {
            await _context.links.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
