//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class RawBytePackets : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<RawBytePacket>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RawBytePackets(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RawBytePackets obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RawBytePackets() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_RawBytePackets(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public RawBytePackets(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (RawBytePacket element in c) {
      this.Add(element);
    }
  }

  public RawBytePackets(global::System.Collections.Generic.IEnumerable<RawBytePacket> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (RawBytePacket element in c) {
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

  public RawBytePacket this[int index]  {
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
        throw new global::System.ArgumentOutOfRangeException("Capacity");
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

  public void CopyTo(RawBytePacket[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(RawBytePacket[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, RawBytePacket[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public RawBytePacket[] ToArray() {
    RawBytePacket[] array = new RawBytePacket[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<RawBytePacket> global::System.Collections.Generic.IEnumerable<RawBytePacket>.GetEnumerator() {
    return new RawBytePacketsEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new RawBytePacketsEnumerator(this);
  }

  public RawBytePacketsEnumerator GetEnumerator() {
    return new RawBytePacketsEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class RawBytePacketsEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<RawBytePacket>
  {
    private RawBytePackets collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public RawBytePacketsEnumerator(RawBytePackets collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public RawBytePacket Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (RawBytePacket)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
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
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    msclPINVOKE.RawBytePackets_Clear(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(RawBytePacket x) {
    msclPINVOKE.RawBytePackets_Add(swigCPtr, RawBytePacket.getCPtr(x));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = msclPINVOKE.RawBytePackets_size(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = msclPINVOKE.RawBytePackets_capacity(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    msclPINVOKE.RawBytePackets_reserve(swigCPtr, n);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RawBytePackets() : this(msclPINVOKE.new_RawBytePackets__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RawBytePackets(RawBytePackets other) : this(msclPINVOKE.new_RawBytePackets__SWIG_1(RawBytePackets.getCPtr(other)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RawBytePackets(int capacity) : this(msclPINVOKE.new_RawBytePackets__SWIG_2(capacity), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private RawBytePacket getitemcopy(int index) {
    RawBytePacket ret = new RawBytePacket(msclPINVOKE.RawBytePackets_getitemcopy(swigCPtr, index), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private RawBytePacket getitem(int index) {
    RawBytePacket ret = new RawBytePacket(msclPINVOKE.RawBytePackets_getitem(swigCPtr, index), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, RawBytePacket val) {
    msclPINVOKE.RawBytePackets_setitem(swigCPtr, index, RawBytePacket.getCPtr(val));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(RawBytePackets values) {
    msclPINVOKE.RawBytePackets_AddRange(swigCPtr, RawBytePackets.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RawBytePackets GetRange(int index, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.RawBytePackets_GetRange(swigCPtr, index, count);
    RawBytePackets ret = (cPtr == global::System.IntPtr.Zero) ? null : new RawBytePackets(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, RawBytePacket x) {
    msclPINVOKE.RawBytePackets_Insert(swigCPtr, index, RawBytePacket.getCPtr(x));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, RawBytePackets values) {
    msclPINVOKE.RawBytePackets_InsertRange(swigCPtr, index, RawBytePackets.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    msclPINVOKE.RawBytePackets_RemoveAt(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    msclPINVOKE.RawBytePackets_RemoveRange(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static RawBytePackets Repeat(RawBytePacket value, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.RawBytePackets_Repeat(RawBytePacket.getCPtr(value), count);
    RawBytePackets ret = (cPtr == global::System.IntPtr.Zero) ? null : new RawBytePackets(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    msclPINVOKE.RawBytePackets_Reverse__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    msclPINVOKE.RawBytePackets_Reverse__SWIG_1(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, RawBytePackets values) {
    msclPINVOKE.RawBytePackets_SetRange(swigCPtr, index, RawBytePackets.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
