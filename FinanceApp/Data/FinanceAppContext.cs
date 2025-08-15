using System;
using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data;

public class FinanceAppContext: DbContext
{
    ////add**//

    public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options)
    {
    }

    public DbSet<Expense> Expenses { get; set; }
}
