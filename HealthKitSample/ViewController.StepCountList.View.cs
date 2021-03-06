﻿using System;
using Stateless;
using SharedHealthState;
using System.Linq;

namespace HealthKitSample
{
	partial class ViewController : IListView<StepCountEntry>
	{
		#region IListView implementation

		public void Receive (System.Collections.Generic.IList<StepCountEntry> list, System.Collections.Generic.IList<Stateless.Change> changeset)
		{
			this.weeklyStepCountValue.Text = list.Where(s => (DateTime.Now - s.StartEntryDateTime).TotalDays < 7).Sum(s => s.Count).ToString();
		}

		#endregion
	}
}

