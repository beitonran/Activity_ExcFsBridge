/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace excaliburST {

using System;
using System.Runtime.InteropServices;

public class vecinfo : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerable<t_ExcDevInfoPacket>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vecinfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(vecinfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~vecinfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          stfuncsPINVOKE.delete_vecinfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public vecinfo(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (t_ExcDevInfoPacket element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public t_ExcDevInfoPacket this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(t_ExcDevInfoPacket[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(t_ExcDevInfoPacket[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, t_ExcDevInfoPacket[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<t_ExcDevInfoPacket> System.Collections.Generic.IEnumerable<t_ExcDevInfoPacket>.GetEnumerator() {
    return new vecinfoEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new vecinfoEnumerator(this);
  }

  public vecinfoEnumerator GetEnumerator() {
    return new vecinfoEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class vecinfoEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<t_ExcDevInfoPacket>
#endif
  {
    private vecinfo collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public vecinfoEnumerator(vecinfo collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public t_ExcDevInfoPacket Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (t_ExcDevInfoPacket)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    stfuncsPINVOKE.vecinfo_Clear(swigCPtr);
  }

  public void Add(t_ExcDevInfoPacket x) {
    stfuncsPINVOKE.vecinfo_Add(swigCPtr, t_ExcDevInfoPacket.getCPtr(x));
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = stfuncsPINVOKE.vecinfo_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = stfuncsPINVOKE.vecinfo_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    stfuncsPINVOKE.vecinfo_reserve(swigCPtr, n);
  }

  public vecinfo() : this(stfuncsPINVOKE.new_vecinfo__SWIG_0(), true) {
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public vecinfo(vecinfo other) : this(stfuncsPINVOKE.new_vecinfo__SWIG_1(vecinfo.getCPtr(other)), true) {
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public vecinfo(int capacity) : this(stfuncsPINVOKE.new_vecinfo__SWIG_2(capacity), true) {
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private t_ExcDevInfoPacket getitemcopy(int index) {
    t_ExcDevInfoPacket ret = new t_ExcDevInfoPacket(stfuncsPINVOKE.vecinfo_getitemcopy(swigCPtr, index), true);
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private t_ExcDevInfoPacket getitem(int index) {
    t_ExcDevInfoPacket ret = new t_ExcDevInfoPacket(stfuncsPINVOKE.vecinfo_getitem(swigCPtr, index), false);
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, t_ExcDevInfoPacket val) {
    stfuncsPINVOKE.vecinfo_setitem(swigCPtr, index, t_ExcDevInfoPacket.getCPtr(val));
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(vecinfo values) {
    stfuncsPINVOKE.vecinfo_AddRange(swigCPtr, vecinfo.getCPtr(values));
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public vecinfo GetRange(int index, int count) {
    IntPtr cPtr = stfuncsPINVOKE.vecinfo_GetRange(swigCPtr, index, count);
    vecinfo ret = (cPtr == IntPtr.Zero) ? null : new vecinfo(cPtr, true);
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, t_ExcDevInfoPacket x) {
    stfuncsPINVOKE.vecinfo_Insert(swigCPtr, index, t_ExcDevInfoPacket.getCPtr(x));
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, vecinfo values) {
    stfuncsPINVOKE.vecinfo_InsertRange(swigCPtr, index, vecinfo.getCPtr(values));
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    stfuncsPINVOKE.vecinfo_RemoveAt(swigCPtr, index);
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    stfuncsPINVOKE.vecinfo_RemoveRange(swigCPtr, index, count);
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static vecinfo Repeat(t_ExcDevInfoPacket value, int count) {
    IntPtr cPtr = stfuncsPINVOKE.vecinfo_Repeat(t_ExcDevInfoPacket.getCPtr(value), count);
    vecinfo ret = (cPtr == IntPtr.Zero) ? null : new vecinfo(cPtr, true);
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    stfuncsPINVOKE.vecinfo_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    stfuncsPINVOKE.vecinfo_Reverse__SWIG_1(swigCPtr, index, count);
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, vecinfo values) {
    stfuncsPINVOKE.vecinfo_SetRange(swigCPtr, index, vecinfo.getCPtr(values));
    if (stfuncsPINVOKE.SWIGPendingException.Pending) throw stfuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
