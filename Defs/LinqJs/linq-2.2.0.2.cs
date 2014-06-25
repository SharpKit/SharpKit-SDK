using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Html;
using SharpKit.JavaScript;
[assembly:JsType(JsMode.Prototype, Export=false)]
namespace SharpKit.LinqJs
{
    //TODO: add Params_Contents overload using params
    /*--------------------------------------------------------------------------
    * linq-vsdoc.js - LINQ for JavaScript
    * ver 2.2.0.2 (Jan. 21th, 2011)
    *
    * created and maintained by neuecc <ils@neue.cc>
    * licensed under Microsoft Public License(Ms-PL)
    * http://neue.cc/
    * http://linqjs.codeplex.com/
    *--------------------------------------------------------------------------*/
    [JsType(JsMode.Prototype, Export=false, Name="Enumerable")]
    public static class Enumerable
    {

        /// <summary>Random choice from arguments.
        /// Ex: Choice(1,2,3) - 1,3,2,3,3,2,1...</summary>
        /// <param type="T" name="Params_Contents" parameterArray="true">Array or Params Contents</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Choice<T>(JsArray<T> Params_Contents) { return null; }

        /// <summary>Cycle Repeat from arguments.
        /// Ex: Cycle(1,2,3) - 1,2,3,1,2,3,1,2,3...</summary>
        /// <param type="T" name="Params_Contents" parameterArray="true">Array or Params Contents</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Cycle<T>(JsArray<T> Params_Contents) { return null; }

        /// <summary>Returns an empty Enumerable.</summary>
        /// <returns type="Enumerable"></returns>         
        public static Enumerable<T> Empty<T>() { return null; }

        /// <summary>
        /// Make Enumerable from obj.
        /// 1. null = Enumerable.Empty().
        /// 2. Enumerable = Enumerable.
        /// 3. Number/Boolean = Enumerable.Repeat(obj, 1).
        /// 4. String = to CharArray.(Ex:"abc" => "a","b","c").
        /// 5. Object/Function = to KeyValuePair(except function) Ex:"{a:0}" => (.Key=a, .Value=0).
        /// 6. Array or ArrayLikeObject(has length) = to Enumerable.
        /// 7. JScript's IEnumerable = to Enumerable(using Enumerator).
        /// </summary>
        /// <param name="list">list</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> From<T>(JsArray<T> list) { return null; } //TODO:

        /// <summary>Make one sequence. This equals Repeat(element, 1)</summary>
        /// <param name="element">element</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Return<T>(T element) { return null; }

        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <param type="Optional:String" name="flags" optional="true">If pattern is String then can use regexp flags "i" or "m" or "im"</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsString> Matches<T>(JsString input, JsRegExp pattern, JsString flags) { return null; }
        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsString> Matches<T>(JsString input, JsRegExp pattern) { return null; }
        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <param type="Optional:String" name="flags" optional="true">If pattern is String then can use regexp flags "i" or "m" or "im"</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsString> Matches<T>(JsString input, JsString pattern, JsString flags) { return null; }
        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsString> Matches<T>(JsString input, JsString pattern) { return null; }

        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: Range(1,5) - 1,2,3,4,5</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:Range(0,3,5) - 0,5,10)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsNumber> Range<T>(JsNumber start, JsNumber count, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: Range(1,5) - 1,2,3,4,5</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsNumber> Range<T>(JsNumber start, JsNumber count) { return null; }

        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: RangeDown(5,5) - 5,4,3,2,1</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:RangeDown(0,3,5) - 0,-5,-10)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsNumber> RangeDown<T>(JsNumber start, JsNumber count, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: RangeDown(5,5) - 5,4,3,2,1</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsNumber> RangeDown<T>(JsNumber start, JsNumber count) { return null; }

        /// <summary>Generates a sequence of integral numbers.
        /// Ex: RangeTo(10,12) - 10,11,12 RangeTo(0,-2) - 0, -1, -2</summary>
        /// <param type="Number" integer="true" name="start">start integer</param>
        /// <param type="Number" integer="true" name="to">to integer</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:RangeTo(0,7,3) - 0,3,6)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsNumber> RangeTo<T>(JsNumber start, JsNumber to, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers.
        /// Ex: RangeTo(10,12) - 10,11,12 RangeTo(0,-2) - 0, -1, -2</summary>
        /// <param type="Number" integer="true" name="start">start integer</param>
        /// <param type="Number" integer="true" name="to">to integer</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<JsNumber> RangeTo<T>(JsNumber start, JsNumber to) { return null; }

        /// <summary>Generates a sequence that contains one repeated value.
        /// If omit count then generate to infinity.
        /// Ex: Repeat("foo",3) - "foo","foo","foo"</summary>
        /// <param type="TResult" name="obj">The value to be repeated.</param>
        /// <param type="Optional:Number" integer="true" name="count" optional="true">The number of times to repeat the value in the generated sequence.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Repeat<T>(T obj, JsNumber count) { return null; }
        /// <summary>Generates a sequence that contains one repeated value.
        /// If omit count then generate to infinity.
        /// Ex: Repeat("foo",3) - "foo","foo","foo"</summary>
        /// <param type="TResult" name="obj">The value to be repeated.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Repeat<T>(T obj) { return null; }

        /// <summary>Lazy Generates one value by initializer's result and do finalize when enumerate end</summary>
        /// <param type="Func&lt;T>" name="initializer">value factory.</param>
        /// <param type="Action&lt;T>" name="finalizer">execute when finalize.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> RepeatWithFinalize<T>(JsFunc<T> initializer, JsAction<T> finalizer) { return null; }

        /// <summary>Generates a sequence that execute func value.
        /// If omit count then generate to infinity.
        /// Ex: Generate("Math.random()", 5) - 0.131341,0.95425252,...</summary>
        /// <param type="Func&lt;T>" name="func">The value of execute func to be repeated.</param>
        /// <param type="Optional:Number" integer="true" name="count" optional="true">The number of times to repeat the value in the generated sequence.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Generate<T>(JsFunc<T> func, JsNumber count) { return null; }
        /// <summary>Generates a sequence that execute func value.
        /// If omit count then generate to infinity.
        /// Ex: Generate("Math.random()", 5) - 0.131341,0.95425252,...</summary>
        /// <param type="Func&lt;T>" name="func">The value of execute func to be repeated.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Generate<T>(JsFunc<T> func) { return null; }

        /// <summary>Generates a sequence of integral numbers to infinity.
        /// Ex: ToInfinity() - 0,1,2,3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:ToInfinity(10,3) - 10,13,16,19,...)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> ToInfinity<T>(JsNumber start, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers to infinity.
        /// Ex: ToInfinity() - 0,1,2,3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> ToInfinity<T>(JsNumber start) { return null; }
        /// <summary>Generates a sequence of integral numbers to infinity.
        /// Ex: ToInfinity() - 0,1,2,3...</summary>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> ToInfinity<T>() { return null; }

        /// <summary>Generates a sequence of integral numbers to negative infinity.
        /// Ex: ToNegativeInfinity() - 0,-1,-2,-3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:ToNegativeInfinity(10,3) - 10,7,4,1,...)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> ToNegativeInfinity<T>(JsNumber start, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers to negative infinity.
        /// Ex: ToNegativeInfinity() - 0,-1,-2,-3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> ToNegativeInfinity<T>(JsNumber start) { return null; }
        /// <summary>Generates a sequence of integral numbers to negative infinity.
        /// Ex: ToNegativeInfinity() - 0,-1,-2,-3...</summary>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> ToNegativeInfinity<T>() { return null; }

        /// <summary>Applies function and generates a infinity sequence.
        /// Ex: Unfold(3,"$+10") - 3,13,23,...</summary>
        /// <param type="T" name="seed">The initial accumulator value.</param>
        /// <param type="Func&lt;T,T>" name="func">An accumulator function to be invoked on each element.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable<T> Unfold<T>(T seed, JsFunc<T, T> func) { return null; }
    }
    public class Enumerable<T>
    {
        public Enumerable(JsFunc<Enumerable<T>> getEnumerator) { }
        public Enumerable() { }

