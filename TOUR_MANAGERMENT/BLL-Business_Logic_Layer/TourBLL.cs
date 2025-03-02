using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;
using TOUR_MANAGERMENT.DAL_Data_Access_Layer;

namespace TOUR_MANAGERMENT.BLL_Business_Logic_Layer
{
    public class TourBLL()
    {

        public static DataTable findAllTourData()
        {
            DataTable dt = new DataTable();
            try { dt = TourDAL.findAllTour(); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
        }

        public static void addTour(Tour_DTO tour)
        {
            try { TourDAL.addTour(tour); }
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

        public static void updateTour(Tour_DTO tour, int tourId)
        {
            try { TourDAL.updateTour(tour, tourId); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void deleteTour(int tourId)
        {
            try { TourDAL.deleteTour(tourId); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
