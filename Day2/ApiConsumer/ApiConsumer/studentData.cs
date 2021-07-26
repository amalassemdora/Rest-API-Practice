using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsumer
{
	class studentData
	{
        public int St_Id { get; set; }

        public string St_Fname { get; set; }

        public string St_Lname { get; set; }
        public string St_Address { get; set; }

        public int? St_Age { get; set; }

        public int? Dept_Id { get; set; }
		public depts Department { get; set; }

		/* public int? St_super { get; set; }

		 public string photo { get; set; }

		 public string CV { get; set; }

		 public string Email { get; set; }

		 public string Password { get; set; }

		 public string Phone { get; set; }*/

	}
}