        #region NoRegionMethods
        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use breadth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T>_or_Func&lt;T,int>" optional="true">Optional:the second parameter of the function represents the nestlevel of the source sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> CascadeBreadthFirst(JsFunc<T, JsArray<T>> func, JsFunc<T> resultSelector) { return null; }
        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use breadth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T>_or_Func&lt;T,int>" optional="true">Optional:the second parameter of the function represents the nestlevel of the source sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> CascadeBreadthFirst(JsFunc<T, JsArray<T>> func, JsFunc<T, JsNumber> resultSelector) { return null; }
        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use breadth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> CascadeBreadthFirst(JsFunc<T, JsArray<T>> func) { return null; }

        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use depth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T>_or_Func&lt;T,int>" optional="true">Optional:the second parameter of the function represents the nestlevel of the source sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> CascadeDepthFirst(JsFunc<T, JsArray<T>> func, JsFunc<T> resultSelector) { return null; }
        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use depth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T>_or_Func&lt;T,int>" optional="true">Optional:the second parameter of the function represents the nestlevel of the source sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> CascadeDepthFirst(JsFunc<T, JsArray<T>> func, JsFunc<T, JsNumber> resultSelector) { return null; }
        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use depth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> CascadeDepthFirst(JsFunc<T, JsArray<T>> func) { return null; }

        /// <summary>Flatten sequences into one sequence.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Flatten() { return null; }

        /// <summary>Projects current and next element of a sequence into a new form.</summary>
        /// <param type="Func&lt;TSource,TSource,TResult>" name="selector">A transform function to apply to current and next element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<TResult> Pairwise<TResult>(JsFunc<T, T, TResult> selector) { return null; }

        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <param name="func" type="Optional:Func&lt;TAccumulate,T,TAccumulate>" optional="true">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;TAccumulate,TResult>" optional="true">A function to transform the final accumulator value into the result value.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<TResult> Scan<TAccumulate, TResult>(JsFunc<T, T, T> func_or_seed, JsFunc<TAccumulate, T, TAccumulate> func, Func<TAccumulate, TResult> resultSelector) { return null; }
        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Scan(JsFunc<T, T, T> func_or_seed) { return null; }
        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <param name="func" type="Optional:Func&lt;TAccumulate,T,TAccumulate>" optional="true">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;TAccumulate,TResult>" optional="true">A function to transform the final accumulator value into the result value.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<TResult> Scan<TAccumulate, TResult>(TAccumulate func_or_seed, JsFunc<TAccumulate, T, TAccumulate> func, Func<TAccumulate, TResult> resultSelector) { return null; }
        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Scan<TAccumulate>(TAccumulate func_or_seed) { return null; }


        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <param name="selector" type="Func&lt;T,T>_or_Func&lt;T,int,T>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Select(JsFunc<T, T> selector) { return null; }
        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <param name="selector" type="Func&lt;T,T>_or_Func&lt;T,int,T>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Select(JsFunc<T, JsNumber, T> selector) { return null; }

