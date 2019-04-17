using System;

namespace Geocoding.Microsoft
{
	[Flags]
	public enum MatchCode
	{
		Good,
		Ambiguous,
		UpHierarchy,
		Unknown
	}
}
