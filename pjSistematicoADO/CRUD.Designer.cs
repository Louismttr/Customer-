namespace pjSistematicoADO
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            btnExit = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            pContiene = new Panel();
            dgvCustomer = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtCompanyN = new TextBox();
            label3 = new Label();
            txtContactN = new TextBox();
            txtCountr = new TextBox();
            label11 = new Label();
            label4 = new Label();
            txtFax = new TextBox();
            txtPhone = new TextBox();
            txtContactT = new TextBox();
            label5 = new Label();
            txtPostalC = new TextBox();
            label10 = new Label();
            txtAdres = new TextBox();
            txtRegion = new TextBox();
            label6 = new Label();
            label = new Label();
            txtCity = new TextBox();
            label8 = new Label();
            label7 = new Label();
            pError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            pContiene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pError).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.Cerrar;
            btnExit.Location = new Point(855, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.Maximizar;
            btnMaximizar.Location = new Point(800, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(40, 40);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.Minimizar;
            btnMinimizar.Location = new Point(736, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 40);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // pContiene
            // 
            pContiene.BackColor = Color.FromArgb(0, 126, 176);
            pContiene.Controls.Add(btnExit);
            pContiene.Controls.Add(btnMinimizar);
            pContiene.Controls.Add(btnMaximizar);
            pContiene.Dock = DockStyle.Top;
            pContiene.Location = new Point(0, 0);
            pContiene.Name = "pContiene";
            pContiene.Size = new Size(913, 50);
            pContiene.TabIndex = 3;
            pContiene.MouseDown += pContiene_MouseDown;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.BackgroundColor = Color.FromArgb(10, 40, 60);
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(10, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 40, 60);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.Location = new Point(21, 333);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(10, 40, 60);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(10, 40, 60);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomer.RowTemplate.Height = 25;
            dgvCustomer.Size = new Size(866, 315);
            dgvCustomer.TabIndex = 4;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Right;
            btnAdd.BackColor = Color.DimGray;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(767, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 55);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Right;
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(767, 142);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 55);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Modificar";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(767, 203);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 55);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.BackColor = Color.DimGray;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(767, 264);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 55);
            btnClear.TabIndex = 9;
            btnClear.Text = "Limpiar";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCompanyN);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtContactN);
            groupBox1.Controls.Add(txtCountr);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFax);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtContactT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPostalC);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(txtRegion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(21, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 250);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.DimGray;
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(35, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(145, 23);
            txtId.TabIndex = 12;
            txtId.KeyPress += SoloLetras;
            txtId.Validated += txtId_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "Company Name:";
            // 
            // txtCompanyN
            // 
            txtCompanyN.BackColor = Color.DimGray;
            txtCompanyN.ForeColor = Color.White;
            txtCompanyN.Location = new Point(117, 61);
            txtCompanyN.Name = "txtCompanyN";
            txtCompanyN.Size = new Size(197, 23);
            txtCompanyN.TabIndex = 13;
            txtCompanyN.KeyPress += SoloLetras;
            txtCompanyN.Validated += txtCompanyN_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 3;
            label3.Text = "Contact Name:";
            // 
            // txtContactN
            // 
            txtContactN.BackColor = Color.DimGray;
            txtContactN.ForeColor = Color.White;
            txtContactN.Location = new Point(117, 101);
            txtContactN.Name = "txtContactN";
            txtContactN.Size = new Size(197, 23);
            txtContactN.TabIndex = 14;
            txtContactN.KeyPress += SoloLetras;
            txtContactN.Validated += txtContactN_Validated;
            // 
            // txtCountr
            // 
            txtCountr.BackColor = Color.DimGray;
            txtCountr.ForeColor = Color.White;
            txtCountr.Location = new Point(471, 138);
            txtCountr.Name = "txtCountr";
            txtCountr.Size = new Size(233, 23);
            txtCountr.TabIndex = 20;
            txtCountr.KeyPress += SoloLetras;
            txtCountr.Validated += txtCountr_Validated;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(378, 221);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 11;
            label11.Text = "Fax:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 146);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 4;
            label4.Text = "Contact Title:";
            // 
            // txtFax
            // 
            txtFax.BackColor = Color.DimGray;
            txtFax.ForeColor = Color.White;
            txtFax.Location = new Point(471, 213);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(233, 23);
            txtFax.TabIndex = 22;
            txtFax.KeyPress += SoloNumeros;
            txtFax.Validated += txtFax_Validated;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.DimGray;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(471, 176);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(233, 23);
            txtPhone.TabIndex = 21;
            txtPhone.KeyPress += SoloNumeros;
            txtPhone.Validated += txtPhone_Validated;
            // 
            // txtContactT
            // 
            txtContactT.BackColor = Color.DimGray;
            txtContactT.ForeColor = Color.White;
            txtContactT.Location = new Point(117, 146);
            txtContactT.Name = "txtContactT";
            txtContactT.Size = new Size(236, 23);
            txtContactT.TabIndex = 15;
            txtContactT.KeyPress += SoloLetras;
            txtContactT.Validated += txtContactT_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 195);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 5;
            label5.Text = "Address:";
            // 
            // txtPostalC
            // 
            txtPostalC.BackColor = Color.DimGray;
            txtPostalC.ForeColor = Color.White;
            txtPostalC.Location = new Point(471, 101);
            txtPostalC.Name = "txtPostalC";
            txtPostalC.Size = new Size(233, 23);
            txtPostalC.TabIndex = 19;
            txtPostalC.KeyPress += SoloNumeros;
            txtPostalC.Validated += txtPostalC_Validated;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(378, 184);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 10;
            label10.Text = "Phone:";
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.DimGray;
            txtAdres.ForeColor = Color.White;
            txtAdres.Location = new Point(99, 192);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(233, 23);
            txtAdres.TabIndex = 16;
            txtAdres.KeyPress += SoloLetras;
            txtAdres.Validated += txtAdres_Validated;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = Color.DimGray;
            txtRegion.ForeColor = Color.White;
            txtRegion.Location = new Point(471, 53);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(233, 23);
            txtRegion.TabIndex = 18;
            txtRegion.KeyPress += SoloLetras;
            txtRegion.Validated += txtRegion_Validated;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 18);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 6;
            label6.Text = "City:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(378, 141);
            label.Name = "label";
            label.Size = new Size(53, 15);
            label.TabIndex = 8;
            label.Text = "Country:";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.DimGray;
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(471, 15);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(233, 23);
            txtCity.TabIndex = 17;
            txtCity.KeyPress += SoloLetras;
            txtCity.Validated += txtCity_Validated;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(373, 104);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 8;
            label8.Text = "Postal Code:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 61);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 7;
            label7.Text = "Region:";
            // 
            // pError
            // 
            pError.ContainerControl = this;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 40, 60);
            ClientSize = new Size(913, 660);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomer);
            Controls.Add(pContiene);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CRUD";
            Text = "CRUD";
            MouseDown += CRUD_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            pContiene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnExit;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private Panel pContiene;
        private DataGridView dgvCustomer;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtCompanyN;
        private Label label3;
        private TextBox txtContactN;
        private TextBox txtCountr;
        private Label label11;
        private Label label4;
        private TextBox txtFax;
        private TextBox txtPhone;
        private TextBox txtContactT;
        private Label label5;
        private TextBox txtPostalC;
        private Label label10;
        private TextBox txtAdres;
        private TextBox txtRegion;
        private Label label6;
        private Label label;
        private TextBox txtCity;
        private Label label8;
        private Label label7;
        private ErrorProvider pError;
    }
}