        /// <summary>Projects each element of a sequence and flattens the resulting sequences into one sequence.</summary>
        /// <param name="collectionSelector" type="Func&lt;T,TCollection[]>_or_Func&lt;T,int,TCollection[]>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T,TCollection,TResult>" optional="true">Optional:A transform function to apply to each element of the intermediate sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SelectMany<TCollection, TResult>(JsFunc<T, JsArray<TCollection>> collectionSelector, JsFunc<T, TCollection, TResult> resultSelector) { return null; }
        //TODO: CHECK
        /// <summary>Projects each element of a sequence and flattens the resulting sequences into one sequence.</summary>
        /// <param name="collectionSelector" type="Func&lt;T,TCollection[]>_or_Func&lt;T,int,TCollection[]>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SelectMany<TCollection>(JsFunc<T, JsArray<TCollection>> collectionSelector) { return null; }
        //TODO: CHECK
        /// <summary>Projects each element of a sequence and flattens the resulting sequences into one sequence.</summary>
        /// <param name="collectionSelector" type="Func&lt;T,TCollection[]>_or_Func&lt;T,int,TCollection[]>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T,TCollection,TResult>" optional="true">Optional:A transform function to apply to each element of the intermediate sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SelectMany<TCollection, TResult>(JsFunc<T, JsNumber, TCollection> collectionSelector, JsFunc<T, TCollection, TResult> resultSelector) { return null; }
        //TODO: CHECK
        /// <summary>Projects each element of a sequence and flattens the resulting sequences into one sequence.</summary>
        /// <param name="collectionSelector" type="Func&lt;T,TCollection[]>_or_Func&lt;T,int,TCollection[]>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SelectMany<TCollection>(JsFunc<T, JsNumber, TCollection> collectionSelector) { return null; }
        //TODO: CHECK

        /// <summary>Filters a sequence of values based on a predicate.</summary>
        /// <param name="predicate" type="Func&lt;T,bool>_or_Func&lt;T,int,bool>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Where(JsFunc<T, bool> predicate) { return null; }
        /// <summary>Filters a sequence of values based on a predicate.</summary>
        /// <param name="predicate" type="Func&lt;T,bool>_or_Func&lt;T,int,bool>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Where(JsFunc<T, JsNumber, bool> predicate) { return null; }

        /// <summary>Filters the elements based on a specified type.</summary>
        /// <param name="type" type="T">The type to filter the elements of the sequence on.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> OfType(T type) { return null; }

        /// <summary>Merges two sequences by using the specified predicate function.</summary>
        /// <param name="second" type="T[]">The second sequence to merge.</param>
        /// <param name="selector" type="Func&lt;TFirst,TSecond,TResult>_or_Func&lt;TFirst,TSecond,int,TResult>">A function that specifies how to merge the elements from the two sequences. Optional:the third parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public object Zip<TFirst, TSecond, TResult>(JsArray<T> second, JsFunc<TFirst, TSecond, TResult> selector) { return null; }
        //TODO: CHECK
        /// <summary>Merges two sequences by using the specified predicate function.</summary>
        /// <param name="second" type="T[]">The second sequence to merge.</param>
        /// <param name="selector" type="Func&lt;TFirst,TSecond,TResult>_or_Func&lt;TFirst,TSecond,int,TResult>">A function that specifies how to merge the elements from the two sequences. Optional:the third parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public object Zip<TFirst, TSecond, TResult>(JsArray<T> second, JsFunc<TFirst, TSecond, JsNumber, TResult> selector) { return null; }
        //TODO: CHECK

        #endregion

        #region Join Methods

        /// <summary>Correlates the elements of two sequences based on matching keys.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter,TKey>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner,TKey>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,TInner,TResult>">A function to create a result element from two matching elements.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Join<TOuter, TInner, TResult, TKey, TCompare>(JsArray<T> inner, JsFunc<TOuter, TKey> outerKeySelector, JsFunc<TInner, TKey> innerKeySelector, JsFunc<TOuter, TInner, TResult> resultSelector, JsFunc<TKey, TCompare> compareSelector) { return null; }
        //TODO: CHECK
        /// <summary>Correlates the elements of two sequences based on matching keys.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter,TKey>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner,TKey>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,TInner,TResult>">A function to create a result element from two matching elements.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Join<TOuter, TInner, TResult, TKey>(JsArray<T> inner, JsFunc<TOuter, TKey> outerKeySelector, JsFunc<TInner, TKey> innerKeySelector, JsFunc<TOuter, TInner, TResult> resultSelector) { return null; }
        //TODO: CHECK

        /// <summary>Correlates the elements of two sequences based on equality of keys and groups the results.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,Enumerable&lt;T>&lt;TInner>,TResult">A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> GroupJoin<TOuter, TInner, TResult, TKey, TCompare>(JsArray<T> inner, JsFunc<TOuter> outerKeySelector, JsFunc<TInner> innerKeySelector, JsFunc<TOuter, Enumerable<T>, TInner, TResult> resultSelector, JsFunc<TKey, TCompare> compareSelector) { return null; }
        //TODO: CHECK
        /// <summary>Correlates the elements of two sequences based on equality of keys and groups the results.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,Enumerable&lt;T>&lt;TInner>,TResult">A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> GroupJoin<TOuter, TInner, TResult>(JsArray<T> inner, JsFunc<TOuter> outerKeySelector, JsFunc<TInner> innerKeySelector, JsFunc<TOuter, Enumerable<T>, TInner, TResult> resultSelector) { return null; }
        //TODO: CHECK

        #endregion

        #region Set Methods
        /// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
        /// <param type="Func&lt;T,bool>" name="predicate">A function to test each element for a condition.</param>
        /// <returns type="Boolean"></returns>
        public bool All(JsFunc<T, bool> predicate) { return false; }

        /// <summary>Determines whether a sequence contains any elements or any element of a sequence satisfies a condition.</summary>
        /// <param name="predicate" type="Optional:Func&lt;T,bool>" optional="true">A function to test each element for a condition.</param>
        /// <returns type="Boolean"></returns>
        public bool Any(JsFunc<T, bool> predicate) { return false; }
        /// <summary>Determines whether a sequence contains any elements or any element of a sequence satisfies a condition.</summary>
        /// <returns type="Boolean"></returns>
        public bool Any() { return false; }

