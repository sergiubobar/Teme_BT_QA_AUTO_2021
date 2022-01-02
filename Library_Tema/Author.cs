using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Tema
{
     class Author
    {
        string name ;
        string email ;

        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }


    }
}
