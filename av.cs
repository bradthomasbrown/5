// could be "algorithms"
class _791400f31a7e37a2a6f91246d2b4a9bd_ {

 // could be "align(value,alignment)"
 public static ulong _6bf6a89cbe4e9246643cece419fbb1ac_(ulong a, ulong s) {
  ulong d = s-1;
  ulong f = (a&d)==0?1UL:0UL;
  return (1^f)-1&a|f-1&((a&~d)+s);
 }

}

