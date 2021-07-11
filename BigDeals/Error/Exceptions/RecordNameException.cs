using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Error.Exceptions
{
	public class RecordNameException:Exception
	{
		public string RecordName { get; set; }

		public RecordNameException()
		{

		}

		public RecordNameException(string message) : base(message)
		{

		}

		public RecordNameException(string message, Exception inner) : base(message, inner)
		{

		}

		public RecordNameException(string message, string recordName) : this(message)
		{
			RecordName = recordName;
		}
	}
}