        /// <summary>Concatenates two sequences.</summary>
        /// <param name="second" type="T[]">The sequence to concatenate to the first sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Concat(JsArray<T> second) { return null; }

        /// <summary>Merge two sequences.</summary>
        /// <param name="index" type="Number" integer="true">The index of insert start position.</param>
        /// <param name="second" type="T[]">The sequence to concatenate to the first sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Insert(JsNumber index, JsArray<T> second) { return null; }

        /// <summary>Insert value to between sequence.</summary>
        /// <param name="value" type="T">The value of insert.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Alternate(T value) { return null; }

        /// <summary>Determines whether a sequence contains a specified element.</summary>
        /// <param name="value" type="T">The value to locate in the sequence.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Boolean"></returns>
        public bool Contains<TKey>(T value, JsFunc<T, TKey> compareSelector) { return false; }
        //TODO: check
        /// <summary>Determines whether a sequence contains a specified element.</summary>
        /// <param name="value" type="T">The value to locate in the sequence.</param>
        /// <returns type="Boolean"></returns>
        public bool Contains<TKey>(T value) { return false; }
        //TODO: check

        /// <summary>Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.</summary>
        /// <param name="defaultValue" type="T">The value to return if the sequence is empty.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> DefaultIfEmpty(T defaultValue) { return null; }

        /// <summary>Returns distinct elements from a sequence.</summary>
        /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Distinct<TKey>(JsFunc<T, TKey> compareSelector) { return null; }
        //TODO: check
        /// <summary>Returns distinct elements from a sequence.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Distinct() { return null; }
        //TODO: check

        /// <summary>Produces the set difference of two sequences.</summary>
        /// <param name="second" type="T[]">An T[] whose Elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Except<TKey>(JsArray<T> second, JsFunc<T, TKey> compareSelector) { return null; }
        //TODO: check
        /// <summary>Produces the set difference of two sequences.</summary>
        /// <param name="second" type="T[]">An T[] whose Elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Except(JsArray<T> second) { return null; }
        //TODO: check

        /// <summary>Produces the set difference of two sequences.</summary>
        /// <param name="second" type="T[]">An T[] whose distinct elements that also appear in the first sequence will be returned.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Intersect<TKey>(JsArray<T> second, JsFunc<T, TKey> compareSelector) { return null; }
        //TODO: check
        /// <summary>Produces the set difference of two sequences.</summary>
        /// <param name="second" type="T[]">An T[] whose distinct elements that also appear in the first sequence will be returned.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Intersect(JsArray<T> second) { return null; }
        //TODO: check

        /// <summary>Determines whether two sequences are equal by comparing the elements.</summary>
        /// <param name="second" type="T[]">An T[] to compare to the first sequence.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SequenceEqual<TKey>(JsArray<T> second, JsFunc<T, TKey> compareSelector) { return null; }
        //TODO: check
        /// <summary>Determines whether two sequences are equal by comparing the elements.</summary>
        /// <param name="second" type="T[]">An T[] to compare to the first sequence.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SequenceEqual(JsArray<T> second) { return null; }
        //TODO: check

        /// <summary>Produces the union of two sequences.</summary>
        /// <param name="second" type="T[]">An T[] whose distinct elements form the second set for the union.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Union<TKey>(JsArray<T> second, JsFunc<T, TKey> compareSelector) { return null; }
        /// <summary>Produces the union of two sequences.</summary>
        /// <param name="second" type="T[]">An T[] whose distinct elements form the second set for the union.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Union<TKey>(JsArray<T> second) { return null; }

        #endregion

        #region Ordering Methods
        /// <summary>Sorts the elements of a sequence in ascending order according to a key.</summary>
        /// <param name="keySelector" type="Optional:Func&lt;T,TKey>">A function to extract a key from an element.</param>
        /// return new OrderedEnumerable();
        public OrderedEnumerable<T> OrderBy<TKey>(JsFunc<T, TKey> keySelector) { return null; }
        //TODO: check + return type?
        /// <summary>Sorts the elements of a sequence in ascending order according to a key.</summary>
        /// return new OrderedEnumerable();
        public OrderedEnumerable<T> OrderBy() { return null; }
        //TODO: check + return type?

        /// <summary>Sorts the elements of a sequence in descending order according to a key.</summary>
        /// <param name="keySelector" type="Optional:Func&lt;T,TKey>">A function to extract a key from an element.</param>
        ///return new OrderedEnumerable();
        public OrderedEnumerable<T> OrderByDescending<TKey>(JsFunc<T, TKey> keySelector) { return null; }
        //TODO: check + return type?
        /// <summary>Sorts the elements of a sequence in descending order according to a key.</summary>
        ///return new OrderedEnumerable();
        public OrderedEnumerable<T> OrderByDescending<TKey>() { return null; }
        //TODO: check + return type?

        /// <summary>Inverts the order of the elements in a sequence.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Reverse() { return null; }

        /// <summary>Shuffle sequence.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Shuffle() { return null; }


        #endregion

        #region Grouping Methods

        /// <summary>Groups the elements of a sequence according to a specified key selector function.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract the key for each element.</param>
        /// <param name="elementSelector" type="Optional:Func&lt;T,TElement>">A function to map each source element to an element in an Grouping&lt;TKey, TElement>.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;TKey,Enumerable&lt;T>&lt;TElement>,TResult>">A function to create a result value from each group.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> GroupBy<TKey, TElement, TResult, TCompare>(JsFunc<T, TKey> keySelector, JsFunc<T, TElement> elementSelector, JsFunc<TKey, Enumerable<T>, TElement, TResult> resultSelector, JsFunc<TKey, TCompare> compareSelector) { return null; }
        //TODO: CHECK                               
        /// <summary>Groups the elements of a sequence according to a specified key selector function.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract the key for each element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> GroupBy<TKey>(JsFunc<T, TKey> keySelector) { return null; }
        //TODO: CHECK

