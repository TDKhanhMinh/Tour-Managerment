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
    public class CustomerBLL
        {
        public CustomerBLL() { }
        public static DataTable findAllCustomerData()
            {
            DataTable dt = new DataTable();
            try { dt = CustomerDAL.findAllCustomer(); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
            }

        public static DataTable findCustomerInfo(String info)
            {
            DataTable dt = new DataTable();
            try { dt = CustomerDAL.findCustomer(info); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
            }

        public static bool findCustomerByEmail(String email)
            {
            if (CustomerDAL.getCustomerByEmail(email) == null) { return true; }
            else { return false; }

            }

        public static bool findCustomerByPhone(String phone)
            {
            if (CustomerDAL.getCustomerByPhone(phone) == null) { return true; }
            else { return false; }

            }
        public static void addCustomer(Customer_DTO customer)
            {
            try { CustomerDAL.insertCustomer(customer); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            
            }
        public static void updateCustomer(Customer_DTO customer, int customerId)
            {
            try { CustomerDAL.updateCustomer(customer,customerId); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            }

        public static void deleteCustomer(int customerId)
            {
            try { CustomerDAL.deleteCustomer(customerId); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            }

        public static DataTable fullName()
        {
            try
            {
                return CustomerDAL.fullName();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi" + ex.Message);
                return null; }
        }
    }
}
