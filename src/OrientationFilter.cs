namespace FSpot {
	public class OrientationFilter {
		public static bool Convert (string source, string dest)
		{
			ImageFile img = ImageFile.Create (source);
			bool changed = false;
			
			if (img.Orientation != PixbufOrientation.TopLeft && img is JpegFile) {
				JpegFile jimg = img as JpegFile;
				
				if (img.Orientation == PixbufOrientation.RightTop) {
					JpegUtils.Transform (source,
							     dest,
							     JpegUtils.TransformType.Rotate90);
					changed = true;
				} else if (img.Orientation == PixbufOrientation.LeftBottom) {
					JpegUtils.Transform (source,
							     dest,
							     JpegUtils.TransformType.Rotate270);
					changed = true;
				} else if (img.Orientation == PixbufOrientation.BottomRight) {
					JpegUtils.Transform (source,
							     dest,
							     JpegUtils.TransformType.Rotate180);
					changed = true;
				}
				
				jimg.SetOrientation (PixbufOrientation.TopLeft);
				jimg.SaveMetaData (dest);
			}

			return changed;
		}
	}
}
