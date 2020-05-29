using System.Collections.Generic;

namespace RCV_00081511_2EP
{
    public class Manager
    {
        private static Manager instance=null;
        private User loginUser;
        private List<User> users;
        private Form1 formMain;
        
        private Manager()
        {
        }
        
        public static Manager Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Manager();
                }
                return instance;
            }
        }

        public Form1 FormMain
        {
            get => formMain;
            set => formMain = value;
        }

        public List<User> Users
        {
            get => users;
            set => users = value;
        }

        public User LoginUser
        {
            get => loginUser;
            set => loginUser = value;
        }
    }
}