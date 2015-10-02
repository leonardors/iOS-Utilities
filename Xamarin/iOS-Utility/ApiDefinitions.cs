using Foundation;

namespace iOSUtilities
{
	// @interface MemoryHelper : NSObject
	[BaseType (typeof(NSObject))]
	interface MemoryHelper
	{
		// +(long long)usedMemory;
		[Static]
		[Export ("usedMemory")]
		long UsedMemory { get; }

		// +(long long)freeMemory;
		[Static]
		[Export ("freeMemory")]
		long FreeMemory { get; }

		// +(long long)totalMemory;
		[Static]
		[Export ("totalMemory")]
		long TotalMemory { get; }

		// +(long long)bytesInKb:(long long)bytes;
		[Static]
		[Export ("bytesInKb:")]
		long BytesInKb (long bytes);

		// +(long long)bytesInMb:(long long)bytes;
		[Static]
		[Export ("bytesInMb:")]
		long BytesInMb (long bytes);
	}
}
