using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiConsumer
{
	public partial class Form1 : Form
	{
		HttpClient client;
		
		public Form1()
		{
			InitializeComponent();
		     client = new HttpClient();
			client.BaseAddress = new Uri("http://localhost:8484/");
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			HttpResponseMessage mess = client.GetAsync("api/departments").Result;
			if (mess.IsSuccessStatusCode)
			{
				List<depts> dept = mess.Content.ReadAsAsync<List<depts>>().Result;
				cb_dept.DisplayMember = "Dept_Name";
				cb_dept.ValueMember = "Dept_Id";
				cb_dept.DataSource = dept;
			}
		}
		private void btn_load_Click(object sender, EventArgs e)
		{
			HttpResponseMessage mess = client.GetAsync("api/students").Result;
			if (mess.IsSuccessStatusCode)
			{
				List<studentData> sts = mess.Content.ReadAsAsync<List<studentData>>().Result;
				gv_student.DataSource = (sts.Select(n => new { Id = n.St_Id,FirstName=n.St_Fname ,LastName= n.St_Lname, Address=n.St_Address,age=n.St_Age,Department=n.Department.Dept_Name})).ToList();
			}

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			studentData sts = new studentData() {
				St_Id = int.Parse(txt_id.Text),
				St_Fname = txt_fname.Text,
				St_Lname = txt_lname.Text,
				St_Address = txt_address.Text,
				St_Age = int.Parse(txt_age.Text),
				Dept_Id = (int)cb_dept.SelectedValue,
		    };
			HttpResponseMessage mess= client.PostAsJsonAsync("api/students", sts).Result;
			if (mess.IsSuccessStatusCode)
			{
				btn_load_Click(null,null);
			}
		}

		private void gv_student_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{ 
			txt_id.Text = gv_student.SelectedRows[0].Cells[0].Value.ToString(); 
			txt_fname.Text = gv_student.SelectedRows[0].Cells[1].Value.ToString(); 
			txt_lname.Text = gv_student.SelectedRows[0].Cells[2].Value.ToString(); 
			txt_address.Text = gv_student.SelectedRows[0].Cells[3].Value.ToString(); 
			txt_age.Text= gv_student.SelectedRows[0].Cells[4].Value.ToString(); 
			cb_dept.SelectedValue = gv_student.SelectedRows[0].Cells[5].Value.ToString();

			//Disable change in id field
			txt_id.Enabled = false;
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			studentData sts = new studentData();
			sts.St_Id = int.Parse(txt_id.Text);
			sts.St_Fname = txt_fname.Text;
			sts.St_Lname = txt_lname.Text;
			sts.St_Address = txt_address.Text;
			sts.St_Age = int.Parse(txt_age.Text);
			sts.Dept_Id = (int)cb_dept.SelectedValue;
			
			HttpResponseMessage mess = client.PutAsJsonAsync("api/students/"+sts.St_Id,sts).Result;
			if (mess.IsSuccessStatusCode)
			{
				btn_load_Click(null, null);
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(gv_student.SelectedRows[0].Cells[0].Value.ToString());
			HttpResponseMessage mess= client.DeleteAsync("api/students/" + id).Result;
			if (mess.IsSuccessStatusCode)
			{
				btn_load_Click(null, null);
			}
		}
	}
}
