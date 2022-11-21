
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.TxtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbCountry = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbCity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtDirection = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.LblId = new System.Windows.Forms.Label();
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
            // TxtFirstName
            // 
            this.TxtFirstName.BorderColor = System.Drawing.Color.LightGray;
            this.TxtFirstName.BorderRadius = 5;
            this.TxtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFirstName.DefaultText = "";
            this.TxtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFirstName.DisabledState.Parent = this.TxtFirstName;
            this.TxtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFirstName.FocusedState.Parent = this.TxtFirstName;
            this.TxtFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.TxtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFirstName.HoverState.Parent = this.TxtFirstName;
            this.TxtFirstName.Location = new System.Drawing.Point(131, 121);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.PasswordChar = '\0';
            this.TxtFirstName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtFirstName.PlaceholderText = "Fisrt Name";
            this.TxtFirstName.SelectedText = "";
            this.TxtFirstName.ShadowDecoration.Parent = this.TxtFirstName;
            this.TxtFirstName.Size = new System.Drawing.Size(242, 32);
            this.TxtFirstName.TabIndex = 1;
            // 
            // CmbCountry
            // 
            this.CmbCountry.BackColor = System.Drawing.Color.Transparent;
            this.CmbCountry.BorderColor = System.Drawing.Color.LightGray;
            this.CmbCountry.BorderRadius = 8;
            this.CmbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCountry.FocusedColor = System.Drawing.Color.Empty;
            this.CmbCountry.FocusedState.Parent = this.CmbCountry;
            this.CmbCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbCountry.FormattingEnabled = true;
            this.CmbCountry.HoverState.Parent = this.CmbCountry;
            this.CmbCountry.ItemHeight = 30;
            this.CmbCountry.Items.AddRange(new object[] {
            "Republica Dominicana"});
            this.CmbCountry.ItemsAppearance.Parent = this.CmbCountry;
            this.CmbCountry.Location = new System.Drawing.Point(26, 262);
            this.CmbCountry.Name = "CmbCountry";
            this.CmbCountry.ShadowDecoration.Parent = this.CmbCountry;
            this.CmbCountry.Size = new System.Drawing.Size(217, 36);
            this.CmbCountry.TabIndex = 6;
            // 
            // CmbCity
            // 
            this.CmbCity.BackColor = System.Drawing.Color.Transparent;
            this.CmbCity.BorderColor = System.Drawing.Color.LightGray;
            this.CmbCity.BorderRadius = 8;
            this.CmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FocusedColor = System.Drawing.Color.Empty;
            this.CmbCity.FocusedState.Parent = this.CmbCity;
            this.CmbCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.HoverState.Parent = this.CmbCity;
            this.CmbCity.ItemHeight = 30;
            this.CmbCity.Items.AddRange(new object[] {
            "San Cristobal",
            "Santiago",
            "Santo Domingo",
            "Monseñor Noel",
            "",
            ""});
            this.CmbCity.ItemsAppearance.Parent = this.CmbCity;
            this.CmbCity.Location = new System.Drawing.Point(257, 262);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.ShadowDecoration.Parent = this.CmbCity;
            this.CmbCity.Size = new System.Drawing.Size(217, 36);
            this.CmbCity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(100, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(352, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "City";
            // 
            // TxtLastName
            // 
            this.TxtLastName.BorderColor = System.Drawing.Color.LightGray;
            this.TxtLastName.BorderRadius = 5;
            this.TxtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLastName.DefaultText = "";
            this.TxtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLastName.DisabledState.Parent = this.TxtLastName;
            this.TxtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLastName.FocusedState.Parent = this.TxtLastName;
            this.TxtLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.TxtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLastName.HoverState.Parent = this.TxtLastName;
            this.TxtLastName.Location = new System.Drawing.Point(131, 175);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.PasswordChar = '\0';
            this.TxtLastName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtLastName.PlaceholderText = "Last Name";
            this.TxtLastName.SelectedText = "";
            this.TxtLastName.ShadowDecoration.Parent = this.TxtLastName;
            this.TxtLastName.Size = new System.Drawing.Size(242, 32);
            this.TxtLastName.TabIndex = 10;
            // 
            // TxtPhone
            // 
            this.TxtPhone.BorderColor = System.Drawing.Color.LightGray;
            this.TxtPhone.BorderRadius = 5;
            this.TxtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPhone.DefaultText = "";
            this.TxtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhone.DisabledState.Parent = this.TxtPhone;
            this.TxtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPhone.FocusedState.Parent = this.TxtPhone;
            this.TxtPhone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPhone.HoverState.Parent = this.TxtPhone;
            this.TxtPhone.Location = new System.Drawing.Point(131, 369);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.PasswordChar = '\0';
            this.TxtPhone.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtPhone.PlaceholderText = "Phone";
            this.TxtPhone.SelectedText = "";
            this.TxtPhone.ShadowDecoration.Parent = this.TxtPhone;
            this.TxtPhone.Size = new System.Drawing.Size(242, 32);
            this.TxtPhone.TabIndex = 11;
            // 
            // TxtDirection
            // 
            this.TxtDirection.BorderColor = System.Drawing.Color.LightGray;
            this.TxtDirection.BorderRadius = 5;
            this.TxtDirection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDirection.DefaultText = "";
            this.TxtDirection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDirection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDirection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDirection.DisabledState.Parent = this.TxtDirection;
            this.TxtDirection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDirection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDirection.FocusedState.Parent = this.TxtDirection;
            this.TxtDirection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirection.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDirection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDirection.HoverState.Parent = this.TxtDirection;
            this.TxtDirection.Location = new System.Drawing.Point(131, 319);
            this.TxtDirection.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDirection.Name = "TxtDirection";
            this.TxtDirection.PasswordChar = '\0';
            this.TxtDirection.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtDirection.PlaceholderText = "Direction";
            this.TxtDirection.SelectedText = "";
            this.TxtDirection.ShadowDecoration.Parent = this.TxtDirection;
            this.TxtDirection.Size = new System.Drawing.Size(242, 32);
            this.TxtDirection.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
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
            this.BtnSave.Location = new System.Drawing.Point(257, 454);
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
            this.BtnCancel.Location = new System.Drawing.Point(51, 454);
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
            // AddAndEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 538);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDirection);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCity);
            this.Controls.Add(this.CmbCountry);
            this.Controls.Add(this.TxtFirstName);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal Guna.UI2.WinForms.Guna2TextBox TxtFirstName;
        protected internal Guna.UI2.WinForms.Guna2ComboBox CmbCountry;
        protected internal Guna.UI2.WinForms.Guna2ComboBox CmbCity;
        protected internal Guna.UI2.WinForms.Guna2TextBox TxtLastName;
        protected internal Guna.UI2.WinForms.Guna2TextBox TxtPhone;
        protected internal Guna.UI2.WinForms.Guna2TextBox TxtDirection;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnCancel;
        internal System.Windows.Forms.Label LblId;
    }
}