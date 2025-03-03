using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_MANAGERMENT.DAL_Data_Access_Layer;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;

namespace TOUR_MANAGERMENT.BLL_Business_Logic_Layer
{
    public class UserBLL
    {
        public static User_DTO? Login(string username, string pwd)
        {

            if (username == null || pwd == null)
            {
                return null;
            }
            User_DTO accounts_DTO = new(username, pwd,"NV");

            return UserDAL.Login(accounts_DTO) ? accounts_DTO : null;
        }

        public static string getRole(string username)
        {
            return UserDAL.getRole(username);
        }

        public static DataTable findAllUserData()
            {
            DataTable dt = new DataTable();
            try { dt = UserDAL.findAllStaff(); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
            }

        public static DataTable findUserInfo(String info)
            {
            DataTable dt = new DataTable();
            try { dt = UserDAL.findStaff(info); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
            }



        public static bool findUserByPhone(String phone)
            {
            if (UserDAL.getUserByPhone(phone) == null) { return true; }
            else { return false; }
            }



            public static User_DTO getUser(String username, String pwd)
            {
            return UserDAL.getUser(username, pwd);


            }
        public static void addUser(User_DTO customer)
            {
            try { UserDAL.insertStaff(customer); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }

            }
        public static void updateUser(User_DTO customer, int customerId)
            {
            try { UserDAL.updateStaff(customer, customerId); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            }

        public static void deleteUser(int customerId)
            {
            try { UserDAL.deleteStaff(customerId); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            }
        }
}
