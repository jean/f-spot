// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class FileInfo : GLib.Object {

		[Obsolete]
		protected FileInfo(GLib.GType gtype) : base(gtype) {}
		public FileInfo(IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_new();

		public FileInfo () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FileInfo)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_file_info_new();
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern int g_file_info_get_sort_order(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_sort_order(IntPtr raw, int sort_order);

		public int SortOrder { 
			get {
				int raw_ret = g_file_info_get_sort_order(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				g_file_info_set_sort_order(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_copy_into(IntPtr raw, IntPtr dest_info);

		public void CopyInto(GLib.FileInfo dest_info) {
			g_file_info_copy_into(Handle, dest_info == null ? IntPtr.Zero : dest_info.Handle);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_get_is_symlink(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_is_symlink(IntPtr raw, bool is_symlink);

		public bool IsSymlink { 
			get {
				bool raw_ret = g_file_info_get_is_symlink(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				g_file_info_set_is_symlink(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_uint64(IntPtr raw, IntPtr attribute, ulong attr_value);

		public void SetAttributeULong(string attribute, ulong attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute_uint64(Handle, native_attribute, attr_value);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_attribute_object(IntPtr raw, IntPtr attribute);

		public GLib.Object GetAttributeObject(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr raw_ret = g_file_info_get_attribute_object(Handle, native_attribute);
			GLib.Object ret = GLib.Object.GetObject (raw_ret);
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_dup(IntPtr raw);

		public GLib.FileInfo Dup() {
			IntPtr raw_ret = g_file_info_dup(Handle);
			GLib.FileInfo ret = GLib.Object.GetObject(raw_ret) as GLib.FileInfo;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_get_attribute_boolean(IntPtr raw, IntPtr attribute);

		public bool GetAttributeBoolean(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			bool raw_ret = g_file_info_get_attribute_boolean(Handle, native_attribute);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_get_is_hidden(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_is_hidden(IntPtr raw, bool is_hidden);

		public bool IsHidden { 
			get {
				bool raw_ret = g_file_info_get_is_hidden(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				g_file_info_set_is_hidden(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern int g_file_info_get_file_type(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_file_type(IntPtr raw, int type);

		public GLib.FileType FileType { 
			get {
				int raw_ret = g_file_info_get_file_type(Handle);
				GLib.FileType ret = (GLib.FileType) raw_ret;
				return ret;
			}
			set {
				g_file_info_set_file_type(Handle, (int) value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_symlink_target(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_symlink_target(IntPtr raw, IntPtr symlink_target);

		public string SymlinkTarget { 
			get {
				IntPtr raw_ret = g_file_info_get_symlink_target(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_file_info_set_symlink_target(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_edit_name(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_edit_name(IntPtr raw, IntPtr edit_name);

		public string EditName { 
			get {
				IntPtr raw_ret = g_file_info_get_edit_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_file_info_set_edit_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern uint g_file_info_get_attribute_uint32(IntPtr raw, IntPtr attribute);

		public uint GetAttributeUInt(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			uint raw_ret = g_file_info_get_attribute_uint32(Handle, native_attribute);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern int g_file_info_get_attribute_status(IntPtr raw, IntPtr attribute);

		public GLib.FileAttributeStatus GetAttributeStatus(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			int raw_ret = g_file_info_get_attribute_status(Handle, native_attribute);
			GLib.FileAttributeStatus ret = (GLib.FileAttributeStatus) raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_attribute_stringv(IntPtr raw, IntPtr attribute);

		public string GetAttributeStringv(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr raw_ret = g_file_info_get_attribute_stringv(Handle, native_attribute);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_has_namespace(IntPtr raw, IntPtr name_space);

		public bool HasNamespace(string name_space) {
			IntPtr native_name_space = GLib.Marshaller.StringToPtrGStrdup (name_space);
			bool raw_ret = g_file_info_has_namespace(Handle, native_name_space);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name_space);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_list_attributes(IntPtr raw, IntPtr name_space);

		public string ListAttributes(string name_space) {
			IntPtr native_name_space = GLib.Marshaller.StringToPtrGStrdup (name_space);
			IntPtr raw_ret = g_file_info_list_attributes(Handle, native_name_space);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_name_space);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_attribute_byte_string(IntPtr raw, IntPtr attribute);

		public string GetAttributeByteString(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr raw_ret = g_file_info_get_attribute_byte_string(Handle, native_attribute);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern int g_file_info_get_attribute_int32(IntPtr raw, IntPtr attribute);

		public int GetAttributeInt(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			int raw_ret = g_file_info_get_attribute_int32(Handle, native_attribute);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_attribute_string(IntPtr raw, IntPtr attribute);

		public string GetAttributeString(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr raw_ret = g_file_info_get_attribute_string(Handle, native_attribute);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_content_type(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_content_type(IntPtr raw, IntPtr content_type);

		public string ContentType { 
			get {
				IntPtr raw_ret = g_file_info_get_content_type(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_file_info_set_content_type(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_clear_status(IntPtr raw);

		public void ClearStatus() {
			g_file_info_clear_status(Handle);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_object(IntPtr raw, IntPtr attribute, IntPtr attr_value);

		public void SetAttributeObject(string attribute, GLib.Object attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute_object(Handle, native_attribute, attr_value == null ? IntPtr.Zero : attr_value.Handle);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_mask(IntPtr raw, IntPtr mask);

		public GLib.FileAttributeMatcher AttributeMask { 
			set {
				g_file_info_set_attribute_mask(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_unset_attribute_mask(IntPtr raw);

		public void UnsetAttributeMask() {
			g_file_info_unset_attribute_mask(Handle);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_name(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_name(IntPtr raw, IntPtr name);

		public string Name { 
			get {
				IntPtr raw_ret = g_file_info_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_file_info_set_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_get_attribute_data(IntPtr raw, IntPtr attribute, out int type, IntPtr value_pp, out int status);

		public bool GetAttributeData(string attribute, out GLib.FileAttributeType type, IntPtr value_pp, out GLib.FileAttributeStatus status) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			int native_type;
			int native_status;
			bool raw_ret = g_file_info_get_attribute_data(Handle, native_attribute, out native_type, value_pp, out native_status);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			type = (GLib.FileAttributeType) native_type;
			status = (GLib.FileAttributeStatus) native_status;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_has_attribute(IntPtr raw, IntPtr attribute);

		public bool HasAttribute(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			bool raw_ret = g_file_info_has_attribute(Handle, native_attribute);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_icon(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_icon(IntPtr raw, IntPtr icon);

		public GLib.Icon Icon { 
			get {
				IntPtr raw_ret = g_file_info_get_icon(Handle);
				GLib.Icon ret = GLib.IconAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set {
				g_file_info_set_icon(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute(IntPtr raw, IntPtr attribute, int type, IntPtr value_p);

		public void SetAttribute(string attribute, GLib.FileAttributeType type, IntPtr value_p) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute(Handle, native_attribute, (int) type, value_p);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_string(IntPtr raw, IntPtr attribute, IntPtr attr_value);

		public void SetAttributeString(string attribute, string attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr native_attr_value = GLib.Marshaller.StringToPtrGStrdup (attr_value);
			g_file_info_set_attribute_string(Handle, native_attribute, native_attr_value);
			GLib.Marshaller.Free (native_attribute);
			GLib.Marshaller.Free (native_attr_value);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_boolean(IntPtr raw, IntPtr attribute, bool attr_value);

		public void SetAttributeBoolean(string attribute, bool attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute_boolean(Handle, native_attribute, attr_value);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_remove_attribute(IntPtr raw, IntPtr attribute);

		public void RemoveAttribute(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_remove_attribute(Handle, native_attribute);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern long g_file_info_get_attribute_int64(IntPtr raw, IntPtr attribute);

		public long GetAttributeLong(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			long raw_ret = g_file_info_get_attribute_int64(Handle, native_attribute);
			long ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern int g_file_info_get_attribute_type(IntPtr raw, IntPtr attribute);

		public GLib.FileAttributeType GetAttributeType(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			int raw_ret = g_file_info_get_attribute_type(Handle, native_attribute);
			GLib.FileAttributeType ret = (GLib.FileAttributeType) raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_file_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_int64(IntPtr raw, IntPtr attribute, long attr_value);

		public void SetAttributeLong(string attribute, long attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute_int64(Handle, native_attribute, attr_value);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_etag(IntPtr raw);

		public string Etag { 
			get {
				IntPtr raw_ret = g_file_info_get_etag(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_int32(IntPtr raw, IntPtr attribute, int attr_value);

		public void SetAttributeInt(string attribute, int attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute_int32(Handle, native_attribute, attr_value);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_display_name(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_display_name(IntPtr raw, IntPtr display_name);

		public string DisplayName { 
			get {
				IntPtr raw_ret = g_file_info_get_display_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_file_info_set_display_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_uint32(IntPtr raw, IntPtr attribute, uint attr_value);

		public void SetAttributeUInt(string attribute, uint attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute_uint32(Handle, native_attribute, attr_value);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_get_is_backup(IntPtr raw);

		public bool IsBackup { 
			get {
				bool raw_ret = g_file_info_get_is_backup(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern ulong g_file_info_get_attribute_uint64(IntPtr raw, IntPtr attribute);

		public ulong GetAttributeULong(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			ulong raw_ret = g_file_info_get_attribute_uint64(Handle, native_attribute);
			ulong ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_info_get_attribute_as_string(IntPtr raw, IntPtr attribute);

		public string GetAttributeAsString(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr raw_ret = g_file_info_get_attribute_as_string(Handle, native_attribute);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern long g_file_info_get_size(IntPtr raw);

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_size(IntPtr raw, long size);

		public long Size { 
			get {
				long raw_ret = g_file_info_get_size(Handle);
				long ret = raw_ret;
				return ret;
			}
			set {
				g_file_info_set_size(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_stringv(IntPtr raw, IntPtr attribute, IntPtr attr_value);

		public void SetAttributeStringv(string attribute, string attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_file_info_set_attribute_stringv(Handle, native_attribute, GLib.Marshaller.StringToPtrGStrdup(attr_value));
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_file_info_set_attribute_status(IntPtr raw, IntPtr attribute, int status);

		public bool SetAttributeStatus(string attribute, GLib.FileAttributeStatus status) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			bool raw_ret = g_file_info_set_attribute_status(Handle, native_attribute, (int) status);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_info_set_attribute_byte_string(IntPtr raw, IntPtr attribute, IntPtr attr_value);

		public void SetAttributeByteString(string attribute, string attr_value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr native_attr_value = GLib.Marshaller.StringToPtrGStrdup (attr_value);
			g_file_info_set_attribute_byte_string(Handle, native_attribute, native_attr_value);
			GLib.Marshaller.Free (native_attribute);
			GLib.Marshaller.Free (native_attr_value);
		}

#endregion
#region Customized extensions
#line 1 "FileInfo.custom"
// FileInfo.custom - customizations to GLib.FileInfo
//
// Authors: Ruben Vermeersch  <ruben@savanne.be>
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

~FileInfo ()
{
    Dispose ();
}

#endregion
	}
}
