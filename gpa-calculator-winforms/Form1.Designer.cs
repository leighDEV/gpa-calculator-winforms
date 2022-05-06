namespace gpa_calculator_winforms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbGrade = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.btnClearAll = new MaterialSkin.Controls.MaterialButton();
            this.lstbGrades = new MaterialSkin.Controls.MaterialListBox();
            this.btnCalculate = new MaterialSkin.Controls.MaterialButton();
            this.panel = new System.Windows.Forms.Panel();
            this.lblGPA = new MaterialSkin.Controls.MaterialLabel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGrade
            // 
            this.tbGrade.AnimateReadOnly = false;
            this.tbGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGrade.Depth = 0;
            this.tbGrade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGrade.Hint = "Grades";
            this.tbGrade.LeadingIcon = null;
            this.tbGrade.Location = new System.Drawing.Point(27, 85);
            this.tbGrade.MaxLength = 50;
            this.tbGrade.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGrade.Multiline = false;
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(158, 50);
            this.tbGrade.TabIndex = 4;
            this.tbGrade.Text = "";
            this.tbGrade.TrailingIcon = null;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(27, 142);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(158, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(27, 190);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(158, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = false;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemove.Depth = 0;
            this.btnRemove.HighEmphasis = true;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(27, 238);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(158, 36);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemove.UseAccentColor = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = false;
            this.btnClearAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearAll.Depth = 0;
            this.btnClearAll.HighEmphasis = true;
            this.btnClearAll.Icon = null;
            this.btnClearAll.Location = new System.Drawing.Point(27, 286);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearAll.Size = new System.Drawing.Size(158, 36);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearAll.UseAccentColor = false;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lstbGrades
            // 
            this.lstbGrades.BackColor = System.Drawing.Color.White;
            this.lstbGrades.BorderColor = System.Drawing.Color.LightGray;
            this.lstbGrades.Depth = 0;
            this.lstbGrades.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstbGrades.Location = new System.Drawing.Point(212, 85);
            this.lstbGrades.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstbGrades.Name = "lstbGrades";
            this.lstbGrades.SelectedIndex = -1;
            this.lstbGrades.SelectedItem = null;
            this.lstbGrades.Size = new System.Drawing.Size(111, 321);
            this.lstbGrades.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = false;
            this.btnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalculate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalculate.Depth = 0;
            this.btnCalculate.HighEmphasis = true;
            this.btnCalculate.Icon = null;
            this.btnCalculate.Location = new System.Drawing.Point(27, 367);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalculate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalculate.Size = new System.Drawing.Size(158, 36);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalculate.UseAccentColor = false;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblGPA);
            this.panel.Location = new System.Drawing.Point(206, 419);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(120, 39);
            this.panel.TabIndex = 10;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Depth = 0;
            this.lblGPA.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblGPA.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblGPA.Location = new System.Drawing.Point(3, 6);
            this.lblGPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(60, 29);
            this.lblGPA.TabIndex = 0;
            this.lblGPA.Text = "GPA: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 472);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lstbGrades);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbGrade);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPA Calculator";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox tbGrade;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private MaterialSkin.Controls.MaterialButton btnClearAll;
        private MaterialSkin.Controls.MaterialListBox lstbGrades;
        private MaterialSkin.Controls.MaterialButton btnCalculate;
        private System.Windows.Forms.Panel panel;
        private MaterialSkin.Controls.MaterialLabel lblGPA;
    }
}

