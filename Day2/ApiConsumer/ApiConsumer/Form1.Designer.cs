
namespace ApiConsumer
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
			this.gv_student = new System.Windows.Forms.DataGridView();
			this.btn_load = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.txt_age = new System.Windows.Forms.TextBox();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.txt_lname = new System.Windows.Forms.TextBox();
			this.txt_fname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cb_dept = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.gv_student)).BeginInit();
			this.SuspendLayout();
			// 
			// gv_student
			// 
			this.gv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gv_student.Location = new System.Drawing.Point(130, 298);
			this.gv_student.Name = "gv_student";
			this.gv_student.Size = new System.Drawing.Size(557, 198);
			this.gv_student.TabIndex = 0;
			this.gv_student.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_student_RowHeaderMouseClick);
			// 
			// btn_load
			// 
			this.btn_load.Location = new System.Drawing.Point(181, 244);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(75, 23);
			this.btn_load.TabIndex = 1;
			this.btn_load.Text = "Load";
			this.btn_load.UseVisualStyleBackColor = true;
			this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(287, 244);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 23);
			this.btn_add.TabIndex = 2;
			this.btn_add.Text = "Insert";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(511, 244);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 3;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(395, 244);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(75, 23);
			this.btn_update.TabIndex = 4;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(314, 13);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(257, 20);
			this.txt_id.TabIndex = 5;
			// 
			// txt_age
			// 
			this.txt_age.Location = new System.Drawing.Point(314, 158);
			this.txt_age.Name = "txt_age";
			this.txt_age.Size = new System.Drawing.Size(257, 20);
			this.txt_age.TabIndex = 7;
			// 
			// txt_address
			// 
			this.txt_address.Location = new System.Drawing.Point(314, 120);
			this.txt_address.Name = "txt_address";
			this.txt_address.Size = new System.Drawing.Size(257, 20);
			this.txt_address.TabIndex = 8;
			// 
			// txt_lname
			// 
			this.txt_lname.Location = new System.Drawing.Point(314, 84);
			this.txt_lname.Name = "txt_lname";
			this.txt_lname.Size = new System.Drawing.Size(257, 20);
			this.txt_lname.TabIndex = 9;
			// 
			// txt_fname
			// 
			this.txt_fname.Location = new System.Drawing.Point(314, 48);
			this.txt_fname.Name = "txt_fname";
			this.txt_fname.Size = new System.Drawing.Size(257, 20);
			this.txt_fname.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(193, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(193, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(193, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Last Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(193, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Age";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(193, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "ID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(193, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Department";
			// 
			// cb_dept
			// 
			this.cb_dept.FormattingEnabled = true;
			this.cb_dept.Location = new System.Drawing.Point(314, 195);
			this.cb_dept.Name = "cb_dept";
			this.cb_dept.Size = new System.Drawing.Size(257, 21);
			this.cb_dept.TabIndex = 18;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 508);
			this.Controls.Add(this.cb_dept);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_fname);
			this.Controls.Add(this.txt_lname);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.txt_age);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.btn_load);
			this.Controls.Add(this.gv_student);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gv_student)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gv_student;
		private System.Windows.Forms.Button btn_load;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.TextBox txt_age;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.TextBox txt_lname;
		private System.Windows.Forms.TextBox txt_fname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cb_dept;
	}
}

