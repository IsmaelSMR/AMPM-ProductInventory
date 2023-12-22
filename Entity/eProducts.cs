using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eProducts
    {
        private int productId;
        private string name;
        private int stock;
        private bool active;
        private int supplierId;
        private string imageUrl;
        private string code;
        private string supplierName;

        public int ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool Active { get => active; set => active = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string Code { get => code; set => code = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
    }
}
