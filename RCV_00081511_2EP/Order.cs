using System;

namespace RCV_00081511_2EP
{
    public class Order
    {
        private int idOrder;
        private DateTime creation;
        private int idUser;
        private int idAddress;

        public Order(int idOrder, DateTime creation, int idUser, int idAddress)
        {
            this.idOrder = idOrder;
            this.creation = creation;
            this.idUser = idUser;
            this.idAddress = idAddress;
        }

        public int IdOrder
        {
            get => idOrder;
            set => idOrder = value;
        }

        public DateTime Creation
        {
            get => creation;
            set => creation = value;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }
    }
}