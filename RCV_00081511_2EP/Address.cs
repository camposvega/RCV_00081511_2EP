using System;

namespace RCV_00081511_2EP
{
    public class Address
    {
        private int idAddress;
        private int idUser;
        private String address;

        public Address(int idAddress, int idUser, string address)
        {
            this.idAddress = idAddress;
            this.idUser = idUser;
            this.address = address;
        }

        public Address(int idUser, string address)
        {
            this.idUser = idUser;
            this.address = address;
        }

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public string Address1
        {
            get => address;
            set => address = value;
        }
    }
}