using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOUR_MANAGERMENT.BLL_Business_Logic_Layer;

namespace TOUR_MANAGERMENT.View
{
    public partial class CustomerManagerment : Form
    {
        public CustomerManagerment()
        {
            InitializeComponent();
        }

        private void CustomerManagerment_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=CustomerBLL.findAllCustomerData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
