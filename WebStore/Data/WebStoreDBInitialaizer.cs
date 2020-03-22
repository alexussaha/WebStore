﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;

namespace WebStore.Data
{
    public class WebStoreDBInitialaizer
    {
        private readonly WebStoreDB _db;

        public WebStoreDBInitialaizer(WebStoreDB db) => _db = db;

        public void Initialize() => InitializeAsync().Wait();

        public async Task InitializeAsync()
        {
            var db = _db.Database;

            await db.MigrateAsync().ConfigureAwait(false);

            if (await _db.Products.AnyAsync()) return;

            using(var transactions = await db.BeginTransactionAsync().ConfigureAwait(false))
            {
                await _db.Sections.AddRangeAsync(TestData.Sections).ConfigureAwait(false);

                await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Sections] ON");

                await _db.SaveChangesAsync().ConfigureAwait(false);

                await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Sections] OFF");

                await transactions.CommitAsync().ConfigureAwait(false);
            }

            using (var transactions = await db.BeginTransactionAsync().ConfigureAwait(false))
            {
                await _db.Brands.AddRangeAsync(TestData.Brands).ConfigureAwait(false);

                await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Brands] ON");

                await _db.SaveChangesAsync().ConfigureAwait(false);

                await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Brands] OFF");

                await transactions.CommitAsync().ConfigureAwait(false);
            }

            using (var transactions = await db.BeginTransactionAsync().ConfigureAwait(false))
            {
                await _db.Products.AddRangeAsync(TestData.Products).ConfigureAwait(false);

                await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Products] ON");

                await _db.SaveChangesAsync().ConfigureAwait(false);

                await db.ExecuteSqlRawAsync("SET IDENTITY_INSERT [dbo].[Products] OFF");

                await transactions.CommitAsync().ConfigureAwait(false);
            }
        }
    }
}
