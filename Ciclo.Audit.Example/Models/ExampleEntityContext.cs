using Audit.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ciclo.Audit.Example.Models
{
    public class ExampleEntityContext : AuditDbContext
    {
        public ExampleEntityContext(DbContextOptions<ExampleEntityContext> options)
            : base(options)
        {
        }

        public List<TodoList> TodoLists { get; set; }
    }
}