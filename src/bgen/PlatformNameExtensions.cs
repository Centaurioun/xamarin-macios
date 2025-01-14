using ObjCRuntime;

public static class PlatformNameExtensions {

	public static string GetApplicationClassName (this PlatformName currentPlatform)
	{
		switch (currentPlatform) {
		case PlatformName.iOS:
		case PlatformName.WatchOS:
		case PlatformName.TvOS:
		case PlatformName.MacCatalyst:
			return "UIApplication";
		case PlatformName.MacOSX:
			return "NSApplication";
		default:
			throw new BindingException (1047, currentPlatform);
		}
	}

	public static int GetXamcoreVersion (this PlatformName currentPlatform)
	{
#if NET
		return 4;
#else
		switch (currentPlatform) {
		case PlatformName.MacOSX:
		case PlatformName.iOS:
			return 2;
		case PlatformName.TvOS:
		case PlatformName.WatchOS:
			return 3;
		default:
			return 4;
		}
#endif
	}

	public static string GetCoreImageMap (this PlatformName currentPlatform)
	{
		switch (currentPlatform) {
		case PlatformName.iOS:
		case PlatformName.WatchOS:
		case PlatformName.TvOS:
		case PlatformName.MacCatalyst:
			return "CoreImage";
		case PlatformName.MacOSX:
			return "Quartz";
		default:
			throw new BindingException (1047, currentPlatform);
		}
	}

	public static string GetCoreServicesMap (this PlatformName currentPlatform)
	{
		switch (currentPlatform) {
		case PlatformName.iOS:
		case PlatformName.WatchOS:
		case PlatformName.TvOS:
		case PlatformName.MacCatalyst:
			return "MobileCoreServices";
		case PlatformName.MacOSX:
			return "CoreServices";
		default:
			throw new BindingException (1047, currentPlatform);
		}
	}

	public static string GetPDFKitMap (this PlatformName currentPlatform)
	{
		switch (currentPlatform) {
		case PlatformName.iOS:
		case PlatformName.MacCatalyst:
			return "PDFKit";
		case PlatformName.MacOSX:
			return "Quartz";
		default:
			throw new BindingException (1047, currentPlatform);
		}
	}
}
