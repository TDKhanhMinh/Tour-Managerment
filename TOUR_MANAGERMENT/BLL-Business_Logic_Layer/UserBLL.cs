using System;
using System.Collections.Generic;
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
    }
}
