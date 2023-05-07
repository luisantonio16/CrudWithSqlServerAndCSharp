
namespace Presentation.FormsPrincipal
{
    partial class AddAndEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditPerson));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel1.Controls.Add(this.BtnClose);
            this.guna2Panel1.Controls.Add(this.LblTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(486, 75);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(436, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(38, 32);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(159, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(170, 32);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Add Persons";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderColor = System.Drawing.Color.LightGray;
            this.TxtNombre.BorderRadius = 5;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.DefaultText = "";
            this.TxtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.DisabledState.Parent = this.TxtNombre;
            this.TxtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.FocusedState.Parent = this.TxtNombre;
            this.TxtNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.HoverState.Parent = this.TxtNombre;
            this.TxtNombre.Location = new System.Drawing.Point(113, 173);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtNombre.PlaceholderText = "Nombre";
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.ShadowDecoration.Parent = this.TxtNombre;
            this.TxtNombre.Size = new System.Drawing.Size(274, 32);
            this.TxtNombre.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 10);
            this.panel1.TabIndex = 13;
            // 
            // BtnSave
            // 
            this.BtnSave.BorderRadius = 15;
            this.BtnSave.CheckedState.Parent = this.BtnSave;
            this.BtnSave.CustomImages.Parent = this.BtnSave;
            this.BtnSave.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.HoverState.Parent = this.BtnSave;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnSave.Location = new System.Drawing.Point(252, 400);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
            this.BtnSave.Size = new System.Drawing.Size(180, 45);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BorderRadius = 15;
            this.BtnCancel.CheckedState.Parent = this.BtnCancel;
            this.BtnCancel.CustomImages.Parent = this.BtnCancel;
            this.BtnCancel.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.HoverState.Parent = this.BtnCancel;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnCancel.Location = new System.Drawing.Point(32, 400);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.ShadowDecoration.Parent = this.BtnCancel;
            this.BtnCancel.Size = new System.Drawing.Size(180, 45);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.Gray;
            this.LblId.Location = new System.Drawing.Point(12, 81);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 18);
            this.LblId.TabIndex = 16;
            this.LblId.Text = "id";
            // 
            // TxtFecha
            // 
            this.TxtFecha.BorderColor = System.Drawing.Color.DimGray;
            this.TxtFecha.BorderThickness = 1;
            this.TxtFecha.CheckedState.Parent = this.TxtFecha;
            this.TxtFecha.FillColor = System.Drawing.Color.White;
            this.TxtFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TxtFecha.HoverState.Parent = this.TxtFecha;
            this.TxtFecha.Location = new System.Drawing.Point(110, 255);
            this.TxtFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TxtFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.ShadowDecoration.Parent = this.TxtFecha;
            this.TxtFecha.Size = new System.Drawing.Size(274, 36);
            this.TxtFecha.TabIndex = 17;
            this.TxtFecha.Value = new System.DateTime(2023, 5, 6, 14, 59, 36, 663);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(209, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(178, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // AddAndEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAndEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddAndEditPerson_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox BtnClose;
        internal System.Windows.Forms.Label LblTitle;
        protected internal Guna.UI2.WinForms.Guna2TextBox TxtNombre;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnCancel;
        internal System.Windows.Forms.Label LblId;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal Guna.UI2.WinForms.Guna2DateTimePicker TxtFecha;
    }
}