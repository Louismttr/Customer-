using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using pjSistematico.Models;
using System;
using System.Runtime.InteropServices;

namespace pjSistematico
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }
        #region Def. Mov

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);
        #endregion

        Customer oCustomer = null;
        private static string id = string.Empty;

        private void CRUD_Load(object sender, EventArgs e)
        {
            Refresh_CRUD();
        }

        private void Refresh_CRUD()
        {
            using (var context = new NorthwindContext())
            {
                var lst = from c in context.Customers
                          orderby c.CustomerId ascending
                          select new
                          {
                              c.CustomerId,
                              c.CompanyName,
                              c.ContactName,
                              c.ContactTitle,
                              c.Address,
                              c.City
                          ,
                              c.Region,
                              c.PostalCode,
                              c.Country,
                              c.Phone,
                              c.Fax
                          };
                dgvCustomer.DataSource = lst.ToList();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    txtId.Text = row.Cells[0].Value?.ToString()!;
                    txtCompanyN.Text = row.Cells[1].Value?.ToString()!;
                    txtContactN.Text = row.Cells[2].Value?.ToString()!;
                    txtContactT.Text = row.Cells[3].Value?.ToString()!;
                    txtAdres.Text = row.Cells[4].Value?.ToString()!;
                    txtCity.Text = row.Cells[5].Value?.ToString()!;
                    txtRegion.Text = row.Cells[6].Value?.ToString()!;
                    txtPostalC.Text = row.Cells[7].Value?.ToString()!;
                    txtCountr.Text = row.Cells[8].Value?.ToString()!;
                    txtPhone.Text = row.Cells[9].Value?.ToString()!;
                    txtFax.Text = row.Cells[10].Value?.ToString()!;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindContext())
            {

                if (ValidarTextBoxes(this))
                {
                    var cus = new Customer
                    {

                        CustomerId = txtId.Text,
                        CompanyName = txtCompanyN.Text,
                        ContactName = txtContactN.Text,
                        ContactTitle = txtContactT.Text,
                        Address = txtAdres.Text,
                        City = txtCity.Text,
                        Region = txtRegion.Text,
                        PostalCode = txtPostalC.Text,
                        Country = txtCountr.Text,
                        Phone = txtPhone.Text,
                        Fax = txtFax.Text
                    };
                    context.Customers.Add(cus);
                    context.SaveChanges();

                    MessageBox.Show("Se registrado correctamente ", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var customers = context.Customers.ToList();
                    dgvCustomer.DataSource = customers;
                    Limpiar();
                    Refresh_CRUD();
                }
                else
                {
                    MessageBox.Show("Llene todos los campos de forma correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtCompanyN.Clear();
            txtContactN.Clear();
            txtContactT.Clear();
            txtAdres.Clear();
            txtCity.Clear();
            txtRegion.Clear();
            txtPostalC.Clear();
            txtCountr.Clear();
            txtPhone.Clear();
            txtFax.Clear();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindContext())
            {

                var cus = new Customer
                {

                    CustomerId = txtId.Text,
                    CompanyName = txtCompanyN.Text,
                    ContactName = txtContactN.Text,
                    ContactTitle = txtContactT.Text,
                    Address = txtAdres.Text,
                    City = txtCity.Text,
                    Region = txtRegion.Text,
                    PostalCode = txtPostalC.Text,
                    Country = txtCountr.Text,
                    Phone = txtPhone.Text,
                    Fax = txtFax.Text

                };
                context.Entry(cus).State = EntityState.Modified;
                context.SaveChanges();
                Limpiar();
                MessageBox.Show("Registro actualizado");
                Refresh_CRUD();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                using (var context = new NorthwindContext())
                {
                    Customer cr = context.Customers.Find(txtId.Text)!;
                    context.Customers.Remove(cr);
                    context.SaveChanges();
                }
                Limpiar();
                MessageBox.Show("Registro eliminado");
                Refresh_CRUD();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        #region Movilidad
        private void CRUD_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pContiene__MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Botones del pContenedor
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
        #endregion


        #region Validaciones-Vacio
        private void txtId_Validated(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                errorP.SetError(txtId, "Parámetro obligatorio!");
                txtId.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtCompanyN_Validated(object sender, EventArgs e)
        {
            if (txtCompanyN.Text.Trim() == "")
            {
                errorP.SetError(txtCompanyN, "Parámetro obligatorio!");
                txtCompanyN.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtContactN_Validated(object sender, EventArgs e)
        {
            if (txtContactN.Text.Trim() == "")
            {
                errorP.SetError(txtContactN, "Parámetro obligatorio!");
                txtContactN.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtContactT_Validated(object sender, EventArgs e)
        {
            if (txtContactT.Text.Trim() == "")
            {
                errorP.SetError(txtContactT, "Parámetro obligatorio!");
                txtContactT.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtAdres_Validated(object sender, EventArgs e)
        {
            if (txtAdres.Text.Trim() == "")
            {
                errorP.SetError(txtAdres, "Parámetro obligatorio!");
                txtAdres.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim() == "")
            {
                errorP.SetError(txtCity, "Parámetro obligatorio!");
                txtCity.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtRegion_Validated(object sender, EventArgs e)
        {
            if (txtRegion.Text.Trim() == "")
            {
                errorP.SetError(txtRegion, "Parámetro obligatorio!");
                txtRegion.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtPostalC_Validated(object sender, EventArgs e)
        {
            if (txtPostalC.Text.Trim() == "")
            {
                errorP.SetError(txtPostalC, "Parámetro obligatorio!");
                txtPostalC.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }
        private void txtCountr_Validated(object sender, EventArgs e)
        {

            if (txtCountr.Text.Trim() == "")
            {
                errorP.SetError(txtCountr, "Parámetro obligatorio!");
                txtCountr.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {

            if (txtPhone.Text.Trim() == "")
            {
                errorP.SetError(txtPhone, "Parámetro obligatorio!");
                txtPhone.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtFax_Validated(object sender, EventArgs e)
        {
            if (txtFax.Text.Trim() == "")
            {
                errorP.SetError(txtFax, "Parámetro obligatorio!");
                txtFax.Focus();
            }
            else
            {
                errorP.Clear();
            }
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

        #endregion
    }
}