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

public class ChannelMask : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChannelMask(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChannelMask obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChannelMask() {
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
          msclPINVOKE.delete_ChannelMask(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

    public override bool Equals(object obj){ChannelMask other = obj as ChannelMask; return this.__eq__(other);}
    public override int GetHashCode(){ return (int)(toMask()); }
    public static bool operator<(ChannelMask v1, ChannelMask v2) { return v1.__lt__(v2); }
    public static bool operator>(ChannelMask v1, ChannelMask v2) { return v1.__gt__(v2); }

  public ChannelMask(ushort channelMask) : this(msclPINVOKE.new_ChannelMask__SWIG_0(channelMask), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChannelMask() : this(msclPINVOKE.new_ChannelMask__SWIG_1(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool __eq__(ChannelMask other) {
    bool ret = msclPINVOKE.ChannelMask___eq__(swigCPtr, ChannelMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool __ne__(ChannelMask other) {
    bool ret = msclPINVOKE.ChannelMask___ne__(swigCPtr, ChannelMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool __lt__(ChannelMask other) {
    bool ret = msclPINVOKE.ChannelMask___lt__(swigCPtr, ChannelMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool __gt__(ChannelMask other) {
    bool ret = msclPINVOKE.ChannelMask___gt__(swigCPtr, ChannelMask.getCPtr(other));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void fromMask(ushort channelMask) {
    msclPINVOKE.ChannelMask_fromMask(swigCPtr, channelMask);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort toMask() {
    ushort ret = msclPINVOKE.ChannelMask_toMask(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte count() {
    byte ret = msclPINVOKE.ChannelMask_count(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool enabled(byte channel) {
    bool ret = msclPINVOKE.ChannelMask_enabled(swigCPtr, channel);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enable(byte channel, bool enable) {
    msclPINVOKE.ChannelMask_enable__SWIG_0(swigCPtr, channel, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enable(byte channel) {
    msclPINVOKE.ChannelMask_enable__SWIG_1(swigCPtr, channel);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte lastChEnabled() {
    byte ret = msclPINVOKE.ChannelMask_lastChEnabled(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly byte MAX_CHANNELS = msclPINVOKE.ChannelMask_MAX_CHANNELS_get();
}

}
