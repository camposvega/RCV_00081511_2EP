using System;

namespace RCV_00081511_2EP
{
    public class Business
    {
        private int idBusiness;
        private String name;
        private String description;

        public Business(int idBusiness, string name, string description)
        {
            this.idBusiness = idBusiness;
            this.name = name;
            this.description = description;
        }

        public Business(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public int IdBusiness
        {
            get => idBusiness;
            set => idBusiness = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}