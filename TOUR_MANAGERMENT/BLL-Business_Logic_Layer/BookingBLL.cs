using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TOUR_MANAGERMENT.DAL_Data_Access_Layer;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;

namespace TOUR_MANAGERMENT.BLL_Business_Logic_Layer
{
    public class BookingBLL
    {
        public static DataTable findAllBookingData()
        {
            DataTable dt = new DataTable();
            try { dt = BookingDAL.findAllBooking(); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
        }

        public static void createBooking(Booking_DTO booking)
        {
            try { BookingDAL.createBooking(booking); }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);

            }
        }

        public static DataTable findTourInfo(string type, decimal min, decimal max, string transportation)
        {
            DataTable dt = new DataTable();
            try { dt = TourDAL.findTour(type, min, max, transportation); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
        }

        public static void updateBooking(Booking_DTO booking, int bookingId)
        {
            try { BookingDAL.updateBooking(booking, bookingId); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void deleteBooking(int bookingId)
        {
            try { BookingDAL.deleteBooking(bookingId); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
