// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class FileOutputStream : GLib.OutputStream, GLib.Seekable {

		[Obsolete]
		protected FileOutputStream(GLib.GType gtype) : base(gtype) {}
		public FileOutputStream(IntPtr raw) : base(raw) {}

		protected FileOutputStream() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_output_stream_get_etag(IntPtr raw);

		public string Etag { 
			get {
				IntPtr raw_ret = g_file_output_stream_get_etag(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe IntPtr g_file_output_stream_query_info(IntPtr raw, IntPtr attributes, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.FileInfo QueryInfo(string attributes, GLib.Cancellable cancellable) {
			IntPtr native_attributes = GLib.Marshaller.StringToPtrGStrdup (attributes);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_file_output_stream_query_info(Handle, native_attributes, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.FileInfo ret = GLib.Object.GetObject(raw_ret) as GLib.FileInfo;
			GLib.Marshaller.Free (native_attributes);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_file_output_stream_query_info_async(IntPtr raw, IntPtr attributes, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void QueryInfoAsync(string attributes, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_attributes = GLib.Marshaller.StringToPtrGStrdup (attributes);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_file_output_stream_query_info_async(Handle, native_attributes, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_attributes);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_file_output_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_file_output_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe IntPtr g_file_output_stream_query_info_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.FileInfo QueryInfoFinish(GLib.AsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_file_output_stream_query_info_finish(Handle, result == null ? IntPtr.Zero : result.Handle, out error);
			GLib.FileInfo ret = GLib.Object.GetObject(raw_ret) as GLib.FileInfo;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_seekable_can_truncate(IntPtr raw);

		public bool CanTruncate() {
			bool raw_ret = g_seekable_can_truncate(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern long g_seekable_tell(IntPtr raw);

		public long Position { 
			get {
				long raw_ret = g_seekable_tell(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_seekable_truncate(IntPtr raw, long offset, IntPtr cancellable, out IntPtr error);

		public bool Truncate(long offset, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_seekable_truncate(Handle, offset, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_seekable_seek(IntPtr raw, long offset, GLib.SeekType type, IntPtr cancellable, out IntPtr error);

		public bool Seek(long offset, GLib.SeekType type, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_seekable_seek(Handle, offset, type, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_seekable_can_seek(IntPtr raw);

		public bool CanSeek { 
			get {
				bool raw_ret = g_seekable_can_seek(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}
