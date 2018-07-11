using System;
using System.Collections.Generic;

namespace RevoIE.Domain.Entities
{
    public class OtbList : List<OtbItem>
	{
		public UInt16 MinId => 100;
		public UInt16 MaxId => (UInt16)(MinId + Count - 1);

		public UInt32 DwMajorVersion { get; set; }
		public UInt32 DwMinorVersion { get; set; }
		public UInt32 DwBuildNumber { get; set; }

		public UInt32 ClientVersion { get; set; }
	}
}
