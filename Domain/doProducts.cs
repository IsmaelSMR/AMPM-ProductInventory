using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Domain
{
    public class doProducts
    {
        dProducts objProducts = new dProducts();

        //Create method
        public void CreateProduct(eProducts products)
        {
            objProducts.CreateProduct(products);
        }

        //Update method
        public void EditProduct(eProducts products)
        {
            objProducts.EditProduct(products);
        }

        //Read method
        public void ViewProduct(eProducts products)
        {
            objProducts.ViewProduct(products);
        }

        //Delete method
        public void DeleteProduct(eProducts products)
        {
            objProducts.DeleteProduct(products);
        }

    }
}
