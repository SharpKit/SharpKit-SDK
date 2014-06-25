using SharpKit.JavaScript;

namespace SharpKit.Rx
{
	// ReSharper disable InconsistentNaming

	#region Classes

	#region Pattern

	/// <summary>
	/// Represents a join pattern.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public abstract class Pattern
	{
	}

	/// <summary>
	/// Represents a join pattern.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public abstract class Pattern<T1, T2> : Pattern
	{
		/// <summary>
		/// Creates a pattern that matches the current plan matches and when the specified observable sequences has an available value.
		/// </summary>
		/// <param name="other">Observable sequence to match in addition to the current pattern.</param>
		/// <returns>Pattern object that matches when all observable sequences in the pattern have an available value.</returns>
		public Pattern<T1, T2, T3> and<T3>(IObservable<T3> other) { return null; }

		/// <summary>
		/// Matches when all observable sequences in the pattern (specified using a chain of and operators) have an available value and projects the values.
		/// </summary>
		/// <param name="selector">Selector that will be invoked with available values from the source sequences, in the same order of the sequences in the pattern.</param>
		/// <returns>Plan that produces the projected values, to be fed (with other plans) to the when operator.</returns>
		public Plan<TResult> then<TResult>(JsFunc<T1, T2, TResult> selector) { return null; }
	}

	/// <summary>
	/// Represents a join pattern.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public abstract class Pattern<T1, T2, T3> : Pattern
	{
		/// <summary>
		/// Creates a pattern that matches the current plan matches and when the specified observable sequences has an available value.
		/// </summary>
		/// <param name="other">Observable sequence to match in addition to the current pattern.</param>
		/// <returns>Pattern object that matches when all observable sequences in the pattern have an available value.</returns>
		public Pattern<T1, T2, T3, T4> and<T4>(IObservable<T4> other) { return null; }

		/// <summary>
		/// Matches when all observable sequences in the pattern (specified using a chain of and operators) have an available value and projects the values.
		/// </summary>
		/// <param name="selector">Selector that will be invoked with available values from the source sequences, in the same order of the sequences in the pattern.</param>
		/// <returns>Plan that produces the projected values, to be fed (with other plans) to the when operator.</returns>
		public Plan<TResult> then<TResult>(JsFunc<T1, T2, T3, TResult> selector) { return null; }
	}

	/// <summary>
	/// Represents a join pattern.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public abstract class Pattern<T1, T2, T3, T4> : Pattern
	{
		/// <summary>
		/// Creates a pattern that matches the current plan matches and when the specified observable sequences has an available value.
		/// </summary>
		/// <param name="other">Observable sequence to match in addition to the current pattern.</param>
		/// <returns>Pattern object that matches when all observable sequences in the pattern have an available value.</returns>
		public Pattern<T1, T2, T3, T4, T5> and<T5>(IObservable<T5> other) { return null; }

		/// <summary>
		/// Matches when all observable sequences in the pattern (specified using a chain of and operators) have an available value and projects the values.
		/// </summary>
		/// <param name="selector">Selector that will be invoked with available values from the source sequences, in the same order of the sequences in the pattern.</param>
		/// <returns>Plan that produces the projected values, to be fed (with other plans) to the when operator.</returns>
		public Plan<TResult> then<TResult>(JsFunc<T1, T2, T3, T4, TResult> selector) { return null; }
	}

	/// <summary>
	/// Represents a join pattern.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public abstract class Pattern<T1, T2, T3, T4, T5> : Pattern
	{
		/// <summary>
		/// Creates a pattern that matches the current plan matches and when the specified observable sequences has an available value.
		/// </summary>
		/// <param name="other">Observable sequence to match in addition to the current pattern.</param>
		/// <returns>Pattern object that matches when all observable sequences in the pattern have an available value.</returns>
		public Pattern<T1, T2, T3, T4, T5, T6> and<T6>(IObservable<T6> other) { return null; }

		/// <summary>
		/// Matches when all observable sequences in the pattern (specified using a chain of and operators) have an available value and projects the values.
		/// </summary>
		/// <param name="selector">Selector that will be invoked with available values from the source sequences, in the same order of the sequences in the pattern.</param>
		/// <returns>Plan that produces the projected values, to be fed (with other plans) to the when operator.</returns>
		public Plan<TResult> then<TResult>(JsFunc<T1, T2, T3, T4, T5, TResult> selector) { return null; }
	}

	/// <summary>
	/// Represents a join pattern.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public abstract class Pattern<T1, T2, T3, T4, T5, T6> : Pattern
	{
		/// <summary>
		/// Matches when all observable sequences in the pattern (specified using a chain of and operators) have an available value and projects the values.
		/// </summary>
		/// <param name="selector">Selector that will be invoked with available values from the source sequences, in the same order of the sequences in the pattern.</param>
		/// <returns>Plan that produces the projected values, to be fed (with other plans) to the when operator.</returns>
		public Plan<TResult> then<TResult>(JsFunc<T1, T2, T3, T4, T5, T6, TResult> selector) { return null; }
	}

	#endregion

	#region Plan

	/// <summary>
	/// Represents an execution plan for join patterns.
	/// </summary>
	/// <typeparam name="TResult">The type of result.</typeparam>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public abstract class Plan<TResult>
	{
	}

	#endregion

	#region Observable

	public static partial class Observable
	{
		/// <summary>
		/// Creates a pattern that matches when both observable sequences have an available value.
		/// </summary>
		/// <param name="left">Observable sequence to match with the right sequence.</param>
		/// <param name="right">Observable sequence to match with the current sequence.</param>
		/// <returns>Pattern object that matches when both observable sequences have an available value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static Pattern<TLeft, TRight> and<TLeft, TRight>(this IObservable<TLeft> left, IObservable<TRight> right) { return null; }

		/// <summary>
		/// Matches when the observable sequence has an available value and projects the value.
		/// </summary>
		/// <param name="source">Observable sequence to apply the selector on.</param>
		/// <param name="selector">Selector that will be invoked for values in the source sequence.</param>
		/// <returns>Plan that produces the projected values, to be fed (with other plans) to the when operator.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static Plan<TResult> then<TSource, TResult>(this IObservable<TSource> source, JsFunc<TSource, TResult> selector) { return null; }

		/// <summary>
		/// Joins together the results from several patterns.
		/// </summary>
		/// <param name="plans">A series of plans (specified as an Array of as a series of arguments) created by use of the Then operator on patterns.</param>
		/// <returns>Observable sequence with the results form matching several patterns.</returns>
		[JsMethod(NativeParams = true)]
		public static IObservable<TResult> when<TResult>(params Plan<TResult>[] plans) { return null; }
	}

	#endregion

	#endregion

	// ReSharper restore InconsistentNaming
}
