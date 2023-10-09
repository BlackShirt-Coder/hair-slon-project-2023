namespace HairSlonManagementProject
{
    partial class StaffPayRoll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPayRoll));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.staffRecord = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.staffCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCalculate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtCalculate = new Guna.UI2.WinForms.Guna2TextBox();
            this.dpicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.staffRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // staffRecord
            // 
            this.staffRecord.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.staffRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.staffRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.staffRecord.ColumnHeadersHeight = 40;
            this.staffRecord.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.staffRecord.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.staffRecord.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.staffRecord.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.staffRecord.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.staffRecord.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.staffRecord.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.staffRecord.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.staffRecord.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.staffRecord.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffRecord.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.staffRecord.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.staffRecord.CurrentTheme.Name = null;
            this.staffRecord.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffRecord.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.staffRecord.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.staffRecord.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.staffRecord.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffRecord.DefaultCellStyle = dataGridViewCellStyle6;
            this.staffRecord.EnableHeadersVisualStyles = false;
            this.staffRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.staffRecord.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.staffRecord.HeaderBgColor = System.Drawing.Color.Empty;
            this.staffRecord.HeaderForeColor = System.Drawing.Color.White;
            this.staffRecord.Location = new System.Drawing.Point(18, 112);
            this.staffRecord.Name = "staffRecord";
            this.staffRecord.RowHeadersVisible = false;
            this.staffRecord.RowTemplate.Height = 40;
            this.staffRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffRecord.Size = new System.Drawing.Size(1194, 613);
            this.staffRecord.TabIndex = 0;
            this.staffRecord.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // staffCombo
            // 
            this.staffCombo.BackColor = System.Drawing.Color.Transparent;
            this.staffCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.staffCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffCombo.FocusedColor = System.Drawing.Color.Empty;
            this.staffCombo.FocusedState.Parent = this.staffCombo;
            this.staffCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.staffCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.staffCombo.FormattingEnabled = true;
            this.staffCombo.HoverState.Parent = this.staffCombo;
            this.staffCombo.ItemHeight = 30;
            this.staffCombo.ItemsAppearance.Parent = this.staffCombo;
            this.staffCombo.Location = new System.Drawing.Point(18, 55);
            this.staffCombo.Name = "staffCombo";
            this.staffCombo.ShadowDecoration.Parent = this.staffCombo;
            this.staffCombo.Size = new System.Drawing.Size(276, 36);
            this.staffCombo.TabIndex = 5;
            this.staffCombo.SelectedIndexChanged += new System.EventHandler(this.StaffCombo_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AllowAnimations = true;
            this.btnCalculate.AllowMouseEffects = true;
            this.btnCalculate.AllowToggling = false;
            this.btnCalculate.AnimationSpeed = 200;
            this.btnCalculate.AutoGenerateColors = false;
            this.btnCalculate.AutoRoundBorders = false;
            this.btnCalculate.AutoSizeLeftIcon = true;
            this.btnCalculate.AutoSizeRightIcon = true;
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.BackgroundImage")));
            this.btnCalculate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.ButtonText = "Calculate";
            this.btnCalculate.ButtonTextMarginLeft = 0;
            this.btnCalculate.ColorContrastOnClick = 45;
            this.btnCalculate.ColorContrastOnHover = 45;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCalculate.CustomizableEdges = borderEdges2;
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalculate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCalculate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCalculate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCalculate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCalculate.IconMarginLeft = 11;
            this.btnCalculate.IconPadding = 10;
            this.btnCalculate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCalculate.IconSize = 25;
            this.btnCalculate.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.IdleBorderRadius = 1;
            this.btnCalculate.IdleBorderThickness = 1;
            this.btnCalculate.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.IdleIconLeftImage = null;
            this.btnCalculate.IdleIconRightImage = null;
            this.btnCalculate.IndicateFocus = false;
            this.btnCalculate.Location = new System.Drawing.Point(334, 55);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCalculate.OnDisabledState.BorderRadius = 1;
            this.btnCalculate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.OnDisabledState.BorderThickness = 1;
            this.btnCalculate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCalculate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCalculate.OnDisabledState.IconLeftImage = null;
            this.btnCalculate.OnDisabledState.IconRightImage = null;
            this.btnCalculate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCalculate.onHoverState.BorderRadius = 1;
            this.btnCalculate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.onHoverState.BorderThickness = 1;
            this.btnCalculate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCalculate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.onHoverState.IconLeftImage = null;
            this.btnCalculate.onHoverState.IconRightImage = null;
            this.btnCalculate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.OnIdleState.BorderRadius = 1;
            this.btnCalculate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.OnIdleState.BorderThickness = 1;
            this.btnCalculate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.OnIdleState.IconLeftImage = null;
            this.btnCalculate.OnIdleState.IconRightImage = null;
            this.btnCalculate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCalculate.OnPressedState.BorderRadius = 1;
            this.btnCalculate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCalculate.OnPressedState.BorderThickness = 1;
            this.btnCalculate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCalculate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.OnPressedState.IconLeftImage = null;
            this.btnCalculate.OnPressedState.IconRightImage = null;
            this.btnCalculate.Size = new System.Drawing.Size(150, 39);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalculate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalculate.TextMarginLeft = 0;
            this.btnCalculate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCalculate.UseDefaultRadiusAndThickness = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
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
            this.txtCalculate.Location = new System.Drawing.Point(502, 58);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.PasswordChar = '\0';
            this.txtCalculate.PlaceholderText = "";
            this.txtCalculate.ReadOnly = true;
            this.txtCalculate.SelectedText = "";
            this.txtCalculate.ShadowDecoration.Parent = this.txtCalculate;
            this.txtCalculate.Size = new System.Drawing.Size(200, 36);
            this.txtCalculate.TabIndex = 8;
            // 
            // dpicker
            // 
            this.dpicker.BackColor = System.Drawing.Color.Transparent;
            this.dpicker.BorderRadius = 1;
            this.dpicker.Color = System.Drawing.Color.Silver;
            this.dpicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpicker.DisabledColor = System.Drawing.Color.Gray;
            this.dpicker.DisplayWeekNumbers = false;
            this.dpicker.DPHeight = 0;
            this.dpicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpicker.FillDatePicker = false;
            this.dpicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpicker.ForeColor = System.Drawing.Color.Black;
            this.dpicker.Icon = ((System.Drawing.Image)(resources.GetObject("dpicker.Icon")));
            this.dpicker.IconColor = System.Drawing.Color.Gray;
            this.dpicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpicker.LeftTextMargin = 5;
            this.dpicker.Location = new System.Drawing.Point(18, 3);
            this.dpicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpicker.Name = "dpicker";
            this.dpicker.Size = new System.Drawing.Size(276, 32);
            this.dpicker.TabIndex = 9;
            this.dpicker.ValueChanged += new System.EventHandler(this.BunifuDatePicker1_ValueChanged);
            // 
            // StaffPayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpicker);
            this.Controls.Add(this.txtCalculate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.staffCombo);
            this.Controls.Add(this.staffRecord);
            this.Name = "StaffPayRoll";
            this.Size = new System.Drawing.Size(1225, 531);
            this.Load += new System.EventHandler(this.StaffPayRoll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView staffRecord;
        private Guna.UI2.WinForms.Guna2ComboBox staffCombo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCalculate;
        private Guna.UI2.WinForms.Guna2TextBox txtCalculate;
        private Bunifu.UI.WinForms.BunifuDatePicker dpicker;
    }
}
