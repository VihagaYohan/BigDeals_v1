using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDeals.Error.Exceptions
{
	[Serializable]
	public class RecordWasNotFoundException:Exception
	{
		public string RecordName { get; set; }

		public RecordWasNotFoundException()
		{

		}

		public RecordWasNotFoundException(string message):base(message)
		{

		}

		public RecordWasNotFoundException(string message, Exception inner):base(message,inner)
		{

		}

		public RecordWasNotFoundException(string message, string recordName):this(message)
		{
			RecordName = recordName;
		}
	}
}
