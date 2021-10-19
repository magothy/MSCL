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

public class MipChannelIdentifiers : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<MipChannelIdentifier>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MipChannelIdentifiers(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MipChannelIdentifiers obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MipChannelIdentifiers() {
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
          msclPINVOKE.delete_MipChannelIdentifiers(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public MipChannelIdentifiers(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MipChannelIdentifier element in c) {
      this.Add(element);
    }
  }

  public MipChannelIdentifiers(global::System.Collections.Generic.IEnumerable<MipChannelIdentifier> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MipChannelIdentifier element in c) {
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

  public MipChannelIdentifier this[int index]  {
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

  public void CopyTo(MipChannelIdentifier[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(MipChannelIdentifier[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, MipChannelIdentifier[] array, int arrayIndex, int count)
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

  public MipChannelIdentifier[] ToArray() {
    MipChannelIdentifier[] array = new MipChannelIdentifier[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<MipChannelIdentifier> global::System.Collections.Generic.IEnumerable<MipChannelIdentifier>.GetEnumerator() {
    return new MipChannelIdentifiersEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new MipChannelIdentifiersEnumerator(this);
  }

  public MipChannelIdentifiersEnumerator GetEnumerator() {
    return new MipChannelIdentifiersEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class MipChannelIdentifiersEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<MipChannelIdentifier>
  {
    private MipChannelIdentifiers collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public MipChannelIdentifiersEnumerator(MipChannelIdentifiers collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public MipChannelIdentifier Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (MipChannelIdentifier)currentObject;
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
    msclPINVOKE.MipChannelIdentifiers_Clear(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(MipChannelIdentifier x) {
    msclPINVOKE.MipChannelIdentifiers_Add(swigCPtr, MipChannelIdentifier.getCPtr(x));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = msclPINVOKE.MipChannelIdentifiers_size(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = msclPINVOKE.MipChannelIdentifiers_capacity(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    msclPINVOKE.MipChannelIdentifiers_reserve(swigCPtr, n);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public MipChannelIdentifiers() : this(msclPINVOKE.new_MipChannelIdentifiers__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public MipChannelIdentifiers(MipChannelIdentifiers other) : this(msclPINVOKE.new_MipChannelIdentifiers__SWIG_1(MipChannelIdentifiers.getCPtr(other)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public MipChannelIdentifiers(int capacity) : this(msclPINVOKE.new_MipChannelIdentifiers__SWIG_2(capacity), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private MipChannelIdentifier getitemcopy(int index) {
    MipChannelIdentifier ret = new MipChannelIdentifier(msclPINVOKE.MipChannelIdentifiers_getitemcopy(swigCPtr, index), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private MipChannelIdentifier getitem(int index) {
    MipChannelIdentifier ret = new MipChannelIdentifier(msclPINVOKE.MipChannelIdentifiers_getitem(swigCPtr, index), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, MipChannelIdentifier val) {
    msclPINVOKE.MipChannelIdentifiers_setitem(swigCPtr, index, MipChannelIdentifier.getCPtr(val));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(MipChannelIdentifiers values) {
    msclPINVOKE.MipChannelIdentifiers_AddRange(swigCPtr, MipChannelIdentifiers.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public MipChannelIdentifiers GetRange(int index, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.MipChannelIdentifiers_GetRange(swigCPtr, index, count);
    MipChannelIdentifiers ret = (cPtr == global::System.IntPtr.Zero) ? null : new MipChannelIdentifiers(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, MipChannelIdentifier x) {
    msclPINVOKE.MipChannelIdentifiers_Insert(swigCPtr, index, MipChannelIdentifier.getCPtr(x));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, MipChannelIdentifiers values) {
    msclPINVOKE.MipChannelIdentifiers_InsertRange(swigCPtr, index, MipChannelIdentifiers.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    msclPINVOKE.MipChannelIdentifiers_RemoveAt(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    msclPINVOKE.MipChannelIdentifiers_RemoveRange(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static MipChannelIdentifiers Repeat(MipChannelIdentifier value, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.MipChannelIdentifiers_Repeat(MipChannelIdentifier.getCPtr(value), count);
    MipChannelIdentifiers ret = (cPtr == global::System.IntPtr.Zero) ? null : new MipChannelIdentifiers(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    msclPINVOKE.MipChannelIdentifiers_Reverse__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    msclPINVOKE.MipChannelIdentifiers_Reverse__SWIG_1(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, MipChannelIdentifiers values) {
    msclPINVOKE.MipChannelIdentifiers_SetRange(swigCPtr, index, MipChannelIdentifiers.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
