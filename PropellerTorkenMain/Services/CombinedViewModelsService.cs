using PropellerTorkenMain.Models.Database;
using System.Collections.Generic;

namespace PropellerTorkenMain.Services
{
    public class CombinedViewModelsService
    {
        public PropellerDataContext ctx = new PropellerDataContext();

        public CombinedViewModelsService()
        {
        }

     
        public CombinedViewModelsService(List<Models.Database.Customer> custList, List<Models.Database.Product> prodList, List<Models.Database.Order> ordList)
        {
            this._Customer = custList;
            this._Product = prodList;
            this._Order = ordList;
        }

        public List<Models.Database.Customer> _Customer { get; set; }
        public List<Models.Database.Order> _Order { get; set; }
        public List<Models.Database.Product> _Product { get; set; }
       
    }
}