        /// <summary>Create Group by continuation key.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract the key for each element.</param>
        /// <param name="elementSelector" type="Optional:Func&lt;T,TElement>">A function to map each source element to an element in an Grouping&lt;TKey, TElement>.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;TKey,Enumerable&lt;T>&lt;TElement>,TResult>">A function to create a result value from each group.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> PartitionBy<TKey, TElement, TResult, TCompare>(JsFunc<T, TKey> keySelector, JsFunc<T, TElement> elementSelector, JsFunc<TKey, Enumerable<T>, TElement, TResult> resultSelector, JsFunc<TKey, TCompare> compareSelector) { return null; }
        //TODO: CHECK
        /// <summary>Create Group by continuation key.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract the key for each element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> PartitionBy<TKey>(JsFunc<T, TKey> keySelector) { return null; }
        //TODO: CHECK

        /// <summary>Divide by count</summary>
        /// <param name="count" type="Number" integer="true">integer</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> BufferWithCount(JsNumber count) { return null; }


        #endregion

        #region Aggregate Methods

        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <param name="func" type="Optional:Func&lt;TAccumulate,T,TAccumulate>" optional="true">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;TAccumulate,TResult>" optional="true">A function to transform the final accumulator value into the result value.</param>
        /// <returns type="TResult"></returns>
        public TResult Aggregate<TAccumulate, TResult>(JsFunc<T, T, T> func_or_seed, JsFunc<TAccumulate, T, TAccumulate> func, JsFunc<TAccumulate, TResult> resultSelector) { return default(TResult); }
        //TODO: check
        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <returns type="TResult"></returns>
        public T Aggregate(JsFunc<T, T, T> func_or_seed) { return default(T); }
        //TODO: check

        /// <summary>Computes the average of a sequence.</summary>
        /// <param name="selector" type="Optional:Func&lt;T,Number>" optional="true">A transform function to apply to each element.</param>
        /// <returns type="Number"></returns>
        public JsNumber Average(JsFunc<T, JsNumber> selector) { return null; }
        /// <summary>Computes the average of a sequence.</summary>
        /// <returns type="Number"></returns>
        public JsNumber Average() { return null; }

        /// <summary>Returns the number of elements in a sequence.</summary>
        /// <param name="predicate" type="Optional:Func&lt;T,Boolean>" optional="true">A function to test each element for a condition.</param>
        /// <returns type="Number"></returns>
        public JsNumber Count(JsFunc<T, bool> predicate) { return null; }
        /// <summary>Returns the number of elements in a sequence.</summary>
        /// <returns type="Number"></returns>
        public JsNumber Count() { return null; }

        /// <summary>Returns the maximum value in a sequence</summary>
        /// <param name="selector" type="Optional:Func&lt;T,TKey>" optional="true">A transform function to apply to each element.</param>
        /// <returns type="Number"></returns>
        public JsNumber Max<TKey>(JsFunc<T, TKey> selector) { return null; }
        /// <summary>Returns the maximum value in a sequence</summary>
        /// <returns type="Number"></returns>
        public JsNumber Max() { return null; }

        /// <summary>Returns the minimum value in a sequence</summary>
        /// <param name="selector" type="Optional:Func&lt;T,TKey>" optional="true">A transform function to apply to each element.</param>
        /// <returns type="Number"></returns>
        public JsNumber Min<TKey>(JsFunc<T, TKey> selector) { return null; }
        /// <summary>Returns the minimum value in a sequence</summary>
        /// <returns type="Number"></returns>
        public JsNumber Min() { return null; }

        /// <summary>Returns the maximum value in a sequence by keySelector</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A compare selector of element.</param>
        /// <returns type="T"></returns>
        public T MaxBy<TKey>(JsFunc<T, TKey> keySelector) { return default(T); }
        /// <summary>Returns the maximum value in a sequence by keySelector</summary>
        /// <returns type="T"></returns>
        public T MaxBy() { return default(T); }

        /// <summary>Returns the minimum value in a sequence by keySelector</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A compare selector of element.</param>
        /// <returns type="T"></returns>
        public T MinBy<TKey>(JsFunc<T, TKey> keySelector) { return default(T); }
        /// <summary>Returns the minimum value in a sequence by keySelector</summary>
        /// <returns type="T"></returns>
        public T MinBy() { return default(T); }

        /// <summary>Computes the sum of a sequence of values.</summary>
        /// <param name="selector" type="Optional:Func&lt;T,TKey>" optional="true">A transform function to apply to each element.</param>
        /// <returns type="Number"></returns>
        public JsNumber Sum<TKey>(JsFunc<T, TKey> selector) { return null; }
        /// <summary>Computes the sum of a sequence of values.</summary>
        /// <returns type="Number"></returns>
        public JsNumber Sum() { return null; }


        #endregion

        #region Paging Methods

        /// <summary>Returns the element at a specified index in a sequence.</summary>
        /// <param name="index" type="Number" integer="true">The zero-based index of the element to retrieve.</param>
        /// <returns type="T"></returns>
        public T ElementAt(JsNumber index) { return default(T); }

        /// <summary>Returns the element at a specified index in a sequence or a default value if the index is out of range.</summary>
        /// <param name="index" type="Number" integer="true">The zero-based index of the element to retrieve.</param>
        /// <param name="defaultValue" type="T">The value if the index is outside the bounds then send.</param>
        /// <returns type="T"></returns>
        public T ElementAtOrDefault(JsNumber index, T defaultValue) { return default(T); }

        /// <summary>Returns the first element of a sequence.</summary>
        /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>
        /// <returns type="T"></returns>
        public T First(JsFunc<T, bool> predicate) { return default(T); }

