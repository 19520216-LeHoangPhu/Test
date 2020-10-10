using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class TODOLIST
    {
        public int iSL
        {
            get
            {
                return iSL;
            }
            set
            {
                iSL = value;
            }
        }
        public TODO[] tdList
        {
            get
            {
                return tdList;
            }
            set
            {
                tdList = value;
            }
        }
        public int iCapacity
        {
            get
            {
                return iCapacity;
            }
            set
            {
                iCapacity = value;
            }
        }
        public TODOLIST(int sl = 0)
        {
            iSL = 0;
            iCapacity = sl;
            tdList = new TODO[iSL];
        }
        public void AddContent(string content, bool checkbox)
        {
            iSL++;
            if (iSL > iCapacity)
            {
                TODO[] tmp = new TODO[iSL];
                for (int i = 0; i < iSL - 1; i++)
                {
                    tmp[i].sContent = tdList[i].sContent;
                }
                tmp[iSL - 1].sContent = content;
                tdList = new TODO[iSL];
                tdList = tmp;
                iCapacity = iSL;
            }
            else
                tdList[iSL - 1].sContent = content;
            tdList[iSL - 1].bCheckBox = checkbox;
        }

        public void AddContent(ref USER admin,string content, bool checkbox)
        {
            admin.AddContent(content, checkbox);
        }

        public void EditContent(int pos, string content, bool checkbox)
        {
            if (pos < 0 || pos >= iSL)
                return;
            tdList[pos].sContent = content;
            tdList[pos].bCheckBox = checkbox;
        }

        public void EditContent(ref USER admin, int pos, string content, bool checkbox)
        {
            admin.EditContent(pos, content, checkbox);
        }

        public void DeleteContent(int pos)
        {
            if (pos < 0 || pos >= iSL)
                return;
            for (int i = pos - 1; i < iSL; i++)
            {
                tdList[i].sContent = tdList[i + 1].sContent;
                tdList[i].bCheckBox = tdList[i + 1].bCheckBox;
            }
            iSL--;
        } 

        public void DeleteContent(ref USER admin, int pos)
        {
            admin.DeleteContent(pos);
        }
        public void DeleteAllContent()
        {
            iSL = 0;
        }

        public void DeleteAllContent(ref USER admin)
        {
            admin.DeleteALlContent();
        }
    }
}
