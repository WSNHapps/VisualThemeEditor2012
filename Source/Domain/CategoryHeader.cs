using System;

namespace VisualThemeEditor2013.Domain
{
	public struct CategoryHeader
	{
		public int CategoryDataSize { get; set; }
		public int VisualStudioVersion { get; set; }
		public int Unknown { get; set; }
		public Guid CategoryGuid { get; set; }
		public int ColorCount { get; set; }
	}
}