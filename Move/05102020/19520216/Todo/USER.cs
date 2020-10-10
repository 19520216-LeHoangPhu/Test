using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    class USER
    {
        public TODOLIST tdlUser;
        private string sUserName;
        private string sPassword;

        public string getUserName()
        {
            return sUserName;
        }
        
        public bool setUserName(string value)
        {
            if (value == "")
                return false;
            sUserName = value;
            return true;
        }

        public string getPassword()
        {
            return sPassword;
        }

        public bool setPassword(string value)
        {
            if (value == "")
                return false;
            sPassword = value;
            return true;
        }

        private int iID;

        public bool setID(int value)
        {
            if (!char.IsDigit(Convert.ToChar(value)))
                return false;
            iID = value;
            return true;
        }

        public int getID()
        {
            return iID;
        }

        public USER(string user = "", string pass = "", int id = -1)
        {
            sUserName = user;
            sPassword = pass;
            iID = id;
            tdlUser = null;
        }

        public void CreateToDoList(int sl)
        {
            tdlUser.iSL = sl;
            tdlUser.iCapacity = sl;
            tdlUser.tdList = new TODO[sl];
        }

        public void AddContent(string content, bool checkbox)
        {
            tdlUser.AddContent(content, checkbox);
        }

        public void EditContent(int pos, string content, bool checkbox)
        {
            tdlUser.EditContent(pos, content, checkbox);
        }

        public void DeleteContent(int pos)
        {
            tdlUser.DeleteContent(pos);
        }

        public void DeleteALlContent()
        {
            tdlUser.DeleteAllContent();
        }

        public override string ToString()
        {
            return iID.ToString() + ' ' + sUserName + ' '+ sPassword;
        }

    }
}
