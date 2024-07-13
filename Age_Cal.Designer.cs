namespace WindowsFormsApplication_testing
{
    partial class frmca
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.btnclr = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtyr = new System.Windows.Forms.TextBox();
            this.btndobcal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Age";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.Transparent;
            this.lbldob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(12, 9);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(196, 16);
            this.lbldob.TabIndex = 19;
            this.lbldob.Text = "Choose your Date Of Birth";
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.SystemColors.Control;
            this.btnclr.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(470, 157);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(100, 30);
            this.btnclr.TabIndex = 24;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(449, 23);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // txtyr
            // 
            this.txtyr.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyr.Location = new System.Drawing.Point(12, 159);
            this.txtyr.Name = "txtyr";
            this.txtyr.ReadOnly = true;
            this.txtyr.Size = new System.Drawing.Size(449, 23);
            this.txtyr.TabIndex = 22;
            // 
            // btndobcal
            // 
            this.btndobcal.BackColor = System.Drawing.SystemColors.Control;
            this.btndobcal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndobcal.Location = new System.Drawing.Point(470, 57);
            this.btndobcal.Name = "btndobcal";
            this.btndobcal.Size = new System.Drawing.Size(100, 30);
            this.btndobcal.TabIndex = 21;
            this.btndobcal.Text = "Calculate";
            this.btndobcal.UseVisualStyleBackColor = false;
            this.btndobcal.Click += new System.EventHandler(this.btndobcal_Click);
            // 
            // frmca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication_testing.Properties.Resources.SP_Back;
            this.ClientSize = new System.Drawing.Size(594, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtyr);
            this.Controls.Add(this.btndobcal);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(610, 256);
            this.Name = "frmca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.frmca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtyr;
        private System.Windows.Forms.Button btndobcal;
    }
}