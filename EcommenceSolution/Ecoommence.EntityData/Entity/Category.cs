using EshopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopSolution.Data.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOder { get; set; }
        public Boolean IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        public List<ProductXCategory>? ProductXCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
