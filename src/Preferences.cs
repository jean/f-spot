
using System;
using Mono.Posix;

namespace FSpot
{
	public class PreferenceSetting
	{
		private string key;

		public string Key {
			get { return key; }
		}
		
		public object Value {
			get {
				return Preferences.Get (key);
			}
			set {
				Preferences.Set (key, Value);
			}
		}
		
		public PreferenceSetting (string key)
		{
			this.key = key;
		}
	}

	public class Preferences
	{
		public const string MAIN_WINDOW_MAXIMIZED = "/apps/f-spot/ui/maximized";

		public const string MAIN_WINDOW_X = "/apps/f-spot/ui/main_window_x";
		public const string MAIN_WINDOW_Y = "/apps/f-spot/ui/main_window_y";
		public const string MAIN_WINDOW_WIDTH = "/apps/f-spot/ui/main_window_width";
		public const string MAIN_WINDOW_HEIGHT = "/apps/f-spot/ui/main_window_height";
		
		public const string VIEWER_WIDTH = "/apps/f-spot/ui/viewer_width";
		public const string VIEWER_HEIGHT = "/apps/f-spot/ui/viewer_height";
		public const string VIEWER_MAXIMIZED = "/apps/f-spot/ui/viewer_maximized";
		public const string VIEWER_SHOW_TOOLBAR = "/apps/f-spot/ui/viewer_show_toolbar";
		
		public const string SHOW_TOOLBAR = "/apps/f-spot/ui/show_toolbar";
		public const string SHOW_SIDEBAR = "/apps/f-spot/ui/show_sidebar";
		public const string SHOW_TIMELINE = "/apps/f-spot/ui/show_timeline";
		public const string SHOW_TAGS = "/apps/f-spot/ui/show_tags";
		public const string SHOW_DATES = "/apps/f-spot/ui/show_dates";
		public const string EXPANDED_TAGS = "/apps/f-spot/ui/expanded_tags";
		
		public const string SIDEBAR_POSITION = "/apps/f-spot/ui/sidebar_size";
		public const string ZOOM = "/apps/f-spot/ui/zoom";
		public const string ICON_VIEW_POSITION = "/apps/f-spot/ui/icon_view_position";

		public const string EXPORT_FLICKR_SCALE = "/apps/f-spot/export/flickr/scale";
		public const string EXPORT_FLICKR_SIZE = "/apps/f-spot/export/flickr/size";
		public const string EXPORT_FLICKR_BROWSER = "/apps/f-spot/export/flickr/browser";
		public const string EXPORT_FLICKR_TAGS = "/apps/f-spot/export/flickr/tags";
		public const string EXPORT_FLICKR_STRIP_META = "/apps/f-spot/export/flickr/strip_meta";
		public const string EXPORT_FLICKR_EMAIL = "/apps/f-spot/export/flickr/email";
		public const string EXPORT_FLICKR_TOKEN = "/apps/f-spot/export/flickr/token";
		public const string EXPORT_FLICKR_PUBLIC = "/apps/f-spot/export/flickr/public";
		public const string EXPORT_FLICKR_FRIENDS = "/apps/f-spot/export/flickr/friends";
		public const string EXPORT_FLICKR_FAMILY = "/apps/f-spot/export/flickr/family";

		public const string EXPORT_GALLERY_SCALE = "/apps/f-spot/export/gallery/scale";
		public const string EXPORT_GALLERY_SIZE = "/apps/f-spot/export/gallery/size";
		public const string EXPORT_GALLERY_BROWSER = "/apps/f-spot/export/gallery/browser";
		public const string EXPORT_GALLERY_META = "/apps/f-spot/export/gallery/meta";

		public const string SCREENSAVER_TAG = "/apps/f-spot/screensaver/tag_id";

		public const string METADATA_EMBED_IN_IMAGE = "/apps/f-spot/metadata/embed_in_image";

		static GConf.Client client;
		static GConf.NotifyEventHandler changed_handler;

		public static GConf.Client Client 
		{
			get {
				if (client == null) {
					client = new GConf.Client ();

					changed_handler = new GConf.NotifyEventHandler (OnSettingChanged);
					client.AddNotify ("/apps/f-spot", changed_handler);
				}
				return client;
			}
		}

		// NOTE: Keep synced with tomboy.schemas.in
		public static object GetDefault (string key)
		{
			switch (key) {
			case MAIN_WINDOW_X:
			case MAIN_WINDOW_Y:
			case MAIN_WINDOW_HEIGHT:
			case MAIN_WINDOW_WIDTH:
				return null;
			
			case METADATA_EMBED_IN_IMAGE:
			case MAIN_WINDOW_MAXIMIZED:
				return false;

			case SHOW_TOOLBAR:
			case SHOW_SIDEBAR:
			case SHOW_TIMELINE:
			case SHOW_TAGS:
			case SHOW_DATES:
				return true;
		
			case SIDEBAR_POSITION:
			case ZOOM:
			case ICON_VIEW_POSITION:
				return null;
			case SCREENSAVER_TAG:
				return  (uint) 1;
			}

			return null;
		}

		public static object Get (string key)
		{
			try {
				return Client.Get (key);
			} catch (GConf.NoSuchKeyException) {
				object default_val = GetDefault (key);

				if (default_val != null)
					Client.Set (key, default_val);

				return default_val;
			}
		}

		public static void Set (string key, object value)
		{
			Client.Set (key, value);
		}

		public static event GConf.NotifyEventHandler SettingChanged;

		static void OnSettingChanged (object sender, GConf.NotifyEventArgs args)
		{
			if (SettingChanged != null) {
				SettingChanged (sender, args);
			}
		}
	}
}
