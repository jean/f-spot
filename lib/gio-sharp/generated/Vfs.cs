// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Vfs : GLib.Object {

		[Obsolete]
		protected Vfs(GLib.GType gtype) : base(gtype) {}
		public Vfs(IntPtr raw) : base(raw) {}

		protected Vfs() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_vfs_parse_name(IntPtr raw, IntPtr parse_name);

		public GLib.File ParseName(string parse_name) {
			IntPtr native_parse_name = GLib.Marshaller.StringToPtrGStrdup (parse_name);
			IntPtr raw_ret = g_vfs_parse_name(Handle, native_parse_name);
			GLib.File ret = GLib.FileAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_parse_name);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_vfs_get_default();

		public static GLib.Vfs Default { 
			get {
				IntPtr raw_ret = g_vfs_get_default();
				GLib.Vfs ret = GLib.Object.GetObject(raw_ret) as GLib.Vfs;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_vfs_get_local();

		public static GLib.Vfs Local { 
			get {
				IntPtr raw_ret = g_vfs_get_local();
				GLib.Vfs ret = GLib.Object.GetObject(raw_ret) as GLib.Vfs;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_vfs_is_active(IntPtr raw);

		public bool IsActive { 
			get {
				bool raw_ret = g_vfs_is_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_vfs_get_supported_uri_schemes(IntPtr raw);

		public string SupportedUriSchemes { 
			get {
				IntPtr raw_ret = g_vfs_get_supported_uri_schemes(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_vfs_get_file_for_path(IntPtr raw, IntPtr path);

		public GLib.File GetFileForPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = g_vfs_get_file_for_path(Handle, native_path);
			GLib.File ret = GLib.FileAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_vfs_get_file_for_uri(IntPtr raw, IntPtr uri);

		public GLib.File GetFileForUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr raw_ret = g_vfs_get_file_for_uri(Handle, native_uri);
			GLib.File ret = GLib.FileAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_vfs_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_vfs_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
