// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.FileCreateFlagsGType))]
	public enum FileCreateFlags {

		None,
		Private = 1 << 0,
		ReplaceDestination = 1 << 1,
	}

	internal class FileCreateFlagsGType {
		[DllImport ("libgio-2.0-0.dll")]
		static extern IntPtr g_file_create_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_file_create_flags_get_type ());
			}
		}
	}
#endregion
}