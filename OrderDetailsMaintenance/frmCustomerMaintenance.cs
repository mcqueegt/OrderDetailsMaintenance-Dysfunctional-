using OrderDetailsMaintenance.Models.DataLayer;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        private NorthwindContext _context;
        private Customer _customer;
        public string id;
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        //Gavin McQueen
        private void btnFind_Click(object sender, EventArgs e)
        {
            _context = new NorthwindContext();
            id = txtCustomerId.Text;
            _customer = _context.Customers.Find(id); //I don't know how to fix this
            if (_customer != null)
            {
                txtContact.Text = _customer.ContactName;
                txtAddress.Text = _customer.Address;
                txtCity.Text = _customer.City;
                txtCountry.Text = _customer.Country;
            }
            else
            {
                MessageBox.Show("Customer not found.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Gavin McQueen
        private void btnSave_Click(object sender, EventArgs e)
        {
            _customer.ContactName = txtContact.Text;
            _customer.Address = txtAddress.Text;
            _customer.City = txtCity.Text;
            _customer.Country = txtCountry.Text;
            _context.SaveChanges();
        }
    }
}