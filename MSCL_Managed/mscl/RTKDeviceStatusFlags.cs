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

public class RTKDeviceStatusFlags : Bitfield {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RTKDeviceStatusFlags(global::System.IntPtr cPtr, bool cMemoryOwn) : base(msclPINVOKE.RTKDeviceStatusFlags_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RTKDeviceStatusFlags obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_RTKDeviceStatusFlags(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public RTKDeviceStatusFlags() : this(msclPINVOKE.new_RTKDeviceStatusFlags__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RTKDeviceStatusFlags(uint flags) : this(msclPINVOKE.new_RTKDeviceStatusFlags__SWIG_1(flags), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RTKDeviceStatusFlags(RTKDeviceStatusFlags_v1 rtk_v1) : this(msclPINVOKE.new_RTKDeviceStatusFlags__SWIG_2(RTKDeviceStatusFlags_v1.getCPtr(rtk_v1)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte version() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_version(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RTKDeviceStatusFlags.ModemState modemState() {
    RTKDeviceStatusFlags.ModemState ret = (RTKDeviceStatusFlags.ModemState)msclPINVOKE.RTKDeviceStatusFlags_modemState__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void modemState(RTKDeviceStatusFlags.ModemState state) {
    msclPINVOKE.RTKDeviceStatusFlags_modemState__SWIG_1(swigCPtr, (int)state);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RTKDeviceStatusFlags.ConnectionType connectionType() {
    RTKDeviceStatusFlags.ConnectionType ret = (RTKDeviceStatusFlags.ConnectionType)msclPINVOKE.RTKDeviceStatusFlags_connectionType__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void connectionType(RTKDeviceStatusFlags.ConnectionType state) {
    msclPINVOKE.RTKDeviceStatusFlags_connectionType__SWIG_1(swigCPtr, (int)state);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public sbyte rssi() {
    sbyte ret = msclPINVOKE.RTKDeviceStatusFlags_rssi__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void rssi(byte value) {
    msclPINVOKE.RTKDeviceStatusFlags_rssi__SWIG_1(swigCPtr, value);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte signalQuality() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_signalQuality__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void signalQuality(byte quality) {
    msclPINVOKE.RTKDeviceStatusFlags_signalQuality__SWIG_1(swigCPtr, quality);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte towerChangeIndicator() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_towerChangeIndicator__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void towerChangeIndicator(byte value) {
    msclPINVOKE.RTKDeviceStatusFlags_towerChangeIndicator__SWIG_1(swigCPtr, value);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte nmeaTimeout() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_nmeaTimeout__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void nmeaTimeout(byte timeout) {
    msclPINVOKE.RTKDeviceStatusFlags_nmeaTimeout__SWIG_1(swigCPtr, timeout);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte serverTimeout() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_serverTimeout__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void serverTimeout(byte timeout) {
    msclPINVOKE.RTKDeviceStatusFlags_serverTimeout__SWIG_1(swigCPtr, timeout);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte rtcmTimeout() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_rtcmTimeout__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void rtcmTimeout(byte timeout) {
    msclPINVOKE.RTKDeviceStatusFlags_rtcmTimeout__SWIG_1(swigCPtr, timeout);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte deviceOutOfRange() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_deviceOutOfRange__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void deviceOutOfRange(byte outOfRange) {
    msclPINVOKE.RTKDeviceStatusFlags_deviceOutOfRange__SWIG_1(swigCPtr, outOfRange);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte correctionsUnavailable() {
    byte ret = msclPINVOKE.RTKDeviceStatusFlags_correctionsUnavailable__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void correctionsUnavailable(byte unavailable) {
    msclPINVOKE.RTKDeviceStatusFlags_correctionsUnavailable__SWIG_1(swigCPtr, unavailable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static readonly uint MODEM_STATE = msclPINVOKE.RTKDeviceStatusFlags_MODEM_STATE_get();
  public static readonly uint CONNECTION_TYPE = msclPINVOKE.RTKDeviceStatusFlags_CONNECTION_TYPE_get();
  public static readonly uint RSSI = msclPINVOKE.RTKDeviceStatusFlags_RSSI_get();
  public static readonly uint SIGNAL_QUALITY = msclPINVOKE.RTKDeviceStatusFlags_SIGNAL_QUALITY_get();
  public static readonly uint TOWER_CHANGE_INDICATOR = msclPINVOKE.RTKDeviceStatusFlags_TOWER_CHANGE_INDICATOR_get();
  public static readonly uint NMEA_TIMEOUT = msclPINVOKE.RTKDeviceStatusFlags_NMEA_TIMEOUT_get();
  public static readonly uint SERVER_TIMEOUT = msclPINVOKE.RTKDeviceStatusFlags_SERVER_TIMEOUT_get();
  public static readonly uint RTCM_TIMEOUT = msclPINVOKE.RTKDeviceStatusFlags_RTCM_TIMEOUT_get();
  public static readonly uint DEVICE_OUT_OF_RANGE = msclPINVOKE.RTKDeviceStatusFlags_DEVICE_OUT_OF_RANGE_get();
  public static readonly uint CORRECTIONS_UNAVAILABLE = msclPINVOKE.RTKDeviceStatusFlags_CORRECTIONS_UNAVAILABLE_get();
  public static readonly uint VERSION = msclPINVOKE.RTKDeviceStatusFlags_VERSION_get();
  public enum ModemState {
    OFF = 0x00,
    NO_NETWORK = 0x01,
    NETWORK_CONNECTED = 0x02,
    CONFIGURING_DATA_CONTEXT = 0x03,
    ACTIVATING_DATA_CONTEXT = 0x04,
    CONFIGURING_SOCKET = 0x05,
    WAITING_ON_SERVER_HANDSHAKE = 0x06,
    CONNECTED_AND_IDLE = 0x07,
    CONNECTED_AND_STREAMING = 0x08
  }

  public enum ConnectionType {
    NO_CONNECTION = 0x00,
    CONNECTION_2G = 0x02,
    CONNECTION_3G = 0x03,
    CONNECTION_4G = 0x04,
    CONNECTION_5G = 0x05
  }

}

}