        /// <summary>Returns the first element of a sequence.</summary>
        /// <returns type="T"></returns>
        public T First() { return default(T); }

        /// <summary>Returns the first element of a sequence, or a default value.</summary>
        /// <param name="defaultValue" type="T">The value if not found then send.</param>
        /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>        
        /// <returns type="T"></returns>
        public T FirstOrDefault(T defaultValue, JsFunc<T, bool> predicate) { return default(T); }

        /// <summary>Returns the first element of a sequence, or a default value.</summary>
        /// <param name="defaultValue" type="T">The value if not found then send.</param>
        /// <returns type="T"></returns>
        public T FirstOrDefault(T defaultValue) { return default(T); }

        /// <summary>Returns the last element of a sequence.</summary>
        /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>
        /// <returns type="T"></returns>
        public T Last(JsFunc<T, bool> predicate) { return default(T); }

        /// <summary>Returns the last element of a sequence.</summary>
        /// <returns type="T"></returns>
        public T Last() { return default(T); }

        /// <summary>Returns the last element of a sequence, or a default value.</summary>
        /// <param name="defaultValue" type="T">The value if not found then send.</param>
        /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>        
        /// <returns type="T"></returns>
        public T LastOrDefault(T defaultValue, JsFunc<T, bool> predicate) { return default(T); }

        /// <summary>Returns the last element of a sequence, or a default value.</summary>
        /// <param name="defaultValue" type="T">The value if not found then send.</param>
        /// <returns type="T"></returns>
        public T LastOrDefault(T defaultValue) { return default(T); }

        /// <summary>Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.</summary>
        /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>
        /// <returns type="T"></returns>
        public T Single(JsFunc<T, bool> predicate) { return default(T); }

        /// <summary>Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.</summary>
        /// <returns type="T"></returns>
        public T Single() { return default(T); }

        /// <summary>Returns a single, specific element of a sequence of values, or a default value if no such element is found.</summary>
        /// <param name="defaultValue" type="T">The value if not found then send.</param>
        /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>        
        /// <returns type="T"></returns>
        public T SingleOrDefault(T defaultValue, JsFunc<T, bool> predicate) { return default(T); }

        /// <summary>Returns a single, specific element of a sequence of values, or a default value if no such element is found.</summary>
        /// <param name="defaultValue" type="T">The value if not found then send.</param>
        /// <returns type="T"></returns>
        public T SingleOrDefault(T defaultValue) { return default(T); }

        /// <summary>Bypasses a specified number of elements in a sequence and then returns the remaining elements.</summary>
        /// <param name="count" type="Number" integer="true">The number of elements to skip before returning the remaining elements.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Skip(JsNumber count) { return null; }

        /// <summary>Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.</summary>
        /// <param name="predicate" type="Func&lt;T,Boolean>_or_Func&lt;T,int,Boolean>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SkipWhile(JsFunc<T, bool> predicate) { return null; }
        /// <summary>Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.</summary>
        /// <param name="predicate" type="Func&lt;T,Boolean>_or_Func&lt;T,int,Boolean>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> SkipWhile(JsFunc<T, JsNumber, bool> predicate) { return null; }


        /// <summary>Returns a specified number of contiguous elements from the start of a sequence.</summary>
        /// <param name="count" type="Number" integer="true">The number of elements to return.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Take(JsNumber count) { return null; }

        /// <summary>Returns elements from a sequence as long as a specified condition is true, and then skips the remaining elements.</summary>
        /// <param name="predicate" type="Func&lt;T,Boolean>_or_Func&lt;T,int,Boolean>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> TakeWhile(JsFunc<T, bool> predicate) { return null; }
        /// <summary>Returns elements from a sequence as long as a specified condition is true, and then skips the remaining elements.</summary>
        /// <param name="predicate" type="Func&lt;T,Boolean>_or_Func&lt;T,int,Boolean>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> TakeWhile(JsFunc<T, JsNumber, bool> predicate) { return null; }

        /// <summary>Take a sequence except last count.</summary>
        /// <param name="count" type="Optional:Number" integer="true">The number of skip count.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> TakeExceptLast(JsNumber count) { return null; }
        /// <summary>Take a sequence except last count.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> TakeExceptLast() { return null; }

        /// <summary>Take a sequence from last count.</summary>
        /// <param name="count" type="Number" integer="true">The number of take count.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> TakeFromLast(JsNumber count) { return null; }

        /// <summary>Returns the zero-based index of the flrst occurrence of a value.</summary>
        /// <param name="item" type="T">The zero-based starting index of the search.</param>
        /// <returns type="Number" integer="true"></returns>
        public JsNumber IndexOf(T item) { return null; }

        /// <summary>Returns the zero-based index of the last occurrence of a value.</summary>
        /// <param name="item" type="T">The zero-based starting index of the search.</param>
        /// <returns type="Number" integer="true"></returns>
        public JsNumber LastIndexOf(T item) { return null; }

        #endregion

        #region Convert Methods

        /// <summary>Creates an array from this sequence.</summary>
        /// <returns type="Array"></returns>
        public JsArray<T> ToArray() { return null; }

        /// <summary>Creates a Lookup from this sequence.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        /// <param name="elementSelector" type="Optional:Func&lt;T,TElement>">A transform function to produce a result element value from each element.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        ///return new Lookup();
        public Lookup<TKey, TElement> ToLookup<TKey, TElement, TCompare>(JsFunc<T, TKey> keySelector, JsFunc<T, TElement> elementSelector, JsFunc<T, TKey, TCompare> compareSelector) { return null; }

        /// <summary>Creates a Lookup from this sequence.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        ///return new Lookup();
        public Lookup<TKey, T> ToLookup<TKey>(JsFunc<T, TKey> keySelector) { return null; }
        //TODO: return type?

