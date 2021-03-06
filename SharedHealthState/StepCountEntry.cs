﻿using System;
using Stateless;

namespace SharedHealthState
{
	public class StepCountEntry : IIdentifiable
	{		
		public StepCountEntry()
		{
		}

		public StepCountEntry(double stepCount)
		{
			Count = stepCount;
		}

		public double Count {get; protected set;}
		public DateTime StartEntryDateTime {get; protected set;}
		public DateTime EndEntryDateTime {get; protected set;}

		public int ID
		{
			get {
				return Count.GetHashCode () + StartEntryDateTime.GetHashCode () + EndEntryDateTime.GetHashCode ();
			}
		}

		public override int GetHashCode ()
		{
			return this.ID;
		}

		public override bool Equals (object obj)
		{
			if (obj is StepCountEntry) {
				return ((StepCountEntry)obj).ID == ID;
			}
			return base.Equals (obj);
		}
	}
}

