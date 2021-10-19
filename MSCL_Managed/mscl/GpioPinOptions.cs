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

public class GpioPinOptions : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<byte, GpioFeatureBehaviors>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GpioPinOptions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GpioPinOptions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GpioPinOptions() {
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
          msclPINVOKE.delete_GpioPinOptions(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }


  public GpioFeatureBehaviors this[byte key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(byte key, out GpioFeatureBehaviors value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(GpioFeatureBehaviors);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public global::System.Collections.Generic.ICollection<byte> Keys {
    get {
      global::System.Collections.Generic.ICollection<byte> keys = new global::System.Collections.Generic.List<byte>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<GpioFeatureBehaviors> Values {
    get {
      global::System.Collections.Generic.ICollection<GpioFeatureBehaviors> vals = new global::System.Collections.Generic.List<GpioFeatureBehaviors>();
      foreach (global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }

  public void Add(global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<byte> keyList = new global::System.Collections.Generic.List<byte>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      byte currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>>.GetEnumerator() {
    return new GpioPinOptionsEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new GpioPinOptionsEnumerator(this);
  }

  public GpioPinOptionsEnumerator GetEnumerator() {
    return new GpioPinOptionsEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class GpioPinOptionsEnumerator : global::System.Collections.IEnumerator,
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>>
  {
    private GpioPinOptions collectionRef;
    private global::System.Collections.Generic.IList<byte> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public GpioPinOptionsEnumerator(GpioPinOptions collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<byte>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>)currentObject;
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
        byte currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<byte, GpioFeatureBehaviors>(currentKey, collectionRef[currentKey]);
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


  public GpioPinOptions() : this(msclPINVOKE.new_GpioPinOptions__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GpioPinOptions(GpioPinOptions other) : this(msclPINVOKE.new_GpioPinOptions__SWIG_1(GpioPinOptions.getCPtr(other)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = msclPINVOKE.GpioPinOptions_size(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = msclPINVOKE.GpioPinOptions_empty(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    msclPINVOKE.GpioPinOptions_Clear(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private GpioFeatureBehaviors getitem(byte key) {
    GpioFeatureBehaviors ret = new GpioFeatureBehaviors(msclPINVOKE.GpioPinOptions_getitem(swigCPtr, key), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(byte key, GpioFeatureBehaviors x) {
    msclPINVOKE.GpioPinOptions_setitem(swigCPtr, key, GpioFeatureBehaviors.getCPtr(x));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(byte key) {
    bool ret = msclPINVOKE.GpioPinOptions_ContainsKey(swigCPtr, key);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(byte key, GpioFeatureBehaviors value) {
    msclPINVOKE.GpioPinOptions_Add(swigCPtr, key, GpioFeatureBehaviors.getCPtr(value));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(byte key) {
    bool ret = msclPINVOKE.GpioPinOptions_Remove(swigCPtr, key);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = msclPINVOKE.GpioPinOptions_create_iterator_begin(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private byte get_next_key(global::System.IntPtr swigiterator) {
    byte ret = msclPINVOKE.GpioPinOptions_get_next_key(swigCPtr, swigiterator);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    msclPINVOKE.GpioPinOptions_destroy_iterator(swigCPtr, swigiterator);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
