// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core.queue
{
    /// <summary>
	/// <para>This class performs the auto flush of all layout relevant queues.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.queue.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager 
    {
		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Flush all layout queues in the correct order. This function is called
		/// deferred if <see cref="ScheduleFlush"/> is called.</para>
		/// </summary>
		[JsMethod(Name = "flush")]
		public static void Flush() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Schedule a deferred flush of all queues.</para>
		/// </summary>
		/// <param name="job">The job, which should be performed. Valid values are layout, decoration and element.</param>
		[JsMethod(Name = "scheduleFlush")]
		public static void ScheduleFlush(string job) { throw new NotImplementedException(); }

		#endregion Methods
    }
}