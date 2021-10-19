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

public class AdaptiveFilterLevels : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<InertialTypes.AutoAdaptiveFilteringLevel>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AdaptiveFilterLevels(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AdaptiveFilterLevels obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AdaptiveFilterLevels() {
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
          msclPINVOKE.delete_AdaptiveFilterLevels(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public AdaptiveFilterLevels(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (InertialTypes.AutoAdaptiveFilteringLevel element in c) {
      this.Add(element);
    }
  }

  public AdaptiveFilterLevels(global::System.Collections.Generic.IEnumerable<InertialTypes.AutoAdaptiveFilteringLevel> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (InertialTypes.AutoAdaptiveFilteringLevel element in c) {
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

  public InertialTypes.AutoAdaptiveFilteringLevel this[int index]  {
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

  public void CopyTo(InertialTypes.AutoAdaptiveFilteringLevel[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(InertialTypes.AutoAdaptiveFilteringLevel[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, InertialTypes.AutoAdaptiveFilteringLevel[] array, int arrayIndex, int count)
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

  public InertialTypes.AutoAdaptiveFilteringLevel[] ToArray() {
    InertialTypes.AutoAdaptiveFilteringLevel[] array = new InertialTypes.AutoAdaptiveFilteringLevel[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<InertialTypes.AutoAdaptiveFilteringLevel> global::System.Collections.Generic.IEnumerable<InertialTypes.AutoAdaptiveFilteringLevel>.GetEnumerator() {
    return new AdaptiveFilterLevelsEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new AdaptiveFilterLevelsEnumerator(this);
  }

  public AdaptiveFilterLevelsEnumerator GetEnumerator() {
    return new AdaptiveFilterLevelsEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class AdaptiveFilterLevelsEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<InertialTypes.AutoAdaptiveFilteringLevel>
  {
    private AdaptiveFilterLevels collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public AdaptiveFilterLevelsEnumerator(AdaptiveFilterLevels collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public InertialTypes.AutoAdaptiveFilteringLevel Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (InertialTypes.AutoAdaptiveFilteringLevel)currentObject;
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
    msclPINVOKE.AdaptiveFilterLevels_Clear(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(InertialTypes.AutoAdaptiveFilteringLevel x) {
    msclPINVOKE.AdaptiveFilterLevels_Add(swigCPtr, (int)x);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = msclPINVOKE.AdaptiveFilterLevels_size(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = msclPINVOKE.AdaptiveFilterLevels_capacity(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    msclPINVOKE.AdaptiveFilterLevels_reserve(swigCPtr, n);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdaptiveFilterLevels() : this(msclPINVOKE.new_AdaptiveFilterLevels__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdaptiveFilterLevels(AdaptiveFilterLevels other) : this(msclPINVOKE.new_AdaptiveFilterLevels__SWIG_1(AdaptiveFilterLevels.getCPtr(other)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdaptiveFilterLevels(int capacity) : this(msclPINVOKE.new_AdaptiveFilterLevels__SWIG_2(capacity), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private InertialTypes.AutoAdaptiveFilteringLevel getitemcopy(int index) {
    InertialTypes.AutoAdaptiveFilteringLevel ret = (InertialTypes.AutoAdaptiveFilteringLevel)msclPINVOKE.AdaptiveFilterLevels_getitemcopy(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private InertialTypes.AutoAdaptiveFilteringLevel getitem(int index) {
    InertialTypes.AutoAdaptiveFilteringLevel ret = (InertialTypes.AutoAdaptiveFilteringLevel)msclPINVOKE.AdaptiveFilterLevels_getitem(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, InertialTypes.AutoAdaptiveFilteringLevel val) {
    msclPINVOKE.AdaptiveFilterLevels_setitem(swigCPtr, index, (int)val);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(AdaptiveFilterLevels values) {
    msclPINVOKE.AdaptiveFilterLevels_AddRange(swigCPtr, AdaptiveFilterLevels.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdaptiveFilterLevels GetRange(int index, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.AdaptiveFilterLevels_GetRange(swigCPtr, index, count);
    AdaptiveFilterLevels ret = (cPtr == global::System.IntPtr.Zero) ? null : new AdaptiveFilterLevels(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, InertialTypes.AutoAdaptiveFilteringLevel x) {
    msclPINVOKE.AdaptiveFilterLevels_Insert(swigCPtr, index, (int)x);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, AdaptiveFilterLevels values) {
    msclPINVOKE.AdaptiveFilterLevels_InsertRange(swigCPtr, index, AdaptiveFilterLevels.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    msclPINVOKE.AdaptiveFilterLevels_RemoveAt(swigCPtr, index);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    msclPINVOKE.AdaptiveFilterLevels_RemoveRange(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static AdaptiveFilterLevels Repeat(InertialTypes.AutoAdaptiveFilteringLevel value, int count) {
    global::System.IntPtr cPtr = msclPINVOKE.AdaptiveFilterLevels_Repeat((int)value, count);
    AdaptiveFilterLevels ret = (cPtr == global::System.IntPtr.Zero) ? null : new AdaptiveFilterLevels(cPtr, true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    msclPINVOKE.AdaptiveFilterLevels_Reverse__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    msclPINVOKE.AdaptiveFilterLevels_Reverse__SWIG_1(swigCPtr, index, count);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, AdaptiveFilterLevels values) {
    msclPINVOKE.AdaptiveFilterLevels_SetRange(swigCPtr, index, AdaptiveFilterLevels.getCPtr(values));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
