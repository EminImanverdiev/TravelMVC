using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class About2
	{
		[Key]
		public int About2Id { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }

	}
}
