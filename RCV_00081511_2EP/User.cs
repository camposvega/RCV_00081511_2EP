using System;
using System.Collections.Generic;

namespace RCV_00081511_2EP
{
    public class User 
    {
        private String idUser;
        private String name;
        private String username;
        private String pass;
        private Boolean userType;

        public User(String idUser, string name, string username, string pass, bool userType)
        {
            this.idUser = idUser;
            this.name = name;
            this.username = username;
            this.pass = pass;
            this.userType = userType;
        }

        public User(string name, string username, string pass, bool userType)
        {
            this.name = name;
            this.username = username;
            this.pass = pass;
            this.userType = userType;
        }

        public String IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Pass
        {
            get => pass;
            set => pass = value;
        }

        public bool UserType
        {
            get => userType;
            set => userType = value;
        }
    }
}