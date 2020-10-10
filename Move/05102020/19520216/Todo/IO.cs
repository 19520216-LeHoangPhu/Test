using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    class IO
    {
        static public USER[] CreateListUser(string pathUser = "", string pathID = "") // Trả về danh sách các USER có List các ToDo
        {
            try
            {
                string userPath = Path.Combine(pathUser, "user.txt");
                string idPath;
                if (!File.Exists(userPath))
                    return null;
                USER[] a ;
                using (StreamReader users = new StreamReader(userPath))
                {
                    a = new USER[int.Parse(users.ReadLine())];
                    int length_a = a.Length, count = -1;
                    string user;
                    while ((user = users.ReadLine()) != null)
                    {
                        string[] user_element = user.Split(' ');
                        count++;
                        a[count] = new USER(user_element[1],user_element[2],int.Parse(user_element[0]));
                        idPath = Path.Combine(pathID, a[count].getID().ToString());
                        if (!File.Exists(idPath))
                        {
                            MessageBox.Show($"Dữ liệu của ID {a[count].getID()} không tồn tại!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CreateFileID(pathID, a[count].getID().ToString());
                        }
                        using (StreamReader ids = new StreamReader(idPath))
                        {
                            string id;
                            id = ids.ReadLine();
                            int capacity_id = int.Parse(id);
                            bool On = false;
                            bool checkbox = false;
                            string content = "";
                            for (int i = 0; i < capacity_id; i++)
                            {
                                id = ids.ReadLine();
                                if (id == "<")
                                {
                                    On = true;
                                    content = "";
                                    id = ids.ReadLine();
                                    checkbox = Convert.ToBoolean(id);
                                    continue;
                                }
                                else if (id == ">")
                                {
                                    On = false;
                                    a[count].tdlUser.AddContent(content, checkbox);
                                    continue;
                                }
                                if (On)
                                {
                                    content += id;
                                }
                            }
                        }
                    }
                }
                return a;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                return null;
            }
            
        }

        static public bool CreateFileID(string pathID, string ID)
        {
            try
            {
                string idPath = Path.Combine(pathID, ID);
                File.Create(idPath).Close();
                File.WriteAllText(idPath, 0.ToString());
                return true;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                return false;
            }
        } // Tạo file Id.txt của ID

        static public bool AddUserToFileUser(string pathUser, USER a)
        {
            try
            {
                string userPath = Path.Combine(pathUser, "user.txt");
                if (!File.Exists(userPath))
                    File.Create(userPath).Close();
                File.WriteAllText(userPath, 0.ToString());

                string[] data = File.ReadAllLines(userPath);
                data[0] = (int.Parse(data[0]) + 1).ToString();
                File.Delete(userPath);
                File.Create(userPath).Close();
                File.WriteAllLines(userPath, data);
                using (StreamWriter user = new StreamWriter(userPath))
                    user.WriteLine(a.ToString());
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        } // Thêm 1 user

        static public bool LoadToDoForUSer(string pathID, ref USER a)
        {
            string idPath = Path.Combine(pathID, a.getID().ToString());
            if (!File.Exists(idPath))
            {
                MessageBox.Show($"Không load được dữ liệu cho ID {a.getID()}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            using (StreamReader ids = new StreamReader(idPath))
            {
                a.tdlUser.DeleteAllContent();
                string id;
                id = ids.ReadLine();
                int capacity_id = int.Parse(id);
                bool On = false;
                bool checkbox = false;
                string content = "";
                for (int i = 0; i < capacity_id; i++)
                {
                    id = ids.ReadLine();
                    if (id == "<")
                    {
                        On = true;
                        content = "";
                        id = ids.ReadLine();
                        checkbox = Convert.ToBoolean(id);
                        continue;
                    }
                    else if (id == ">")
                    {
                        On = false;
                        a.tdlUser.AddContent(content, checkbox);
                        continue;
                    }
                    if (On)
                    {
                        content += id;
                    }
                }
            }
            return true;
        } // Lấy danh sách Todo của user

        static public bool InputUser(string pathUser, string pathID, ref USER userinput) // Trả về true hoặc false cho việc kiểm tra đăng nhập
        {
           try
            {
                string userPath = Path.Combine(pathUser, "user.txt");
                if (!File.Exists(pathUser))
                {
                    userinput.setID(1);
                    return false;
                }
                using (StreamReader users = new StreamReader(userPath))
                {
                    USER[] a;
                    string user;
                    int dem = -1;
                    a = new USER[int.Parse(users.ReadLine())];
                    while ((user = users.ReadLine()) != null)
                    {
                        string[] user_divide = user.Split(' ');
                        dem++;
                        a[dem] = new USER(user_divide[1], user_divide[2], int.Parse(user_divide[0]));
                        if (a[dem].getUserName() == userinput.getUserName() && a[dem].getPassword() == userinput.getPassword())
                        {
                            userinput.setID(a[dem].getID());
                            string idPath = Path.Combine(pathID, userinput.getID().ToString());
                            LoadToDoForUSer(idPath, ref userinput);
                            return true;
                        }
                    }
                    userinput.setID(dem + 2);
                    return false;
                }
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
                return false;
            }
        }

        static public bool Save(string pathID, dynamic parent, USER a) // Thực hiện chức năng sao lưu dữ liệu ToDo cho file trong đường dẫn
        {
            File.Delete(pathID);
            parent.Enabled = false;
            string idPath = Path.Combine(pathID, a.getID().ToString());
            File.Delete(idPath);
            File.Create(idPath).Close();
            using (StreamWriter IDs = new StreamWriter(idPath))
            {

                IDs.WriteLine(a.tdlUser.iSL);
                for (int j = 0; j < a.tdlUser.iSL; j++)
                    IDs.WriteLine("<\n"  + a.tdlUser.tdList[j].bCheckBox.ToString() + '\n' + a.tdlUser.tdList[j].sContent + "\n>");
            }
            parent.Enabled = true;
            return true;
        }

        static public bool SignUp(dynamic parent, string pathUser, string pathID, USER a)
        {
            string userPath = Path.Combine(pathUser, "user.txt");
            parent.Enabled = false;
            if (InputUser(pathUser,pathID, ref a))
            {
                parent.Enabled = true;
                return false;
            }
            CreateFileID(pathID, a.getID().ToString());

            AddUserToFileUser(pathUser,a);    
            
            parent.Enabled = true;
            return true;
        } //Đăng ký 1 user mới
    }
}
