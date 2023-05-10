namespace pjSistematico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pContiene_ = new Panel();
            btnMinizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtId = new TextBox();
            txtCompanyN = new TextBox();
            txtContactN = new TextBox();
            txtContactT = new TextBox();
            txtAdres = new TextBox();
            txtCity = new TextBox();
            txtRegion = new TextBox();
            txtPostalC = new TextBox();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            txtFax = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvCustomer = new DataGridView();
            groupBox1 = new GroupBox();
            errorP = new ErrorProvider(components);
            pContiene_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorP).BeginInit();
            SuspendLayout();
            // 
            // pContiene_
            // 
            pContiene_.BackColor = Color.FromArgb(10, 59, 54);
            pContiene_.Controls.Add(btnMinizar);
            pContiene_.Controls.Add(btnMaximizar);
            pContiene_.Controls.Add(btnCerrar);
            pContiene_.Dock = DockStyle.Top;
            pContiene_.Location = new Point(0, 0);
            pContiene_.Name = "pContiene_";
            pContiene_.Size = new Size(850, 49);
            pContiene_.TabIndex = 0;
            pContiene_.MouseDown += pContiene__MouseDown;
            // 
            // btnMinizar
            // 
            btnMinizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMinizar.Cursor = Cursors.Hand;
            btnMinizar.Image = (Image)resources.GetObject("btnMinizar.Image");
            btnMinizar.Location = new Point(683, 3);
            btnMinizar.Name = "btnMinizar";
            btnMinizar.Size = new Size(40, 40);
            btnMinizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinizar.TabIndex = 2;
            btnMinizar.TabStop = false;
            btnMinizar.Click += btnMinizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(742, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(40, 40);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = pjSistematicoEF.Properties.Resources.Cerrar;
            btnCerrar.Location = new Point(795, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 2;
            label2.Text = "Company Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 3;
            label3.Text = "Contact Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 146);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 4;
            label4.Text = "Contact Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 195);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 5;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 18);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 6;
            label6.Text = "City:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(373, 69);
            label7.Name = "label7";
            label7.Size = new Size(52, 17);
            label7.TabIndex = 7;
            label7.Text = "Region:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(373, 109);
            label8.Name = "label8";
            label8.Size = new Size(81, 17);
            label8.TabIndex = 8;
            label8.Text = "Postal Code:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(461, 219);
            label9.Name = "label9";
            label9.Size = new Size(56, 17);
            label9.TabIndex = 9;
            label9.Text = "Country:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(378, 149);
            label10.Name = "label10";
            label10.Size = new Size(47, 17);
            label10.TabIndex = 10;
            label10.Text = "Phone:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(378, 195);
            label11.Name = "label11";
            label11.Size = new Size(30, 17);
            label11.TabIndex = 11;
            label11.Text = "Fax:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.DimGray;
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(35, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(145, 25);
            txtId.TabIndex = 12;
            txtId.Validated += txtId_Validated;
            // 
            // txtCompanyN
            // 
            txtCompanyN.BackColor = Color.DimGray;
            txtCompanyN.ForeColor = Color.White;
            txtCompanyN.Location = new Point(117, 61);
            txtCompanyN.Name = "txtCompanyN";
            txtCompanyN.Size = new Size(197, 25);
            txtCompanyN.TabIndex = 13;
            txtCompanyN.Validated += txtCompanyN_Validated;
            // 
            // txtContactN
            // 
            txtContactN.BackColor = Color.DimGray;
            txtContactN.ForeColor = Color.White;
            txtContactN.Location = new Point(117, 101);
            txtContactN.Name = "txtContactN";
            txtContactN.Size = new Size(197, 25);
            txtContactN.TabIndex = 14;
            txtContactN.Validated += txtContactN_Validated;
            // 
            // txtContactT
            // 
            txtContactT.BackColor = Color.DimGray;
            txtContactT.ForeColor = Color.White;
            txtContactT.Location = new Point(117, 146);
            txtContactT.Name = "txtContactT";
            txtContactT.Size = new Size(236, 25);
            txtContactT.TabIndex = 15;
            txtContactT.Validated += txtContactT_Validated;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.DimGray;
            txtAdres.ForeColor = Color.White;
            txtAdres.Location = new Point(99, 192);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(233, 25);
            txtAdres.TabIndex = 16;
            txtAdres.Validated += txtAdres_Validated;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.DimGray;
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(471, 15);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(233, 25);
            txtCity.TabIndex = 17;
            txtCity.Validated += txtCity_Validated;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = Color.DimGray;
            txtRegion.ForeColor = Color.White;
            txtRegion.Location = new Point(471, 61);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(233, 25);
            txtRegion.TabIndex = 18;
            txtRegion.Validated += txtRegion_Validated;
            // 
            // txtPostalC
            // 
            txtPostalC.BackColor = Color.DimGray;
            txtPostalC.ForeColor = Color.White;
            txtPostalC.Location = new Point(471, 101);
            txtPostalC.Name = "txtPostalC";
            txtPostalC.Size = new Size(233, 25);
            txtPostalC.TabIndex = 19;
            txtPostalC.Validated += txtPostalC_Validated;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.DimGray;
            txtCountry.ForeColor = Color.White;
            txtCountry.Location = new Point(520, 222);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(126, 25);
            txtCountry.TabIndex = 20;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.DimGray;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(471, 146);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(233, 25);
            txtPhone.TabIndex = 21;
            txtPhone.Validated += txtPhone_Validated;
            // 
            // txtFax
            // 
            txtFax.BackColor = Color.DimGray;
            txtFax.ForeColor = Color.White;
            txtFax.Location = new Point(471, 192);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(233, 25);
            txtFax.TabIndex = 22;
            txtFax.Validated += txtFax_Validated;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left;
            btnAgregar.BackColor = Color.FromArgb(5, 4, 39);
            btnAgregar.CausesValidation = false;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Image = pjSistematicoEF.Properties.Resources.Add;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(12, 654);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 55);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Left;
            btnModificar.BackColor = Color.FromArgb(5, 4, 39);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Image = pjSistematicoEF.Properties.Resources.Edit;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(138, 654);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 55);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(170, 48, 46);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = pjSistematicoEF.Properties.Resources.Delete;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(264, 654);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 55);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Left;
            btnLimpiar.BackColor = Color.FromArgb(170, 48, 46);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Image = pjSistematicoEF.Properties.Resources.Clear;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(393, 654);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 55);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top;
            dgvCustomer.BackgroundColor = Color.FromArgb(15, 15, 15);
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(10, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 54, 59);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.GridColor = Color.DarkGray;
            dgvCustomer.Location = new Point(31, 343);
            dgvCustomer.Name = "dgvCustomer";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 40, 60);
            dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomer.RowTemplate.Height = 25;
            dgvCustomer.Size = new Size(771, 288);
            dgvCustomer.TabIndex = 29;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
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
            groupBox1.Controls.Add(txtFax);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtContactT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPostalC);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(txtRegion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(31, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 242);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // errorP
            // 
            errorP.ContainerControl = this;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(850, 737);
            Controls.Add(groupBox1);
            Controls.Add(dgvCustomer);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCountry);
            Controls.Add(label9);
            Controls.Add(pContiene_);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CRUD";
            Text = "CRUD";
            Load += CRUD_Load;
            MouseDown += CRUD_MouseDown;
            pContiene_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContiene_;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtId;
        private TextBox txtCompanyN;
        private TextBox txtContactN;
        private TextBox txtContactT;
        private TextBox txtAdres;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtPostalC;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private TextBox txtFax;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private PictureBox btnCerrar;
        private PictureBox btnMinizar;
        private PictureBox btnMaximizar;
        private DataGridView dgvCustomer;
        private GroupBox groupBox1;
        private ErrorProvider errorP;
    }
}