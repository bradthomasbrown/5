using System.Runtime.InteropServices;

class _212a3cbcd7bb3b0147570e48665a1ee7_ {

 [DllImport("kernel32.dll", EntryPoint="VirtualAlloc"       )] static extern ulong a
  (ulong a=0, ulong s=0, ulong d=0, ulong f=0 );

 [DllImport("kernel32.dll", EntryPoint="VirtualFree"        )] static extern ulong s
  (ulong a=0, ulong s=0, ulong d=0            );

 [DllImport("ntdll.dll"   , EntryPoint="NtQueueApcThreadEx2")] static extern ulong d
  (ulong a=0, ulong s=0, ulong d=0, ulong f=0,
   ulong z=0, ulong x=0, ulong c=0            );

 unsafe public static byte[] RDRAND128() {
  byte[] f = new byte[0x10];
  ulong z = a(0,0x10000,0x3000,0x40);
  *(ulong*) z    = 0x48018948f0c70f48;
  *(ulong*)(z+8) = 0xc308418948f0c70f;
  fixed (byte* x = f) unchecked { d((ulong)-2,0,1,z,(ulong)x); }
  s(z,0x10000,0x8000);
  return f;
 }

}