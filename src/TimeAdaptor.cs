using System;
using System.Collections;

namespace FSpot {
	public class TimeAdaptor : GroupAdaptor, FSpot.ILimitable {
		public PhotoQuery query;

		ArrayList years = new ArrayList ();
		struct YearData {
			public int Year;
			public int [] Months;
		}

		public override event GlassSetHandler GlassSet;
		public override void SetGlass (int min)
		{
			DateTime date = DateFromIndex (min);
			
			if (GlassSet != null)
				GlassSet (this, LookupItem (date));
		}

		public int LookupItem (System.DateTime date)
		{
			int i = 0;
			while (i < query.Count && query [i].Time > date)
				i++;

			return i;
		}
		
		public void SetLimits (int min, int max) 
		{
			Console.WriteLine ("min {0} max {1}", min, max);
			DateTime start = DateFromIndex (min);
			DateTime end = DateFromIndex (max).AddMonths (1);
			
			Console.WriteLine ("{0} {1}", start, end);
			if (start > end)
				query.Range = new PhotoStore.DateRange (end, start);
			else 
				query.Range = new PhotoStore.DateRange (start, end);
				
		}

		public override int Count ()
		{
			return years.Count * 12;
		}

		public override string GlassLabel (int item)
		{
			DateTime start = DateFromIndex (item);
			
			return start.ToString ("MMMM yyyy");
		}

		public override string TickLabel (int item)
		{
			DateTime start = DateFromIndex (item);
			
			if (start.Month == 12)
				return start.Year.ToString ();
			else 
				return null;
		}

		public override int Value (int item)
		{
			YearData data = (YearData)years [item/12];

			return data.Months [item % 12];
		}

		public DateTime DateFromIndex (int item) 
		{
			item = Math.Max (item, 0);
			item = Math.Min (years.Count * 12 - 1, item);
			
			int year =  (int)((YearData)years [item / 12]).Year;
			int month = 12 - (item % 12);
			
			return new DateTime (year, month, DateTime.DaysInMonth (year, month)).AddDays (1.0).AddMilliseconds (-.1);
		}
		
		public override int IndexFromPhoto (FSpot.IBrowsableItem photo) 
		{
			int year = photo.Time.Year;
			int max_year = ((YearData)years [0]).Year;
			int min_year = ((YearData)years [years.Count - 1]).Year;
		
			if (year < min_year || year > max_year) {
				Console.WriteLine("TimeAdaptor.IndexFromPhoto year out of range[{1},{2}]: {0}", year, min_year, max_year);
				return 0;
			}

			int index = 12 - photo.Time.Month;

			for (int i = 0; i < years.Count; i++)
				if (year < ((YearData)years[i]).Year)
					index += 12;

			//Console.WriteLine("IndexFromPhoto " + photo.Name + " is " + index);

			return index;
		}

		private void HandleChanged (IBrowsableCollection sender)
		{
			Console.WriteLine ("Reloading");
			Reload ();
		}
		
		public override event ChangedHandler Changed;
		
		public override void Reload () 
		{
			years.Clear ();

			Photo [] photos = query.Store.Query (null, null);
			Array.Sort (query.Photos);
			Array.Reverse (query.Photos);
			Array.Reverse (photos);

			if (photos.Length > 0) {
				YearData data = new YearData ();
				data.Year = 0;

				foreach (Photo photo in photos) {
					int current = photo.Time.Year;
					if (current != data.Year) {
						
						data.Year = current;
						data.Months = new int [12];
						years.Add (data);
						//Console.WriteLine ("Found Year {0}", current);
					}
					data.Months [12 - photo.Time.Month] += 1;
				}
			} else {
				YearData data = new YearData ();
				data.Year = DateTime.Now.Year;
				data.Months = new int [12];
				years.Add (data);
			}

 			if (Changed != null)
				Changed (this);
		}


		public TimeAdaptor (PhotoQuery query) {
			this.query = query;
			this.query.Changed += HandleChanged;
			
			Reload ();
		}
	}
}
