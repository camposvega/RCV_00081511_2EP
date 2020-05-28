using System;

namespace RCV_00081511_2EP
{
    public class Product
    {
        private int idProduct;
        private String name;
        private int idBusiness;

        public Product(int idProduct, string name, int idBusiness)
        {
            this.idProduct = idProduct;
            this.name = name;
            this.idBusiness = idBusiness;
        }

        public Product(string name, int idBusiness)
        {
            this.name = name;
            this.idBusiness = idBusiness;
        }

        public int IdProduct
        {
            get => idProduct;
            set => idProduct = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int IdBusiness
        {
            get => idBusiness;
            set => idBusiness = value;
        }
    }
}