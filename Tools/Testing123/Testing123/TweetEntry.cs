using System;
using System.Collections.Generic;
using System.Text;

namespace Testing123
{
	public class TweetEntry
	{
		public string Title { get; set; }
		public string Paragraph { get; set; }
		public List<int> Links { get; set; }	
		public List<Link> LinkRefs { get; set; }
	}
}