        /// <summary>Creates a Object from this sequence.</summary>
        /// <param name="keySelector" type="Func&lt;T,String>">A function to extract a key from each element.</param>
        /// <param name="elementSelector" type="Func&lt;T,TElement>">A transform function to produce a result element value from each element.</param>
        /// <returns type="Object"></returns>
        public object ToObject<TElement>(JsFunc<T, JsString> keySelector, JsFunc<T, TElement> elementSelector) { return null; }

        /// <summary>Creates a Dictionary from this sequence.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        /// <param name="elementSelector" type="Func&lt;T,TElement>">A transform function to produce a result element value from each element.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        ///return new Dictionary();
        public Dictionary<TKey, TElement> ToDictionary<TKey, TElement, TCompare>(JsFunc<T, TKey> keySelector, JsFunc<T, TElement> elementSelector, JsFunc<T, TKey, TCompare> compareSelector) { return null; }
        /// <summary>Creates a Dictionary from this sequence.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        /// <param name="elementSelector" type="Func&lt;T,TElement>">A transform function to produce a result element value from each element.</param>
        ///return new Dictionary();
        public Dictionary<TKey, TElement> ToDictionary<TKey, TElement>(JsFunc<T, TKey> keySelector, JsFunc<T, TElement> elementSelector) { return null; }

        /// <summary>Creates a JSON String from sequence, performed only native JSON support browser or included json2.js.</summary>
        /// <param name="replacer" type="Optional:Func">a replacer.</param>
        /// <param name="space" type="Optional:Number">indent spaces.</param>
        /// <returns type="String"></returns>
        public JsString ToJSON<TKey, TValue, TResult>(JsFunc<TKey, TValue, TResult> replacer, JsNumber space) { return null; }
        /// <summary>Creates a JSON String from sequence, performed only native JSON support browser or included json2.js.</summary>
        /// <param name="replacer" type="Optional:Func">a replacer.</param>
        /// <returns type="String"></returns>
        public JsString ToJSON<TKey, TValue, TResult>(JsFunc<TKey, TValue, TResult> replacer) { return null; }
        /// <summary>Creates a JSON String from sequence, performed only native JSON support browser or included json2.js.</summary>
        /// <returns type="String"></returns>
        public JsString ToJSON() { return null; }

        /// <summary>Creates Joined string from this sequence.</summary>
        /// <param name="separator" type="Optional:String">A String.</param>
        /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        /// <returns type="String"></returns>
        public JsString ToString(JsString separator, JsFunc<T, JsString> selector) { return null; }
        /// <summary>Creates Joined string from this sequence.</summary>
        /// <param name="separator" type="Optional:String">A String.</param>
        /// <returns type="String"></returns>
        public JsString ToString(JsString separator) { return null; }

        /// <summary>Creates Joined string from this sequence.</summary>
        /// <returns type="String"></returns>
        public new JsString ToString() { return null; }



        #endregion

        #region Action Methods

        /// <summary>Performs the specified action on each element of the sequence.</summary>
        /// <param name="action" type="Action&lt;T>_or_Action&lt;T,int>">Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Do(JsAction<T> action) { return null; }
        /// <summary>Performs the specified action on each element of the sequence.</summary>
        /// <param name="action" type="Action&lt;T>_or_Action&lt;T,int>">Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Do(JsAction<T, JsNumber> action) { return null; }

        /// <summary>Performs the specified action on each element of the sequence.</summary>
        /// <param name="action" type="Action&lt;T>_or_Action&lt;T,int>">[return true;]continue iteration.[return false;]break iteration. Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="void"></returns>
        public void ForEach(JsAction<T> action) { }
        /// <summary>Performs the specified action on each element of the sequence.</summary>
        /// <param name="action" type="Action&lt;T>_or_Action&lt;T,int>">[return true;]continue iteration.[return false;]break iteration. Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="void"></returns>
        public void ForEach(JsAction<T, JsNumber> action) { }

        /// <summary>Do document.write.</summary>
        /// <param name="separator" type="Optional:String">A String.</param>
        /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        /// <returns type="void"></returns>
        public void Write(JsString separator, JsFunc<T, JsString> selector) { }
        /// <summary>Do document.write.</summary>
        /// <param name="separator" type="Optional:String">A String.</param>
        /// <returns type="void"></returns>
        public void Write(JsString separator) { }
        /// <summary>Do document.write.</summary>
        /// <returns type="void"></returns>
        public void Write() { }

        /// <summary>Do document.write + &lt;br />.</summary>
        /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        /// <returns type="void"></returns>
        public void WriteLine(JsFunc<T, JsString> selector) { }
        /// <summary>Do document.write + &lt;br />.</summary>
        /// <returns type="void"></returns>
        public void WriteLine() { }

        /// <summary>Execute enumerate.</summary>
        /// <returns type="void"></returns>
        public void Force() { }

        #endregion

        #region Functional Methods

        /// <summary>Bind the source to the parameter so that it can be used multiple times.</summary>
        /// <param name="func" type="Func&lt;Enumerable&lt;T>&lt;T>,Enumerable&lt;T>&lt;TR>>">apply function.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Let<TR>(JsFunc<Enumerable<T>, T, Enumerable<T>, TR> func) { return null; }
        //TODO: check

        /// <summary>Shares cursor of all enumerators to the sequence.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Share() { return null; }

        /// <summary>Creates an enumerable that enumerates the original enumerable only once and caches its results.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> MemoizeAll() { return null; }

        #endregion

        #region Error Handling Methods

        /// <summary>catch error and do handler.</summary>
        /// <param name="handler" type="Action&lt;Error>">execute if error occured.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Catch(JsAction<JsError> handler) { return null; }
        //TODO: CHECK

        /// <summary>do action if enumerate end or disposed or error occured.</summary>
        /// <param name="finallyAction" type="Action">finally execute.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Finally(JsAction finallyAction) { return null; }

