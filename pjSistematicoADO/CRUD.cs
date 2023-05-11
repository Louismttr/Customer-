using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace pjSistematicoADO
{
    public partial class CRUD : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public CRUD()
        {
            InitializeComponent();
            GetCustomer();
        }
        #region Def. Mov

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);
        #endregion

        #region Botones del panel
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Movilidad
        private void CRUD_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pContiene_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void GetCustomer()
        {
            string queryString = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax " +
                                 "FROM Customers ORDER BY CompanyName ASC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvCustomer.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                txtId.Text = row.Cells["CustomerID"].Value.ToString();
                txtCompanyN.Text = row.Cells["CompanyName"].Value.ToString();
                txtContactN.Text = row.Cells["ContactName"].Value.ToString();
                txtContactT.Text = row.Cells["ContactTitle"].Value.ToString();
                txtAdres.Text = row.Cells["Address"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtRegion.Text = row.Cells["Region"].Value.ToString();
                txtPostalC.Text = row.Cells["PostalCode"].Value.ToString();
                txtCountr.Text = row.Cells["Country"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtFax.Text = row.Cells["Fax"].Value.ToString();
            }
        }

        private void InsertClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "INSERT INTO Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)" +
                    "VALUES('" + txtId.Text + "', '" + txtCompanyN.Text + "', '" + txtContactN.Text + "', '" + txtContactT.Text + "', '"
                    + txtAdres.Text + "', '" + txtCity.Text + "', '" + txtRegion.Text + "', '" + txtPostalC.Text + "', '" + txtCountr.Text + "', '"
                    + txtPhone.Text + "', '" + txtFax.Text + "')";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado correctamente");
                    LimpiarTxt(this);
                    GetCustomer();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LimpiarTxt(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    LimpiarTxt(c);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxes(this))
            {
                InsertClientes();
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region validaciones


        private void txtId_Validated(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                pError.SetError(txtId, "Campos Vacios, Ingrese los datos...");
                txtId.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtCompanyN_Validated(object sender, EventArgs e)
        {
            if (txtCompanyN.Text.Trim() == "")
            {
                pError.SetError(txtCompanyN, "Campos Vacios, Ingrese los datos...");
                txtCompanyN.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtContactN_Validated(object sender, EventArgs e)
        {
            if (txtContactN.Text.Trim() == "")
            {
                pError.SetError(txtContactN, "Campos Vacios, Ingrese los datos...");
                txtContactN.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtContactT_Validated(object sender, EventArgs e)
        {
            if (txtContactT.Text.Trim() == "")
            {
                pError.SetError(txtContactT, "Campos Vacios, Ingrese los datos...");
                txtContactT.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtAdres_Validated(object sender, EventArgs e)
        {
            if (txtAdres.Text.Trim() == "")
            {
                pError.SetError(txtAdres, "Campos Vacios, Ingrese los datos...");
                txtAdres.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim() == "")
            {
                pError.SetError(txtCity, "Campos Vacios, Ingrese los datos...");
                txtCity.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtRegion_Validated(object sender, EventArgs e)
        {
            if (txtRegion.Text.Trim() == "")
            {
                pError.SetError(txtRegion, "Campos Vacios, Ingrese los datos...");
                txtRegion.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtPostalC_Validated(object sender, EventArgs e)
        {
            if (txtPostalC.Text.Trim() == "")
            {
                pError.SetError(txtPostalC, "Campos Vacios, Ingrese los datos...");
                txtPostalC.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtCountr_Validated(object sender, EventArgs e)
        {
            if (txtCountr.Text.Trim() == "")
            {
                pError.SetError(txtCountr, "Campos Vacios, Ingrese los datos...");
                txtCountr.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim() == "")
            {
                pError.SetError(txtPhone, "Campos Vacios, Ingrese los datos...");
                txtPhone.Focus();
            }
            else { pError.Clear(); }
        }

        private void txtFax_Validated(object sender, EventArgs e)
        {
            if (txtFax.Text.Trim() == "")
            {
                pError.SetError(txtFax, "Campos Vacios, Ingrese los datos...");
                txtFax.Focus();
            }
            else { pError.Clear(); }
        }

        public bool ValidarTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        return false;
                    }
                }
                if (c.HasChildren)
                {
                    if (!ValidarTextBoxes(c))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClients();
        }

        private void DeleteClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "DELETE FROM Customers WHERE CustomerID = '" + txtId.Text + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente eliminado correctamente");
                    LimpiarTxt(this);
                    GetCustomer();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxes(this))
            {
                UpdateClients();
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "UPDATE Customers SET CompanyName = '" + txtCompanyN.Text
                        + "', ContactName = '" + txtContactN.Text + "', ContactTitle = '" + txtContactT.Text + "', Address = '" + txtAdres.Text + "', " +
                        "City = '" + txtCity.Text + "', Region = '" + txtRegion.Text + "', PostalCode = '" + txtPostalC.Text + "', Country = '" + txtCountr.Text + "', " +
                        "Phone = '" + txtPhone.Text + "', Fax = '" + txtFax.Text + "' WHERE CustomerID = '" + txtId.Text + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado correctamente");
                    LimpiarTxt(this);
                    GetCustomer();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarTxt(this);
        }
    }
}
