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

public class GnssSignalConfiguration : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GnssSignalConfiguration(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GnssSignalConfiguration obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GnssSignalConfiguration() {
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
          msclPINVOKE.delete_GnssSignalConfiguration(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public GnssSignalConfiguration() : this(msclPINVOKE.new_GnssSignalConfiguration(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableGpsSignal(GnssSignalConfiguration.GpsSignal signal, bool enable) {
    msclPINVOKE.GnssSignalConfiguration_enableGpsSignal__SWIG_0(swigCPtr, (int)signal, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableGpsSignal(GnssSignalConfiguration.GpsSignal signal) {
    msclPINVOKE.GnssSignalConfiguration_enableGpsSignal__SWIG_1(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool gpsSignalEnabled(GnssSignalConfiguration.GpsSignal signal) {
    bool ret = msclPINVOKE.GnssSignalConfiguration_gpsSignalEnabled(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void gpsSignalValue(byte val) {
    msclPINVOKE.GnssSignalConfiguration_gpsSignalValue__SWIG_0(swigCPtr, val);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte gpsSignalValue() {
    byte ret = msclPINVOKE.GnssSignalConfiguration_gpsSignalValue__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableGlonassSignal(GnssSignalConfiguration.GlonassSignal signal, bool enable) {
    msclPINVOKE.GnssSignalConfiguration_enableGlonassSignal__SWIG_0(swigCPtr, (int)signal, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableGlonassSignal(GnssSignalConfiguration.GlonassSignal signal) {
    msclPINVOKE.GnssSignalConfiguration_enableGlonassSignal__SWIG_1(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool glonassSignalEnabled(GnssSignalConfiguration.GlonassSignal signal) {
    bool ret = msclPINVOKE.GnssSignalConfiguration_glonassSignalEnabled(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void glonassSignalValue(byte val) {
    msclPINVOKE.GnssSignalConfiguration_glonassSignalValue__SWIG_0(swigCPtr, val);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte glonassSignalValue() {
    byte ret = msclPINVOKE.GnssSignalConfiguration_glonassSignalValue__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableGalileoSignal(GnssSignalConfiguration.GalileoSignal signal, bool enable) {
    msclPINVOKE.GnssSignalConfiguration_enableGalileoSignal__SWIG_0(swigCPtr, (int)signal, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableGalileoSignal(GnssSignalConfiguration.GalileoSignal signal) {
    msclPINVOKE.GnssSignalConfiguration_enableGalileoSignal__SWIG_1(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool galileoSignalEnabled(GnssSignalConfiguration.GalileoSignal signal) {
    bool ret = msclPINVOKE.GnssSignalConfiguration_galileoSignalEnabled(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void galileoSignalValue(byte val) {
    msclPINVOKE.GnssSignalConfiguration_galileoSignalValue__SWIG_0(swigCPtr, val);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte galileoSignalValue() {
    byte ret = msclPINVOKE.GnssSignalConfiguration_galileoSignalValue__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableBeiDouSignal(GnssSignalConfiguration.BeiDouSignal signal, bool enable) {
    msclPINVOKE.GnssSignalConfiguration_enableBeiDouSignal__SWIG_0(swigCPtr, (int)signal, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableBeiDouSignal(GnssSignalConfiguration.BeiDouSignal signal) {
    msclPINVOKE.GnssSignalConfiguration_enableBeiDouSignal__SWIG_1(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool beidouSignalEnabled(GnssSignalConfiguration.BeiDouSignal signal) {
    bool ret = msclPINVOKE.GnssSignalConfiguration_beidouSignalEnabled(swigCPtr, (int)signal);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void beidouSignalValue(byte val) {
    msclPINVOKE.GnssSignalConfiguration_beidouSignalValue__SWIG_0(swigCPtr, val);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte beidouSignalValue() {
    byte ret = msclPINVOKE.GnssSignalConfiguration_beidouSignalValue__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum GpsSignal {
    L1CA = 0x01,
    L2C = 0x02
  }

  public enum GlonassSignal {
    L1OF = 0x01,
    L2OF = 0x02
  }

  public enum GalileoSignal {
    E1 = 0x01,
    E5B = 0x02
  }

  public enum BeiDouSignal {
    B1 = 0x01,
    B2 = 0x02
  }

}

}
