﻿using System;
using System.Collections.Generic;

using System.Text;

using System.Collections;
using System.Security.Permissions;
using System.Diagnostics;
using System.Threading;

namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Collections.ArrayList", Filename = "~/res/System.Collections.js")]
	internal class JsImplArrayList : JsImplList<object>
	{

	}

	//[RunAtClient]
	//[JsType(Name = "System.Collections.ArrayList")]
	////[Serializable, DebuggerTypeProxy(typeof(ArrayListDebugView)), ComVisible(true), DebuggerDisplay("Count = {Count}")]
	//public class JsImplArrayList : IList, ICollection, IEnumerable//, ICloneable
	//{
	//  // Fields
	//  private const int _defaultCapacity = 4;
	//  private JsExtendedArray _items;
	//  private int _size;
	//  [NonSerialized]
	//  private object _syncRoot;
	//  private int _version;
	//  private static readonly object[] emptyArray = new object[0];

	//  // Methods
	//  public JsImplArrayList()
	//  {
	//    this._items = new JsExtendedArray();
	//  }

	//  internal JsImplArrayList(bool trash)
	//  {
	//  }

	//  public JsImplArrayList(ICollection c)
	//  {
	//    if (c == null)
	//    {
	//      throw new ArgumentNullException("ArgumentNull_Collection");
	//    }
	//    this._items = new JsExtendedArray();// object[c.Count];
	//    this.AddRange(c);
	//  }

	//  public JsImplArrayList(int capacity)
	//  {
	//    if (capacity < 0)
	//    {
	//      throw new ArgumentOutOfRangeException("ArgumentOutOfRange_MustBeNonNegNum");
	//    }
	//    this._items = new JsExtendedArray();// object[capacity];
	//  }


	//  public virtual int Add(object value)
	//  {
	//    //if (this._size == this._items.length)
	//    //{
	//    //  this.EnsureCapacity(this._size + 1);
	//    //}
	//    this._items.push(value);//[this._size] = value;
	//    this._version++;
	//    return this._size++;
	//  }

	//  public virtual void AddRange(ICollection c)
	//  {
	//    foreach (object obj in c)
	//    {
	//      Add(obj);
	//    }
	//    //this.InsertRange(this._size, c);
	//  }

	//  //public virtual int BinarySearch(object value)
	//  //{
	//  //  return this.BinarySearch(0, this.Count, value, null);
	//  //}

	//  //public virtual int BinarySearch(object value, IComparer comparer)
	//  //{
	//  //  return this.BinarySearch(0, this.Count, value, comparer);
	//  //}

	//  //public virtual int BinarySearch(int index, int count, object value, IComparer comparer)
	//  //{
	//  //  if ((index < 0) || (count < 0))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //  }
	//  //  if ((this._size - index) < count)
	//  //  {
	//  //    throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //  }
	//  //  return Array.BinarySearch(this._items, index, count, value, comparer);
	//  //}

	//  public virtual void Clear()
	//  {
	//    this._items = new JsExtendedArray();
	//    //Array.Clear(this._items, 0, this._size);
	//    this._size = 0;
	//    this._version++;
	//  }

	//  public virtual object Clone()
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//    //JsImplArrayList list = new JsImplArrayList(this._size);
	//    //list._size = this._size;
	//    //list._version = this._version;
	//    //Array.Copy(this._items, 0, list._items, 0, this._size);
	//    //return list;
	//  }

	//  public virtual bool Contains(object item)
	//  {
	//    if (item == null)
	//    {
	//      for (int j = 0; j < this._size; j++)
	//      {
	//        if (this._items[j] == null)
	//        {
	//          return true;
	//        }
	//      }
	//      return false;
	//    }
	//    for (int i = 0; i < this._size; i++)
	//    {
	//      if ((this._items[i] != null) && this._items[i].Equals(item))
	//      {
	//        return true;
	//      }
	//    }
	//    return false;
	//  }

	//  //public virtual void CopyTo(Array array)
	//  //{
	//  //  this.CopyTo(array, 0);
	//  //}

	//  public virtual void CopyTo(Array array, int arrayIndex)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//    //if ((array != null) && (array.Rank != 1))
	//    //{
	//    //  throw new ArgumentException("Arg_RankMultiDimNotSupported");
	//    //}
	//    //Array.Copy(this._items, 0, array, arrayIndex, this._size);
	//  }

	//  //public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
	//  //{
	//  //  if ((this._size - index) < count)
	//  //  {
	//  //    throw new ArgumentException("Argument_InvalidOffLen");
	//  //  }
	//  //  if ((array != null) && (array.Rank != 1))
	//  //  {
	//  //    throw new ArgumentException(("Arg_RankMultiDimNotSupported"));
	//  //  }
	//  //  Array.Copy(this._items, index, array, arrayIndex, count);
	//  //}

	//  //private void EnsureCapacity(int min)
	//  //{
	//  //  if (this._items.length < min)
	//  //  {
	//  //    int num = (this._items.length == 0) ? 4 : (this._items.length * 2);
	//  //    if (num < min)
	//  //    {
	//  //      num = min;
	//  //    }
	//  //    this.Capacity = num;
	//  //  }
	//  //}


	//  public virtual IEnumerator GetEnumerator()
	//  {
	//    return _items.GetEnumerator();
	//  }


	//  public virtual int IndexOf(object value)
	//  {
	//    return _items.indexOf(value);
	//    //return Array.IndexOf(this._items, value, 0, this._size);
	//  }

	//  public virtual int IndexOf(object value, int startIndex)
	//  {
	//    return _items.indexOf(value, startIndex);
	//    //if (startIndex > this._size)
	//    //{
	//    //  throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//    //}
	//    //return Array.IndexOf(this._items, value, startIndex, this._size - startIndex);
	//  }

	//  //public virtual int IndexOf(object value, int startIndex, int count)
	//  //{
	//  //  if (startIndex > this._size)
	//  //  {
	//  //    throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//  //  }
	//  //  if ((count < 0) || (startIndex > (this._size - count)))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException("count", ("ArgumentOutOfRange_Count"));
	//  //  }
	//  //  return Array.IndexOf(this._items, value, startIndex, count);
	//  //}

	//  public virtual void Insert(int index, object value)
	//  {
	//    if ((index < 0) || (index > this._size))
	//    {
	//      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_ArrayListInsert"));
	//    }
	//    _items.insert(index, value);
	//    //if (this._size == this._items.length)
	//    //{
	//    //  this.EnsureCapacity(this._size + 1);
	//    //}
	//    //if (index < this._size)
	//    //{
	//    //  Array.Copy(this._items, index, this._items, index + 1, this._size - index);
	//    //}
	//    this._items[index] = value;
	//    this._size++;
	//    this._version++;
	//  }

	//  //public virtual void InsertRange(int index, ICollection c)
	//  //{
	//  //  if (c == null)
	//  //  {
	//  //    throw new ArgumentNullException("c", ("ArgumentNull_Collection"));
	//  //  }
	//  //  if ((index < 0) || (index > this._size))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //  }
	//  //  int count = c.Count;
	//  //  if (count > 0)
	//  //  {
	//  //    this.EnsureCapacity(this._size + count);
	//  //    if (index < this._size)
	//  //    {
	//  //      Array.Copy(this._items, index, this._items, index + count, this._size - index);
	//  //    }
	//  //    object[] array = new object[count];
	//  //    c.CopyTo(array, 0);
	//  //    array.CopyTo(this._items, index);
	//  //    this._size += count;
	//  //    this._version++;
	//  //  }
	//  //}

	//  //public virtual int LastIndexOf(object value)
	//  //{
	//  //  return this.LastIndexOf(value, this._size - 1, this._size);
	//  //}

	//  //public virtual int LastIndexOf(object value, int startIndex)
	//  //{
	//  //  if (startIndex >= this._size)
	//  //  {
	//  //    throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//  //  }
	//  //  return this.LastIndexOf(value, startIndex, startIndex + 1);
	//  //}

	//  //public virtual int LastIndexOf(object value, int startIndex, int count)
	//  //{
	//  //  if (this._size == 0)
	//  //  {
	//  //    return -1;
	//  //  }
	//  //  if ((startIndex < 0) || (count < 0))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((startIndex < 0) ? "startIndex" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //  }
	//  //  if ((startIndex >= this._size) || (count > (startIndex + 1)))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((startIndex >= this._size) ? "startIndex" : "count", ("ArgumentOutOfRange_BiggerThanCollection"));
	//  //  }
	//  //  return Array.LastIndexOf(this._items, value, startIndex, count);
	//  //}


	//  public virtual void Remove(object obj)
	//  {
	//    int index = this.IndexOf(obj);
	//    if (index >= 0)
	//    {
	//      this.RemoveAt(index);
	//    }
	//  }

	//  public virtual void RemoveAt(int index)
	//  {
	//    throw new NotImplementedException("TODO: Implement");
	//    //if ((index < 0) || (index >= this._size))
	//    //{
	//    //  throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//    //}
	//    //this._size--;
	//    //if (index < this._size)
	//    //{
	//    //  Array.Copy(this._items, index + 1, this._items, index, this._size - index);
	//    //}
	//    //this._items[this._size] = null;
	//    //this._version++;
	//  }

	//  //public virtual void RemoveRange(int index, int count)
	//  //{
	//  //  if ((index < 0) || (count < 0))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //  }
	//  //  if ((this._size - index) < count)
	//  //  {
	//  //    throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //  }
	//  //  if (count > 0)
	//  //  {
	//  //    int num = this._size;
	//  //    this._size -= count;
	//  //    if (index < this._size)
	//  //    {
	//  //      Array.Copy(this._items, index + count, this._items, index, this._size - index);
	//  //    }
	//  //    while (num > this._size)
	//  //    {
	//  //      this._items[--num] = null;
	//  //    }
	//  //    this._version++;
	//  //  }
	//  //}

	//  public static ArrayList Repeat(object value, int count)
	//  {
	//    if (count < 0)
	//    {
	//      throw new ArgumentOutOfRangeException("count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//    }
	//    ArrayList list = new ArrayList((count > 4) ? count : 4);
	//    for (int i = 0; i < count; i++)
	//    {
	//      list.Add(value);
	//    }
	//    return list;
	//  }

	//  //public virtual void Reverse()
	//  //{
	//  //  this.Reverse(0, this.Count);
	//  //}

	//  //public virtual void Reverse(int index, int count)
	//  //{
	//  //  if ((index < 0) || (count < 0))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //  }
	//  //  if ((this._size - index) < count)
	//  //  {
	//  //    throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //  }
	//  //  Array.Reverse(this._items, index, count);
	//  //  this._version++;
	//  //}

	//  //public virtual void SetRange(int index, ICollection c)
	//  //{
	//  //  if (c == null)
	//  //  {
	//  //    throw new ArgumentNullException("c", ("ArgumentNull_Collection"));
	//  //  }
	//  //  int count = c.Count;
	//  //  if ((index < 0) || (index > (this._size - count)))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //  }
	//  //  if (count > 0)
	//  //  {
	//  //    c.CopyTo(this._items, index);
	//  //    this._version++;
	//  //  }
	//  //}

	//  //public virtual void Sort()
	//  //{
	//  //  this.Sort(0, this.Count, Comparer.Default);
	//  //}

	//  //public virtual void Sort(IComparer comparer)
	//  //{
	//  //  this.Sort(0, this.Count, comparer);
	//  //}

	//  //public virtual void Sort(int index, int count, IComparer comparer)
	//  //{
	//  //  if ((index < 0) || (count < 0))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //  }
	//  //  if ((this._size - index) < count)
	//  //  {
	//  //    throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //  }
	//  //  Array.Sort(this._items, index, count, comparer);
	//  //  this._version++;
	//  //}


	//  public virtual object[] ToArray()
	//  {
	//    return _items.As<object[]>();
	//    //object[] destinationArray = new object[this._size];
	//    //Array.Copy(this._items, 0, destinationArray, 0, this._size);
	//    //return destinationArray;
	//  }

	//  //public virtual Array ToArray(Type type)
	//  //{
	//  //  if (type == null)
	//  //  {
	//  //    throw new ArgumentNullException("type");
	//  //  }
	//  //  Array destinationArray = Array.CreateInstance(type, this._size);
	//  //  Array.Copy(this._items, 0, destinationArray, 0, this._size);
	//  //  return destinationArray;
	//  //}

	//  //public virtual void TrimToSize()
	//  //{
	//  //  this.Capacity = this._size;
	//  //}

	//  // Properties
	//  public virtual int Capacity
	//  {
	//    get
	//    {
	//      return this._items.length;
	//    }
	//    //set
	//    //{
	//    //  if (value != this._items.length)
	//    //  {
	//    //    if (value < this._size)
	//    //    {
	//    //      throw new ArgumentOutOfRangeException("value", ("ArgumentOutOfRange_SmallCapacity"));
	//    //    }
	//    //    if (value > 0)
	//    //    {
	//    //      object[] destinationArray = new object[value];
	//    //      if (this._size > 0)
	//    //      {
	//    //        Array.Copy(this._items, 0, destinationArray, 0, this._size);
	//    //      }
	//    //      this._items = destinationArray;
	//    //    }
	//    //    else
	//    //    {
	//    //      this._items = new object[4];
	//    //    }
	//    //  }
	//    //}
	//  }

	//  public virtual int Count
	//  {
	//    get
	//    {
	//      return this._size;
	//    }
	//  }

	//  public virtual bool IsFixedSize
	//  {
	//    get
	//    {
	//      return false;
	//    }
	//  }

	//  public virtual bool IsReadOnly
	//  {
	//    get
	//    {
	//      return false;
	//    }
	//  }

	//  public virtual bool IsSynchronized
	//  {
	//    get
	//    {
	//      return false;
	//    }
	//  }

	//  public virtual object this[int index]
	//  {
	//    get
	//    {
	//      if ((index < 0) || (index >= this._size))
	//      {
	//        throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//      }
	//      return this._items[index];
	//    }
	//    set
	//    {
	//      if ((index < 0) || (index >= this._size))
	//      {
	//        throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//      }
	//      this._items[index] = value;
	//      this._version++;
	//    }
	//  }

	//  public virtual object SyncRoot
	//  {
	//    get
	//    {
	//      if (this._syncRoot == null)
	//      {
	//        Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
	//      }
	//      return this._syncRoot;
	//    }
	//  }
	//  #region Not Supported Yet
	//  //public static ArrayList Adapter(IList list)
	//  //{
	//  //  if (list == null)
	//  //  {
	//  //    throw new ArgumentNullException("list");
	//  //  }
	//  //  return new IListWrapper(list);
	//  //}
	//  //public static ArrayList FixedSize(ArrayList list)
	//  //{
	//  //  if (list == null)
	//  //  {
	//  //    throw new ArgumentNullException("list");
	//  //  }
	//  //  return new FixedSizeArrayList(list);
	//  //}

	//  //public static IList FixedSize(IList list)
	//  //{
	//  //  if (list == null)
	//  //  {
	//  //    throw new ArgumentNullException("list");
	//  //  }
	//  //  return new FixedSizeList(list);
	//  //}
	//  //public virtual IEnumerator GetEnumerator(int index, int count)
	//  //{
	//  //  if ((index < 0) || (count < 0))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //  }
	//  //  if ((this._size - index) < count)
	//  //  {
	//  //    throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //  }
	//  //  return new ArrayListEnumerator(this, index, count);
	//  //}

	//  //public virtual ArrayList GetRange(int index, int count)
	//  //{
	//  //  if ((index < 0) || (count < 0))
	//  //  {
	//  //    throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //  }
	//  //  if ((this._size - index) < count)
	//  //  {
	//  //    throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //  }
	//  //  return new Range(this, index, count);
	//  //}
	//  //public static ArrayList ReadOnly(ArrayList list)
	//  //{
	//  //  if (list == null)
	//  //  {
	//  //    throw new ArgumentNullException("list");
	//  //  }
	//  //  return new ReadOnlyArrayList(list);
	//  //}

	//  //public static IList ReadOnly(IList list)
	//  //{
	//  //  if (list == null)
	//  //  {
	//  //    throw new ArgumentNullException("list");
	//  //  }
	//  //  return new ReadOnlyList(list);
	//  //}

	//  //[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	//  //public static ArrayList Synchronized(ArrayList list)
	//  //{
	//  //  if (list == null)
	//  //  {
	//  //    throw new ArgumentNullException("list");
	//  //  }
	//  //  return new SyncArrayList(list);
	//  //}

	//  //[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	//  //public static IList Synchronized(IList list)
	//  //{
	//  //  if (list == null)
	//  //  {
	//  //    throw new ArgumentNullException("list");
	//  //  }
	//  //  return new SyncIList(list);
	//  //}

	//  //[Serializable]
	//  //private sealed class ArrayListEnumerator : IEnumerator, ICloneable
	//  //{
	//  //  // Fields
	//  //  private object currentElement;
	//  //  private int endIndex;
	//  //  private int index;
	//  //  private ArrayList list;
	//  //  private int startIndex;
	//  //  private int version;

	//  //  // Methods
	//  //  internal ArrayListEnumerator(ArrayList list, int index, int count)
	//  //  {
	//  //    this.list = list;
	//  //    this.startIndex = index;
	//  //    this.index = index - 1;
	//  //    this.endIndex = this.index + count;
	//  //    this.version = list._version;
	//  //    this.currentElement = null;
	//  //  }

	//  //  public object Clone()
	//  //  {
	//  //    return base.MemberwiseClone();
	//  //  }

	//  //  public bool MoveNext()
	//  //  {
	//  //    if (this.version != this.list._version)
	//  //    {
	//  //      throw new InvalidOperationException(("InvalidOperation_EnumFailedVersion"));
	//  //    }
	//  //    if (this.index < this.endIndex)
	//  //    {
	//  //      this.currentElement = this.list[++this.index];
	//  //      return true;
	//  //    }
	//  //    this.index = this.endIndex + 1;
	//  //    return false;
	//  //  }

	//  //  public void Reset()
	//  //  {
	//  //    if (this.version != this.list._version)
	//  //    {
	//  //      throw new InvalidOperationException(("InvalidOperation_EnumFailedVersion"));
	//  //    }
	//  //    this.index = this.startIndex - 1;
	//  //  }

	//  //  // Properties
	//  //  public object Current
	//  //  {
	//  //    get
	//  //    {
	//  //      if (this.index < this.startIndex)
	//  //      {
	//  //        throw new InvalidOperationException(("InvalidOperation_EnumNotStarted"));
	//  //      }
	//  //      if (this.index > this.endIndex)
	//  //      {
	//  //        throw new InvalidOperationException(("InvalidOperation_EnumEnded"));
	//  //      }
	//  //      return this.currentElement;
	//  //    }
	//  //  }
	//  //}


	//  //[Serializable]
	//  //private class FixedSizeArrayList : ArrayList
	//  //{
	//  //  // Fields
	//  //  private ArrayList _list;

	//  //  // Methods
	//  //  internal FixedSizeArrayList(ArrayList l)
	//  //  {
	//  //    this._list = l;
	//  //    base._version = this._list._version;
	//  //  }

	//  //  public override int Add(object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override void AddRange(ICollection c)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override int BinarySearch(int index, int count, object value, IComparer comparer)
	//  //  {
	//  //    return this._list.BinarySearch(index, count, value, comparer);
	//  //  }

	//  //  public override void Clear()
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override object Clone()
	//  //  {
	//  //    ArrayList.FixedSizeArrayList list = new ArrayList.FixedSizeArrayList(this._list);
	//  //    list._list = (ArrayList)this._list.Clone();
	//  //    return list;
	//  //  }

	//  //  public override bool Contains(object obj)
	//  //  {
	//  //    return this._list.Contains(obj);
	//  //  }

	//  //  public override void CopyTo(Array array, int index)
	//  //  {
	//  //    this._list.CopyTo(array, index);
	//  //  }

	//  //  public override void CopyTo(int index, Array array, int arrayIndex, int count)
	//  //  {
	//  //    this._list.CopyTo(index, array, arrayIndex, count);
	//  //  }

	//  //  public override IEnumerator GetEnumerator()
	//  //  {
	//  //    return this._list.GetEnumerator();
	//  //  }

	//  //  public override IEnumerator GetEnumerator(int index, int count)
	//  //  {
	//  //    return this._list.GetEnumerator(index, count);
	//  //  }

	//  //  public override ArrayList GetRange(int index, int count)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    return new ArrayList.Range(this, index, count);
	//  //  }

	//  //  public override int IndexOf(object value)
	//  //  {
	//  //    return this._list.IndexOf(value);
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex)
	//  //  {
	//  //    return this._list.IndexOf(value, startIndex);
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    return this._list.IndexOf(value, startIndex, count);
	//  //  }

	//  //  public override void Insert(int index, object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override void InsertRange(int index, ICollection c)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override int LastIndexOf(object value)
	//  //  {
	//  //    return this._list.LastIndexOf(value);
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex)
	//  //  {
	//  //    return this._list.LastIndexOf(value, startIndex);
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    return this._list.LastIndexOf(value, startIndex, count);
	//  //  }

	//  //  public override void Remove(object value)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override void RemoveAt(int index)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override void RemoveRange(int index, int count)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public override void Reverse(int index, int count)
	//  //  {
	//  //    this._list.Reverse(index, count);
	//  //    base._version = this._list._version;
	//  //  }

	//  //  public override void SetRange(int index, ICollection c)
	//  //  {
	//  //    this._list.SetRange(index, c);
	//  //    base._version = this._list._version;
	//  //  }

	//  //  public override void Sort(int index, int count, IComparer comparer)
	//  //  {
	//  //    this._list.Sort(index, count, comparer);
	//  //    base._version = this._list._version;
	//  //  }

	//  //  public override object[] ToArray()
	//  //  {
	//  //    return this._list.ToArray();
	//  //  }

	//  //  public override Array ToArray(Type type)
	//  //  {
	//  //    return this._list.ToArray(type);
	//  //  }

	//  //  public override void TrimToSize()
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  // Properties
	//  //  public override int Capacity
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Capacity;
	//  //    }
	//  //    set
	//  //    {
	//  //      throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //    }
	//  //  }

	//  //  public override int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Count;
	//  //    }
	//  //  }

	//  //  public override bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public override bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsReadOnly;
	//  //    }
	//  //  }

	//  //  public override bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsSynchronized;
	//  //    }
	//  //  }

	//  //  public override object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list[index];
	//  //    }
	//  //    set
	//  //    {
	//  //      this._list[index] = value;
	//  //      base._version = this._list._version;
	//  //    }
	//  //  }

	//  //  public override object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.SyncRoot;
	//  //    }
	//  //  }
	//  //}

	//  //[Serializable]
	//  //private class FixedSizeList : IList, ICollection, IEnumerable
	//  //{
	//  //  // Fields
	//  //  private IList _list;

	//  //  // Methods
	//  //  internal FixedSizeList(IList l)
	//  //  {
	//  //    this._list = l;
	//  //  }

	//  //  public virtual int Add(object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public virtual void Clear()
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public virtual bool Contains(object obj)
	//  //  {
	//  //    return this._list.Contains(obj);
	//  //  }

	//  //  public virtual void CopyTo(Array array, int index)
	//  //  {
	//  //    this._list.CopyTo(array, index);
	//  //  }

	//  //  public virtual IEnumerator GetEnumerator()
	//  //  {
	//  //    return this._list.GetEnumerator();
	//  //  }

	//  //  public virtual int IndexOf(object value)
	//  //  {
	//  //    return this._list.IndexOf(value);
	//  //  }

	//  //  public virtual void Insert(int index, object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public virtual void Remove(object value)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  public virtual void RemoveAt(int index)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //  }

	//  //  // Properties
	//  //  public virtual int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Count;
	//  //    }
	//  //  }

	//  //  public virtual bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public virtual bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsReadOnly;
	//  //    }
	//  //  }

	//  //  public virtual bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsSynchronized;
	//  //    }
	//  //  }

	//  //  public virtual object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list[index];
	//  //    }
	//  //    set
	//  //    {
	//  //      this._list[index] = value;
	//  //    }
	//  //  }

	//  //  public virtual object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.SyncRoot;
	//  //    }
	//  //  }
	//  //}

	//  //[Serializable]
	//  //private class IListWrapper : ArrayList
	//  //{
	//  //  // Fields
	//  //  private IList _list;

	//  //  // Methods
	//  //  internal IListWrapper(IList list)
	//  //  {
	//  //    this._list = list;
	//  //    base._version = 0;
	//  //  }

	//  //  public override int Add(object obj)
	//  //  {
	//  //    int num = this._list.Add(obj);
	//  //    base._version++;
	//  //    return num;
	//  //  }

	//  //  public override void AddRange(ICollection c)
	//  //  {
	//  //    this.InsertRange(this.Count, c);
	//  //  }

	//  //  public override int BinarySearch(int index, int count, object value, IComparer comparer)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._list.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    if (comparer == null)
	//  //    {
	//  //      comparer = Comparer.Default;
	//  //    }
	//  //    int num = index;
	//  //    int num2 = (index + count) - 1;
	//  //    while (num <= num2)
	//  //    {
	//  //      int num3 = (num + num2) / 2;
	//  //      int num4 = comparer.Compare(value, this._list[num3]);
	//  //      if (num4 == 0)
	//  //      {
	//  //        return num3;
	//  //      }
	//  //      if (num4 < 0)
	//  //      {
	//  //        num2 = num3 - 1;
	//  //      }
	//  //      else
	//  //      {
	//  //        num = num3 + 1;
	//  //      }
	//  //    }
	//  //    return ~num;
	//  //  }

	//  //  public override void Clear()
	//  //  {
	//  //    if (this._list.IsFixedSize)
	//  //    {
	//  //      throw new NotSupportedException(("NotSupported_FixedSizeCollection"));
	//  //    }
	//  //    this._list.Clear();
	//  //    base._version++;
	//  //  }

	//  //  public override object Clone()
	//  //  {
	//  //    return new ArrayList.IListWrapper(this._list);
	//  //  }

	//  //  public override bool Contains(object obj)
	//  //  {
	//  //    return this._list.Contains(obj);
	//  //  }

	//  //  public override void CopyTo(Array array, int index)
	//  //  {
	//  //    this._list.CopyTo(array, index);
	//  //  }

	//  //  public override void CopyTo(int index, Array array, int arrayIndex, int count)
	//  //  {
	//  //    if (array == null)
	//  //    {
	//  //      throw new ArgumentNullException("array");
	//  //    }
	//  //    if ((index < 0) || (arrayIndex < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "arrayIndex", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if (count < 0)
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((array.Length - arrayIndex) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    if ((this._list.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    if (array.Rank != 1)
	//  //    {
	//  //      throw new ArgumentException(("Arg_RankMultiDimNotSupported"));
	//  //    }
	//  //    for (int i = index; i < (index + count); i++)
	//  //    {
	//  //      array.SetValue(this._list[i], arrayIndex++);
	//  //    }
	//  //  }

	//  //  public override IEnumerator GetEnumerator()
	//  //  {
	//  //    return this._list.GetEnumerator();
	//  //  }

	//  //  public override IEnumerator GetEnumerator(int index, int count)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._list.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    return new IListWrapperEnumWrapper(this, index, count);
	//  //  }

	//  //  public override ArrayList GetRange(int index, int count)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._list.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    return new ArrayList.Range(this, index, count);
	//  //  }

	//  //  public override int IndexOf(object value)
	//  //  {
	//  //    return this._list.IndexOf(value);
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex)
	//  //  {
	//  //    return this.IndexOf(value, startIndex, this._list.Count - startIndex);
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    if ((startIndex < 0) || (startIndex > this._list.Count))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    if ((count < 0) || (startIndex > (this._list.Count - count)))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("count", ("ArgumentOutOfRange_Count"));
	//  //    }
	//  //    int num = startIndex + count;
	//  //    if (value == null)
	//  //    {
	//  //      for (int j = startIndex; j < num; j++)
	//  //      {
	//  //        if (this._list[j] == null)
	//  //        {
	//  //          return j;
	//  //        }
	//  //      }
	//  //      return -1;
	//  //    }
	//  //    for (int i = startIndex; i < num; i++)
	//  //    {
	//  //      if ((this._list[i] != null) && this._list[i].Equals(value))
	//  //      {
	//  //        return i;
	//  //      }
	//  //    }
	//  //    return -1;
	//  //  }

	//  //  public override void Insert(int index, object obj)
	//  //  {
	//  //    this._list.Insert(index, obj);
	//  //    base._version++;
	//  //  }

	//  //  public override void InsertRange(int index, ICollection c)
	//  //  {
	//  //    if (c == null)
	//  //    {
	//  //      throw new ArgumentNullException("c", ("ArgumentNull_Collection"));
	//  //    }
	//  //    if ((index < 0) || (index > this._list.Count))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    if (c.Count > 0)
	//  //    {
	//  //      ArrayList list = this._list as ArrayList;
	//  //      if (list != null)
	//  //      {
	//  //        list.InsertRange(index, c);
	//  //      }
	//  //      else
	//  //      {
	//  //        IEnumerator enumerator = c.GetEnumerator();
	//  //        while (enumerator.MoveNext())
	//  //        {
	//  //          this._list.Insert(index++, enumerator.Current);
	//  //        }
	//  //      }
	//  //      base._version++;
	//  //    }
	//  //  }

	//  //  public override int LastIndexOf(object value)
	//  //  {
	//  //    return this.LastIndexOf(value, this._list.Count - 1, this._list.Count);
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex)
	//  //  {
	//  //    return this.LastIndexOf(value, startIndex, startIndex + 1);
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    if (this._list.Count != 0)
	//  //    {
	//  //      if ((startIndex < 0) || (startIndex >= this._list.Count))
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//  //      }
	//  //      if ((count < 0) || (count > (startIndex + 1)))
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("count", ("ArgumentOutOfRange_Count"));
	//  //      }
	//  //      int num = (startIndex - count) + 1;
	//  //      if (value == null)
	//  //      {
	//  //        for (int j = startIndex; j >= num; j--)
	//  //        {
	//  //          if (this._list[j] == null)
	//  //          {
	//  //            return j;
	//  //          }
	//  //        }
	//  //        return -1;
	//  //      }
	//  //      for (int i = startIndex; i >= num; i--)
	//  //      {
	//  //        if ((this._list[i] != null) && this._list[i].Equals(value))
	//  //        {
	//  //          return i;
	//  //        }
	//  //      }
	//  //    }
	//  //    return -1;
	//  //  }

	//  //  public override void Remove(object value)
	//  //  {
	//  //    int index = this.IndexOf(value);
	//  //    if (index >= 0)
	//  //    {
	//  //      this.RemoveAt(index);
	//  //    }
	//  //  }

	//  //  public override void RemoveAt(int index)
	//  //  {
	//  //    this._list.RemoveAt(index);
	//  //    base._version++;
	//  //  }

	//  //  public override void RemoveRange(int index, int count)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._list.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    if (count > 0)
	//  //    {
	//  //      base._version++;
	//  //    }
	//  //    while (count > 0)
	//  //    {
	//  //      this._list.RemoveAt(index);
	//  //      count--;
	//  //    }
	//  //  }

	//  //  public override void Reverse(int index, int count)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._list.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    int num = index;
	//  //    int num2 = (index + count) - 1;
	//  //    while (num < num2)
	//  //    {
	//  //      object obj2 = this._list[num];
	//  //      this._list[num++] = this._list[num2];
	//  //      this._list[num2--] = obj2;
	//  //    }
	//  //    base._version++;
	//  //  }

	//  //  public override void SetRange(int index, ICollection c)
	//  //  {
	//  //    if (c == null)
	//  //    {
	//  //      throw new ArgumentNullException("c", ("ArgumentNull_Collection"));
	//  //    }
	//  //    if ((index < 0) || (index > (this._list.Count - c.Count)))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    if (c.Count > 0)
	//  //    {
	//  //      IEnumerator enumerator = c.GetEnumerator();
	//  //      while (enumerator.MoveNext())
	//  //      {
	//  //        this._list[index++] = enumerator.Current;
	//  //      }
	//  //      base._version++;
	//  //    }
	//  //  }

	//  //  public override void Sort(int index, int count, IComparer comparer)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._list.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    object[] array = new object[count];
	//  //    this.CopyTo(index, array, 0, count);
	//  //    Array.Sort(array, 0, count, comparer);
	//  //    for (int i = 0; i < count; i++)
	//  //    {
	//  //      this._list[i + index] = array[i];
	//  //    }
	//  //    base._version++;
	//  //  }

	//  //  public override object[] ToArray()
	//  //  {
	//  //    object[] array = new object[this.Count];
	//  //    this._list.CopyTo(array, 0);
	//  //    return array;
	//  //  }

	//  //  public override Array ToArray(Type type)
	//  //  {
	//  //    if (type == null)
	//  //    {
	//  //      throw new ArgumentNullException("type");
	//  //    }
	//  //    Array array = Array.CreateInstance(type, this._list.Count);
	//  //    this._list.CopyTo(array, 0);
	//  //    return array;
	//  //  }

	//  //  public override void TrimToSize()
	//  //  {
	//  //  }

	//  //  // Properties
	//  //  public override int Capacity
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Count;
	//  //    }
	//  //    set
	//  //    {
	//  //      if (value < this._list.Count)
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("value", ("ArgumentOutOfRange_SmallCapacity"));
	//  //      }
	//  //    }
	//  //  }

	//  //  public override int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Count;
	//  //    }
	//  //  }

	//  //  public override bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsFixedSize;
	//  //    }
	//  //  }

	//  //  public override bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsReadOnly;
	//  //    }
	//  //  }

	//  //  public override bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsSynchronized;
	//  //    }
	//  //  }

	//  //  public override object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list[index];
	//  //    }
	//  //    set
	//  //    {
	//  //      this._list[index] = value;
	//  //      base._version++;
	//  //    }
	//  //  }

	//  //  public override object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.SyncRoot;
	//  //    }
	//  //  }

	//  //}

	//  //[Serializable]
	//  //private class Range : ArrayList
	//  //{
	//  //  // Fields
	//  //  private int _baseIndex;
	//  //  private ArrayList _baseList;
	//  //  private int _baseSize;
	//  //  private int _baseVersion;

	//  //  // Methods
	//  //  internal Range(ArrayList list, int index, int count)
	//  //    : base(false)
	//  //  {
	//  //    this._baseList = list;
	//  //    this._baseIndex = index;
	//  //    this._baseSize = count;
	//  //    this._baseVersion = list._version;
	//  //    base._version = list._version;
	//  //  }

	//  //  public override int Add(object value)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    this._baseList.Insert(this._baseIndex + this._baseSize, value);
	//  //    this.InternalUpdateVersion();
	//  //    return this._baseSize++;
	//  //  }

	//  //  public override void AddRange(ICollection c)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (c == null)
	//  //    {
	//  //      throw new ArgumentNullException("c");
	//  //    }
	//  //    int count = c.Count;
	//  //    if (count > 0)
	//  //    {
	//  //      this._baseList.InsertRange(this._baseIndex + this._baseSize, c);
	//  //      this.InternalUpdateVersion();
	//  //      this._baseSize += count;
	//  //    }
	//  //  }

	//  //  public override int BinarySearch(int index, int count, object value, IComparer comparer)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._baseSize - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    int num = this._baseList.BinarySearch(this._baseIndex + index, count, value, comparer);
	//  //    if (num >= 0)
	//  //    {
	//  //      return (num - this._baseIndex);
	//  //    }
	//  //    return (num + this._baseIndex);
	//  //  }

	//  //  public override void Clear()
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (this._baseSize != 0)
	//  //    {
	//  //      this._baseList.RemoveRange(this._baseIndex, this._baseSize);
	//  //      this.InternalUpdateVersion();
	//  //      this._baseSize = 0;
	//  //    }
	//  //  }

	//  //  public override object Clone()
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    ArrayList.Range range = new ArrayList.Range(this._baseList, this._baseIndex, this._baseSize);
	//  //    range._baseList = (ArrayList)this._baseList.Clone();
	//  //    return range;
	//  //  }

	//  //  public override bool Contains(object item)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (item == null)
	//  //    {
	//  //      for (int j = 0; j < this._baseSize; j++)
	//  //      {
	//  //        if (this._baseList[this._baseIndex + j] == null)
	//  //        {
	//  //          return true;
	//  //        }
	//  //      }
	//  //      return false;
	//  //    }
	//  //    for (int i = 0; i < this._baseSize; i++)
	//  //    {
	//  //      if ((this._baseList[this._baseIndex + i] != null) && this._baseList[this._baseIndex + i].Equals(item))
	//  //      {
	//  //        return true;
	//  //      }
	//  //    }
	//  //    return false;
	//  //  }

	//  //  public override void CopyTo(Array array, int index)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (array == null)
	//  //    {
	//  //      throw new ArgumentNullException("array");
	//  //    }
	//  //    if (array.Rank != 1)
	//  //    {
	//  //      throw new ArgumentException(("Arg_RankMultiDimNotSupported"));
	//  //    }
	//  //    if (index < 0)
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((array.Length - index) < this._baseSize)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    this._baseList.CopyTo(this._baseIndex, array, index, this._baseSize);
	//  //  }

	//  //  public override void CopyTo(int index, Array array, int arrayIndex, int count)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (array == null)
	//  //    {
	//  //      throw new ArgumentNullException("array");
	//  //    }
	//  //    if (array.Rank != 1)
	//  //    {
	//  //      throw new ArgumentException(("Arg_RankMultiDimNotSupported"));
	//  //    }
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((array.Length - arrayIndex) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    if ((this._baseSize - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    this._baseList.CopyTo(this._baseIndex + index, array, arrayIndex, count);
	//  //  }

	//  //  public override IEnumerator GetEnumerator()
	//  //  {
	//  //    return this.GetEnumerator(0, this._baseSize);
	//  //  }

	//  //  public override IEnumerator GetEnumerator(int index, int count)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._baseSize - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    return this._baseList.GetEnumerator(this._baseIndex + index, count);
	//  //  }

	//  //  public override ArrayList GetRange(int index, int count)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._baseSize - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    return new ArrayList.Range(this, index, count);
	//  //  }

	//  //  public override int IndexOf(object value)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    int num = this._baseList.IndexOf(value, this._baseIndex, this._baseSize);
	//  //    if (num >= 0)
	//  //    {
	//  //      return (num - this._baseIndex);
	//  //    }
	//  //    return -1;
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (startIndex < 0)
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if (startIndex > this._baseSize)
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    int num = this._baseList.IndexOf(value, this._baseIndex + startIndex, this._baseSize - startIndex);
	//  //    if (num >= 0)
	//  //    {
	//  //      return (num - this._baseIndex);
	//  //    }
	//  //    return -1;
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((startIndex < 0) || (startIndex > this._baseSize))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    if ((count < 0) || (startIndex > (this._baseSize - count)))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("count", ("ArgumentOutOfRange_Count"));
	//  //    }
	//  //    int num = this._baseList.IndexOf(value, this._baseIndex + startIndex, count);
	//  //    if (num >= 0)
	//  //    {
	//  //      return (num - this._baseIndex);
	//  //    }
	//  //    return -1;
	//  //  }

	//  //  public override void Insert(int index, object value)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (index > this._baseSize))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    this._baseList.Insert(this._baseIndex + index, value);
	//  //    this.InternalUpdateVersion();
	//  //    this._baseSize++;
	//  //  }

	//  //  public override void InsertRange(int index, ICollection c)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (index > this._baseSize))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    if (c == null)
	//  //    {
	//  //      throw new ArgumentNullException("c");
	//  //    }
	//  //    int count = c.Count;
	//  //    if (count > 0)
	//  //    {
	//  //      this._baseList.InsertRange(this._baseIndex + index, c);
	//  //      this._baseSize += count;
	//  //      this.InternalUpdateVersion();
	//  //    }
	//  //  }

	//  //  private void InternalUpdateRange()
	//  //  {
	//  //    if (this._baseVersion != this._baseList._version)
	//  //    {
	//  //      throw new InvalidOperationException(("InvalidOperation_UnderlyingArrayListChanged"));
	//  //    }
	//  //  }

	//  //  private void InternalUpdateVersion()
	//  //  {
	//  //    this._baseVersion++;
	//  //    base._version++;
	//  //  }

	//  //  public override int LastIndexOf(object value)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    int num = this._baseList.LastIndexOf(value, (this._baseIndex + this._baseSize) - 1, this._baseSize);
	//  //    if (num >= 0)
	//  //    {
	//  //      return (num - this._baseIndex);
	//  //    }
	//  //    return -1;
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex)
	//  //  {
	//  //    return this.LastIndexOf(value, startIndex, startIndex + 1);
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (this._baseSize != 0)
	//  //    {
	//  //      if (startIndex >= this._baseSize)
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_Index"));
	//  //      }
	//  //      if (startIndex < 0)
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("startIndex", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //      }
	//  //      int num = this._baseList.LastIndexOf(value, this._baseIndex + startIndex, count);
	//  //      if (num >= 0)
	//  //      {
	//  //        return (num - this._baseIndex);
	//  //      }
	//  //    }
	//  //    return -1;
	//  //  }

	//  //  public override void RemoveAt(int index)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (index >= this._baseSize))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    this._baseList.RemoveAt(this._baseIndex + index);
	//  //    this.InternalUpdateVersion();
	//  //    this._baseSize--;
	//  //  }

	//  //  public override void RemoveRange(int index, int count)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._baseSize - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    if (count > 0)
	//  //    {
	//  //      this._baseList.RemoveRange(this._baseIndex + index, count);
	//  //      this.InternalUpdateVersion();
	//  //      this._baseSize -= count;
	//  //    }
	//  //  }

	//  //  public override void Reverse(int index, int count)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._baseSize - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    this._baseList.Reverse(this._baseIndex + index, count);
	//  //    this.InternalUpdateVersion();
	//  //  }

	//  //  public override void SetRange(int index, ICollection c)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (index >= this._baseSize))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //    }
	//  //    this._baseList.SetRange(this._baseIndex + index, c);
	//  //    if (c.Count > 0)
	//  //    {
	//  //      this.InternalUpdateVersion();
	//  //    }
	//  //  }

	//  //  public override void Sort(int index, int count, IComparer comparer)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this._baseSize - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    this._baseList.Sort(this._baseIndex + index, count, comparer);
	//  //    this.InternalUpdateVersion();
	//  //  }

	//  //  public override object[] ToArray()
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    object[] destinationArray = new object[this._baseSize];
	//  //    Array.Copy(this._baseList._items, this._baseIndex, destinationArray, 0, this._baseSize);
	//  //    return destinationArray;
	//  //  }

	//  //  public override Array ToArray(Type type)
	//  //  {
	//  //    this.InternalUpdateRange();
	//  //    if (type == null)
	//  //    {
	//  //      throw new ArgumentNullException("type");
	//  //    }
	//  //    Array array = Array.CreateInstance(type, this._baseSize);
	//  //    this._baseList.CopyTo(this._baseIndex, array, 0, this._baseSize);
	//  //    return array;
	//  //  }

	//  //  public override void TrimToSize()
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_RangeCollection"));
	//  //  }

	//  //  // Properties
	//  //  public override int Capacity
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._baseList.Capacity;
	//  //    }
	//  //    set
	//  //    {
	//  //      if (value < this.Count)
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("value", ("ArgumentOutOfRange_SmallCapacity"));
	//  //      }
	//  //    }
	//  //  }

	//  //  public override int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      this.InternalUpdateRange();
	//  //      return this._baseSize;
	//  //    }
	//  //  }

	//  //  public override bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._baseList.IsFixedSize;
	//  //    }
	//  //  }

	//  //  public override bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._baseList.IsReadOnly;
	//  //    }
	//  //  }

	//  //  public override bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._baseList.IsSynchronized;
	//  //    }
	//  //  }

	//  //  public override object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      this.InternalUpdateRange();
	//  //      if ((index < 0) || (index >= this._baseSize))
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //      }
	//  //      return this._baseList[this._baseIndex + index];
	//  //    }
	//  //    set
	//  //    {
	//  //      this.InternalUpdateRange();
	//  //      if ((index < 0) || (index >= this._baseSize))
	//  //      {
	//  //        throw new ArgumentOutOfRangeException("index", ("ArgumentOutOfRange_Index"));
	//  //      }
	//  //      this._baseList[this._baseIndex + index] = value;
	//  //      this.InternalUpdateVersion();
	//  //    }
	//  //  }

	//  //  public override object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._baseList.SyncRoot;
	//  //    }
	//  //  }
	//  //}

	//  //[Serializable]
	//  //private class ReadOnlyArrayList : ArrayList
	//  //{
	//  //  // Fields
	//  //  private ArrayList _list;

	//  //  // Methods
	//  //  internal ReadOnlyArrayList(ArrayList l)
	//  //  {
	//  //    this._list = l;
	//  //  }

	//  //  public override int Add(object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override void AddRange(ICollection c)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override int BinarySearch(int index, int count, object value, IComparer comparer)
	//  //  {
	//  //    return this._list.BinarySearch(index, count, value, comparer);
	//  //  }

	//  //  public override void Clear()
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override object Clone()
	//  //  {
	//  //    ArrayList.ReadOnlyArrayList list = new ArrayList.ReadOnlyArrayList(this._list);
	//  //    list._list = (ArrayList)this._list.Clone();
	//  //    return list;
	//  //  }

	//  //  public override bool Contains(object obj)
	//  //  {
	//  //    return this._list.Contains(obj);
	//  //  }

	//  //  public override void CopyTo(Array array, int index)
	//  //  {
	//  //    this._list.CopyTo(array, index);
	//  //  }

	//  //  public override void CopyTo(int index, Array array, int arrayIndex, int count)
	//  //  {
	//  //    this._list.CopyTo(index, array, arrayIndex, count);
	//  //  }

	//  //  public override IEnumerator GetEnumerator()
	//  //  {
	//  //    return this._list.GetEnumerator();
	//  //  }

	//  //  public override IEnumerator GetEnumerator(int index, int count)
	//  //  {
	//  //    return this._list.GetEnumerator(index, count);
	//  //  }

	//  //  public override ArrayList GetRange(int index, int count)
	//  //  {
	//  //    if ((index < 0) || (count < 0))
	//  //    {
	//  //      throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", ("ArgumentOutOfRange_NeedNonNegNum"));
	//  //    }
	//  //    if ((this.Count - index) < count)
	//  //    {
	//  //      throw new ArgumentException(("Argument_InvalidOffLen"));
	//  //    }
	//  //    return new ArrayList.Range(this, index, count);
	//  //  }

	//  //  public override int IndexOf(object value)
	//  //  {
	//  //    return this._list.IndexOf(value);
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex)
	//  //  {
	//  //    return this._list.IndexOf(value, startIndex);
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    return this._list.IndexOf(value, startIndex, count);
	//  //  }

	//  //  public override void Insert(int index, object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override void InsertRange(int index, ICollection c)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override int LastIndexOf(object value)
	//  //  {
	//  //    return this._list.LastIndexOf(value);
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex)
	//  //  {
	//  //    return this._list.LastIndexOf(value, startIndex);
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    return this._list.LastIndexOf(value, startIndex, count);
	//  //  }

	//  //  public override void Remove(object value)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override void RemoveAt(int index)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override void RemoveRange(int index, int count)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override void Reverse(int index, int count)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override void SetRange(int index, ICollection c)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override void Sort(int index, int count, IComparer comparer)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public override object[] ToArray()
	//  //  {
	//  //    return this._list.ToArray();
	//  //  }

	//  //  public override Array ToArray(Type type)
	//  //  {
	//  //    return this._list.ToArray(type);
	//  //  }

	//  //  public override void TrimToSize()
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  // Properties
	//  //  public override int Capacity
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Capacity;
	//  //    }
	//  //    set
	//  //    {
	//  //      throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //    }
	//  //  }

	//  //  public override int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Count;
	//  //    }
	//  //  }

	//  //  public override bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public override bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public override bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsSynchronized;
	//  //    }
	//  //  }

	//  //  public override object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list[index];
	//  //    }
	//  //    set
	//  //    {
	//  //      throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //    }
	//  //  }

	//  //  public override object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.SyncRoot;
	//  //    }
	//  //  }
	//  //}

	//  //[Serializable]
	//  //private class ReadOnlyList : IList, ICollection, IEnumerable
	//  //{
	//  //  // Fields
	//  //  private IList _list;

	//  //  // Methods
	//  //  internal ReadOnlyList(IList l)
	//  //  {
	//  //    this._list = l;
	//  //  }

	//  //  public virtual int Add(object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public virtual void Clear()
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public virtual bool Contains(object obj)
	//  //  {
	//  //    return this._list.Contains(obj);
	//  //  }

	//  //  public virtual void CopyTo(Array array, int index)
	//  //  {
	//  //    this._list.CopyTo(array, index);
	//  //  }

	//  //  public virtual IEnumerator GetEnumerator()
	//  //  {
	//  //    return this._list.GetEnumerator();
	//  //  }

	//  //  public virtual int IndexOf(object value)
	//  //  {
	//  //    return this._list.IndexOf(value);
	//  //  }

	//  //  public virtual void Insert(int index, object obj)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public virtual void Remove(object value)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  public virtual void RemoveAt(int index)
	//  //  {
	//  //    throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //  }

	//  //  // Properties
	//  //  public virtual int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.Count;
	//  //    }
	//  //  }

	//  //  public virtual bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public virtual bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public virtual bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsSynchronized;
	//  //    }
	//  //  }

	//  //  public virtual object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list[index];
	//  //    }
	//  //    set
	//  //    {
	//  //      throw new NotSupportedException(("NotSupported_ReadOnlyCollection"));
	//  //    }
	//  //  }

	//  //  public virtual object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.SyncRoot;
	//  //    }
	//  //  }
	//  //}

	//  //[Serializable]
	//  //private class SyncArrayList : ArrayList
	//  //{
	//  //  // Fields
	//  //  private ArrayList _list;
	//  //  private object _root;

	//  //  // Methods
	//  //  internal SyncArrayList(ArrayList list)
	//  //    : base(false)
	//  //  {
	//  //    this._list = list;
	//  //    this._root = list.SyncRoot;
	//  //  }

	//  //  public override int Add(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.Add(value);
	//  //    }
	//  //  }

	//  //  public override void AddRange(ICollection c)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.AddRange(c);
	//  //    }
	//  //  }

	//  //  public override int BinarySearch(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.BinarySearch(value);
	//  //    }
	//  //  }

	//  //  public override int BinarySearch(object value, IComparer comparer)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.BinarySearch(value, comparer);
	//  //    }
	//  //  }

	//  //  public override int BinarySearch(int index, int count, object value, IComparer comparer)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.BinarySearch(index, count, value, comparer);
	//  //    }
	//  //  }

	//  //  public override void Clear()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Clear();
	//  //    }
	//  //  }

	//  //  public override object Clone()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return new ArrayList.SyncArrayList((ArrayList)this._list.Clone());
	//  //    }
	//  //  }

	//  //  public override bool Contains(object item)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.Contains(item);
	//  //    }
	//  //  }

	//  //  public override void CopyTo(Array array)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.CopyTo(array);
	//  //    }
	//  //  }

	//  //  public override void CopyTo(Array array, int index)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.CopyTo(array, index);
	//  //    }
	//  //  }

	//  //  public override void CopyTo(int index, Array array, int arrayIndex, int count)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.CopyTo(index, array, arrayIndex, count);
	//  //    }
	//  //  }

	//  //  public override IEnumerator GetEnumerator()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.GetEnumerator();
	//  //    }
	//  //  }

	//  //  public override IEnumerator GetEnumerator(int index, int count)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.GetEnumerator(index, count);
	//  //    }
	//  //  }

	//  //  public override ArrayList GetRange(int index, int count)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.GetRange(index, count);
	//  //    }
	//  //  }

	//  //  public override int IndexOf(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.IndexOf(value);
	//  //    }
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.IndexOf(value, startIndex);
	//  //    }
	//  //  }

	//  //  public override int IndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.IndexOf(value, startIndex, count);
	//  //    }
	//  //  }

	//  //  public override void Insert(int index, object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Insert(index, value);
	//  //    }
	//  //  }

	//  //  public override void InsertRange(int index, ICollection c)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.InsertRange(index, c);
	//  //    }
	//  //  }

	//  //  public override int LastIndexOf(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.LastIndexOf(value);
	//  //    }
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.LastIndexOf(value, startIndex);
	//  //    }
	//  //  }

	//  //  public override int LastIndexOf(object value, int startIndex, int count)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.LastIndexOf(value, startIndex, count);
	//  //    }
	//  //  }

	//  //  public override void Remove(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Remove(value);
	//  //    }
	//  //  }

	//  //  public override void RemoveAt(int index)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.RemoveAt(index);
	//  //    }
	//  //  }

	//  //  public override void RemoveRange(int index, int count)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.RemoveRange(index, count);
	//  //    }
	//  //  }

	//  //  public override void Reverse(int index, int count)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Reverse(index, count);
	//  //    }
	//  //  }

	//  //  public override void SetRange(int index, ICollection c)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.SetRange(index, c);
	//  //    }
	//  //  }

	//  //  public override void Sort()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Sort();
	//  //    }
	//  //  }

	//  //  public override void Sort(IComparer comparer)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Sort(comparer);
	//  //    }
	//  //  }

	//  //  public override void Sort(int index, int count, IComparer comparer)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Sort(index, count, comparer);
	//  //    }
	//  //  }

	//  //  public override object[] ToArray()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.ToArray();
	//  //    }
	//  //  }

	//  //  public override Array ToArray(Type type)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.ToArray(type);
	//  //    }
	//  //  }

	//  //  public override void TrimToSize()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.TrimToSize();
	//  //    }
	//  //  }

	//  //  // Properties
	//  //  public override int Capacity
	//  //  {
	//  //    get
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        return this._list.Capacity;
	//  //      }
	//  //    }
	//  //    set
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        this._list.Capacity = value;
	//  //      }
	//  //    }
	//  //  }

	//  //  public override int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        return this._list.Count;
	//  //      }
	//  //    }
	//  //  }

	//  //  public override bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsFixedSize;
	//  //    }
	//  //  }

	//  //  public override bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsReadOnly;
	//  //    }
	//  //  }

	//  //  public override bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public override object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        return this._list[index];
	//  //      }
	//  //    }
	//  //    set
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        this._list[index] = value;
	//  //      }
	//  //    }
	//  //  }

	//  //  public override object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._root;
	//  //    }
	//  //  }
	//  //}

	//  //[Serializable]
	//  //private class SyncIList : IList, ICollection, IEnumerable
	//  //{
	//  //  // Fields
	//  //  private IList _list;
	//  //  private object _root;

	//  //  // Methods
	//  //  internal SyncIList(IList list)
	//  //  {
	//  //    this._list = list;
	//  //    this._root = list.SyncRoot;
	//  //  }

	//  //  public virtual int Add(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.Add(value);
	//  //    }
	//  //  }

	//  //  public virtual void Clear()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Clear();
	//  //    }
	//  //  }

	//  //  public virtual bool Contains(object item)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.Contains(item);
	//  //    }
	//  //  }

	//  //  public virtual void CopyTo(Array array, int index)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.CopyTo(array, index);
	//  //    }
	//  //  }

	//  //  public virtual IEnumerator GetEnumerator()
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.GetEnumerator();
	//  //    }
	//  //  }

	//  //  public virtual int IndexOf(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      return this._list.IndexOf(value);
	//  //    }
	//  //  }

	//  //  public virtual void Insert(int index, object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Insert(index, value);
	//  //    }
	//  //  }

	//  //  public virtual void Remove(object value)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.Remove(value);
	//  //    }
	//  //  }

	//  //  public virtual void RemoveAt(int index)
	//  //  {
	//  //    lock (this._root)
	//  //    {
	//  //      this._list.RemoveAt(index);
	//  //    }
	//  //  }

	//  //  // Properties
	//  //  public virtual int Count
	//  //  {
	//  //    get
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        return this._list.Count;
	//  //      }
	//  //    }
	//  //  }

	//  //  public virtual bool IsFixedSize
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsFixedSize;
	//  //    }
	//  //  }

	//  //  public virtual bool IsReadOnly
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._list.IsReadOnly;
	//  //    }
	//  //  }

	//  //  public virtual bool IsSynchronized
	//  //  {
	//  //    get
	//  //    {
	//  //      return true;
	//  //    }
	//  //  }

	//  //  public virtual object this[int index]
	//  //  {
	//  //    get
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        return this._list[index];
	//  //      }
	//  //    }
	//  //    set
	//  //    {
	//  //      lock (this._root)
	//  //      {
	//  //        this._list[index] = value;
	//  //      }
	//  //    }
	//  //  }

	//  //  public virtual object SyncRoot
	//  //  {
	//  //    get
	//  //    {
	//  //      return this._root;
	//  //    }
	//  //  }
	//  //}
	//  #endregion
	//}




}
