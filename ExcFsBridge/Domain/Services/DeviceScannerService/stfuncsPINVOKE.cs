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

class stfuncsPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("stfuncs", EntryPoint="SWIGRegisterExceptionCallbacks_stfuncs")]
    public static extern void SWIGRegisterExceptionCallbacks_stfuncs(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("stfuncs", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_stfuncs")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_stfuncs(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_stfuncs(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_stfuncs(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(stfuncsPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(stfuncsPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("stfuncs", EntryPoint="SWIGRegisterStringCallback_stfuncs")]
    public static extern void SWIGRegisterStringCallback_stfuncs(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_stfuncs(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static stfuncsPINVOKE() {
  }


  [DllImport("stfuncs", EntryPoint="CSharp_Get_UniqueID_P4000")]
  public static extern int Get_UniqueID_P4000(ushort jarg1, out ushort jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_Get_4000Board_Type")]
  public static extern int Get_4000Board_Type(ushort jarg1, out ushort jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_Get_4000Module_Type")]
  public static extern int Get_4000Module_Type(ushort jarg1, ushort jarg2, out ushort jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fWorkingState_set")]
  public static extern void t_ExcDevInfoPacket_fWorkingState_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fWorkingState_get")]
  public static extern uint t_ExcDevInfoPacket_fWorkingState_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fRegistryDeviceValid_set")]
  public static extern void t_ExcDevInfoPacket_fRegistryDeviceValid_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fRegistryDeviceValid_get")]
  public static extern uint t_ExcDevInfoPacket_fRegistryDeviceValid_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag3_set")]
  public static extern void t_ExcDevInfoPacket_fFlag3_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag3_get")]
  public static extern uint t_ExcDevInfoPacket_fFlag3_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag4_set")]
  public static extern void t_ExcDevInfoPacket_fFlag4_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag4_get")]
  public static extern uint t_ExcDevInfoPacket_fFlag4_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag5_set")]
  public static extern void t_ExcDevInfoPacket_fFlag5_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag5_get")]
  public static extern uint t_ExcDevInfoPacket_fFlag5_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag6_set")]
  public static extern void t_ExcDevInfoPacket_fFlag6_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_fFlag6_get")]
  public static extern uint t_ExcDevInfoPacket_fFlag6_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwBusType_set")]
  public static extern void t_ExcDevInfoPacket_dwBusType_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwBusType_get")]
  public static extern uint t_ExcDevInfoPacket_dwBusType_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwBoardType_set")]
  public static extern void t_ExcDevInfoPacket_dwBoardType_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwBoardType_get")]
  public static extern uint t_ExcDevInfoPacket_dwBoardType_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwSocketNumber_set")]
  public static extern void t_ExcDevInfoPacket_dwSocketNumber_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwSocketNumber_get")]
  public static extern uint t_ExcDevInfoPacket_dwSocketNumber_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwRegistryDevice_set")]
  public static extern void t_ExcDevInfoPacket_dwRegistryDevice_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwRegistryDevice_get")]
  public static extern uint t_ExcDevInfoPacket_dwRegistryDevice_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword5_set")]
  public static extern void t_ExcDevInfoPacket_dwDword5_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword5_get")]
  public static extern uint t_ExcDevInfoPacket_dwDword5_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword6_set")]
  public static extern void t_ExcDevInfoPacket_dwDword6_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword6_get")]
  public static extern uint t_ExcDevInfoPacket_dwDword6_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword7_set")]
  public static extern void t_ExcDevInfoPacket_dwDword7_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword7_get")]
  public static extern uint t_ExcDevInfoPacket_dwDword7_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword8_set")]
  public static extern void t_ExcDevInfoPacket_dwDword8_set(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_t_ExcDevInfoPacket_dwDword8_get")]
  public static extern uint t_ExcDevInfoPacket_dwDword8_get(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_new_t_ExcDevInfoPacket")]
  public static extern IntPtr new_t_ExcDevInfoPacket();

  [DllImport("stfuncs", EntryPoint="CSharp_delete_t_ExcDevInfoPacket")]
  public static extern void delete_t_ExcDevInfoPacket(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_Clear")]
  public static extern void vecinfo_Clear(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_Add")]
  public static extern void vecinfo_Add(HandleRef jarg1, HandleRef jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_size")]
  public static extern uint vecinfo_size(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_capacity")]
  public static extern uint vecinfo_capacity(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_reserve")]
  public static extern void vecinfo_reserve(HandleRef jarg1, uint jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_new_vecinfo__SWIG_0")]
  public static extern IntPtr new_vecinfo__SWIG_0();

  [DllImport("stfuncs", EntryPoint="CSharp_new_vecinfo__SWIG_1")]
  public static extern IntPtr new_vecinfo__SWIG_1(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_new_vecinfo__SWIG_2")]
  public static extern IntPtr new_vecinfo__SWIG_2(int jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_getitemcopy")]
  public static extern IntPtr vecinfo_getitemcopy(HandleRef jarg1, int jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_getitem")]
  public static extern IntPtr vecinfo_getitem(HandleRef jarg1, int jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_setitem")]
  public static extern void vecinfo_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_AddRange")]
  public static extern void vecinfo_AddRange(HandleRef jarg1, HandleRef jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_GetRange")]
  public static extern IntPtr vecinfo_GetRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_Insert")]
  public static extern void vecinfo_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_InsertRange")]
  public static extern void vecinfo_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_RemoveAt")]
  public static extern void vecinfo_RemoveAt(HandleRef jarg1, int jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_RemoveRange")]
  public static extern void vecinfo_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_Repeat")]
  public static extern IntPtr vecinfo_Repeat(HandleRef jarg1, int jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_Reverse__SWIG_0")]
  public static extern void vecinfo_Reverse__SWIG_0(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_Reverse__SWIG_1")]
  public static extern void vecinfo_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_vecinfo_SetRange")]
  public static extern void vecinfo_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_delete_vecinfo")]
  public static extern void delete_vecinfo(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_Init_Module_Px")]
  public static extern int Init_Module_Px(ushort jarg1, ushort jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_Attach_Module_Px")]
  public static extern int Attach_Module_Px(ushort jarg1, ushort jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_Init_Module_RTx")]
  public static extern int Init_Module_RTx(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4);

  [DllImport("stfuncs", EntryPoint="CSharp_Release_Module_Px")]
  public static extern int Release_Module_Px(int jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_Release_Module_RTx")]
  public static extern int Release_Module_RTx(int jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_GetDevInfos")]
  public static extern int GetDevInfos(HandleRef jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_BYTE_RTx")]
  public static extern int Exc_Peek_BYTE_RTx(int jarg1, ushort jarg2, out byte jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_WORD_RTx")]
  public static extern int Exc_Peek_WORD_RTx(int jarg1, ushort jarg2, out ushort jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_DWORD_RTx")]
  public static extern int Exc_Peek_DWORD_RTx(int jarg1, ushort jarg2, out uint jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_Word_Buffer_RTx")]
  public static extern int Exc_Peek_Word_Buffer_RTx(int jarg1, ushort jarg2, out byte jarg3, ushort jarg4);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_Px")]
  public static extern int Exc_Peek_Px(int jarg1, ushort jarg2, out ushort jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_WORD_Px")]
  public static extern int Exc_Peek_WORD_Px(int jarg1, ushort jarg2, out ushort jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_BYTE_Px")]
  public static extern int Exc_Peek_BYTE_Px(int jarg1, ushort jarg2, out byte jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_32Bit_Px")]
  public static extern int Exc_Peek_32Bit_Px(int jarg1, ushort jarg2, out uint jarg3);

  [DllImport("stfuncs", EntryPoint="CSharp_Exc_Peek_Word_Buffer_Px")]
  public static extern int Exc_Peek_Word_Buffer_Px(int jarg1, ushort jarg2, out byte jarg3, ushort jarg4);

  [DllImport("stfuncs", EntryPoint="CSharp_Read_Revision_RTx")]
  public static extern int Read_Revision_RTx(int jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_Read_HwRevision_RTx")]
  public static extern int Read_HwRevision_RTx(int jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_Get_Rev_Level_Px")]
  public static extern int Get_Rev_Level_Px(int jarg1);

  [DllImport("stfuncs", EntryPoint="CSharp_Get_HWRev_DISCR")]
  public static extern int Get_HWRev_DISCR(int jarg1, out ushort jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_Init_Module_DISCR")]
  public static extern int Init_Module_DISCR(int jarg1, int jarg2);

  [DllImport("stfuncs", EntryPoint="CSharp_Get_4000Interface_Rev")]
  public static extern int Get_4000Interface_Rev(ushort jarg1, out ushort jarg2);
}

}
