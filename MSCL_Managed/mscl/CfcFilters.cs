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

public class CfcFilters : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<WirelessTypes.ChannelFrequencyClass>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CfcFilters(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CfcFilters obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CfcFilters() {
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
          msclPINVOKE.delete_CfcFilters(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CfcFilters(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (WirelessTypes.ChannelFrequencyClass element in c) {
      this.Add(element);
    }
  }

  public CfcFilters(global::System.Collections.Generic.IEnumerable<WirelessTypes.ChannelFrequencyClass> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (WirelessTypes.ChannelFrequencyClass element in c) {
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

  public WirelessTypes.ChannelFrequencyClass this[int index]  {
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

  public void CopyTo(WirelessTypes.ChannelFrequencyClass[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(WirelessTypes.ChannelFrequencyClass[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, WirelessTypes.ChannelFrequencyClass[] array, int arrayIndex, int count)
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

  public WirelessTypes.ChannelFrequencyClass[] ToArray() {
    WirelessTypes.ChannelFrequencyClass[] array = new WirelessTypes.ChannelFrequencyClass[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<WirelessTypes.ChannelFrequencyClass> global::System.Collections.Generic.IEnumerable<WirelessTypes.ChannelFrequencyClass>.GetEnumerator() {
    return new CfcFiltersEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CfcFiltersEnumerator(this);
  }

  public CfcFiltersEnumerator GetEnumerator() {
    return new CfcFiltersEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CfcFiltersEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<WirelessTypes.ChannelFrequencyClass>
  {
    private CfcFilters collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CfcFiltersEnumerator(CfcFilters collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public WirelessTypes.ChannelFrequencyClass Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (WirelessTypes.ChannelFrequencyClass)currentObject;
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
    msclPINVOKE.CfcFilters_Clear(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(WirelessTypes.ChannelFrequencyClass x) {
    msclPINVOKE.CfcFilters_Add(swigCPtr, (int)x);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = msclPINVOKE.CfcFilters_size(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = msclPINVOKE.CfcFilters_capacity(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    msclPINVOKE.CfcFilters_reserve(swigCPtr, n);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public CfcFilters() : this(msclPINVOKE.new_CfcFilters__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public CfcFilters(CfcFilters other) : this(msclPINVOKE.new_CfcFilters__SWIG_1(CfcFilters.getCPtr(other)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public CfcFilters(int capacity) : this(msclPINVOKE.new_CfcFilters__SWIG_2(capacity), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private WirelessTypes.ChannelFrequencyClass getitemcopy(int index) {
    WirelessTypes.ChannelFrequencyClass ret = (WirelessTypes.ChannelFrequencyClass)msclPINVOKE.CfcFilters_getitemcopy(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private WirelessTypes.ChannelFrequencyClass getitem(int index) {
    WirelessTypes.ChannelFrequencyClass ret = (WirelessTypes.ChannelFrequencyClass)msclPINVOKE.CfcFilters_getitem(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, WirelessTypes.ChannelFrequencyClass val) {
    msclPINVOKE.CfcFilters_setitem(swigCPtr, index, (int)val);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(CfcFilters values) {
    msclPINVOKE.CfcFilters_AddRange(swigCPtr, CfcFilters.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public CfcFilters GetRange(int index, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.CfcFilters_GetRange(swigCPtr, index, count);
    CfcFilters ret = (cPtr == global::System.IntPtr.Zero) ? null : new CfcFilters(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, WirelessTypes.ChannelFrequencyClass x) {
    msclPINVOKE.CfcFilters_Insert(swigCPtr, index, (int)x);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, CfcFilters values) {
    msclPINVOKE.CfcFilters_InsertRange(swigCPtr, index, CfcFilters.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    msclPINVOKE.CfcFilters_RemoveAt(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    msclPINVOKE.CfcFilters_RemoveRange(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CfcFilters Repeat(WirelessTypes.ChannelFrequencyClass value, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.CfcFilters_Repeat((int)value, count);
    CfcFilters ret = (cPtr == global::System.IntPtr.Zero) ? null : new CfcFilters(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    msclPINVOKE.CfcFilters_Reverse__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    msclPINVOKE.CfcFilters_Reverse__SWIG_1(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, CfcFilters values) {
    msclPINVOKE.CfcFilters_SetRange(swigCPtr, index, CfcFilters.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
