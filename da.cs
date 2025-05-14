using System;
using System.Collections.Generic;

public class _d496c5d2567f691d5bd3670cd6c124cc_ {

 public _d496c5d2567f691d5bd3670cd6c124cc_() { init(); }

 enum T {
 	HUH = 0x00,	
	LGC = 0x01,	REX = 0x02,	E0F = 0x03,	VEX = 0x04,
	XOP = 0x05,	E38 = 0x06,	E3A = 0x07,	RVL = 0x08,
	RXB = 0x09,	WVL = 0x0a,	OP1 = 0x0b,	OP2 = 0x0c,
	O38 = 0x0d,	O3A = 0x0e, 	OV1 = 0x0f,	OV2 = 0x10,
	OV3 = 0x11,	OX8 = 0x12, 	OX9 = 0x13,	OXA = 0x14,
	MOD = 0x15,	SIB = 0x16, 	DIS = 0x17,	N3D = 0x18,
	IMM = 0x19
 }
 class a { public int m; public int r; public a(int _m, int _r) { m=_m; r=_r; } }
 Dictionary<T,a> s = new Dictionary<T,a>();
 public int t;
 public int edge;
 int add;
 int add64;
 int imm;
 int dis;

 public void init() {
  foreach (int a in Enum.GetValues(typeof(T)))
   s[(T)a] = new a ((new HashSet<int>( new int[] { (int)T.LGC, (int)T.REX, (int)T.E0F, (int)T.VEX, (int)T.XOP, (int)T.OP1 } ).Contains(a) ? 1 : 0), 0); 
  t = 0x18;
  edge = 1;
  add = 4;
  add64 = 4;
  imm = 0;
  dis = 0;
 }

