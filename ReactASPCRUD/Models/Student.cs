using System.ComponentModel.DataAnnotations;

namespace ReactASPCRUD.Models
{
	public class Student
	{
		[Key]
		public int stId { get; set; }
		public string stName { get; set; }
		
		public String stCourse { get; set; }

	}
}
