namespace HairSlonManagementProject
{
    partial class StaffRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffRecord));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lblActualFee = new System.Windows.Forms.Label();
            this.txtActualFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtCalculate = new Guna.UI2.WinForms.Guna2TextBox();
            this.sb6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sb5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sb4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sb2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sb3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.sb1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboFee6 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboFee5 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboFee4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboFee2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboFee3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboFee1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.serviceList = new System.Windows.Forms.CheckedListBox();
            this.combostyle6 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboService6 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboService5 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combostyle5 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboService4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combostyle4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combostyle3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboService3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboService2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combostyle2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboService1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboStyle1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoYes = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtMember = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMemberLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1237, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(41, 36);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1073, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 51);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(948, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Check Member ID";
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BorderRadius = 1;
            this.datePicker.Color = System.Drawing.Color.Silver;
            this.datePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datePicker.DisabledColor = System.Drawing.Color.Gray;
            this.datePicker.DisplayWeekNumbers = false;
            this.datePicker.DPHeight = 0;
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.FillDatePicker = false;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.ForeColor = System.Drawing.Color.Black;
            this.datePicker.Icon = ((System.Drawing.Image)(resources.GetObject("datePicker.Icon")));
            this.datePicker.IconColor = System.Drawing.Color.Gray;
            this.datePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datePicker.LeftTextMargin = 5;
            this.datePicker.Location = new System.Drawing.Point(890, 12);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(220, 32);
            this.datePicker.TabIndex = 77;
            // 
            // lblActualFee
            // 
            this.lblActualFee.AutoSize = true;
            this.lblActualFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualFee.Location = new System.Drawing.Point(950, 271);
            this.lblActualFee.Name = "lblActualFee";
            this.lblActualFee.Size = new System.Drawing.Size(81, 21);
            this.lblActualFee.TabIndex = 76;
            this.lblActualFee.Text = "Actual Fee";
            this.lblActualFee.Visible = false;
            // 
            // txtActualFee
            // 
            this.txtActualFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualFee.DefaultText = "";
            this.txtActualFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActualFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualFee.DisabledState.Parent = this.txtActualFee;
            this.txtActualFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualFee.FocusedState.Parent = this.txtActualFee;
            this.txtActualFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualFee.HoverState.Parent = this.txtActualFee;
            this.txtActualFee.Location = new System.Drawing.Point(1073, 256);
            this.txtActualFee.Name = "txtActualFee";
            this.txtActualFee.PasswordChar = '\0';
            this.txtActualFee.PlaceholderText = "";
            this.txtActualFee.SelectedText = "";
            this.txtActualFee.ShadowDecoration.Parent = this.txtActualFee;
            this.txtActualFee.Size = new System.Drawing.Size(180, 36);
            this.txtActualFee.TabIndex = 75;
            this.txtActualFee.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(950, 206);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 21);
            this.lblDiscount.TabIndex = 74;
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(1073, 191);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(180, 36);
            this.txtDiscount.TabIndex = 73;
            this.txtDiscount.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(954, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Member";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(1097, 105);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 82;
            // 
            // txtCalculate
            // 
            this.txtCalculate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalculate.DefaultText = "";
            this.txtCalculate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCalculate.DisabledState.Parent = this.txtCalculate;
            this.txtCalculate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCalculate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCalculate.FocusedState.Parent = this.txtCalculate;
            this.txtCalculate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCalculate.HoverState.Parent = this.txtCalculate;
            this.txtCalculate.Location = new System.Drawing.Point(725, 297);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.PasswordChar = '\0';
            this.txtCalculate.PlaceholderText = "";
            this.txtCalculate.SelectedText = "";
            this.txtCalculate.ShadowDecoration.Parent = this.txtCalculate;
            this.txtCalculate.Size = new System.Drawing.Size(159, 36);
            this.txtCalculate.TabIndex = 165;
            // 
            // sb6
            // 
            this.sb6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sb6.DefaultText = "";
            this.sb6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sb6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sb6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb6.DisabledState.Parent = this.sb6;
            this.sb6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb6.FocusedState.Parent = this.sb6;
            this.sb6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb6.HoverState.Parent = this.sb6;
            this.sb6.Location = new System.Drawing.Point(725, 222);
            this.sb6.Name = "sb6";
            this.sb6.PasswordChar = '\0';
            this.sb6.PlaceholderText = "";
            this.sb6.SelectedText = "";
            this.sb6.ShadowDecoration.Parent = this.sb6;
            this.sb6.Size = new System.Drawing.Size(159, 36);
            this.sb6.TabIndex = 164;
            this.sb6.Visible = false;
            // 
            // sb5
            // 
            this.sb5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sb5.DefaultText = "";
            this.sb5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sb5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sb5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb5.DisabledState.Parent = this.sb5;
            this.sb5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb5.FocusedState.Parent = this.sb5;
            this.sb5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb5.HoverState.Parent = this.sb5;
            this.sb5.Location = new System.Drawing.Point(725, 180);
            this.sb5.Name = "sb5";
            this.sb5.PasswordChar = '\0';
            this.sb5.PlaceholderText = "";
            this.sb5.SelectedText = "";
            this.sb5.ShadowDecoration.Parent = this.sb5;
            this.sb5.Size = new System.Drawing.Size(159, 36);
            this.sb5.TabIndex = 163;
            this.sb5.Visible = false;
            // 
            // sb4
            // 
            this.sb4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sb4.DefaultText = "";
            this.sb4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sb4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sb4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb4.DisabledState.Parent = this.sb4;
            this.sb4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb4.FocusedState.Parent = this.sb4;
            this.sb4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb4.HoverState.Parent = this.sb4;
            this.sb4.Location = new System.Drawing.Point(725, 138);
            this.sb4.Name = "sb4";
            this.sb4.PasswordChar = '\0';
            this.sb4.PlaceholderText = "";
            this.sb4.SelectedText = "";
            this.sb4.ShadowDecoration.Parent = this.sb4;
            this.sb4.Size = new System.Drawing.Size(159, 36);
            this.sb4.TabIndex = 162;
            this.sb4.Visible = false;
            // 
            // sb2
            // 
            this.sb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sb2.DefaultText = "";
            this.sb2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sb2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sb2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb2.DisabledState.Parent = this.sb2;
            this.sb2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb2.FocusedState.Parent = this.sb2;
            this.sb2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb2.HoverState.Parent = this.sb2;
            this.sb2.Location = new System.Drawing.Point(725, 54);
            this.sb2.Name = "sb2";
            this.sb2.PasswordChar = '\0';
            this.sb2.PlaceholderText = "";
            this.sb2.SelectedText = "";
            this.sb2.ShadowDecoration.Parent = this.sb2;
            this.sb2.Size = new System.Drawing.Size(159, 36);
            this.sb2.TabIndex = 161;
            this.sb2.Visible = false;
            // 
            // sb3
            // 
            this.sb3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sb3.DefaultText = "";
            this.sb3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sb3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sb3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb3.DisabledState.Parent = this.sb3;
            this.sb3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb3.FocusedState.Parent = this.sb3;
            this.sb3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb3.HoverState.Parent = this.sb3;
            this.sb3.Location = new System.Drawing.Point(725, 96);
            this.sb3.Name = "sb3";
            this.sb3.PasswordChar = '\0';
            this.sb3.PlaceholderText = "";
            this.sb3.SelectedText = "";
            this.sb3.ShadowDecoration.Parent = this.sb3;
            this.sb3.Size = new System.Drawing.Size(159, 36);
            this.sb3.TabIndex = 160;
            this.sb3.Visible = false;
            // 
            // sb1
            // 
            this.sb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sb1.DefaultText = "";
            this.sb1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sb1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb1.DisabledState.Parent = this.sb1;
            this.sb1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sb1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb1.FocusedState.Parent = this.sb1;
            this.sb1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sb1.HoverState.Parent = this.sb1;
            this.sb1.Location = new System.Drawing.Point(725, 12);
            this.sb1.Name = "sb1";
            this.sb1.PasswordChar = '\0';
            this.sb1.PlaceholderText = "";
            this.sb1.SelectedText = "";
            this.sb1.ShadowDecoration.Parent = this.sb1;
            this.sb1.Size = new System.Drawing.Size(159, 36);
            this.sb1.TabIndex = 159;
            // 
            // comboFee6
            // 
            this.comboFee6.BackColor = System.Drawing.Color.Transparent;
            this.comboFee6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFee6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFee6.FocusedColor = System.Drawing.Color.Empty;
            this.comboFee6.FocusedState.Parent = this.comboFee6;
            this.comboFee6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFee6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFee6.FormattingEnabled = true;
            this.comboFee6.HoverState.Parent = this.comboFee6;
            this.comboFee6.ItemHeight = 30;
            this.comboFee6.ItemsAppearance.Parent = this.comboFee6;
            this.comboFee6.Location = new System.Drawing.Point(232, 222);
            this.comboFee6.Name = "comboFee6";
            this.comboFee6.ShadowDecoration.Parent = this.comboFee6;
            this.comboFee6.Size = new System.Drawing.Size(151, 36);
            this.comboFee6.TabIndex = 158;
            this.comboFee6.Visible = false;
            this.comboFee6.SelectedValueChanged += new System.EventHandler(this.ComboFee6_SelectedValueChanged);
            // 
            // comboFee5
            // 
            this.comboFee5.BackColor = System.Drawing.Color.Transparent;
            this.comboFee5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFee5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFee5.FocusedColor = System.Drawing.Color.Empty;
            this.comboFee5.FocusedState.Parent = this.comboFee5;
            this.comboFee5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFee5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFee5.FormattingEnabled = true;
            this.comboFee5.HoverState.Parent = this.comboFee5;
            this.comboFee5.ItemHeight = 30;
            this.comboFee5.ItemsAppearance.Parent = this.comboFee5;
            this.comboFee5.Location = new System.Drawing.Point(232, 180);
            this.comboFee5.Name = "comboFee5";
            this.comboFee5.ShadowDecoration.Parent = this.comboFee5;
            this.comboFee5.Size = new System.Drawing.Size(151, 36);
            this.comboFee5.TabIndex = 157;
            this.comboFee5.Visible = false;
            this.comboFee5.SelectedValueChanged += new System.EventHandler(this.ComboFee5_SelectedValueChanged);
            // 
            // comboFee4
            // 
            this.comboFee4.BackColor = System.Drawing.Color.Transparent;
            this.comboFee4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFee4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFee4.FocusedColor = System.Drawing.Color.Empty;
            this.comboFee4.FocusedState.Parent = this.comboFee4;
            this.comboFee4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFee4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFee4.FormattingEnabled = true;
            this.comboFee4.HoverState.Parent = this.comboFee4;
            this.comboFee4.ItemHeight = 30;
            this.comboFee4.ItemsAppearance.Parent = this.comboFee4;
            this.comboFee4.Location = new System.Drawing.Point(232, 138);
            this.comboFee4.Name = "comboFee4";
            this.comboFee4.ShadowDecoration.Parent = this.comboFee4;
            this.comboFee4.Size = new System.Drawing.Size(151, 36);
            this.comboFee4.TabIndex = 156;
            this.comboFee4.Visible = false;
            this.comboFee4.SelectedValueChanged += new System.EventHandler(this.ComboFee4_SelectedValueChanged);
            // 
            // comboFee2
            // 
            this.comboFee2.BackColor = System.Drawing.Color.Transparent;
            this.comboFee2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFee2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFee2.FocusedColor = System.Drawing.Color.Empty;
            this.comboFee2.FocusedState.Parent = this.comboFee2;
            this.comboFee2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFee2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFee2.FormattingEnabled = true;
            this.comboFee2.HoverState.Parent = this.comboFee2;
            this.comboFee2.ItemHeight = 30;
            this.comboFee2.ItemsAppearance.Parent = this.comboFee2;
            this.comboFee2.Location = new System.Drawing.Point(232, 54);
            this.comboFee2.Name = "comboFee2";
            this.comboFee2.ShadowDecoration.Parent = this.comboFee2;
            this.comboFee2.Size = new System.Drawing.Size(151, 36);
            this.comboFee2.TabIndex = 155;
            this.comboFee2.Visible = false;
            this.comboFee2.SelectedValueChanged += new System.EventHandler(this.ComboFee2_SelectedValueChanged);
            // 
            // comboFee3
            // 
            this.comboFee3.BackColor = System.Drawing.Color.Transparent;
            this.comboFee3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFee3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFee3.FocusedColor = System.Drawing.Color.Empty;
            this.comboFee3.FocusedState.Parent = this.comboFee3;
            this.comboFee3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFee3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFee3.FormattingEnabled = true;
            this.comboFee3.HoverState.Parent = this.comboFee3;
            this.comboFee3.ItemHeight = 30;
            this.comboFee3.ItemsAppearance.Parent = this.comboFee3;
            this.comboFee3.Location = new System.Drawing.Point(232, 96);
            this.comboFee3.Name = "comboFee3";
            this.comboFee3.ShadowDecoration.Parent = this.comboFee3;
            this.comboFee3.Size = new System.Drawing.Size(151, 36);
            this.comboFee3.TabIndex = 154;
            this.comboFee3.Visible = false;
            this.comboFee3.SelectedValueChanged += new System.EventHandler(this.ComboFee3_SelectedValueChanged);
            // 
            // comboFee1
            // 
            this.comboFee1.BackColor = System.Drawing.Color.Transparent;
            this.comboFee1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFee1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFee1.FocusedColor = System.Drawing.Color.Empty;
            this.comboFee1.FocusedState.Parent = this.comboFee1;
            this.comboFee1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFee1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFee1.FormattingEnabled = true;
            this.comboFee1.HoverState.Parent = this.comboFee1;
            this.comboFee1.ItemHeight = 30;
            this.comboFee1.ItemsAppearance.Parent = this.comboFee1;
            this.comboFee1.Location = new System.Drawing.Point(232, 12);
            this.comboFee1.Name = "comboFee1";
            this.comboFee1.ShadowDecoration.Parent = this.comboFee1;
            this.comboFee1.Size = new System.Drawing.Size(151, 36);
            this.comboFee1.TabIndex = 153;
            this.comboFee1.SelectedValueChanged += new System.EventHandler(this.ComboFee1_SelectedValueChanged);
            // 
            // serviceList
            // 
            this.serviceList.CheckOnClick = true;
            this.serviceList.FormattingEnabled = true;
            this.serviceList.Location = new System.Drawing.Point(22, 12);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(204, 199);
            this.serviceList.TabIndex = 152;
            this.serviceList.ThreeDCheckBoxes = true;
            this.serviceList.SelectedIndexChanged += new System.EventHandler(this.ServiceList_SelectedIndexChanged);
            // 
            // combostyle6
            // 
            this.combostyle6.BackColor = System.Drawing.Color.Transparent;
            this.combostyle6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combostyle6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostyle6.FocusedColor = System.Drawing.Color.Empty;
            this.combostyle6.FocusedState.Parent = this.combostyle6;
            this.combostyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combostyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combostyle6.FormattingEnabled = true;
            this.combostyle6.HoverState.Parent = this.combostyle6;
            this.combostyle6.ItemHeight = 30;
            this.combostyle6.ItemsAppearance.Parent = this.combostyle6;
            this.combostyle6.Location = new System.Drawing.Point(557, 222);
            this.combostyle6.Name = "combostyle6";
            this.combostyle6.ShadowDecoration.Parent = this.combostyle6;
            this.combostyle6.Size = new System.Drawing.Size(162, 36);
            this.combostyle6.TabIndex = 151;
            this.combostyle6.Visible = false;
            this.combostyle6.SelectedValueChanged += new System.EventHandler(this.Combostyle6_SelectedValueChanged);
            // 
            // comboService6
            // 
            this.comboService6.BackColor = System.Drawing.Color.Transparent;
            this.comboService6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboService6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService6.FocusedColor = System.Drawing.Color.Empty;
            this.comboService6.FocusedState.Parent = this.comboService6;
            this.comboService6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboService6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboService6.FormattingEnabled = true;
            this.comboService6.HoverState.Parent = this.comboService6;
            this.comboService6.ItemHeight = 30;
            this.comboService6.ItemsAppearance.Parent = this.comboService6;
            this.comboService6.Location = new System.Drawing.Point(389, 222);
            this.comboService6.Name = "comboService6";
            this.comboService6.ShadowDecoration.Parent = this.comboService6;
            this.comboService6.Size = new System.Drawing.Size(162, 36);
            this.comboService6.TabIndex = 150;
            this.comboService6.Visible = false;
            this.comboService6.SelectedValueChanged += new System.EventHandler(this.ComboService6_SelectedValueChanged);
            // 
            // comboService5
            // 
            this.comboService5.BackColor = System.Drawing.Color.Transparent;
            this.comboService5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboService5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService5.FocusedColor = System.Drawing.Color.Empty;
            this.comboService5.FocusedState.Parent = this.comboService5;
            this.comboService5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboService5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboService5.FormattingEnabled = true;
            this.comboService5.HoverState.Parent = this.comboService5;
            this.comboService5.ItemHeight = 30;
            this.comboService5.ItemsAppearance.Parent = this.comboService5;
            this.comboService5.Location = new System.Drawing.Point(389, 180);
            this.comboService5.Name = "comboService5";
            this.comboService5.ShadowDecoration.Parent = this.comboService5;
            this.comboService5.Size = new System.Drawing.Size(162, 36);
            this.comboService5.TabIndex = 149;
            this.comboService5.Visible = false;
            this.comboService5.SelectedValueChanged += new System.EventHandler(this.ComboService5_SelectedValueChanged);
            // 
            // combostyle5
            // 
            this.combostyle5.BackColor = System.Drawing.Color.Transparent;
            this.combostyle5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combostyle5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostyle5.FocusedColor = System.Drawing.Color.Empty;
            this.combostyle5.FocusedState.Parent = this.combostyle5;
            this.combostyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combostyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combostyle5.FormattingEnabled = true;
            this.combostyle5.HoverState.Parent = this.combostyle5;
            this.combostyle5.ItemHeight = 30;
            this.combostyle5.ItemsAppearance.Parent = this.combostyle5;
            this.combostyle5.Location = new System.Drawing.Point(557, 180);
            this.combostyle5.Name = "combostyle5";
            this.combostyle5.ShadowDecoration.Parent = this.combostyle5;
            this.combostyle5.Size = new System.Drawing.Size(162, 36);
            this.combostyle5.TabIndex = 148;
            this.combostyle5.Visible = false;
            this.combostyle5.SelectedValueChanged += new System.EventHandler(this.Combostyle5_SelectedValueChanged);
            // 
            // comboService4
            // 
            this.comboService4.BackColor = System.Drawing.Color.Transparent;
            this.comboService4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboService4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService4.FocusedColor = System.Drawing.Color.Empty;
            this.comboService4.FocusedState.Parent = this.comboService4;
            this.comboService4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboService4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboService4.FormattingEnabled = true;
            this.comboService4.HoverState.Parent = this.comboService4;
            this.comboService4.ItemHeight = 30;
            this.comboService4.ItemsAppearance.Parent = this.comboService4;
            this.comboService4.Location = new System.Drawing.Point(389, 138);
            this.comboService4.Name = "comboService4";
            this.comboService4.ShadowDecoration.Parent = this.comboService4;
            this.comboService4.Size = new System.Drawing.Size(162, 36);
            this.comboService4.TabIndex = 147;
            this.comboService4.Visible = false;
            this.comboService4.SelectedValueChanged += new System.EventHandler(this.comboService4_SelectedValueChanged);
            // 
            // combostyle4
            // 
            this.combostyle4.BackColor = System.Drawing.Color.Transparent;
            this.combostyle4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combostyle4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostyle4.FocusedColor = System.Drawing.Color.Empty;
            this.combostyle4.FocusedState.Parent = this.combostyle4;
            this.combostyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combostyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combostyle4.FormattingEnabled = true;
            this.combostyle4.HoverState.Parent = this.combostyle4;
            this.combostyle4.ItemHeight = 30;
            this.combostyle4.ItemsAppearance.Parent = this.combostyle4;
            this.combostyle4.Location = new System.Drawing.Point(557, 138);
            this.combostyle4.Name = "combostyle4";
            this.combostyle4.ShadowDecoration.Parent = this.combostyle4;
            this.combostyle4.Size = new System.Drawing.Size(162, 36);
            this.combostyle4.TabIndex = 146;
            this.combostyle4.Visible = false;
            this.combostyle4.SelectedValueChanged += new System.EventHandler(this.Combostyle4_SelectedValueChanged);
            // 
            // combostyle3
            // 
            this.combostyle3.BackColor = System.Drawing.Color.Transparent;
            this.combostyle3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combostyle3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostyle3.FocusedColor = System.Drawing.Color.Empty;
            this.combostyle3.FocusedState.Parent = this.combostyle3;
            this.combostyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combostyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combostyle3.FormattingEnabled = true;
            this.combostyle3.HoverState.Parent = this.combostyle3;
            this.combostyle3.ItemHeight = 30;
            this.combostyle3.ItemsAppearance.Parent = this.combostyle3;
            this.combostyle3.Location = new System.Drawing.Point(557, 96);
            this.combostyle3.Name = "combostyle3";
            this.combostyle3.ShadowDecoration.Parent = this.combostyle3;
            this.combostyle3.Size = new System.Drawing.Size(162, 36);
            this.combostyle3.TabIndex = 145;
            this.combostyle3.Visible = false;
            this.combostyle3.SelectedValueChanged += new System.EventHandler(this.Combostyle3_SelectedValueChanged);
            // 
            // comboService3
            // 
            this.comboService3.BackColor = System.Drawing.Color.Transparent;
            this.comboService3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboService3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService3.FocusedColor = System.Drawing.Color.Empty;
            this.comboService3.FocusedState.Parent = this.comboService3;
            this.comboService3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboService3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboService3.FormattingEnabled = true;
            this.comboService3.HoverState.Parent = this.comboService3;
            this.comboService3.ItemHeight = 30;
            this.comboService3.ItemsAppearance.Parent = this.comboService3;
            this.comboService3.Location = new System.Drawing.Point(389, 96);
            this.comboService3.Name = "comboService3";
            this.comboService3.ShadowDecoration.Parent = this.comboService3;
            this.comboService3.Size = new System.Drawing.Size(162, 36);
            this.comboService3.TabIndex = 144;
            this.comboService3.Visible = false;
            this.comboService3.SelectedValueChanged += new System.EventHandler(this.comboService3_SelectedValueChanged);
            // 
            // comboService2
            // 
            this.comboService2.BackColor = System.Drawing.Color.Transparent;
            this.comboService2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboService2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService2.FocusedColor = System.Drawing.Color.Empty;
            this.comboService2.FocusedState.Parent = this.comboService2;
            this.comboService2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboService2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboService2.FormattingEnabled = true;
            this.comboService2.HoverState.Parent = this.comboService2;
            this.comboService2.ItemHeight = 30;
            this.comboService2.ItemsAppearance.Parent = this.comboService2;
            this.comboService2.Location = new System.Drawing.Point(389, 54);
            this.comboService2.Name = "comboService2";
            this.comboService2.ShadowDecoration.Parent = this.comboService2;
            this.comboService2.Size = new System.Drawing.Size(162, 36);
            this.comboService2.TabIndex = 143;
            this.comboService2.Visible = false;
            this.comboService2.SelectedValueChanged += new System.EventHandler(this.comboService2_SelectedValueChanged);
            // 
            // combostyle2
            // 
            this.combostyle2.BackColor = System.Drawing.Color.Transparent;
            this.combostyle2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combostyle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostyle2.FocusedColor = System.Drawing.Color.Empty;
            this.combostyle2.FocusedState.Parent = this.combostyle2;
            this.combostyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combostyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combostyle2.FormattingEnabled = true;
            this.combostyle2.HoverState.Parent = this.combostyle2;
            this.combostyle2.ItemHeight = 30;
            this.combostyle2.ItemsAppearance.Parent = this.combostyle2;
            this.combostyle2.Location = new System.Drawing.Point(557, 54);
            this.combostyle2.Name = "combostyle2";
            this.combostyle2.ShadowDecoration.Parent = this.combostyle2;
            this.combostyle2.Size = new System.Drawing.Size(162, 36);
            this.combostyle2.TabIndex = 142;
            this.combostyle2.Visible = false;
            this.combostyle2.SelectedValueChanged += new System.EventHandler(this.Combostyle2_SelectedValueChanged);
            // 
            // comboService1
            // 
            this.comboService1.BackColor = System.Drawing.Color.Transparent;
            this.comboService1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboService1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService1.FocusedColor = System.Drawing.Color.Empty;
            this.comboService1.FocusedState.Parent = this.comboService1;
            this.comboService1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboService1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboService1.FormattingEnabled = true;
            this.comboService1.HoverState.Parent = this.comboService1;
            this.comboService1.ItemHeight = 30;
            this.comboService1.ItemsAppearance.Parent = this.comboService1;
            this.comboService1.Location = new System.Drawing.Point(389, 12);
            this.comboService1.Name = "comboService1";
            this.comboService1.ShadowDecoration.Parent = this.comboService1;
            this.comboService1.Size = new System.Drawing.Size(162, 36);
            this.comboService1.TabIndex = 141;
            this.comboService1.SelectedValueChanged += new System.EventHandler(this.ComboService1_SelectedValueChanged);
            // 
            // comboStyle1
            // 
            this.comboStyle1.BackColor = System.Drawing.Color.Transparent;
            this.comboStyle1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboStyle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStyle1.FocusedColor = System.Drawing.Color.Empty;
            this.comboStyle1.FocusedState.Parent = this.comboStyle1;
            this.comboStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboStyle1.FormattingEnabled = true;
            this.comboStyle1.HoverState.Parent = this.comboStyle1;
            this.comboStyle1.ItemHeight = 30;
            this.comboStyle1.ItemsAppearance.Parent = this.comboStyle1;
            this.comboStyle1.Location = new System.Drawing.Point(557, 12);
            this.comboStyle1.Name = "comboStyle1";
            this.comboStyle1.ShadowDecoration.Parent = this.comboStyle1;
            this.comboStyle1.Size = new System.Drawing.Size(162, 36);
            this.comboStyle1.TabIndex = 140;
            this.comboStyle1.SelectedIndexChanged += new System.EventHandler(this.ComboStyle1_SelectedIndexChanged);
            this.comboStyle1.SelectedValueChanged += new System.EventHandler(this.ComboStyle1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 51);
            this.button1.TabIndex = 139;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoYes.CheckedState.BorderThickness = 0;
            this.rdoYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoYes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoYes.CheckedState.InnerOffset = -4;
            this.rdoYes.Location = new System.Drawing.Point(1083, 132);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(43, 17);
            this.rdoYes.TabIndex = 167;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoYes.UncheckedState.BorderThickness = 2;
            this.rdoYes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoYes.UseVisualStyleBackColor = true;
            this.rdoYes.CheckedChanged += new System.EventHandler(this.RdoYes_CheckedChanged_1);
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNo.CheckedState.BorderThickness = 0;
            this.rdoNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoNo.CheckedState.InnerOffset = -4;
            this.rdoNo.Location = new System.Drawing.Point(1158, 132);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(39, 17);
            this.rdoNo.TabIndex = 168;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoNo.UncheckedState.BorderThickness = 2;
            this.rdoNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoNo.UseVisualStyleBackColor = true;
            this.rdoNo.CheckedChanged += new System.EventHandler(this.RdoNo_CheckedChanged_1);
            // 
            // txtMember
            // 
            this.txtMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMember.DefaultText = "";
            this.txtMember.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMember.DisabledState.Parent = this.txtMember;
            this.txtMember.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMember.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMember.FocusedState.Parent = this.txtMember;
            this.txtMember.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMember.HoverState.Parent = this.txtMember;
            this.txtMember.Location = new System.Drawing.Point(1088, 59);
            this.txtMember.Name = "txtMember";
            this.txtMember.PasswordChar = '\0';
            this.txtMember.PlaceholderText = "";
            this.txtMember.SelectedText = "";
            this.txtMember.ShadowDecoration.Parent = this.txtMember;
            this.txtMember.Size = new System.Drawing.Size(148, 31);
            this.txtMember.TabIndex = 169;
            // 
            // btnMemberLoad
            // 
            this.btnMemberLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberLoad.Image")));
            this.btnMemberLoad.Location = new System.Drawing.Point(1116, 8);
            this.btnMemberLoad.Name = "btnMemberLoad";
            this.btnMemberLoad.Size = new System.Drawing.Size(41, 36);
            this.btnMemberLoad.TabIndex = 170;
            this.btnMemberLoad.UseVisualStyleBackColor = true;
            this.btnMemberLoad.Click += new System.EventHandler(this.BtnMemberLoad_Click);
            // 
            // StaffRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 537);
            this.Controls.Add(this.btnMemberLoad);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.rdoNo);
            this.Controls.Add(this.rdoYes);
            this.Controls.Add(this.txtCalculate);
            this.Controls.Add(this.sb6);
            this.Controls.Add(this.sb5);
            this.Controls.Add(this.sb4);
            this.Controls.Add(this.sb2);
            this.Controls.Add(this.sb3);
            this.Controls.Add(this.sb1);
            this.Controls.Add(this.comboFee6);
            this.Controls.Add(this.comboFee5);
            this.Controls.Add(this.comboFee4);
            this.Controls.Add(this.comboFee2);
            this.Controls.Add(this.comboFee3);
            this.Controls.Add(this.comboFee1);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.combostyle6);
            this.Controls.Add(this.comboService6);
            this.Controls.Add(this.comboService5);
            this.Controls.Add(this.combostyle5);
            this.Controls.Add(this.comboService4);
            this.Controls.Add(this.combostyle4);
            this.Controls.Add(this.combostyle3);
            this.Controls.Add(this.comboService3);
            this.Controls.Add(this.comboService2);
            this.Controls.Add(this.combostyle2);
            this.Controls.Add(this.comboService1);
            this.Controls.Add(this.comboStyle1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblActualFee);
            this.Controls.Add(this.txtActualFee);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label5);
            this.Name = "StaffRecord";
            this.Text = "StaffRecord";
            this.Load += new System.EventHandler(this.StaffRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker datePicker;
        private System.Windows.Forms.Label lblActualFee;
        private Guna.UI2.WinForms.Guna2TextBox txtActualFee;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2TextBox txtCalculate;
        private Guna.UI2.WinForms.Guna2TextBox sb6;
        private Guna.UI2.WinForms.Guna2TextBox sb5;
        private Guna.UI2.WinForms.Guna2TextBox sb4;
        private Guna.UI2.WinForms.Guna2TextBox sb2;
        private Guna.UI2.WinForms.Guna2TextBox sb3;
        private Guna.UI2.WinForms.Guna2TextBox sb1;
        private Guna.UI2.WinForms.Guna2ComboBox comboFee6;
        private Guna.UI2.WinForms.Guna2ComboBox comboFee5;
        private Guna.UI2.WinForms.Guna2ComboBox comboFee4;
        private Guna.UI2.WinForms.Guna2ComboBox comboFee2;
        private Guna.UI2.WinForms.Guna2ComboBox comboFee3;
        private Guna.UI2.WinForms.Guna2ComboBox comboFee1;
        private System.Windows.Forms.CheckedListBox serviceList;
        private Guna.UI2.WinForms.Guna2ComboBox combostyle6;
        private Guna.UI2.WinForms.Guna2ComboBox comboService6;
        private Guna.UI2.WinForms.Guna2ComboBox comboService5;
        private Guna.UI2.WinForms.Guna2ComboBox combostyle5;
        private Guna.UI2.WinForms.Guna2ComboBox comboService4;
        private Guna.UI2.WinForms.Guna2ComboBox combostyle4;
        private Guna.UI2.WinForms.Guna2ComboBox combostyle3;
        private Guna.UI2.WinForms.Guna2ComboBox comboService3;
        private Guna.UI2.WinForms.Guna2ComboBox comboService2;
        private Guna.UI2.WinForms.Guna2ComboBox combostyle2;
        private Guna.UI2.WinForms.Guna2ComboBox comboService1;
        private Guna.UI2.WinForms.Guna2ComboBox comboStyle1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2RadioButton rdoYes;
        private Guna.UI2.WinForms.Guna2RadioButton rdoNo;
        private Guna.UI2.WinForms.Guna2TextBox txtMember;
        private System.Windows.Forms.Button btnMemberLoad;
    }
}