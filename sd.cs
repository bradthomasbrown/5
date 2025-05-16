using System.Runtime.InteropServices;

partial class Ntdll {

 // should be same as unchecked { (uint)-2 }
 public const uint CurrentThread = uint.MaxValue - 1;

 public enum ApcFlags {
  QUEUE_USER_APC_FLAGS_NONE                  = 0x00000000,
  QUEUE_USER_APC_FLAGS_SPECIAL_USER_APC      = 0x00000001,
  QUEUE_USER_APC_FLAGS_CALLBACK_DATA_CONTEXT = 0x00010000
 }

 public static ulong NtQueueApcThreadEx2(
  uint     thread        = CurrentThread                                 ,
  uint     reserveHandle = 0                                             ,
  ApcFlags apcFlags      = ApcFlags.QUEUE_USER_APC_FLAGS_SPECIAL_USER_APC,
  ulong    apcRoutine    = 0                                             ,
  ulong    arg0          = 0                                             ,
  ulong    arg1          = 0                                             ,
  ulong    arg2          = 0                                   
 ) {
  return _NtQueueApcThreadEx2(thread, reserveHandle, apcFlags, apcRoutine, arg0, arg1, arg2);
 }

 [DllImport("ntdll.dll", EntryPoint="NtQueueApcThreadEx2")] static extern ulong _NtQueueApcThreadEx2(
  uint     thread       ,
  uint     reserveHandle,
  ApcFlags apcFlags     ,
  ulong    apcRoutine   ,
  ulong    arg0         ,
  ulong    arg1         ,
  ulong    arg2         
 );
 
}