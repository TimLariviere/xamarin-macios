#nullable enable

using Foundation;

namespace WebKit {

	public partial class WebFrame {
		public void LoadHtmlString (string htmlString, NSUrl baseUrl)
		{
			LoadHtmlString ((NSString) htmlString, baseUrl);
		}
	}
}