 public int Digest(byte c) {

  edge = 0;

  s[T.LGC].m =
   (  ( (c>=0x64?1:0) & (c<=0x67?1:0) )
    | ( (c>=0x26?1:0) & (c<=0x3e?1:0) & ((c&7)==  6?1:0) )
    | ( (c>=0xf0?1:0) & (c<=0xf3?1:0) & ( c   !=0xf?1:0) )  )
   &(1^(  s[T.O38].r	| s[T.O3A].r	| s[T.RVL].r	| s[T.RXB].r
	| s[T.WVL].r	| s[T.OV1].r	| s[T.OV2].r	| s[T.OV3].r
	| s[T.OX8].r 	| s[T.OX9].r 	| s[T.OXA].r	| s[T.MOD].r
	| s[T.SIB].r 	| s[T.DIS].r 	| s[T.IMM].r 			));

  s[T.REX].m =
     ( (c&0xf0)==0x40?1:0 )
   &(1^(  s[T.O38].r	| s[T.O3A].r	| s[T.RVL].r	| s[T.RXB].r
	| s[T.WVL].r	| s[T.OV1].r	| s[T.OV2].r	| s[T.OV3].r
	| s[T.OX8].r 	| s[T.OX9].r 	| s[T.OXA].r	| s[T.MOD].r
	| s[T.SIB].r 	| s[T.DIS].r 	| s[T.IMM].r 			));

  s[T.OP1].m =
     1^(  ( (c <0x40?1:0) & ((c&7) >   5?1:0) )					// invalids escapes null prefixes
	| ( (c>=0x40?1:0) & ( c   <=0x4f?1:0) ) 				// rex
	| ( (c>=0x60?1:0) & ( c   <=0x67?1:0) & (c!=0x63?1:0) )			// prefixes except movsxd
	|   (c==0x82?1:0) | ( c   ==0x9a?1:0) | (c==0x9b?1:0)			// misc
	|   (c==0xc4?1:0) | ( c   ==0xc5?1:0)					// misc
	| ( (c>=0xd4?1:0) & ( c   <=0xd6?1:0) )					// misc
	| ( (c>=0xf0?1:0) & ( c   <=0xf3?1:0) & (c!=0xf1?1:0) )			// prefixes except int1
        | (t==(int)T.E0F?1:0)							// if previous type is escape 0f, won't be an op1
	| s[T.O38].r	| s[T.O3A].r	| s[T.RVL].r	| s[T.RXB].r
	| s[T.WVL].r	| s[T.OV1].r	| s[T.OV2].r	| s[T.OV3].r
	| s[T.OX8].r 	| s[T.OX9].r 	| s[T.OXA].r	| s[T.MOD].r
	| s[T.SIB].r 	| s[T.DIS].r 	| s[T.IMM].r 			 );

  s[T.E0F].m =
     ( c==0x0f?1:0 )
   &(1^(  s[T.O38].r	| s[T.O3A].r	| s[T.RVL].r	| s[T.RXB].r
	| s[T.WVL].r	| s[T.OV1].r	| s[T.OV2].r	| s[T.OV3].r
	| s[T.OX8].r 	| s[T.OX9].r 	| s[T.OXA].r	| s[T.MOD].r
	| s[T.SIB].r 	| s[T.DIS].r 	| s[T.IMM].r			));

  s[T.VEX].m =
       (  (c==0xc4?1:0) | (c==0xc5?1:0)  )
   &(1^(  s[T.O38].r	| s[T.O3A].r	| s[T.RVL].r	| s[T.RXB].r
	| s[T.WVL].r	| s[T.OV1].r	| s[T.OV2].r	| s[T.OV3].r
	| s[T.OX8].r 	| s[T.OX9].r 	| s[T.OXA].r	| s[T.MOD].r
	| s[T.SIB].r 	| s[T.DIS].r 	| s[T.IMM].r 			));

  s[T.XOP].m =
       ( c==0x8f?1:0 )
   &(1^(  s[T.O38].r	| s[T.O3A].r	| s[T.RVL].r	| s[T.RXB].r
	| s[T.WVL].r	| s[T.OV1].r	| s[T.OV2].r	| s[T.OV3].r
	| s[T.OX8].r 	| s[T.OX9].r 	| s[T.OXA].r	| s[T.MOD].r
	| s[T.SIB].r 	| s[T.DIS].r 	| s[T.IMM].r 			));

  s[T.MOD].m = s[T.MOD].r;

  s[T.E38].m = (  (t==(int)T.E0F?1:0) & (c==0x38?1:0)  );

  s[T.E3A].m = (  (t==(int)T.E0F?1:0) & (c==0x3a?1:0)  );

  s[T.RVL].m = s[T.RVL].r;

  s[T.RXB].m = s[T.RXB].r;

  s[T.SIB].m = s[T.SIB].r;

  s[T.OP2].m =
          (t==(int)T.E0F?1:0)
   &(1^(  (c==0x04?1:0) | (c==0x0a?1:0) | (c==0x0c?1:0) | (c==0x0e?1:0) | (c==0x0f?1:0)
        | ( (c>=0x24?1:0) & (c<=0x27?1:0) )
  	| (c==0x38?1:0) | (c==0x39?1:0) | (c==0x3a?1:0)
	| ( (c>=0x3b?1:0) & (c<=0x3f?1:0) )
	| (c==0x7a?1:0) | (c==0x7b?1:0)
	| (c==0xa6?1:0) | (c==0xa7?1:0)
	| (c==0xff?1:0)  ));

  s[T.OV1].m = s[T.OV1].r &(1^( s[T.WVL].r ));

  s[T.WVL].m = s[T.WVL].r &(1^( s[T.RXB].r ));

  s[T.DIS].m = s[T.DIS].r &(1^( s[T.MOD].r | s[T.SIB].r ));

  s[T.OV2].m = s[T.OV2].r &(1^( s[T.WVL].r ));

  s[T.OV3].m = s[T.OV3].r &(1^( s[T.WVL].r ));

  s[T.OX8].m = s[T.OX8].r &(1^( s[T.WVL].r ));

  s[T.OX9].m = s[T.OX9].r &(1^( s[T.WVL].r ));
 
  s[T.OXA].m = s[T.OXA].r &(1^( s[T.WVL].r ));

  s[T.IMM].m = s[T.IMM].r &(1^( s[T.MOD].r | s[T.SIB].r | s[T.DIS].r ));

  t =
     (int)T.LGC & ((1^s[T.LGC].m)-1) | (int)T.REX & ((1^s[T.REX].m)-1) | (int)T.E0F & ((1^s[T.E0F].m)-1) | (int)T.VEX & ((1^s[T.VEX].m)-1)
   | (int)T.XOP & ((1^s[T.XOP].m)-1) | (int)T.E38 & ((1^s[T.E38].m)-1) | (int)T.E3A & ((1^s[T.E3A].m)-1) | (int)T.RVL & ((1^s[T.RVL].m)-1)
   | (int)T.RXB & ((1^s[T.RXB].m)-1) | (int)T.WVL & ((1^s[T.WVL].m)-1) | (int)T.OP1 & ((1^s[T.OP1].m)-1) | (int)T.OP2 & ((1^s[T.OP2].m)-1)
   | (int)T.O38 & ((1^s[T.O38].m)-1) | (int)T.O3A & ((1^s[T.O3A].m)-1) | (int)T.OV1 & ((1^s[T.OV1].m)-1) | (int)T.OV2 & ((1^s[T.OV2].m)-1)
   | (int)T.OV3 & ((1^s[T.OV3].m)-1) | (int)T.OX8 & ((1^s[T.OX8].m)-1) | (int)T.OX9 & ((1^s[T.OX9].m)-1) | (int)T.OXA & ((1^s[T.OXA].m)-1)
   | (int)T.MOD & ((1^s[T.MOD].m)-1) | (int)T.SIB & ((1^s[T.SIB].m)-1) | (int)T.DIS & ((1^s[T.DIS].m)-1) | (int)T.N3D & ((1^s[T.N3D].m)-1)
   | (int)T.IMM & ((1^s[T.IMM].m)-1);

  /*
  Console.Write("\n\n");
  Console.Write("LGC:{0} REX:{1} E0F:{2} VEX:{3}\n", s[T.LGC].m, s[T.REX].m, s[T.E0F].m, s[T.VEX].m);
  Console.Write("XOP:{0} E38:{1} E3A:{2} RVL:{3}\n", s[T.XOP].m, s[T.E38].m, s[T.E3A].m, s[T.RVL].m);
  Console.Write("RXB:{0} WVL:{1} OP1:{2} OP2:{3}\n", s[T.RXB].m, s[T.WVL].m, s[T.OP1].m, s[T.OP2].m);
  Console.Write("O38:{0} O3A:{1} OV1:{2} OV2:{3}\n", s[T.O38].m, s[T.O3A].m, s[T.OV1].m, s[T.OV2].m);
  Console.Write("OV3:{0} OX8:{1} OX9:{2} OXA:{3}\n", s[T.OV3].m, s[T.OX8].m, s[T.OX9].m, s[T.OXA].m);
  Console.Write("MOD:{0} SIB:{1} DIS:{2} N3D:{3}\n", s[T.MOD].m, s[T.SIB].m, s[T.DIS].m, s[T.N3D].m);
  Console.Write("IMM:{0}\n", s[T.IMM].m);
  */

  s[T.MOD].r =
     (  (t==(int)T.OP1?1:0) & (c <0x40?1:0) & ((c&7)<=3?1:0)  )
   | (  (t==(int)T.OP1?1:0) & (c==0x63?1:0)  )
   | (  (t==(int)T.OP1?1:0) & (c>=0x68?1:0) & ( c   <=0x6b?1:0) & ((c&1)!=   0?1:0)  )
   | (  (t==(int)T.OP1?1:0) & (c>=0x80?1:0) & ( c   <=0x8f?1:0) * ( c   !=0x82?1:0)  )
   | (  (t==(int)T.OP1?1:0) & ( (c==0xc0?1:0) | (c==0xc1?1:0) | (c==0xc6?1:0) | (c==0xc7?1:0) )  )
   | (  (t==(int)T.OP1?1:0) & (c>=0xd0?1:0) & ( c   <=0xd3?1:0)  )
   | (  (t==(int)T.OP1?1:0) & (c>=0xd8?1:0) & ( c   <=0xdf?1:0)  )
   | (  (t==(int)T.OP1?1:0) & (c>=0xf0?1:0) & ((c&7)>=   6?1:0)  )
   | (  (t==(int)T.OP2?1:0) & (c>=0x90?1:0) & ( c   <=0x9f?1:0)  )
   | (  (t==(int)T.OP2?1:0) & ((c&0xf0)==0xa0?1:0) & ((c&7)>=3?1:0) & ((c&7)<=5?1:0)  )		// bt shld bts shrd
   | (  (t==(int)T.OP2?1:0) & ( (c==0xb6?1:0) | (c==0xb7?1:0) )  )					// movzx
   | (  (t==(int)T.OV1?1:0) & ( (c>=0x50?1:0) & (c<=0x76?1:0) & (c!=0x52?1:0) & (c!=0x53?1:0) )  )
   | (  (t==(int)T.OV1?1:0) & ( (c>=0x7c?1:0) & (c<=0x7f?1:0) )  )
   | (  (t==(int)T.OV1?1:0) & ( (c>=0xc2?1:0) & (c<=0xc7?1:0) & (c!=0xc3?1:0) )  )
   | (  (t==(int)T.OV1?1:0) & ( (c>=0xd0?1:0) & (c<=0xfe?1:0) & (c!=0xf0?1:0) )  )
   | (  (t==(int)T.OV2?1:0) & ( (c==0x00?1:0) | (c<=0x02?1:0) | (c!=0x06?1:0) | ( (c>=0x08?1:0) & (c<=0x0a?1:0) ) )  )
   | (  (t==(int)T.OV2?1:0) & (c==0x28?1:0)  )
   | (  (t==(int)T.OV2?1:0)
        & ((c&0xf0)>=0x90?1:0) & ((c&0xf0)<=0xb0?1:0)
        & ((c&0x0f)>=6?1:0) & ((c&0x0f)<=0xe?1:0) & ((c&0x0f)!=9?1:0) & ((c&0x0f)!=0xd?1:0)  );

  s[T.RVL].r =
     (  (t==(int)T.VEX?1:0) & (c==0xc5?1:0) );

  s[T.RXB].r =
     (  (t==(int)T.VEX?1:0) & (c==0xc4?1:0) )
   | (  (t==(int)T.XOP?1:0)  );

  s[T.SIB].r =
     (  (t==(int)T.MOD?1:0) & ((c&0xc0)!=0xc0?1:0) & ((c&7)==4?1:0)  );

  s[T.OV1].r =
     (  (t==(int)T.RVL?1:0)  )
   | (  (t==(int)T.RXB?1:0) & ((c&0x1f)==1?1:0)  )
   | (  s[T.OV1].r & (1^s[T.OV1].m)  );

  s[T.WVL].r = (  (t==(int)T.RXB?1:0)  );

  dis = 
     (        (1^(    (t==(int)T.MOD?1:0) & (  ( ((c&0xc0)==0?1:0) & ((c&7)==5?1:0) ) | ((c&0xc0)==0x80?1:0)  )    ))-1 & 4        )
   | (        (1^(    (t==(int)T.MOD?1:0) & ((c&0xc0)==0x40?1:0)    ))-1 & 1        )
   | (        (1^(    (t==(int)T.SIB?1:0) & ((c&7)==5?1:0) & ( ((c&0xc0)==0?1:0) | ((c&0xc0)==0x80?1:0) )    ))-1 & 4        )
   | (        (1^(    (t==(int)T.SIB?1:0) & ((c&7)==5?1:0) & ((c&0x40)==0x80?1:0)    ))-1 & 1        )
   | (        (1^(    (t==(int)T.OP1?1:0) & (c==0xa2?1:0)    ))-1 & 1        )
   | (        (1^(    (t==(int)T.OP1?1:0) & (c==0xa3?1:0)    ))-1 & 8        )
   | (        (1^(    (dis>0?1:0)    ))-1 & dis-(s[T.DIS].m>0?1:0)  );	// real weird

  s[T.DIS].r = dis>0?1:0;

  s[T.OV2].r =
     (  (t==(int)T.RXB?1:0) & ((c&0x1f)==2?1:0)  )
   | (  s[T.OV2].r & (1^s[T.OV2].m)  );

  s[T.OV3].r =
     (  (t==(int)T.RXB?1:0) & ((c&0x1f)==3?1:0)  )
   | (  s[T.OV3].r & (1^s[T.OV3].m)  );

  s[T.OX8].r =
     (  (t==(int)T.RXB?1:0) & ((c&0x1f)==8?1:0)  )
   | (  s[T.OX8].r & (1^s[T.OX8].m)  );

  s[T.OX9].r =
     (  (t==(int)T.RXB?1:0) & ((c&0x1f)==9?1:0)  )
   | (  s[T.OX9].r & (1^s[T.OX9].m)  );

  s[T.OXA].r =
     (  (t==(int)T.RXB?1:0) & ((c&0x1f)==0xa?1:0)  )
   | (  s[T.OXA].r & (1^s[T.OXA].m)  );

  imm =
     (        (1^(  (t==(int)T.OP1?1:0) & (c<0x40?1:0) & ((c&7)==4?1:0)  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c<0x40?1:0) & ((c&7)==5?1:0)  ))-1 & add        )
   | (        (1^(  (t==(int)T.OP1?1:0) & ( (c==0x68?1:0) | (c==0x69?1:0) )  ))-1 & add        )
   | (        (1^(  (t==(int)T.OP1?1:0) & ( (c==0x6a?1:0) | (c==0x6b?1:0) )  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & ( (c==0x80?1:0) | (c==0x83?1:0) )  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0x81?1:0)  ))-1 & add        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xa8?1:0)  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xa9?1:0)  ))-1 & add        )
   | (        (1^(  (t==(int)T.OP1?1:0) & ( (c>=0xb0?1:0) & (c<=0xb7?1:0) )  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & ( (c>=0xb8?1:0) & (c<=0xbf?1:0) )  ))-1 & add64        )
   | (        (1^(  (t==(int)T.OP1?1:0) & ( (c==0xc0?1:0) | (c==0xc1?1:0) )  ))-1 & 1        )  
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xc2?1:0)  ))-1 & 2        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xc6?1:0) & ((c&7)==0?1:0)  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xc7?1:0) & ((c&7)==0?1:0)  ))-1 & add        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xc8?1:0)  ))-1 & 3        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xca?1:0)  ))-1 & 2        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c==0xcd?1:0)  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & ( (c>=0xe4?1:0) & (c<=0xe7?1:0) )  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c>=0xf6?1:0) & ((c&7)<=2?1:0)  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OP1?1:0) & (c>=0xf7?1:0) & ((c&7)<=2?1:0)  ))-1 & add        )
   | (        (1^(  (t==(int)T.OV1?1:0) & (c>=0x70?1:0) & (c<=0x73?1:0)  ))-1 & 1        )
   | (        (1^(  (t==(int)T.OV1?1:0) & (c>=0xc2?1:0) & (c<=0xc6?1:0) & (c!=0xc3?1:0)  ))-1 & 1        )
   | (        ((1^(  (imm>0?1:0)  ))-1 & imm-(s[T.IMM].m>0?1:0))        );

  s[T.IMM].r = imm>0?1:0;

  edge =
     (  (t==(int)T.OP1?1:0) & (1^( s[T.MOD].r | s[T.DIS].r | s[T.IMM].r ))  )
   | (  (t==(int)T.MOD?1:0) & (1^( s[T.SIB].r | s[T.DIS].r | s[T.IMM].r ))  )
   | (  (t==(int)T.SIB?1:0) & (1^( s[T.DIS].r | s[T.IMM].r ))  )
   | (  (t==(int)T.DIS?1:0) & (1^( s[T.DIS].r | s[T.IMM].r ))  )
   | (  (t==(int)T.IMM?1:0) & (1^( s[T.IMM].r ))  );

  add =
     (  (1^edge)-1 &      4 )
   | (     (  edge -1 & add)
        >> (  (t==(int)T.LGC?1:0) & (c==0x66?1:0)  )    );

  add64 =
     (  (1^edge)-1 &      4 )
   | (     (  edge -1 & add64)
        >> (  (t==(int)T.LGC?1:0) & (c==0x66?1:0)  )
        << (  (t==(int)T.REX?1:0) & ((c&8)>0?1:0)  )    );

  return t;

 }

}