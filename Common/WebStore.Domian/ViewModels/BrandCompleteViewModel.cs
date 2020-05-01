using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domian.ViewModels
{
    public class BrandCompleteViewModel
    {
        public IEnumerable<BrandViewModel> Brands { get; set; }

        public int? CurrentBrandId { get; set; }
    }
}
