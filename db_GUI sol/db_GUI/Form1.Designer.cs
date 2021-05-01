namespace db_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.tbCCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtCourses = new System.Windows.Forms.DataGridView();
            this.LoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // tbCName
            // 
            this.tbCName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCName.Location = new System.Drawing.Point(256, 57);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(414, 43);
            this.tbCName.TabIndex = 1;
            // 
            // tbCCode
            // 
            this.tbCCode.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCCode.Location = new System.Drawing.Point(256, 145);
            this.tbCCode.Name = "tbCCode";
            this.tbCCode.Size = new System.Drawing.Size(414, 43);
            this.tbCCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Code";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(540, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtCourses
            // 
            this.dtCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCourses.Location = new System.Drawing.Point(749, 57);
            this.dtCourses.Name = "dtCourses";
            this.dtCourses.RowTemplate.Height = 24;
            this.dtCourses.Size = new System.Drawing.Size(505, 492);
            this.dtCourses.TabIndex = 5;
            // 
            // LoadData
            // 
            this.LoadData.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadData.Location = new System.Drawing.Point(256, 231);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(130, 60);
            this.LoadData.TabIndex = 6;
            this.LoadData.Text = "Load";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 590);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.dtCourses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.TextBox tbCCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtCourses;
        private System.Windows.Forms.Button LoadData;
    }
}