        #endregion

        #region For Debug Methods

        /// <summary>Trace object use console.log.</summary>
        /// <param name="message" type="Optional:String">Default is 'Trace:'.</param>
        /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Trace(JsString message, JsFunc<T, JsString> selector) { return null; }
        /// <summary>Trace object use console.log.</summary>
        /// <param name="message" type="Optional:String">Default is 'Trace:'.</param>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Trace(JsString message) { return null; }
        /// <summary>Trace object use console.log.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Trace() { return null; }

        #endregion

        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        ///return new IEnumerator();
        public object GetEnumerator() { return null; }

    }

    public class IEnumerator<T>
    {
        /// <summary>Gets the element in the collection at the current position of the enumerator.</summary>
        /// <returns type="T"></returns>
        public static T Current() { return default(T); }

        /// <summary>Advances the enumerator to the next element of the collection.</summary>
        /// <returns type="Boolean"></returns>
        public static bool MoveNext() { return false; }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <returns type="Void"></returns>
        public static void Dispose() { }
    }

    public class Dictionary<K, T>
    {
        /// <summary>add new pair. if duplicate key then overwrite new value.</summary>
        /// <returns type="Void"></returns>
        public static void Add(K key, T value) { }

        /// <summary>get value. if not find key then return undefined.</summary>
        /// <returns type="T"></returns>
        public static T Get(K key) { return default(T); }

        /// <summary>set value. if complete set value then return true, not find key then return false.</summary>
        /// <returns type="Boolean"></returns>
        public static bool Set(K key, T value) { return false; }

        /// <summary>check contains key.</summary>
        /// <returns type="Boolean"></returns>
        public static bool Contains(K key) { return false; }

        /// <summary>clear dictionary.</summary>
        /// <returns type="Void"></returns>
        public static void Clear() { }

        /// <summary>remove key and value.</summary>
        /// <returns type="Void"></returns>
        public static void Remove(K key) { }

        /// <summary>contains value's count.</summary>
        /// <returns type="Number"></returns>
        public static JsNumber Count() { return null; }

        /// <summary>Convert to Enumerable&lt;T&gt;&lt;{Key:, Value:}&gt;.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<KeyValuePair<K, T>> ToEnumerable() { return null; }

    }

    public class KeyValuePair<K, T>
    {
        public K Key{ get; set; }
        public T Value { get; set; }
    }
    public class Lookup<K, T>
    {
        /// <summary>contains value's count.</summary>
        /// <returns type="Number"></returns>
        public JsNumber Count() { return null; }

        /// <summary>get grouped enumerable.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<T> Get(K key) { return null; }

        /// <summary>check contains key.</summary>
        /// <returns type="Boolean"></returns>
        public bool Contains(K key) { return false; }

        /// <summary>Convert to Enumerable&lt;T>&lt;Grouping&gt;.</summary>
        /// <returns type="Enumerable&lt;T&gt;"></returns>
        public Enumerable<Grouping<K, T>> ToEnumerable() { return null; }

    }

    public class Grouping<K, T> : Enumerable<T>
    {
        /// <summary>get grouping key.</summary>
        /// <returns type="T"></returns>  
        public static K Key() { return default(K); }
    }

    public class OrderedEnumerable<T> : Enumerable<T>
    {
        /// <summary>Performs a subsequent ordering of the elements in a sequence in ascending order according to a key.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        ///return Enumerable&lt;T>.Empty().OrderBy();
        public OrderedEnumerable<T> ThenBy<TKey>(JsFunc<T, TKey> keySelector) { return null; }

        /// <summary>Performs a subsequent ordering of the elements in a sequence in descending order, according to a key.</summary>
        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        ///return Enumerable&lt;T>.Empty().OrderBy();
        public OrderedEnumerable<T> ThenByDescending<TKey>(JsFunc<T, TKey> keySelector) { return null; }
    }

}

namespace SharpKit.JavaScript
{
    [JsType(JsMode.Prototype, Export = false, Name = "Enumerable")]
    public static class LinqJsEnumerable
    {
        /// <summary>
        /// Make Enumerable from obj.
        /// 1. null = Enumerable.Empty().
        /// 2. Enumerable = Enumerable.
        /// 3. Number/Boolean = Enumerable.Repeat(obj, 1).
        /// 4. String = to CharArray.(Ex:"abc" => "a","b","c").
        /// 5. Object/Function = to KeyValuePair(except function) Ex:"{a:0}" => (.Key=a, .Value=0).
        /// 6. Array or ArrayLikeObject(has length) = to Enumerable.
        /// 7. JScript's IEnumerable = to Enumerable(using Enumerator).
        /// </summary>
        /// <param name="list">list</param>
        /// <returns type="Enumerable"></returns>
        [JsMethod(Name="From")]
        public static LinqJs.Enumerable<T> ToLinqJsEnumerable<T>(this JsArray<T> list) { return null; }

        ///// <summary>
        ///// Make Enumerable from obj.
        ///// 1. null = Enumerable.Empty().
        ///// 2. Enumerable = Enumerable.
        ///// 3. Number/Boolean = Enumerable.Repeat(obj, 1).
        ///// 4. String = to CharArray.(Ex:"abc" => "a","b","c").
        ///// 5. Object/Function = to KeyValuePair(except function) Ex:"{a:0}" => (.Key=a, .Value=0).
        ///// 6. Array or ArrayLikeObject(has length) = to Enumerable.
        ///// 7. JScript's IEnumerable = to Enumerable(using Enumerator).
        ///// </summary>
        ///// <param name="list">list</param>
        ///// <returns type="Enumerable"></returns>
        //[JsMethod(Name = "From")]
        //public static LinqJs.Enumerable<T> ToLinqJsEnumerable<T>(this IEnumerable<T> list) { return null; }
    }

}