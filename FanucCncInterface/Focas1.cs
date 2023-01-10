using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FanucCncInterface
{
    public class Focas1
    {
        public const short MAX_AXIS = 8;
        public const short ALL_AXES = -1;
        public const short ALL_SPINDLES = -1;
        public const short EW_OK = 0;

        /*berk*/

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpdf_alldir(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.AsAny), In] object b, [MarshalAs(UnmanagedType.AsAny), Out] object c);

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBPDFADIR
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 212)]
            public string path = new string(' ', 212);
            public short req_num;
            public short size_kind;
            public short type;
            public short dummy;
        }

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpdf_drive(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPDFADIR
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string d_f = new string(' ', 36);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string comment = new string(' ', 52);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string o_time = new string(' ', 12);
            public short data_kind;
            public short year;
            public short mon;
            public short day;
            public short hour;
            public short min;
            public short sec;
            public short dummy;
            public int dummy2;
            public int size;
            public int attr;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPDFDRV
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive1 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive2 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive3 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive4 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive5 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive6 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive7 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive8 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive9 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive10 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive11 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive12 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive13 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive14 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive15 = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string drive16 = new string(' ', 12);
            public short max_num;
            public short dummy;
        }

        /*berk*/

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_actf(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBACT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_absolute(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_machine(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_relative(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_distance(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_skip(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srvdelay(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_accdecdly(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddynamic(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDY_1 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddynamic(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDY_2 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddynamic2(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDY2_1 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddynamic2(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDY2_2 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_acts(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBACT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_acts2(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBACT2 a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrrelpos(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBWRR b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_prstwkcd(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBWRA b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmovrlap(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBOVL c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_canmovrlap(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspload(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPN b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspmaxrpm(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPN b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspgear(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPN b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_absolute2(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_relative2(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_setvrtclpos(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_setthrdngpos(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdposition(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPOS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspeed(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPEED b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsvmeter(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSVLOAD b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspmeter(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPLOAD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdhndintrpt(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBHND c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspcss(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBCSS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dwnstart(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_download(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_cdownload(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dwnend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dwnend2(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dwnstart3(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dwnstart3_f(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b, [MarshalAs(UnmanagedType.AsAny), In] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_download3(ushort FlibHndl, ref int a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dwnend3(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_vrfstart(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_verify(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_cverify(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_vrfend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dncstart(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dnc(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, ushort b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_cdnc(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, ushort b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dncend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dncstart2(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dnc2(ushort FlibHndl, ref int a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dncend2(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddncdgndt(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDNCDGN a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_upstart(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_upload(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBUP a, ref ushort b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_cupload(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBUP a, ref ushort b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_upend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_upstart3(ushort FlibHndl, short a, int b, int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_upstart3_f(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b, [MarshalAs(UnmanagedType.AsAny), In] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_upload3(ushort FlibHndl, ref int a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_upend3(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_buff(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBBUF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_search(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_search2(ushort FlibHndl, int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_delall(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_delete(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdprogdir(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          ushort d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.PRGDIR e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdproginfo(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBNC_1 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdproginfo(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBNC_2 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdprgnum(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPRO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdseqnum(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSEQ a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_seqsrch(ushort FlibHndl, int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rewind(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdblkcount(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdexecprog(
          ushort FlibHndl,
          ref ushort a,
          out short b,
          [MarshalAs(UnmanagedType.AsAny), Out] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmdiprog(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmdiprog(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmdipntr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMDIP a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmdipntr(ushort FlibHndl, int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_newprog(ushort FlibHndl, int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_copyprog(ushort FlibHndl, int a, int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_renameprog(ushort FlibHndl, int a, int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_condense(ushort FlibHndl, short a, int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdactpt(ushort FlibHndl, out int a, out int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rduvactpt(ushort FlibHndl, out int a, out int b, out int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wractpt(ushort FlibHndl, int a, short b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdprogline(
          ushort FlibHndl,
          int a,
          uint b,
          [MarshalAs(UnmanagedType.AsAny), Out] object c,
          ref uint d,
          ref uint e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrprogline(ushort FlibHndl, int a, uint b, [MarshalAs(UnmanagedType.AsAny), In] object c, uint d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_delprogline(ushort FlibHndl, int a, uint b, uint c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_searchword(
          ushort FlibHndl,
          int a,
          uint b,
          short c,
          short d,
          uint e,
          [MarshalAs(UnmanagedType.AsAny), In] object f);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_searchresult(ushort FlibHndl, out uint a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_setpglock(ushort FlibHndl, int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_resetpglock(ushort FlibHndl, int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpglockstat(ushort FlibHndl, out int a, out int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtofs(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTOFS d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtofs(ushort FlibHndl, short a, short b, short c, int d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtofsr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTO_1_1 e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtofsr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTO_1_2 e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtofsr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTO_1_3 e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtofsr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTO_2 e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtofsr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTO_3 e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtofsr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTO_1_1 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtofsr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTO_1_2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtofsr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTO_1_3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtofsr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTO_2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtofsr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTO_3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdzofs(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBZOFS d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrzofs(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBZOFS b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdzofsr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBZOR e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrzofsr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBZOR b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmsptype(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBMSTP d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmsptype(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBMSTP d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparam(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_1 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparam(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_2 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparam(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_3 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparam(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_4 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrparam(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_1 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrparam(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrparam(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrparam(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_4 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparar(
          ushort FlibHndl,
          ref short a,
          short b,
          ref short c,
          ref short d,
          [MarshalAs(UnmanagedType.AsAny), Out] object e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrparas(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdset(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_1 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdset(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_2 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdset(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_3 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdset(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSD_4 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrset(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_1 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrset(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrset(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrset(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSD_4 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsetr(
          ushort FlibHndl,
          ref short a,
          short b,
          ref short c,
          ref short d,
          [MarshalAs(UnmanagedType.AsAny), Out] object e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrsets(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparam_ext(
          ushort FlibHndl,
          [MarshalAs(UnmanagedType.LPStruct), In, Out] Focas1.IODBPRMNO a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPRM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_start_async_wrparam(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_end_async_wrparam(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_async_busy_state(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddiag_ext(
          ushort FlibHndl,
          [MarshalAs(UnmanagedType.LPStruct), In, Out] Focas1.IODBPRMNO a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPRM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpitchr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPI d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrpitchr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPI b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmacro(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmacro(ushort FlibHndl, short a, short b, int c, short d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmacror(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBMR d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmacror(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBMR b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpmacro(ushort FlibHndl, int a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPM b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrpmacro(ushort FlibHndl, int a, int b, short c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpmacror(
          ushort FlibHndl,
          int a,
          int b,
          ushort c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPR d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrpmacror(ushort FlibHndl, ushort a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPR b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtofsinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLINF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdzofsinfo(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpitchinfo(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmacroinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMVINF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpmacroinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPMINF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgrpid(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE1 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdngrp(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE2 a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdntool(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlife(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcount(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd1length(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd2length(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd1radius(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd2radius(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_t1info(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_t2info(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_toolnum(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtoolrng(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTR d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtoolgrp(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTG c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrcountr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBWRC b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdusegrpid(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBUSEGR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmaxgrp(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBLFNO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmaxtool(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBLFNO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdusetlno(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLUSE d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd1tlifedata(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd2tlifedata(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wr1tlifedata(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTD a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wr2tlifedata(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTD a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgrpinfo(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTGI d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgrpinfo2(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTGI2 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgrpinfo3(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTGI3 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrgrpinfo(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTGI b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrgrpinfo2(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTGI2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrgrpinfo3(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTGI3 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_deltlifegrp(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_instlifedt(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBITD a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_deltlifedt(ushort FlibHndl, short a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clrcntinfo(ushort FlibHndl, short a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgrpid2(ushort FlibHndl, int a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLIFE5 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd1tlifedat2(ushort FlibHndl, short a, int b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTD2 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wr1tlifedat2(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTD2 a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtlinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBTLINFO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtlusegrp(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBUSEGRP a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtlgrp(
          ushort FlibHndl,
          int a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLGRP c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtltool(
          ushort FlibHndl,
          int a,
          int b,
          ref short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLTOOL d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_regtool(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTLMNG c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_deltool(ushort FlibHndl, short a, ref short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtool(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLMNG c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtool(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTLMNG b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtool2(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBTLM b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_regmagazine(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTLMAG b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_delmagazine(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTLMAG2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmagazine(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLMAG b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmagazine(ushort FlibHndl, short a, short b, short c);

        [DllImport("FWLIB32.dll", EntryPoint = "cnc_stop is")]
        public static extern short cnc_stopophis(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startophis(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdophisno(ushort FlibHndl, out ushort a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdophistry(
          ushort FlibHndl,
          ushort a,
          ushort b,
          ushort c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBHIS d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdophistry2(
          ushort FlibHndl,
          ushort a,
          ref ushort b,
          ref ushort c,
          [MarshalAs(UnmanagedType.AsAny), Out] object d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdalmhisno(ushort FlibHndl, out ushort a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdalmhistry(
          ushort FlibHndl,
          ushort a,
          ushort b,
          ushort c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAHIS d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdalmhistry_w(
          ushort FlibHndl,
          ushort a,
          ushort b,
          ushort c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAHIS d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdalmhistry2(
          ushort FlibHndl,
          ushort a,
          ushort b,
          ushort c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAHIS2 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clearophis(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdhissgnl(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSIG a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrhissgnl(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSIG a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sysinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSYS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_statinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBST a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_alarm(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBALM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_alarm2(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdalminfo(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ALMINFO_1 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdalminfo(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ALMINFO_2 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdalmmsg(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBALMMSG c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clralm(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_modal(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMDL_1 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_modal(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMDL_2 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_modal(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMDL_3 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_modal(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMDL_4 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_modal(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMDL_5 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgcode(
          ushort FlibHndl,
          short a,
          short b,
          ref short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBGCD d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcommand(
          ushort FlibHndl,
          short a,
          short b,
          ref short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBCMD d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_diagnoss(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDGN_1 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_diagnoss(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDGN_2 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_diagnoss(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDGN_3 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_diagnoss(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDGN_4 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_diagnosr(
          ushort FlibHndl,
          ref short a,
          short b,
          ref short c,
          ref short d,
          [MarshalAs(UnmanagedType.AsAny), Out] object e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_adcnv(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdopmsg(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.OPMSG c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdopmsg2(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.OPMSG2 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdopmsg3(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.OPMSG3 c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_setpath(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getpath(ushort FlibHndl, out short a, out short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_allclibhndl(out ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_freelibhndl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getmactype(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_setmactype(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getpmactype(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_setpmactype(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getcrntscrn(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_slctscrn(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sysconfig(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSYSC a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdprstrinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPRS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rstrseqsrch(ushort FlibHndl, int a, int b, short c, short d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rstrseqsrch2(
          ushort FlibHndl,
          int a,
          int b,
          short c,
          short d,
          int e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdopnlsgnl(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSGNL b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wropnlsgnl(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSGNL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdopnlgnrl(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBGNRL b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wropnlgnrl(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBGNRL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdopnlgsname(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBRDNA b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wropnlgsname(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBRDNA a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getdtailerr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBERR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparainfo(
          ushort FlibHndl,
          short a,
          ushort b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPARAIF c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsetinfo(
          ushort FlibHndl,
          short a,
          ushort b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSETIF c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddiaginfo(
          ushort FlibHndl,
          short a,
          ushort b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDIAGIF c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdparanum(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPARANUM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsetnum(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSETNUM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddiagnum(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDIAGNUM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getfigure(
          ushort FlibHndl,
          short a,
          out short b,
          [MarshalAs(UnmanagedType.AsAny), Out] object c,
          [MarshalAs(UnmanagedType.AsAny), Out] object d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdfrominfo(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBFINFO b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromsvstart(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b, int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromsave(ushort FlibHndl, out short a, [MarshalAs(UnmanagedType.AsAny), Out] object b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromsvend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromldstart(ushort FlibHndl, short a, int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromload(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, ref int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromldend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromdelete(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b, int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsraminfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSINFO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srambkstart(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srambackup(ushort FlibHndl, out short a, [MarshalAs(UnmanagedType.AsAny), Out] object b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srambkend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getfrominfo(
          ushort FlibHndl,
          short a,
          out short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBFINFORM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromgetstart(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromget(ushort FlibHndl, out short a, [MarshalAs(UnmanagedType.AsAny), Out] object b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromgetend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromputstart(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromput(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, ref int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromputend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_fromremove(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getsraminfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSINFO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sramgetstart(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sramgetstart2(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sramget(ushort FlibHndl, out short a, [MarshalAs(UnmanagedType.AsAny), Out] object b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sramget2(ushort FlibHndl, out short a, [MarshalAs(UnmanagedType.AsAny), Out] object b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sramgetend(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sramgetend2(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsramnum(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsramaddr(ushort FlibHndl, out short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.SRAMADDR b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getlockstat(ushort FlibHndl, short a, out byte b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_chgprotbit(ushort FlibHndl, short a, ref byte b, int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvftpget(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvftpput(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvftpstat(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvrdpgdir(
          ushort FlibHndl,
          [MarshalAs(UnmanagedType.AsAny), In] object a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDSDIR c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvdelete(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvdownload(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvupload(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvcnclupdn(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvupdnstat(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvgetdncpg(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvsetdncpg(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvrdset(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBDSSET a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvwrset(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBDSSET a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvchkdsk(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvhdformat(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvsavecram(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvrdcram(ushort FlibHndl, int a, ref int b, [MarshalAs(UnmanagedType.AsAny), Out] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvmntinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDSMNT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvgetmode(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvsetmode(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvrderrmsg(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvwrfile(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, [MarshalAs(UnmanagedType.AsAny), In] object b, short c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dtsvrdfile(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, [MarshalAs(UnmanagedType.AsAny), In] object b, short c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdloopgain(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcurrent(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsrvspeed(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdopmode(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdposerrs(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdposerrs2(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPSER a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdposerrz(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsynerrsy(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsynerrrg(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspdlalm(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdctrldi(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPDI a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdctrldo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPDO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdnspdl(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdfbusmem(
          ushort FlibHndl,
          short a,
          short b,
          int c,
          int d,
          [MarshalAs(UnmanagedType.AsAny), Out] object e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrfbusmem(
          ushort FlibHndl,
          short a,
          short b,
          int c,
          int d,
          [MarshalAs(UnmanagedType.AsAny), In] object e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdwaveprm(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBWAVE a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrwaveprm(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBWAVE a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdwaveprm2(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBWVPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrwaveprm2(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBWVPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wavestart(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wavestop(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wavestat(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdwavedata(
          ushort FlibHndl,
          short a,
          short b,
          int c,
          ref int d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBWVDT e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdrmtwaveprm(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBRMTPRM a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrrmtwaveprm(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBRMTPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rmtwavestart(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rmtwavestop(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rmtwavestat(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdrmtwavedt(
          ushort FlibHndl,
          short a,
          int b,
          ref int c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBRMTDT d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsavsigadr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSIGAD a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrsavsigadr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSIGAD a, out short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsavsigdata(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.AsAny), Out] object c,
          ref short d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmgrpdata(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMGRP c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmgrpdata(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBMGRP a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdexecmcode(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBEXEM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdrstrmcode(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBRSTRM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdproctime(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPTIME a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdprgdirtime(
          ushort FlibHndl,
          ref int a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.PRGDIRTM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdprogdir2(
          ushort FlibHndl,
          short a,
          ref short b,
          ref short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.PRGDIR2 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdprogdir3(
          ushort FlibHndl,
          short a,
          ref int b,
          ref short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.PRGDIR3 d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddncfname(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrdncfname(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcomparam(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBCPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrcomparam(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBCPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcomlogmsg(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcomopemsg(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdrcvmsg(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsndmsg(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sendmessage(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clrmsgbuff(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdrcvstat(ushort FlibHndl, out ushort a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdintchk(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBINT e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrintchk(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBINT b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdintinfo(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdwkcdshft(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBWCSF c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrwkcdshft(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBWCSF b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdwkcdsfms(
          ushort FlibHndl,
          short a,
          short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBWCSF c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrwkcdsfms(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBWCSF b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_stopomhis(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startomhis(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdomhisinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBOMIF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdomhistry(
          ushort FlibHndl,
          ushort a,
          ref ushort b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBOMHIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clearomhis(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdbtofsr(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBBTO e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrbtofsr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBBTO b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdbtofsinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBBTLINF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdbaxis(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBBAXIS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsyssoft(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSYSS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsyssoft2(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSYSS2 a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmdlconfig(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMDLC a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmdlconfig2(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpscdproc(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPSCD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrpscdproc(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPSCD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpscdpirc(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPIRC c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrpscdpirc(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPIRC c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpscdedge(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBEDGE c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrpscdedge(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBEDGE c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpscdslop(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSLOP c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrpscdslop(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSLOP c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlpwrdty(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBLPWDT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrlpwrdty(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBLPWDT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlpwrdat(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBLOPDT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlpwrcpst(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrlpwrcpst(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlagslt(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBLAGSL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrlagslt(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBLAGSL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlagst(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBLAGST a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrlagst(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBLAGST a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdledgprc(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBLEGPR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrledgprc(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBLEGPR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlprcprc(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBLPCPR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrlprcprc(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBLPCPR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlcmddat(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBLCMDT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdldsplc(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrldsplc(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlerrz(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlactnum(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBLACTN a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlcmmt(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBLCMMT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlpwrslt(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrlpwrslt(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlpwrctrl(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrlpwrctrl(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdpwofsthis(
          ushort FlibHndl,
          int a,
          ref int b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPWOFST c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmngtime(
          ushort FlibHndl,
          int a,
          ref int b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBMNGTIME c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmngtime(ushort FlibHndl, int a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBMNGTIME b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddischarge(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDISCHRG a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddischrgalm(
          ushort FlibHndl,
          int a,
          ref int b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBDISCHRGALM c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_gettimer(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTIMER a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_settimer(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTIMER a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtimer(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTIME b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtimer(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTIME b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtlctldata(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLCTL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtlctldata(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTLCTL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtooldata(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLDT c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtooldata(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLDT c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmultitldt(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBMLTTL c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmultitldt(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBMLTTL c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmtapdata(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBMTAP c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmtapdata(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBMTAP c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmultipieceno(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtoolinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPTLINF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsafetyzone(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSAFE c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrsafetyzone(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSAFE c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdtoolzone(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBTLZN c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrtoolzone(
          ushort FlibHndl,
          short a,
          ref short b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBTLZN c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdacttlzone(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBACTTLZN a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdsetzone(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrsetzone(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdbrstrinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBBRS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmenuswitch(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrmenuswitch(ushort FlibHndl, short a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdradofs(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBROFS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdlenofs(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBLOFS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdfixcycle(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBFIX a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcdrotate(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBROT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd3dcdcnv(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODB3DCD a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdmirimage(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBMIR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdscaling(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSCL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd3dtofs(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODB3DTO a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdposofs(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPOFS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdhpccset(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBHPST a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrhpccset(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBHPST a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_hpccatset(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdhpcctupr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBHPPR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrhpcctupr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBHPPR a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdhpcctuac(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBHPAC a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrhpcctuac(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBHPAC a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_hpccattune(ushort FlibHndl, short a, out short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_hpccactfine(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_hpccselfine(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdactfixofs(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBZOFS b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdfixofs(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          short d,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBZOR e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrfixofs(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBZOR b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd3dtooltip(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODB3DHDL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd3dpulse(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODB3DPLS a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd3dmovrlap(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODB3DHDL a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rd3dofschg(ushort FlibHndl, ref int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clr3dplsmov(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_start(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_reset(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdaxisname(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXISNAME b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdspdlname(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSPDLNAME b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcexesram(ushort FlibHndl, int a, [MarshalAs(UnmanagedType.AsAny), Out] object b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrcexesram(ushort FlibHndl, int a, [MarshalAs(UnmanagedType.AsAny), In] object b, ref int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_cexesraminfo(
          ushort FlibHndl,
          out short a,
          out int b,
          out int c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_cexesramsize(ushort FlibHndl, out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcoordnum(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_ftosjis(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrunsolicprm(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBUNSOLIC b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdunsolicprm(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBUNSOLIC b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_unsolicstart(
          ushort FlibHndl,
          short a,
          int hWnd,
          uint c,
          short d,
          out short e);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_unsolicstop(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdunsolicmsg(short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IDBUNSOLICMSG b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_dispoptmsg(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_optmsgans(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getcncmodel(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_progdigit(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsrsvchnl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsrdidinfo(
          ushort FlibHndl,
          int a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.AsAny), Out] Focas1.IODBIDINF d);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcswridinfo(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBIDINF a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsstartrd(ushort FlibHndl, int a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsstartwrt(ushort FlibHndl, int a, short b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsstopexec(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsrdexstat(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSRCSST a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsrdopdata(ushort FlibHndl, int a, ref int b, [MarshalAs(UnmanagedType.AsAny), Out] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcswropdata(ushort FlibHndl, int a, int b, [MarshalAs(UnmanagedType.AsAny), In] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsfreechnl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsrdlayout(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSRCSLYT a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_srcsrddrvcp(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startdrawpos(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_stopdrawpos(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startdyngrph(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_stopdyngrph(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgrphcmd(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrgrphcmdptr(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdgrphcanflg(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clrgrphcmd(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_svdtstartrd(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_svdtstartwr(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_svdtendrd(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_svdtendwr(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_svdtstopexec(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_svdtrddata(ushort FlibHndl, out short a, ref int b, [MarshalAs(UnmanagedType.AsAny), Out] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_svdtwrdata(ushort FlibHndl, out short a, ref int b, [MarshalAs(UnmanagedType.AsAny), In] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sdsetchnl(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBCHAN b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sdclrchnl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sdstartsmpl(ushort FlibHndl, short a, int b, [MarshalAs(UnmanagedType.AsAny), Out] object c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sdcancelsmpl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sdreadsmpl(ushort FlibHndl, out short a, int b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sdendsmpl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sdread1shot(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sfbsetchnl(
          ushort FlibHndl,
          short a,
          int b,
          [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IDBSFBCHAN c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sfbclrchnl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sfbstartsmpl(ushort FlibHndl, short a, int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sfbcancelsmpl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sfbreadsmpl(
          ushort FlibHndl,
          out short a,
          int b,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSD c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_sfbendsmpl(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startnccmd(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startnccmd2(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_stopnccmd(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getdspmode(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startrmtdgn(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_stoprmtdgn(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdrmtdgn(ushort FlibHndl, out int a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrrmtdgn(ushort FlibHndl, ref int a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrcommstatus(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_chkrmtdgn(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_allowance(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_allowcnd(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBCAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_workzero(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBZOFS b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_slide(ushort FlibHndl, short a, short b, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBAXIS c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_startgetdgdat(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_stopgetdgdat(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rddgdat(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrdgdatptr(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_clrdgdat(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_opencexefile(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, short b, short c);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_closecexefile(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdcexefile(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), Out] object a, ref uint b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_wrcexefile(ushort FlibHndl, [MarshalAs(UnmanagedType.AsAny), In] object a, ref uint b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_cexedirectory(
          ushort FlibHndl,
          [MarshalAs(UnmanagedType.AsAny), In] object a,
          ref ushort b,
          ushort c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.CFILEINFO d);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdmsg(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrmsg(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_crdmsg(ushort FlibHndl, ref short a, [MarshalAs(UnmanagedType.AsAny), Out] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_cwrmsg(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.AsAny), In] object b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdpmcrng(
          ushort FlibHndl,
          short a,
          short b,
          ushort c,
          ushort d,
          ushort e,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPMC f);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrpmcrng(ushort FlibHndl, ushort a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPMC b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdkpm(ushort FlibHndl, uint a, [MarshalAs(UnmanagedType.AsAny), Out] object b, ushort c);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrkpm(ushort FlibHndl, uint a, [MarshalAs(UnmanagedType.AsAny), In] object b, ushort c);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdkpm2(ushort FlibHndl, uint a, [MarshalAs(UnmanagedType.AsAny), Out] object b, uint c);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrkpm2(ushort FlibHndl, uint a, [MarshalAs(UnmanagedType.AsAny), In] object b, uint c);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_kpmsiz(ushort FlibHndl, out uint a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdpmcinfo(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPMCINF b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdcntldata(
          ushort FlibHndl,
          short a,
          short b,
          short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPMCCNTL d);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrcntldata(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPMCCNTL b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdcntlgrp(ushort FlibHndl, out short a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrcntlgrp(ushort FlibHndl, short a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdalmmsg(
          ushort FlibHndl,
          short a,
          ref short b,
          out short c,
          [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPMCALM d);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_getdtailerr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPMCERR a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdpmcmem(ushort FlibHndl, short a, int b, int c, [MarshalAs(UnmanagedType.AsAny), Out] object d);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrpmcmem(ushort FlibHndl, short a, int b, int c, [MarshalAs(UnmanagedType.AsAny), In] object d);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdpmcsemem(ushort FlibHndl, short a, int b, int c, [MarshalAs(UnmanagedType.AsAny), Out] object d);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_wrpmcsemem(ushort FlibHndl, short a, int b, int c, [MarshalAs(UnmanagedType.AsAny), In] object d);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdpmctitle(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPMCTITLE a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_rdpmcaddr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPMCADR a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfrdconfig(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBPRFCNF a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfrdbusprm(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBBUSPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfwrbusprm(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBBUSPRM a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfrdslvprm(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSLVPRM b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfrdslvprm(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSLVPRM2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfwrslvprm(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSLVPRM b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfwrslvprm(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSLVPRM2 b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfrdallcadr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBPRFADR b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfwrallcadr(ushort FlibHndl, short a, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBPRFADR b);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfrdslvaddr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.IODBSLVADR a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfwrslvaddr(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), In] Focas1.IODBSLVADR a);

        [DllImport("FWLIB32.dll")]
        public static extern short pmc_prfrdslvstat(ushort FlibHndl, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBSLVST a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdnodenum(out int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdnodeinfo(int a, [MarshalAs(UnmanagedType.LPStruct), Out] Focas1.ODBNODE b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_setdefnode(int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_allclibhndl2(int node, out ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_allclibhndl3(
          [MarshalAs(UnmanagedType.AsAny), In] object ip,
          ushort port,
          int timeout,
          out ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_allclibhndl4(
          [MarshalAs(UnmanagedType.AsAny), In] object ip,
          ushort port,
          int timeout,
          uint id,
          out ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_settimeout(ushort FlibHndl, int a);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_resetconnect(ushort FlibHndl);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_getfocas1opt(ushort FlibHndl, short a, out int b);

        [DllImport("FWLIB32.dll")]
        public static extern short cnc_rdetherinfo(ushort FlibHndl, out short a, out short b);

        public enum focas_ret
        {
            DNC_CANCEL = -32768, // 0xFFFF8000
            DNC_READERR = -517, // 0xFFFFFDFB
            DNC_NOFILE = -516, // 0xFFFFFDFC
            DNC_OPENERR = -514, // 0xFFFFFDFE
            EW_PROTOCOL = -17, // 0xFFFFFFEF
            EW_SOCKET = -16, // 0xFFFFFFF0
            EW_NODLL = -15, // 0xFFFFFFF1
            EW_BUS = -11, // 0xFFFFFFF5
            EW_SYSTEM2 = -10, // 0xFFFFFFF6
            EW_HSSB = -9, // 0xFFFFFFF7
            EW_HANDLE = -8, // 0xFFFFFFF8
            EW_VERSION = -7, // 0xFFFFFFF9
            EW_UNEXP = -6, // 0xFFFFFFFA
            EW_SYSTEM = -5, // 0xFFFFFFFB
            EW_PARITY = -4, // 0xFFFFFFFC
            EW_MMCSYS = -3, // 0xFFFFFFFD
            EW_RESET = -2, // 0xFFFFFFFE
            DNC_NORMAL = -1, // 0xFFFFFFFF
            EW_BUSY = -1, // 0xFFFFFFFF
            EW_OK = 0,
            EW_FUNC = 1,
            EW_NOPMC = 1,
            EW_LENGTH = 2,
            EW_NUMBER = 3,
            EW_RANGE = 3,
            EW_ATTRIB = 4,
            EW_TYPE = 4,
            EW_DATA = 5,
            EW_NOOPT = 6,
            EW_PROT = 7,
            EW_OVRFLOW = 8,
            EW_PARAM = 9,
            EW_BUFFER = 10, // 0x0000000A
            EW_PATH = 11, // 0x0000000B
            EW_MODE = 12, // 0x0000000C
            EW_REJECT = 13, // 0x0000000D
            EW_DTSRVR = 14, // 0x0000000E
            EW_ALARM = 15, // 0x0000000F
            EW_STOP = 16, // 0x00000010
            EW_PASSWD = 17, // 0x00000011
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBACT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBACT2
        {
            public short datano;
            public short type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBAXIS
        {
            public short dummy;
            public short type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class FAXIS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] absolute;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] machine;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] relative;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] distance;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OAXIS
        {
            public int absolute;
            public int machine;
            public int relative;
            public int distance;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDY_1
        {
            public Focas1.FAXIS pos = new Focas1.FAXIS();
            public short dummy;
            public short axis;
            public short alarm;
            public short prgnum;
            public short prgmnum;
            public int seqnum;
            public int actf;
            public int acts;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDY_2
        {
            public Focas1.OAXIS pos = new Focas1.OAXIS();
            public short dummy;
            public short axis;
            public short alarm;
            public short prgnum;
            public short prgmnum;
            public int seqnum;
            public int actf;
            public int acts;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDY2_1
        {
            public Focas1.FAXIS pos = new Focas1.FAXIS();
            public short dummy;
            public short axis;
            public int alarm;
            public int prgnum;
            public int prgmnum;
            public int seqnum;
            public int actf;
            public int acts;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDY2_2
        {
            public Focas1.OAXIS pos = new Focas1.OAXIS();
            public short dummy;
            public short axis;
            public int alarm;
            public int prgnum;
            public int prgmnum;
            public int seqnum;
            public int actf;
            public int acts;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBWRR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] data = new int[8];
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBWRA
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] data = new int[8];
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBOVL
        {
            public short datano;
            public short type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPN
        {
            public short datano;
            public short type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public short[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class POSELM
        {
            public int data;
            public short dec;
            public short unit;
            public short disp;
            public char name;
            public char suff;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class POSELMALL
        {
            public Focas1.POSELM abs = new Focas1.POSELM();
            public Focas1.POSELM mach = new Focas1.POSELM();
            public Focas1.POSELM rel = new Focas1.POSELM();
            public Focas1.POSELM dist = new Focas1.POSELM();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPOS
        {
            public Focas1.POSELMALL p1 = new Focas1.POSELMALL();
            public Focas1.POSELMALL p2 = new Focas1.POSELMALL();
            public Focas1.POSELMALL p3 = new Focas1.POSELMALL();
            public Focas1.POSELMALL p4 = new Focas1.POSELMALL();
            public Focas1.POSELMALL p5 = new Focas1.POSELMALL();
            public Focas1.POSELMALL p6 = new Focas1.POSELMALL();
            public Focas1.POSELMALL p7 = new Focas1.POSELMALL();
            public Focas1.POSELMALL p8 = new Focas1.POSELMALL();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBHND_data
        {
            public Focas1.POSELM input = new Focas1.POSELM();
            public Focas1.POSELM output = new Focas1.POSELM();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBHND
        {
            public Focas1.ODBHND_data p1 = new Focas1.ODBHND_data();
            public Focas1.ODBHND_data p2 = new Focas1.ODBHND_data();
            public Focas1.ODBHND_data p3 = new Focas1.ODBHND_data();
            public Focas1.ODBHND_data p4 = new Focas1.ODBHND_data();
            public Focas1.ODBHND_data p5 = new Focas1.ODBHND_data();
            public Focas1.ODBHND_data p6 = new Focas1.ODBHND_data();
            public Focas1.ODBHND_data p7 = new Focas1.ODBHND_data();
            public Focas1.ODBHND_data p8 = new Focas1.ODBHND_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class SPEEDELM
        {
            public int data;
            public short dec;
            public short unit;
            public short disp;
            public byte name;
            public byte suff;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPEED
        {
            public Focas1.SPEEDELM actf = new Focas1.SPEEDELM();
            public Focas1.SPEEDELM acts = new Focas1.SPEEDELM();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class LOADELM
        {
            public int data;
            public short dec;
            public short unit;
            public byte name;
            public byte suff1;
            public byte suff2;
            public byte reserve;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSVLOAD
        {
            public Focas1.LOADELM svload1 = new Focas1.LOADELM();
            public Focas1.LOADELM svload2 = new Focas1.LOADELM();
            public Focas1.LOADELM svload3 = new Focas1.LOADELM();
            public Focas1.LOADELM svload4 = new Focas1.LOADELM();
            public Focas1.LOADELM svload5 = new Focas1.LOADELM();
            public Focas1.LOADELM svload6 = new Focas1.LOADELM();
            public Focas1.LOADELM svload7 = new Focas1.LOADELM();
            public Focas1.LOADELM svload8 = new Focas1.LOADELM();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPLOAD_data
        {
            public Focas1.LOADELM spload = new Focas1.LOADELM();
            public Focas1.LOADELM spspeed = new Focas1.LOADELM();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPLOAD
        {
            public Focas1.ODBSPLOAD_data spload1 = new Focas1.ODBSPLOAD_data();
            public Focas1.ODBSPLOAD_data spload2 = new Focas1.ODBSPLOAD_data();
            public Focas1.ODBSPLOAD_data spload3 = new Focas1.ODBSPLOAD_data();
            public Focas1.ODBSPLOAD_data spload4 = new Focas1.ODBSPLOAD_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDNCDGN
        {
            public short ctrl_word;
            public short can_word;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public char[] nc_file;
            public ushort read_ptr;
            public ushort write_ptr;
            public ushort empty_cnt;
            public uint total_size;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBUP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBBUF
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy;
            public short data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class PRGDIR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5000)]
            public char[] prg_data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBNC_1
        {
            public short reg_prg;
            public short unreg_prg;
            public int used_mem;
            public int unused_mem;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBNC_2
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
            public char[] asc;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPRO
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy;
            public short data;
            public short mdata;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSEQ
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMDIP
        {
            public short mdiprog;
            public int mdipntr;
            public short crntprog;
            public int crntpntr;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBCSS
        {
            public int srpm;
            public int sspm;
            public int smax;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTOFS
        {
            public short datano;
            public short type;
            public int data;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class OFS_1
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            [FieldOffset(0)]
            public int[] m_ofs = new int[5];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            [FieldOffset(0)]
            public int[] m_ofs_a = new int[5];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            [FieldOffset(0)]
            public short[] t_tip = new short[5];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            [FieldOffset(0)]
            public int[] t_ofs = new int[5];
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OFS_2
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] m_ofs_b = new int[10];
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OFS_3
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public int[] m_ofs_c = new int[20];
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class T_OFS_A
        {
            public short tip;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class T_OFS_A_data
        {
            public Focas1.T_OFS_A data1 = new Focas1.T_OFS_A();
            public Focas1.T_OFS_A data2 = new Focas1.T_OFS_A();
            public Focas1.T_OFS_A data3 = new Focas1.T_OFS_A();
            public Focas1.T_OFS_A data4 = new Focas1.T_OFS_A();
            public Focas1.T_OFS_A data5 = new Focas1.T_OFS_A();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class T_OFS_B
        {
            public short tip;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class T_OFS_B_data
        {
            public Focas1.T_OFS_B data1 = new Focas1.T_OFS_B();
            public Focas1.T_OFS_B data2 = new Focas1.T_OFS_B();
            public Focas1.T_OFS_B data3 = new Focas1.T_OFS_B();
            public Focas1.T_OFS_B data4 = new Focas1.T_OFS_B();
            public Focas1.T_OFS_B data5 = new Focas1.T_OFS_B();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTO_1_1
        {
            public Focas1.OFS_1 ofs = new Focas1.OFS_1();
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTO_1_2
        {
            public Focas1.OFS_2 ofs = new Focas1.OFS_2();
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTO_1_3
        {
            public Focas1.OFS_3 ofs = new Focas1.OFS_3();
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTO_2
        {
            public Focas1.T_OFS_A_data tofsa = new Focas1.T_OFS_A_data();
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTO_3
        {
            public Focas1.T_OFS_B_data tofsb = new Focas1.T_OFS_B_data();
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBZOFS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] data = new int[8];
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBZOR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
            public int[] data = new int[56];
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMSTP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public sbyte[] data = new sbyte[7];
            public short datano_s;
            public short dummy;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REALPRM
        {
            public int prm_val;
            public int dec_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REALPRMS
        {
            public Focas1.REALPRM rdata1 = new Focas1.REALPRM();
            public Focas1.REALPRM rdata2 = new Focas1.REALPRM();
            public Focas1.REALPRM rdata3 = new Focas1.REALPRM();
            public Focas1.REALPRM rdata4 = new Focas1.REALPRM();
            public Focas1.REALPRM rdata5 = new Focas1.REALPRM();
            public Focas1.REALPRM rdata6 = new Focas1.REALPRM();
            public Focas1.REALPRM rdata7 = new Focas1.REALPRM();
            public Focas1.REALPRM rdata8 = new Focas1.REALPRM();
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBPSD_1
        {
            [FieldOffset(0)]
            public short datano;
            [FieldOffset(2)]
            public short type;
            [FieldOffset(4)]
            public byte cdata;
            [FieldOffset(4)]
            public short idata;
            [FieldOffset(4)]
            public int ldata;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSD_2
        {
            public Focas1.REALPRM rdata = new Focas1.REALPRM();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBPSD_3
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            [FieldOffset(4)]
            public byte[] cdatas = new byte[8];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            [FieldOffset(4)]
            public short[] idatas = new short[8];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            [FieldOffset(4)]
            public int[] ldatas = new int[8];
            [FieldOffset(0)]
            public short datano;
            [FieldOffset(2)]
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSD_4
        {
            public Focas1.REALPRMS rdatas = new Focas1.REALPRMS();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSD_A
        {
            public Focas1.IODBPSD_1 data1 = new Focas1.IODBPSD_1();
            public Focas1.IODBPSD_1 data2 = new Focas1.IODBPSD_1();
            public Focas1.IODBPSD_1 data3 = new Focas1.IODBPSD_1();
            public Focas1.IODBPSD_1 data4 = new Focas1.IODBPSD_1();
            public Focas1.IODBPSD_1 data5 = new Focas1.IODBPSD_1();
            public Focas1.IODBPSD_1 data6 = new Focas1.IODBPSD_1();
            public Focas1.IODBPSD_1 data7 = new Focas1.IODBPSD_1();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSD_B
        {
            public Focas1.IODBPSD_2 data1 = new Focas1.IODBPSD_2();
            public Focas1.IODBPSD_2 data2 = new Focas1.IODBPSD_2();
            public Focas1.IODBPSD_2 data3 = new Focas1.IODBPSD_2();
            public Focas1.IODBPSD_2 data4 = new Focas1.IODBPSD_2();
            public Focas1.IODBPSD_2 data5 = new Focas1.IODBPSD_2();
            public Focas1.IODBPSD_2 data6 = new Focas1.IODBPSD_2();
            public Focas1.IODBPSD_2 data7 = new Focas1.IODBPSD_2();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSD_C
        {
            public Focas1.IODBPSD_3 data1 = new Focas1.IODBPSD_3();
            public Focas1.IODBPSD_3 data2 = new Focas1.IODBPSD_3();
            public Focas1.IODBPSD_3 data3 = new Focas1.IODBPSD_3();
            public Focas1.IODBPSD_3 data4 = new Focas1.IODBPSD_3();
            public Focas1.IODBPSD_3 data5 = new Focas1.IODBPSD_3();
            public Focas1.IODBPSD_3 data6 = new Focas1.IODBPSD_3();
            public Focas1.IODBPSD_3 data7 = new Focas1.IODBPSD_3();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSD_D
        {
            public Focas1.IODBPSD_4 data1 = new Focas1.IODBPSD_4();
            public Focas1.IODBPSD_4 data2 = new Focas1.IODBPSD_4();
            public Focas1.IODBPSD_4 data3 = new Focas1.IODBPSD_4();
            public Focas1.IODBPSD_4 data4 = new Focas1.IODBPSD_4();
            public Focas1.IODBPSD_4 data5 = new Focas1.IODBPSD_4();
            public Focas1.IODBPSD_4 data6 = new Focas1.IODBPSD_4();
            public Focas1.IODBPSD_4 data7 = new Focas1.IODBPSD_4();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPRMNO
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] prm = new int[10];
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPRM_data
        {
            public int prm_val;
            public int dec_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPRM1
        {
            public Focas1.IODBPRM_data data1 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data2 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data3 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data4 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data5 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data6 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data7 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data8 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data9 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data10 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data11 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data12 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data13 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data14 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data15 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data16 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data17 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data18 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data19 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data20 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data21 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data22 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data23 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data24 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data25 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data26 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data27 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data28 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data29 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data30 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data31 = new Focas1.IODBPRM_data();
            public Focas1.IODBPRM_data data32 = new Focas1.IODBPRM_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPRM2
        {
            public Focas1.IODBPRM1 data = new Focas1.IODBPRM1();
            public int datano;
            public short type;
            public short axis;
            public short info;
            public short unit;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPRM
        {
            public Focas1.IODBPRM2 prm1 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm2 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm3 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm4 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm5 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm6 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm7 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm8 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm9 = new Focas1.IODBPRM2();
            public Focas1.IODBPRM2 prm10 = new Focas1.IODBPRM2();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPI
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public sbyte[] data = new sbyte[5];
            public short datano_s;
            public short dummy;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBM
        {
            public short datano;
            public short dummy;
            public int mcr_val;
            public short dec_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMR_data
        {
            public int mcr_val;
            public short dec_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMR1
        {
            public Focas1.IODBMR_data data1 = new Focas1.IODBMR_data();
            public Focas1.IODBMR_data data2 = new Focas1.IODBMR_data();
            public Focas1.IODBMR_data data3 = new Focas1.IODBMR_data();
            public Focas1.IODBMR_data data4 = new Focas1.IODBMR_data();
            public Focas1.IODBMR_data data5 = new Focas1.IODBMR_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMR
        {
            public Focas1.IODBMR1 data = new Focas1.IODBMR1();
            public short datano_s;
            public short dummy;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPM
        {
            public int datano;
            public short dummy;
            public int mcr_val;
            public short dec_val;
        }

        public class IODBPR_data
        {
            public int mcr_val;
            public short dec_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPR1
        {
            public Focas1.IODBPR_data data1 = new Focas1.IODBPR_data();
            public Focas1.IODBPR_data data2 = new Focas1.IODBPR_data();
            public Focas1.IODBPR_data data3 = new Focas1.IODBPR_data();
            public Focas1.IODBPR_data data4 = new Focas1.IODBPR_data();
            public Focas1.IODBPR_data data5 = new Focas1.IODBPR_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPR
        {
            public Focas1.IODBPR1 data = new Focas1.IODBPR1();
            public int datano_s;
            public short dummy;
            public int datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLINF
        {
            public short ofs_type;
            public short use_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMVINF
        {
            public short use_no1;
            public short use_no2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMINF
        {
            public short use_no1;
            public short use_no2;
            public short v2_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLIFE1
        {
            public short dummy;
            public short type;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLIFE2
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLIFE3
        {
            public short datano;
            public short dummy;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLIFE4
        {
            public short datano;
            public short type;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLIFE5
        {
            public int dummy;
            public int type;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTR_data
        {
            public int ntool;
            public int life;
            public int count;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTR1
        {
            public Focas1.IODBTR_data data1 = new Focas1.IODBTR_data();
            public Focas1.IODBTR_data data2 = new Focas1.IODBTR_data();
            public Focas1.IODBTR_data data3 = new Focas1.IODBTR_data();
            public Focas1.IODBTR_data data4 = new Focas1.IODBTR_data();
            public Focas1.IODBTR_data data5 = new Focas1.IODBTR_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTR
        {
            public Focas1.IODBTR1 data = new Focas1.IODBTR1();
            public short datano_s;
            public short dummy;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTG_data
        {
            public int tuse_num;
            public int tool_num;
            public int length_num;
            public int radius_num;
            public int tinfo;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTG1
        {
            public Focas1.ODBTG_data data1 = new Focas1.ODBTG_data();
            public Focas1.ODBTG_data data2 = new Focas1.ODBTG_data();
            public Focas1.ODBTG_data data3 = new Focas1.ODBTG_data();
            public Focas1.ODBTG_data data4 = new Focas1.ODBTG_data();
            public Focas1.ODBTG_data data5 = new Focas1.ODBTG_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTG
        {
            public Focas1.ODBTG1 data = new Focas1.ODBTG1();
            public short grp_num;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy;
            public int ntool;
            public int life;
            public int count;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBWRC_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] dummy;
            public int count;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBWRC1
        {
            public Focas1.IDBWRC_data data1 = new Focas1.IDBWRC_data();
            public Focas1.IDBWRC_data data2 = new Focas1.IDBWRC_data();
            public Focas1.IDBWRC_data data3 = new Focas1.IDBWRC_data();
            public Focas1.IDBWRC_data data4 = new Focas1.IDBWRC_data();
            public Focas1.IDBWRC_data data5 = new Focas1.IDBWRC_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBWRC
        {
            public Focas1.IDBWRC1 data = new Focas1.IDBWRC1();
            public short datano_s;
            public short dummy;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBUSEGR
        {
            public short datano;
            public short type;
            public int next;
            public int use;
            public int slct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBLFNO
        {
            public short datano;
            public short type;
            public short data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLUSE
        {
            public short s_grp;
            public short dummy;
            public short e_grp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTD
        {
            public short datano;
            public short type;
            public int tool_num;
            public int h_code;
            public int d_code;
            public int tool_inf;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTD2
        {
            public short datano;
            public short dummy;
            public int type;
            public int tool_num;
            public int h_code;
            public int d_code;
            public int tool_inf;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTGI_data
        {
            public int n_tool;
            public int count_value;
            public int counter;
            public int count_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTGI1
        {
            public Focas1.IODBTGI_data data1 = new Focas1.IODBTGI_data();
            public Focas1.IODBTGI_data data2 = new Focas1.IODBTGI_data();
            public Focas1.IODBTGI_data data3 = new Focas1.IODBTGI_data();
            public Focas1.IODBTGI_data data4 = new Focas1.IODBTGI_data();
            public Focas1.IODBTGI_data data5 = new Focas1.IODBTGI_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTGI
        {
            public Focas1.IODBTGI1 data = new Focas1.IODBTGI1();
            public short s_grp;
            public short dummy;
            public short e_grp;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTGI2
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public int[] opt_grpno = new int[5];
            public short s_grp;
            public short dummy;
            public short e_grp;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTGI3
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public int[] life_rest = new int[5];
            public short s_grp;
            public short dummy;
            public short e_grp;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBITD
        {
            public short datano;
            public short type;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBTLINFO
        {
            public int max_group;
            public int max_tool;
            public int max_minute;
            public int max_cycle;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBUSEGRP
        {
            public int next;
            public int use;
            public int slct;
            public int opt_next;
            public int opt_use;
            public int opt_slct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLGRP_data
        {
            public int ntool;
            public int nfree;
            public int life;
            public int count;
            public int use_tool;
            public int opt_grpno;
            public int life_rest;
            public short rest_sig;
            public short count_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLGRP
        {
            public Focas1.IODBTLGRP_data data1 = new Focas1.IODBTLGRP_data();
            public Focas1.IODBTLGRP_data data2 = new Focas1.IODBTLGRP_data();
            public Focas1.IODBTLGRP_data data3 = new Focas1.IODBTLGRP_data();
            public Focas1.IODBTLGRP_data data4 = new Focas1.IODBTLGRP_data();
            public Focas1.IODBTLGRP_data data5 = new Focas1.IODBTLGRP_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLTOOL_data
        {
            public int tool_num;
            public int h_code;
            public int d_code;
            public int tool_inf;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLTOOL
        {
            public Focas1.IODBTLTOOL_data data1 = new Focas1.IODBTLTOOL_data();
            public Focas1.IODBTLTOOL_data data2 = new Focas1.IODBTLTOOL_data();
            public Focas1.IODBTLTOOL_data data3 = new Focas1.IODBTLTOOL_data();
            public Focas1.IODBTLTOOL_data data4 = new Focas1.IODBTLTOOL_data();
            public Focas1.IODBTLTOOL_data data5 = new Focas1.IODBTLTOOL_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLMNG_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public int[] reserved = new int[5];
            public int T_code;
            public int life_count;
            public int max_life;
            public int rest_life;
            public byte life_stat;
            public byte cust_bits;
            public ushort tool_info;
            public short H_code;
            public short D_code;
            public int spindle_speed;
            public int feedrate;
            public short magazine;
            public short pot;
            public short G_code;
            public short W_code;
            public int custom1;
            public int custom2;
            public int custom3;
            public int custom4;
            public int custom5;
            public int custom6;
            public int custom7;
            public int custom8;
            public int custom9;
            public int custom10;
            public int custom11;
            public int custom12;
            public int custom13;
            public int custom14;
            public int custom15;
            public int custom16;
            public int custom17;
            public int custom18;
            public int custom19;
            public int custom20;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLMNG
        {
            public Focas1.IODBTLMNG_data data1 = new Focas1.IODBTLMNG_data();
            public Focas1.IODBTLMNG_data data2 = new Focas1.IODBTLMNG_data();
            public Focas1.IODBTLMNG_data data3 = new Focas1.IODBTLMNG_data();
            public Focas1.IODBTLMNG_data data4 = new Focas1.IODBTLMNG_data();
            public Focas1.IODBTLMNG_data data5 = new Focas1.IODBTLMNG_data();
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IDBTLM_item
        {
            [FieldOffset(0)]
            public sbyte data1;
            [FieldOffset(0)]
            public short data2;
            [FieldOffset(0)]
            public int data4;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBTLM
        {
            public Focas1.IDBTLM_item item = new Focas1.IDBTLM_item();
            public short data_id;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLMAG_data
        {
            public short magazine;
            public short pot;
            public short tool_index;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLMAG
        {
            public Focas1.IODBTLMAG_data data1 = new Focas1.IODBTLMAG_data();
            public Focas1.IODBTLMAG_data data2 = new Focas1.IODBTLMAG_data();
            public Focas1.IODBTLMAG_data data3 = new Focas1.IODBTLMAG_data();
            public Focas1.IODBTLMAG_data data4 = new Focas1.IODBTLMAG_data();
            public Focas1.IODBTLMAG_data data5 = new Focas1.IODBTLMAG_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLMAG2_data
        {
            public short magazine;
            public short pot;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLMAG2
        {
            public Focas1.IODBTLMAG2_data data1 = new Focas1.IODBTLMAG2_data();
            public Focas1.IODBTLMAG2_data data2 = new Focas1.IODBTLMAG2_data();
            public Focas1.IODBTLMAG2_data data3 = new Focas1.IODBTLMAG2_data();
            public Focas1.IODBTLMAG2_data data4 = new Focas1.IODBTLMAG2_data();
            public Focas1.IODBTLMAG2_data data5 = new Focas1.IODBTLMAG2_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_ALM
        {
            public short rec_type;
            public short alm_grp;
            public short alm_no;
            public sbyte axis_no;
            public sbyte dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_MDI
        {
            public short rec_type;
            public byte key_code;
            public byte pw_flag;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public sbyte[] dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_SGN
        {
            public short rec_type;
            public sbyte sig_name;
            public byte sig_old;
            public byte sig_new;
            public sbyte dummy;
            public short sig_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_DATE
        {
            public short rec_type;
            public sbyte year;
            public sbyte month;
            public sbyte day;
            public sbyte pw_flag;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public sbyte[] dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_TIME
        {
            public short rec_type;
            public sbyte hour;
            public sbyte minute;
            public sbyte second;
            public sbyte pw_flag;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public sbyte[] dummy;
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public class ODBHIS_data
        {
            [FieldOffset(0)]
            public short rec_type;
            [FieldOffset(0)]
            public short alm_rec_type;
            [FieldOffset(2)]
            public short alm_alm_grp;
            [FieldOffset(4)]
            public short alm_alm_no;
            [FieldOffset(6)]
            public sbyte alm_axis_no;
            [FieldOffset(7)]
            public sbyte alm_dummy;
            [FieldOffset(0)]
            public short mdi_rec_type;
            [FieldOffset(2)]
            public byte mdi_key_code;
            [FieldOffset(3)]
            public byte mdi_pw_flag;
            [FieldOffset(4)]
            public sbyte mdi_dummy1;
            [FieldOffset(5)]
            public sbyte mdi_dummy2;
            [FieldOffset(6)]
            public sbyte mdi_dummy3;
            [FieldOffset(7)]
            public sbyte mdi_dummy4;
            [FieldOffset(0)]
            public short sgn_rec_type;
            [FieldOffset(2)]
            public sbyte sgn_sig_name;
            [FieldOffset(3)]
            public byte sgn_sig_old;
            [FieldOffset(4)]
            public byte sgn_sig_new;
            [FieldOffset(5)]
            public sbyte sgn_dummy;
            [FieldOffset(6)]
            public short sgn_sig_no;
            [FieldOffset(0)]
            public short date_rec_type;
            [FieldOffset(2)]
            public sbyte date_year;
            [FieldOffset(3)]
            public sbyte date_month;
            [FieldOffset(4)]
            public sbyte date_day;
            [FieldOffset(5)]
            public sbyte date_pw_flag;
            [FieldOffset(6)]
            public sbyte date_dummy1;
            [FieldOffset(7)]
            public sbyte date_dummy2;
            [FieldOffset(0)]
            public short time_rec_type;
            [FieldOffset(2)]
            public sbyte time_hour;
            [FieldOffset(3)]
            public sbyte time_minute;
            [FieldOffset(4)]
            public sbyte time_second;
            [FieldOffset(5)]
            public sbyte time_pw_flag;
            [FieldOffset(6)]
            public sbyte time_dummy1;
            [FieldOffset(7)]
            public sbyte time_dummy2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBHIS1
        {
            public Focas1.ODBHIS_data data1 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data2 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data3 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data4 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data5 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data6 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data7 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data8 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data9 = new Focas1.ODBHIS_data();
            public Focas1.ODBHIS_data data10 = new Focas1.ODBHIS_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBHIS
        {
            public Focas1.ODBHIS1 data = new Focas1.ODBHIS1();
            public ushort s_no;
            public short type;
            public ushort e_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_MDI2
        {
            public byte key_code;
            public byte pw_flag;
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_MDI2_data
        {
            public Focas1.REC_MDI2 data = new Focas1.REC_MDI2();
            public short rec_len;
            public short rec_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_SGN2
        {
            public short sig_name;
            public short sig_no;
            public byte sig_old;
            public byte sig_new;
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_SGN2_data
        {
            public Focas1.REC_SGN2 data = new Focas1.REC_SGN2();
            public short rec_len;
            public short rec_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_ALM2
        {
            public short alm_grp;
            public short alm_no;
            public short axis_no;
            public short year;
            public short month;
            public short day;
            public short hour;
            public short minute;
            public short second;
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_ALM2_data
        {
            public Focas1.REC_ALM2 data = new Focas1.REC_ALM2();
            public short rec_len;
            public short rec_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_DATE2
        {
            public short evnt_type;
            public short year;
            public short month;
            public short day;
            public short hour;
            public short minute;
            public short second;
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REC_DATE2_data
        {
            public Focas1.REC_DATE2 data = new Focas1.REC_DATE2();
            public short rec_len;
            public short rec_type;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class ODBOPHIS
        {
            [FieldOffset(0)]
            public Focas1.REC_MDI2_data rec_mdi = new Focas1.REC_MDI2_data();
            [FieldOffset(0)]
            public Focas1.REC_SGN2_data rec_sgn = new Focas1.REC_SGN2_data();
            [FieldOffset(0)]
            public Focas1.REC_ALM2_data rec_alm = new Focas1.REC_ALM2_data();
            [FieldOffset(0)]
            public Focas1.REC_DATE2_data rec_date = new Focas1.REC_DATE2_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALM_HIS_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string alm_msg = new string(' ', 32);
            public short dummy;
            public short alm_grp;
            public short alm_no;
            public byte axis_no;
            public byte year;
            public byte month;
            public byte day;
            public byte hour;
            public byte minute;
            public byte second;
            public byte dummy2;
            public short len_msg;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALM_HIS1
        {
            public Focas1.ALM_HIS_data data1 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data2 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data3 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data4 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data5 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data6 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data7 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data8 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data9 = new Focas1.ALM_HIS_data();
            public Focas1.ALM_HIS_data data10 = new Focas1.ALM_HIS_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBAHIS
        {
            public Focas1.ALM_HIS1 alm_his = new Focas1.ALM_HIS1();
            public ushort s_no;
            public short type;
            public ushort e_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALM_HIS2_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string alm_msg = new string(' ', 32);
            public short alm_grp;
            public short alm_no;
            public short axis_no;
            public short year;
            public short month;
            public short day;
            public short hour;
            public short minute;
            public short second;
            public short len_msg;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALM_HIS2
        {
            public Focas1.ALM_HIS2_data data1 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data2 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data3 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data4 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data5 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data6 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data7 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data8 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data9 = new Focas1.ALM_HIS2_data();
            public Focas1.ALM_HIS2_data data10 = new Focas1.ALM_HIS2_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBAHIS2
        {
            public Focas1.ALM_HIS2 alm_his = new Focas1.ALM_HIS2();
            public ushort s_no;
            public ushort e_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSIG_data
        {
            public short ent_no;
            public short sig_no;
            public byte sig_name;
            public byte mask_pat;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSIG1
        {
            public Focas1.IODBSIG_data data1 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data2 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data3 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data4 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data5 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data6 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data7 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data8 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data9 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data10 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data11 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data12 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data13 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data14 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data15 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data16 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data17 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data18 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data19 = new Focas1.IODBSIG_data();
            public Focas1.IODBSIG_data data20 = new Focas1.IODBSIG_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSIG
        {
            public Focas1.IODBSIG1 data = new Focas1.IODBSIG1();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSYS
        {
            public short addinfo;
            public short max_axis;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public char[] cnc_type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public char[] mt_type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public char[] series;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public char[] version;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public char[] axes;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBST
        {
            public short dummy;
            public short tmmode;
            public short aut;
            public short run;
            public short motion;
            public short mstb;
            public short emergency;
            public short alarm;
            public short edit;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBALM
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] dummy = new short[2];
            public ushort data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALMINFO1_data
        {
            public short axis;
            public short alm_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALMINFO2_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string alm_msg = new string(' ', 32);
            public short axis;
            public short alm_no;
            public short msg_len;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALMINFO_1
        {
            public Focas1.ALMINFO1_data msg1 = new Focas1.ALMINFO1_data();
            public Focas1.ALMINFO1_data msg2 = new Focas1.ALMINFO1_data();
            public Focas1.ALMINFO1_data msg3 = new Focas1.ALMINFO1_data();
            public Focas1.ALMINFO1_data msg4 = new Focas1.ALMINFO1_data();
            public Focas1.ALMINFO1_data msg5 = new Focas1.ALMINFO1_data();
            public short data_end;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ALMINFO_2
        {
            public Focas1.ALMINFO2_data msg1 = new Focas1.ALMINFO2_data();
            public Focas1.ALMINFO2_data msg2 = new Focas1.ALMINFO2_data();
            public Focas1.ALMINFO2_data msg3 = new Focas1.ALMINFO2_data();
            public Focas1.ALMINFO2_data msg4 = new Focas1.ALMINFO2_data();
            public Focas1.ALMINFO2_data msg5 = new Focas1.ALMINFO2_data();
            public short dataend;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBALMMSG_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string alm_msg = new string(' ', 32);
            public int alm_no;
            public short type;
            public short axis;
            public short dummy;
            public short msg_len;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBALMMSG
        {
            public Focas1.ODBALMMSG_data msg1 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg2 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg3 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg4 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg5 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg6 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg7 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg8 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg9 = new Focas1.ODBALMMSG_data();
            public Focas1.ODBALMMSG_data msg10 = new Focas1.ODBALMMSG_data();

            public List<Focas1.ODBALMMSG_data> msgs()
            {
                return ((IEnumerable<Focas1.ODBALMMSG_data>)new Focas1.ODBALMMSG_data[10]
                {
          this.msg1,
          this.msg2,
          this.msg3,
          this.msg4,
          this.msg5,
          this.msg6,
          this.msg7,
          this.msg8,
          this.msg9,
          this.msg10
                }).ToList<Focas1.ODBALMMSG_data>();
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class MODAL_AUX_data
        {
            public int aux_data;
            public byte flag1;
            public byte flag2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class MODAL_RAUX1_data
        {
            public Focas1.MODAL_AUX_data data1 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data2 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data3 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data4 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data5 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data6 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data7 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data8 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data9 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data10 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data11 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data12 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data13 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data14 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data15 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data16 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data17 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data18 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data19 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data20 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data21 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data22 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data23 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data24 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data25 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data26 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data27 = new Focas1.MODAL_AUX_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class MODAL_RAUX2_data
        {
            public Focas1.MODAL_AUX_data data1 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data2 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data3 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data4 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data5 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data6 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data7 = new Focas1.MODAL_AUX_data();
            public Focas1.MODAL_AUX_data data8 = new Focas1.MODAL_AUX_data();
        }

        [StructLayout(LayoutKind.Explicit)]
        public class ODBMDL_1
        {
            [FieldOffset(0)]
            public short datano;
            [FieldOffset(2)]
            public short type;
            [FieldOffset(4)]
            public char g_data;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class ODBMDL_2
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            [FieldOffset(4)]
            public byte[] g_1shot = new byte[4];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 35)]
            [FieldOffset(4)]
            public byte[] g_rdata = new byte[35];
            [FieldOffset(0)]
            public short datano;
            [FieldOffset(2)]
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMDL_3
        {
            public Focas1.MODAL_AUX_data aux = new Focas1.MODAL_AUX_data();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMDL_4
        {
            public Focas1.MODAL_RAUX1_data raux1 = new Focas1.MODAL_RAUX1_data();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMDL_5
        {
            public Focas1.MODAL_RAUX2_data raux2 = new Focas1.MODAL_RAUX2_data();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBGCD_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string code = new string(' ', 8);
            public short group;
            public short flag;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBGCD
        {
            public Focas1.ODBGCD_data gcd0 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd1 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd2 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd3 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd4 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd5 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd6 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd7 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd8 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd9 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd10 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd11 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd12 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd13 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd14 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd15 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd16 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd17 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd18 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd19 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd20 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd21 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd22 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd23 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd24 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd25 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd26 = new Focas1.ODBGCD_data();
            public Focas1.ODBGCD_data gcd27 = new Focas1.ODBGCD_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBCMD_data
        {
            public byte adrs;
            public byte num;
            public short flag;
            public int cmd_val;
            public int dec_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBCMD
        {
            public Focas1.ODBCMD_data cmd0 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd1 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd2 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd3 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd4 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd5 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd6 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd7 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd8 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd9 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd10 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd11 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd12 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd13 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd14 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd15 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd16 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd17 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd18 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd19 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd20 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd21 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd22 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd23 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd24 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd25 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd26 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd27 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd28 = new Focas1.ODBCMD_data();
            public Focas1.ODBCMD_data cmd29 = new Focas1.ODBCMD_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REALDGN
        {
            public int dgn_val;
            public int dec_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class REALDGNS
        {
            public Focas1.REALDGN rdata1 = new Focas1.REALDGN();
            public Focas1.REALDGN rdata2 = new Focas1.REALDGN();
            public Focas1.REALDGN rdata3 = new Focas1.REALDGN();
            public Focas1.REALDGN rdata4 = new Focas1.REALDGN();
            public Focas1.REALDGN rdata5 = new Focas1.REALDGN();
            public Focas1.REALDGN rdata6 = new Focas1.REALDGN();
            public Focas1.REALDGN rdata7 = new Focas1.REALDGN();
            public Focas1.REALDGN rdata8 = new Focas1.REALDGN();
        }

        [StructLayout(LayoutKind.Explicit)]
        public class ODBDGN_1
        {
            [FieldOffset(0)]
            public short datano;
            [FieldOffset(2)]
            public short type;
            [FieldOffset(4)]
            public byte cdata;
            [FieldOffset(4)]
            public short idata;
            [FieldOffset(4)]
            public int ldata;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDGN_2
        {
            public Focas1.REALDGN rdata = new Focas1.REALDGN();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class ODBDGN_3
        {
            [FieldOffset(0)]
            public short datano;
            [FieldOffset(2)]
            public short type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            [FieldOffset(4)]
            public byte[] cdatas;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            [FieldOffset(4)]
            public short[] idatas;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            [FieldOffset(4)]
            public int[] ldatas;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDGN_4
        {
            public Focas1.REALDGNS rdatas = new Focas1.REALDGNS();
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDGN_A
        {
            public Focas1.ODBDGN_1 data1 = new Focas1.ODBDGN_1();
            public Focas1.ODBDGN_1 data2 = new Focas1.ODBDGN_1();
            public Focas1.ODBDGN_1 data3 = new Focas1.ODBDGN_1();
            public Focas1.ODBDGN_1 data4 = new Focas1.ODBDGN_1();
            public Focas1.ODBDGN_1 data5 = new Focas1.ODBDGN_1();
            public Focas1.ODBDGN_1 data6 = new Focas1.ODBDGN_1();
            public Focas1.ODBDGN_1 data7 = new Focas1.ODBDGN_1();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDGN_B
        {
            public Focas1.ODBDGN_2 data1 = new Focas1.ODBDGN_2();
            public Focas1.ODBDGN_2 data2 = new Focas1.ODBDGN_2();
            public Focas1.ODBDGN_2 data3 = new Focas1.ODBDGN_2();
            public Focas1.ODBDGN_2 data4 = new Focas1.ODBDGN_2();
            public Focas1.ODBDGN_2 data5 = new Focas1.ODBDGN_2();
            public Focas1.ODBDGN_2 data6 = new Focas1.ODBDGN_2();
            public Focas1.ODBDGN_2 data7 = new Focas1.ODBDGN_2();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDGN_C
        {
            public Focas1.ODBDGN_3 data1 = new Focas1.ODBDGN_3();
            public Focas1.ODBDGN_3 data2 = new Focas1.ODBDGN_3();
            public Focas1.ODBDGN_3 data3 = new Focas1.ODBDGN_3();
            public Focas1.ODBDGN_3 data4 = new Focas1.ODBDGN_3();
            public Focas1.ODBDGN_3 data5 = new Focas1.ODBDGN_3();
            public Focas1.ODBDGN_3 data6 = new Focas1.ODBDGN_3();
            public Focas1.ODBDGN_3 data7 = new Focas1.ODBDGN_3();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDGN_D
        {
            public Focas1.ODBDGN_4 data1 = new Focas1.ODBDGN_4();
            public Focas1.ODBDGN_4 data2 = new Focas1.ODBDGN_4();
            public Focas1.ODBDGN_4 data3 = new Focas1.ODBDGN_4();
            public Focas1.ODBDGN_4 data4 = new Focas1.ODBDGN_4();
            public Focas1.ODBDGN_4 data5 = new Focas1.ODBDGN_4();
            public Focas1.ODBDGN_4 data6 = new Focas1.ODBDGN_4();
            public Focas1.ODBDGN_4 data7 = new Focas1.ODBDGN_4();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBAD
        {
            public short datano;
            public short type;
            public short data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OPMSG_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string data = new string(' ', 256);
            public short datano;
            public short type;
            public short char_num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OPMSG
        {
            public Focas1.OPMSG_data msg1 = new Focas1.OPMSG_data();
            public Focas1.OPMSG_data msg2 = new Focas1.OPMSG_data();
            public Focas1.OPMSG_data msg3 = new Focas1.OPMSG_data();
            public Focas1.OPMSG_data msg4 = new Focas1.OPMSG_data();
            public Focas1.OPMSG_data msg5 = new Focas1.OPMSG_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OPMSG2_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string data = new string(' ', 64);
            public short datano;
            public short type;
            public short char_num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OPMSG2
        {
            public Focas1.OPMSG2_data msg1 = new Focas1.OPMSG2_data();
            public Focas1.OPMSG2_data msg2 = new Focas1.OPMSG2_data();
            public Focas1.OPMSG2_data msg3 = new Focas1.OPMSG2_data();
            public Focas1.OPMSG2_data msg4 = new Focas1.OPMSG2_data();
            public Focas1.OPMSG2_data msg5 = new Focas1.OPMSG2_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OPMSG3_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string data = new string(' ', 256);
            public short datano;
            public short type;
            public short char_num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class OPMSG3
        {
            public Focas1.OPMSG3_data msg1 = new Focas1.OPMSG3_data();
            public Focas1.OPMSG3_data msg2 = new Focas1.OPMSG3_data();
            public Focas1.OPMSG3_data msg3 = new Focas1.OPMSG3_data();
            public Focas1.OPMSG3_data msg4 = new Focas1.OPMSG3_data();
            public Focas1.OPMSG3_data msg5 = new Focas1.OPMSG3_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSYSC
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series1 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series2 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series3 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series4 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series5 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series6 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series7 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series8 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series9 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series10 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series11 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series12 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series13 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series14 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series15 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_series16 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version1 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version2 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version3 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version4 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version5 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version6 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version7 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version8 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version9 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version10 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version11 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version12 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version13 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version14 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version15 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string s_version16 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] slot_no_p;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] slot_no_l;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] mod_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] soft_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] dummy;
            public short m_rom;
            public short s_rom;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public char[] svo_soft;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public char[] pmc_soft;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public char[] lad_soft;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public char[] mcr_soft;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public char[] spl1_soft;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public char[] spl2_soft;
            public short frmmin;
            public short drmmin;
            public short srmmin;
            public short pmcmin;
            public short crtmin;
            public short sv1min;
            public short sv3min;
            public short sicmin;
            public short posmin;
            public short drmmrc;
            public short drmarc;
            public short pmcmrc;
            public short dmaarc;
            public short iopt;
            public short hdiio;
            public short frmsub;
            public short drmsub;
            public short srmsub;
            public short sv5sub;
            public short sv7sub;
            public short sicsub;
            public short possub;
            public short hamsub;
            public short gm2gr1;
            public short crtgr2;
            public short gm1gr2;
            public short gm2gr2;
            public short cmmrb;
            public short sv5axs;
            public short sv7axs;
            public short sicaxs;
            public short posaxs;
            public short hanaxs;
            public short romr64;
            public short srmr64;
            public short dr1r64;
            public short dr2r64;
            public short iopio2;
            public short hdiio2;
            public short cmmrb2;
            public short romfap;
            public short srmfap;
            public short drmfap;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPRS
        {
            public short datano;
            public short type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public short[] data_info;
            public int rstr_bc;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 35)]
            public int[] rstr_m;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] rstr_t;
            public int rstr_s;
            public int rstr_b;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dest;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dist;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSGNL
        {
            public short datano;
            public short type;
            public short mode;
            public short hndl_ax;
            public short hndl_mv;
            public short rpd_ovrd;
            public short jog_ovrd;
            public short feed_ovrd;
            public short spdl_ovrd;
            public short blck_del;
            public short sngl_blck;
            public short machn_lock;
            public short dry_run;
            public short mem_prtct;
            public short feed_hold;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBGNRL
        {
            public short datano;
            public short type;
            public byte sgnal;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBRDNA
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl1_name = new string(' ', 9);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl2_name = new string(' ', 9);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl3_name = new string(' ', 9);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl4_name = new string(' ', 9);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl5_name = new string(' ', 9);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl6_name = new string(' ', 9);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl7_name = new string(' ', 9);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
            public string sgnl8_name = new string(' ', 9);
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBERR
        {
            public short err_no;
            public short err_dtno;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPARAIF_info
        {
            public short prm_no;
            public short prm_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPARAIF1
        {
            public Focas1.ODBPARAIF_info info1 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info2 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info3 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info4 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info5 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info6 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info7 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info8 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info9 = new Focas1.ODBPARAIF_info();
            public Focas1.ODBPARAIF_info info10 = new Focas1.ODBPARAIF_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPARAIF
        {
            public Focas1.ODBPARAIF1 info = new Focas1.ODBPARAIF1();
            public ushort info_no;
            public short prev_no;
            public short next_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSETIF_info
        {
            public short set_no;
            public short set_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSETIF1
        {
            public Focas1.ODBSETIF_info info1 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info2 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info3 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info4 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info5 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info6 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info7 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info8 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info9 = new Focas1.ODBSETIF_info();
            public Focas1.ODBSETIF_info info10 = new Focas1.ODBSETIF_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSETIF
        {
            public Focas1.ODBSETIF1 info = new Focas1.ODBSETIF1();
            public ushort info_no;
            public short prev_no;
            public short next_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDIAGIF_info
        {
            public short diag_no;
            public short diag_type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDIAGIF1
        {
            public Focas1.ODBDIAGIF_info info1 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info2 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info3 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info4 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info5 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info6 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info7 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info8 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info9 = new Focas1.ODBDIAGIF_info();
            public Focas1.ODBDIAGIF_info info10 = new Focas1.ODBDIAGIF_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDIAGIF
        {
            public Focas1.ODBDIAGIF1 info = new Focas1.ODBDIAGIF1();
            public ushort info_no;
            public short prev_no;
            public short next_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPARANUM
        {
            public ushort para_min;
            public ushort para_max;
            public ushort total_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSETNUM
        {
            public ushort set_min;
            public ushort set_max;
            public ushort total_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDIAGNUM
        {
            public ushort diag_min;
            public ushort diag_max;
            public ushort total_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBFINFO_info
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string sysname = new string(' ', 12);
            public int fromsize;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBFINFO1
        {
            public Focas1.ODBFINFO_info info1 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info2 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info3 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info4 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info5 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info6 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info7 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info8 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info9 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info10 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info11 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info12 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info13 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info14 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info15 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info16 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info17 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info18 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info19 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info20 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info21 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info22 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info23 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info24 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info25 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info26 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info27 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info28 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info29 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info30 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info31 = new Focas1.ODBFINFO_info();
            public Focas1.ODBFINFO_info info32 = new Focas1.ODBFINFO_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBFINFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string slotname = new string(' ', 12);
            public Focas1.ODBFINFO1 info = new Focas1.ODBFINFO1();
            public int fromnum;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBFINFORM_info
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string sysname = new string(' ', 12);
            public int fromsize;
            public int fromattrib;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBFINFORM1
        {
            public Focas1.ODBFINFORM_info info1 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info2 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info3 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info4 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info5 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info6 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info7 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info8 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info9 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info10 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info11 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info12 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info13 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info14 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info15 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info16 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info17 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info18 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info19 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info20 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info21 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info22 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info23 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info24 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info25 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info26 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info27 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info28 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info29 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info30 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info31 = new Focas1.ODBFINFORM_info();
            public Focas1.ODBFINFORM_info info32 = new Focas1.ODBFINFORM_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBFINFORM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string slotname = new string(' ', 12);
            public Focas1.ODBFINFORM1 info = new Focas1.ODBFINFORM1();
            public int slotno;
            public int fromnum;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSINFO_info
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string sramname = new string(' ', 12);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string fname1 = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string fname2 = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string fname3 = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string fname4 = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string fname5 = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string fname6 = new string(' ', 16);
            public int sramsize;
            public short divnumber;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSINFO1
        {
            public Focas1.ODBSINFO_info info1 = new Focas1.ODBSINFO_info();
            public Focas1.ODBSINFO_info info2 = new Focas1.ODBSINFO_info();
            public Focas1.ODBSINFO_info info3 = new Focas1.ODBSINFO_info();
            public Focas1.ODBSINFO_info info4 = new Focas1.ODBSINFO_info();
            public Focas1.ODBSINFO_info info5 = new Focas1.ODBSINFO_info();
            public Focas1.ODBSINFO_info info6 = new Focas1.ODBSINFO_info();
            public Focas1.ODBSINFO_info info7 = new Focas1.ODBSINFO_info();
            public Focas1.ODBSINFO_info info8 = new Focas1.ODBSINFO_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSINFO
        {
            public Focas1.ODBSINFO1 info = new Focas1.ODBSINFO1();
            public int sramnum;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class SRAMADDR
        {
            public short type;
            public int size;
            public int offset;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDSDIR_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string file_name = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string comment = new string(' ', 64);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string date = new string(' ', 16);
            public int size;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDSDIR1
        {
            public Focas1.ODBDSDIR_data data1 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data2 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data3 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data4 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data5 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data6 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data7 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data8 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data9 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data10 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data11 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data12 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data13 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data14 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data15 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data16 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data17 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data18 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data19 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data20 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data21 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data22 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data23 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data24 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data25 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data26 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data27 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data28 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data29 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data30 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data31 = new Focas1.ODBDSDIR_data();
            public Focas1.ODBDSDIR_data data32 = new Focas1.ODBDSDIR_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDSDIR
        {
            public Focas1.ODBDSDIR1 data = new Focas1.ODBDSDIR1();
            public int file_num;
            public int remainder;
            public short data_num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBDSSET
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string host_ip = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string host_uname = new string(' ', 32);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string host_passwd = new string(' ', 32);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string host_dir = new string(' ', 128);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
            public string dtsv_mac = new string(' ', 13);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string dtsv_ip = new string(' ', 16);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string dtsv_mask = new string(' ', 16);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDSMNT
        {
            public int empty_cnt;
            public int total_size;
            public int read_ptr;
            public int write_ptr;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPSER
        {
            public int poserr1;
            public int poserr2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPDI_data
        {
            public byte sgnl1;
            public byte sgnl2;
            public byte sgnl3;
            public byte sgnl4;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPDI
        {
            public Focas1.ODBSPDI_data di1 = new Focas1.ODBSPDI_data();
            public Focas1.ODBSPDI_data di2 = new Focas1.ODBSPDI_data();
            public Focas1.ODBSPDI_data di3 = new Focas1.ODBSPDI_data();
            public Focas1.ODBSPDI_data di4 = new Focas1.ODBSPDI_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPDO_data
        {
            public byte sgnl1;
            public byte sgnl2;
            public byte sgnl3;
            public byte sgnl4;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPDO
        {
            public Focas1.ODBSPDO_data do1 = new Focas1.ODBSPDO_data();
            public Focas1.ODBSPDO_data do2 = new Focas1.ODBSPDO_data();
            public Focas1.ODBSPDO_data do3 = new Focas1.ODBSPDO_data();
            public Focas1.ODBSPDO_data do4 = new Focas1.ODBSPDO_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWAVE_io
        {
            public byte adr;
            public byte bit;
            public short no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWAVE_axis
        {
            public short axis;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBWAVE_u
        {
            [FieldOffset(0)]
            public Focas1.IODBWAVE_io io = new Focas1.IODBWAVE_io();
            [FieldOffset(0)]
            public Focas1.IODBWAVE_axis axis = new Focas1.IODBWAVE_axis();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWAVE_ch_data
        {
            public Focas1.IODBWAVE_u u = new Focas1.IODBWAVE_u();
            public short kind;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWAVE_ch
        {
            public Focas1.IODBWAVE_ch_data ch1 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch2 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch3 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch4 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch5 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch6 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch7 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch8 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch9 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch10 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch11 = new Focas1.IODBWAVE_ch_data();
            public Focas1.IODBWAVE_ch_data ch12 = new Focas1.IODBWAVE_ch_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWAVE
        {
            public Focas1.IODBWAVE_ch ch = new Focas1.IODBWAVE_ch();
            public short condition;
            public char trg_adr;
            public byte trg_bit;
            public short trg_no;
            public short delay;
            public short t_range;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWVPRM_io
        {
            public byte adr;
            public byte bit;
            public short no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWVPRM_axis
        {
            public short axis;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBWVPRM_u
        {
            [FieldOffset(0)]
            public Focas1.IODBWVPRM_io io = new Focas1.IODBWVPRM_io();
            [FieldOffset(0)]
            public Focas1.IODBWVPRM_axis axis = new Focas1.IODBWVPRM_axis();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWVPRM_ch_data
        {
            public Focas1.IODBWVPRM_u u = new Focas1.IODBWVPRM_u();
            public short kind;
            public int reserve2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWVPRM_ch
        {
            public Focas1.IODBWVPRM_ch_data ch1 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch2 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch3 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch4 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch5 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch6 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch7 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch8 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch9 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch10 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch11 = new Focas1.IODBWVPRM_ch_data();
            public Focas1.IODBWVPRM_ch_data ch12 = new Focas1.IODBWVPRM_ch_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWVPRM
        {
            public Focas1.IODBWVPRM_ch ch = new Focas1.IODBWVPRM_ch();
            public short condition;
            public byte trg_adr;
            public byte trg_bit;
            public short trg_no;
            public short reserve1;
            public int delay;
            public int t_range;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBWVDT_io
        {
            public byte adr;
            public byte bit;
            public short no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBWVDT_axis
        {
            public short axis;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class ODBWVDT_u
        {
            [FieldOffset(0)]
            public Focas1.ODBWVDT_io io = new Focas1.ODBWVDT_io();
            [FieldOffset(0)]
            public Focas1.ODBWVDT_axis axis = new Focas1.ODBWVDT_axis();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBWVDT
        {
            public Focas1.ODBWVDT_u u = new Focas1.ODBWVDT_u();
            public short channel;
            public short kind;
            public byte year;
            public byte month;
            public byte day;
            public byte hour;
            public byte minute;
            public byte second;
            public short t_cycle;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8192)]
            public short[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBRMTPRM_alm
        {
            public short no;
            public sbyte axis;
            public byte type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBRMTPRM_io
        {
            public char adr;
            public byte bit;
            public short no;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBRMTPRM_trg
        {
            [FieldOffset(0)]
            public Focas1.IODBRMTPRM_alm alm = new Focas1.IODBRMTPRM_alm();
            [FieldOffset(0)]
            public Focas1.IODBRMTPRM_io io = new Focas1.IODBRMTPRM_io();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBRMTPRM_smpl
        {
            public char adr;
            public byte bit;
            public short no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBRMTPRM1
        {
            public Focas1.IODBRMTPRM_smpl ampl1 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl2 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl3 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl4 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl5 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl6 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl7 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl8 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl9 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl10 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl11 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl12 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl13 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl14 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl15 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl16 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl17 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl18 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl19 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl20 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl21 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl22 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl23 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl24 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl25 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl26 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl27 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl28 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl29 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl30 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl31 = new Focas1.IODBRMTPRM_smpl();
            public Focas1.IODBRMTPRM_smpl ampl32 = new Focas1.IODBRMTPRM_smpl();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBRMTPRM
        {
            public Focas1.IODBRMTPRM_trg trg = new Focas1.IODBRMTPRM_trg();
            public Focas1.IODBRMTPRM1 ampl = new Focas1.IODBRMTPRM1();
            public short condition;
            public short reserve;
            public int delay;
            public short wv_intrvl;
            public short io_intrvl;
            public short kind1;
            public short kind2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBRMTDT
        {
            public short channel;
            public short kind;
            public byte year;
            public byte month;
            public byte day;
            public byte hour;
            public byte minute;
            public byte second;
            public short t_intrvl;
            public short trg_data;
            public int ins_ptr;
            public short t_delta;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1917)]
            public short[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSIGAD
        {
            public byte adr;
            public byte reserve;
            public short no;
            public short size;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMGRP_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
            public string m_name = new string(' ', 21);
            public int m_code;
            public short grp_no;
            public byte dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMGRP
        {
            public Focas1.ODBMGRP_data mgrp1 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp2 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp3 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp4 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp5 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp6 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp7 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp8 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp9 = new Focas1.ODBMGRP_data();
            public Focas1.ODBMGRP_data mgrp10 = new Focas1.ODBMGRP_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBMGRP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 500)]
            public short[] group = new short[500];
            public short s_no;
            public short dummy;
            public short num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBEXEM_data
        {
            public int no;
            public short flag;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBEXEM1
        {
            public Focas1.ODBEXEM_data m_code1 = new Focas1.ODBEXEM_data();
            public Focas1.ODBEXEM_data m_code2 = new Focas1.ODBEXEM_data();
            public Focas1.ODBEXEM_data m_code3 = new Focas1.ODBEXEM_data();
            public Focas1.ODBEXEM_data m_code4 = new Focas1.ODBEXEM_data();
            public Focas1.ODBEXEM_data m_code5 = new Focas1.ODBEXEM_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBEXEM
        {
            public Focas1.ODBEXEM1 m_code = new Focas1.ODBEXEM1();
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
            public string m_name = new string(' ', 21);
            public short grp_no;
            public short mem_no;
            public byte dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class M_CODE_data
        {
            public int no;
            public short flag;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class M_CODE1
        {
            public Focas1.M_CODE_data m_code1 = new Focas1.M_CODE_data();
            public Focas1.M_CODE_data m_code2 = new Focas1.M_CODE_data();
            public Focas1.M_CODE_data m_code3 = new Focas1.M_CODE_data();
            public Focas1.M_CODE_data m_code4 = new Focas1.M_CODE_data();
            public Focas1.M_CODE_data m_code5 = new Focas1.M_CODE_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBRSTRM
        {
            public Focas1.M_CODE1 m_code = new Focas1.M_CODE1();
            public short grp_no;
            public short mem_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPTIME_data
        {
            public int prg_no;
            public short hour;
            public byte minute;
            public byte second;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPTIME1
        {
            public Focas1.ODBPTIME_data data1 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data2 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data3 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data4 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data5 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data6 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data7 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data8 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data9 = new Focas1.ODBPTIME_data();
            public Focas1.ODBPTIME_data data10 = new Focas1.ODBPTIME_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPTIME
        {
            public Focas1.ODBPTIME1 data = new Focas1.ODBPTIME1();
            public short num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class PRGDIRTM_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
            public string comment = new string(' ', 51);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
            public string cuttime = new string(' ', 13);
            public int prg_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class PRGDIRTM
        {
            public Focas1.PRGDIRTM_data data1 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data2 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data3 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data4 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data5 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data6 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data7 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data8 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data9 = new Focas1.PRGDIRTM_data();
            public Focas1.PRGDIRTM_data data10 = new Focas1.PRGDIRTM_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class PRGDIR2_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
            public string comment = new string(' ', 51);
            public short number;
            public int length;
            public byte dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class PRGDIR2
        {
            public Focas1.PRGDIR2_data dir1 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir2 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir3 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir4 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir5 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir6 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir7 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir8 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir9 = new Focas1.PRGDIR2_data();
            public Focas1.PRGDIR2_data dir10 = new Focas1.PRGDIR2_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class DIR3_MDATE
        {
            public short year;
            public short month;
            public short day;
            public short hour;
            public short minute;
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class DIR3_CDATE
        {
            public short year;
            public short month;
            public short day;
            public short hour;
            public short minute;
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class PRGDIR3_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string comment = new string(' ', 52);
            public Focas1.DIR3_MDATE mdate = new Focas1.DIR3_MDATE();
            public Focas1.DIR3_CDATE cdate = new Focas1.DIR3_CDATE();
            public int number;
            public int length;
            public int page;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class PRGDIR3
        {
            public Focas1.PRGDIR3_data dir1 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir2 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir3 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir4 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir5 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir6 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir7 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir8 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir9 = new Focas1.PRGDIR3_data();
            public Focas1.PRGDIR3_data dir10 = new Focas1.PRGDIR3_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBCPRM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
            public string NcApli = new string(' ', 65);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
            public string HostApli = new string(' ', 65);
            public byte Dummy1;
            public byte Dummy2;
            public uint StatPstv;
            public uint StatNgtv;
            public uint Statmask;
            public uint AlarmStat;
            public uint PsclHaddr;
            public uint PsclLaddr;
            public ushort SvcMode1;
            public ushort SvcMode2;
            public int FileTout;
            public int RemTout;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBINT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public int[] data = new int[24];
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBWCSF
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] data = new int[8];
            public short datano;
            public short type;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBOMIF
        {
            public ushort om_max;
            public ushort om_sum;
            public ushort om_char;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBOMHIS_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string om_msg = new string(' ', 256);
            public short om_no;
            public short year;
            public short month;
            public short day;
            public short hour;
            public short minute;
            public short second;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBOMHIS
        {
            public Focas1.ODBOMHIS_data omhis1 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis2 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis3 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis4 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis5 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis6 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis7 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis8 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis9 = new Focas1.ODBOMHIS_data();
            public Focas1.ODBOMHIS_data omhis10 = new Focas1.ODBOMHIS_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBBTO
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] ofs = new int[18];
            public short datano_s;
            public short type;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBBTLINF
        {
            public short ofs_type;
            public short use_no;
            public short sub_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBBAXIS
        {
            public short flag;
            public short command;
            public ushort speed;
            public int sub_data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSYSS
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series1 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series2 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series3 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series4 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series5 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series6 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series7 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series8 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series9 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series10 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series11 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series12 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series13 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series14 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series15 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series16 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version1 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version2 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version3 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version4 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version5 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version6 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version7 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version8 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version9 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version10 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version11 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version12 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version13 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version14 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version15 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version16 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string boot_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string boot_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string servo_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string servo_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string ladder_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string ladder_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrlib_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrlib_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrapl_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrapl_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl1_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl1_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl2_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl2_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl3_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl3_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exelib_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exelib_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exeapl_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exeapl_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string int_vga_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string int_vga_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string out_vga_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string out_vga_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmm_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmm_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_mng_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_mng_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shin_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shin_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shout_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shout_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_c_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_c_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_edit_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_edit_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_mng_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_mng_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_apl_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_apl_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl4_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl4_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr2_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr2_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr3_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr3_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string eth_boot_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string eth_boot_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] slot_no_p;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] slot_no_l;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] module_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] soft_id;
            public short soft_inst;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] reserve;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSYSS2
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series1 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series2 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series3 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series4 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series5 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series6 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series7 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series8 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series9 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series10 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series11 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series12 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series13 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series14 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series15 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_series16 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version1 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version2 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version3 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version4 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version5 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version6 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version7 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version8 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version9 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version10 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version11 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version12 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version13 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version14 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version15 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string soft_version16 = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string boot_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string boot_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string servo_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string servo_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string ladder_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string ladder_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrlib_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrlib_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrapl_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcrapl_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl1_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl1_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl2_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl2_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl3_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl3_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exelib_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exelib_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exeapl_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string c_exeapl_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string int_vga_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string int_vga_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string out_vga_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string out_vga_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmm_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmm_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_mng_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_mng_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shin_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shin_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shout_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_shout_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_c_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_c_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_edit_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string pmc_edit_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_mng_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_mng_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_apl_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string lddr_apl_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl4_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string spl4_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr2_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr2_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr3_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string mcr3_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string eth_boot_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string eth_boot_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string embEthe_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string embEthe_ver = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] slot_no_p;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] slot_no_l;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] module_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] soft_id;
            public short soft_inst;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] reserve;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 190)]
            public byte[] reserve2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMDLC
        {
            public short from;
            public short dram;
            public short sram;
            public short pmc;
            public short crtc;
            public short servo12;
            public short servo34;
            public short servo56;
            public short servo78;
            public short sic;
            public short pos_lsi;
            public short hi_aio;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public short[] reserve;
            public short drmmrc;
            public short drmarc;
            public short pmcmrc;
            public short dmaarc;
            public short iopt;
            public short hdiio;
            public short gm2gr1;
            public short crtgr2;
            public short gm1gr2;
            public short gm2gr2;
            public short cmmrb;
            public short sv5axs;
            public short sv7axs;
            public short sicaxs;
            public short posaxs;
            public short hamaxs;
            public short romr64;
            public short srmr64;
            public short dr1r64;
            public short dr2r64;
            public short iopio2;
            public short hdiio2;
            public short cmmrb2;
            public short romfap;
            public short srmfap;
            public short drmfap;
            public short drmare;
            public short pmcmre;
            public short dmaare;
            public short frmbgg;
            public short drmbgg;
            public short asrbgg;
            public short edtpsc;
            public short slcpsc;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
            public short[] reserve2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSCD_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public short[] reserve = new short[5];
            public short slct;
            public int feed;
            public short power;
            public short freq;
            public short duty;
            public short g_press;
            public short g_kind;
            public short g_ready_t;
            public short displace;
            public int supple;
            public short edge_slt;
            public short appr_slt;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPSCD
        {
            public Focas1.IODBPSCD_data data1 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data2 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data3 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data4 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data5 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data6 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data7 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data8 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data9 = new Focas1.IODBPSCD_data();
            public Focas1.IODBPSCD_data data10 = new Focas1.IODBPSCD_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPIRC_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public short[] reserve = new short[4];
            public short slct;
            public short power;
            public short freq;
            public short duty;
            public short i_freq;
            public short i_duty;
            public short step_t;
            public short step_sum;
            public int pier_t;
            public short g_press;
            public short g_kind;
            public short g_time;
            public short def_pos;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPIRC
        {
            public Focas1.IODBPIRC_data data1 = new Focas1.IODBPIRC_data();
            public Focas1.IODBPIRC_data data2 = new Focas1.IODBPIRC_data();
            public Focas1.IODBPIRC_data data3 = new Focas1.IODBPIRC_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBEDGE_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public short[] reserve = new short[5];
            public short slct;
            public short angle;
            public short power;
            public short freq;
            public short duty;
            public int pier_t;
            public short g_press;
            public short g_kind;
            public int r_len;
            public short r_feed;
            public short r_freq;
            public short r_duty;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBEDGE
        {
            public Focas1.IODBEDGE_data data1 = new Focas1.IODBEDGE_data();
            public Focas1.IODBEDGE_data data2 = new Focas1.IODBEDGE_data();
            public Focas1.IODBEDGE_data data3 = new Focas1.IODBEDGE_data();
            public Focas1.IODBEDGE_data data4 = new Focas1.IODBEDGE_data();
            public Focas1.IODBEDGE_data data5 = new Focas1.IODBEDGE_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSLOP_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public short[] upsp = new short[10];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public short[] dwsp = new short[10];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public short[] reserve = new short[10];
            public int slct;
            public int upleng;
            public int dwleng;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSLOP
        {
            public Focas1.IODBSLOP_data data1 = new Focas1.IODBSLOP_data();
            public Focas1.IODBSLOP_data data2 = new Focas1.IODBSLOP_data();
            public Focas1.IODBSLOP_data data3 = new Focas1.IODBSLOP_data();
            public Focas1.IODBSLOP_data data4 = new Focas1.IODBSLOP_data();
            public Focas1.IODBSLOP_data data5 = new Focas1.IODBSLOP_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBLPWDT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public short[] reserve = new short[6];
            public short slct;
            public short dty_const;
            public short dty_min;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBLOPDT
        {
            public short slct;
            public short pwr_mon;
            public short pwr_ofs;
            public short pwr_act;
            public int feed_act;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public short[] reserve;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBLAGSL
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public short[] reserve = new short[6];
            public short slct;
            public short ag_slt;
            public short agflow_slt;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class GASFLOW
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] reserve = new short[3];
            public short slct;
            public short pre_time;
            public short pre_press;
            public short proc_press;
            public short end_time;
            public short end_press;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBLAGST
        {
            public Focas1.GASFLOW data1 = new Focas1.GASFLOW();
            public Focas1.GASFLOW data2 = new Focas1.GASFLOW();
            public Focas1.GASFLOW data3 = new Focas1.GASFLOW();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBLEGPR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public short[] reserve = new short[5];
            public short slct;
            public short power;
            public short freq;
            public short duty;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBLPCPR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public short[] reserve = new short[4];
            public short slct;
            public short power;
            public short freq;
            public short duty;
            public int time;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBLCMDT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public short[] reserve = new short[7];
            public short slct;
            public int feed;
            public short power;
            public short freq;
            public short duty;
            public short g_kind;
            public short g_ready_t;
            public short g_press;
            public short error;
            public int dsplc;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBLACTN
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public short[] reserve = new short[5];
            public short slct;
            public short act_proc;
            public short act_pirce;
            public short act_slop;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBLCMMT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 25)]
            public string comment = new string(' ', 25);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPWOFST_data
        {
            public int pwratio;
            public int rfvolt;
            public ushort year;
            public ushort month;
            public ushort day;
            public ushort hour;
            public ushort minute;
            public ushort second;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPWOFST
        {
            public Focas1.ODBPWOFST_data data1 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data2 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data3 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data4 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data5 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data6 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data7 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data8 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data9 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data10 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data11 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data12 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data13 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data14 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data15 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data16 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data17 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data18 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data19 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data20 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data21 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data22 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data23 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data24 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data25 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data26 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data27 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data28 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data29 = new Focas1.ODBPWOFST_data();
            public Focas1.ODBPWOFST_data data30 = new Focas1.ODBPWOFST_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMNGTIME_data
        {
            public uint life;
            public uint total;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMNGTIME
        {
            public Focas1.IODBMNGTIME_data data1 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data2 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data3 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data4 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data5 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data6 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data7 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data8 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data9 = new Focas1.IODBMNGTIME_data();
            public Focas1.IODBMNGTIME_data data10 = new Focas1.IODBMNGTIME_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDISCHRG
        {
            public ushort aps;
            public ushort year;
            public ushort month;
            public ushort day;
            public ushort hour;
            public ushort minute;
            public ushort second;
            public short hpc;
            public short hfq;
            public short hdt;
            public short hpa;
            public int hce;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] rfi;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] rfv;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dci;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dcv;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dcw;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDISCHRGALM_data
        {
            public ushort year;
            public ushort month;
            public ushort day;
            public ushort hour;
            public ushort minute;
            public ushort second;
            public int almnum;
            public uint psec;
            public short hpc;
            public short hfq;
            public short hdt;
            public short hpa;
            public int hce;
            public ushort asq;
            public ushort psu;
            public ushort aps;
            public short dummy;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] rfi;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] rfv;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dci;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dcv;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dcw;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] almcd;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBDISCHRGALM
        {
            public Focas1.ODBDISCHRGALM_data data1 = new Focas1.ODBDISCHRGALM_data();
            public Focas1.ODBDISCHRGALM_data data2 = new Focas1.ODBDISCHRGALM_data();
            public Focas1.ODBDISCHRGALM_data data3 = new Focas1.ODBDISCHRGALM_data();
            public Focas1.ODBDISCHRGALM_data data4 = new Focas1.ODBDISCHRGALM_data();
            public Focas1.ODBDISCHRGALM_data data5 = new Focas1.ODBDISCHRGALM_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class TIMER_DATE
        {
            public short year;
            public short month;
            public short date;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class TIMER_TIME
        {
            public short hour;
            public short minute;
            public short second;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBTIMER
        {
            [FieldOffset(4)]
            public Focas1.TIMER_DATE date = new Focas1.TIMER_DATE();
            [FieldOffset(4)]
            public Focas1.TIMER_TIME time = new Focas1.TIMER_TIME();
            [FieldOffset(0)]
            public short type;
            [FieldOffset(2)]
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTIME
        {
            public int minute;
            public int msec;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLCTL
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] total_punch = new int[2];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public short[] reserve = new short[11];
            public short slct;
            public short used_tool;
            public short turret_indx;
            public int zero_tl_no;
            public int t_axis_move;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLDT_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] reserve = new int[3];
            public short slct;
            public int tool_no;
            public int x_axis_ofs;
            public int y_axis_ofs;
            public int turret_pos;
            public int chg_tl_no;
            public int punch_count;
            public int tool_life;
            public int m_tl_radius;
            public int m_tl_angle;
            public byte tl_shape;
            public int tl_size_i;
            public int tl_size_j;
            public int tl_angle;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLDT
        {
            public Focas1.IODBTLDT_data data1 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data2 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data3 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data4 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data5 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data6 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data7 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data8 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data9 = new Focas1.IODBTLDT_data();
            public Focas1.IODBTLDT_data data10 = new Focas1.IODBTLDT_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMLTTL_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public int[] reserve = new int[7];
            public short slct;
            public short m_tl_no;
            public int m_tl_radius;
            public int m_tl_angle;
            public int x_axis_ofs;
            public int y_axis_ofs;
            public byte tl_shape;
            public int tl_size_i;
            public int tl_size_j;
            public int tl_angle;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMLTTL
        {
            public Focas1.IODBMLTTL_data data1 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data2 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data3 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data4 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data5 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data6 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data7 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data8 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data9 = new Focas1.IODBMLTTL_data();
            public Focas1.IODBMLTTL_data data10 = new Focas1.IODBMLTTL_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMTAP_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public int[] reserve = new int[11];
            public short slct;
            public int tool_no;
            public int x_axis_ofs;
            public int y_axis_ofs;
            public int punch_count;
            public int tool_life;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBMTAP
        {
            public Focas1.IODBMTAP_data data1 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data2 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data3 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data4 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data5 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data6 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data7 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data8 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data9 = new Focas1.IODBMTAP_data();
            public Focas1.IODBMTAP_data data10 = new Focas1.IODBMTAP_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPTLINF
        {
            public short tld_max;
            public short mlt_max;
            public short reserve;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] tld_size;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] mlt_size;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public short[] reserves;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSAFE_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] data = new int[3];
            public short slct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSAFE
        {
            public Focas1.IODBSAFE_data data1 = new Focas1.IODBSAFE_data();
            public Focas1.IODBSAFE_data data2 = new Focas1.IODBSAFE_data();
            public Focas1.IODBSAFE_data data3 = new Focas1.IODBSAFE_data();
            public Focas1.IODBSAFE_data data4 = new Focas1.IODBSAFE_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLZN_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] data = new int[12];
            public short slct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBTLZN
        {
            public Focas1.IODBTLZN_data data1 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data2 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data3 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data4 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data5 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data6 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data7 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data8 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data9 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data10 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data11 = new Focas1.IODBTLZN_data();
            public Focas1.IODBTLZN_data data12 = new Focas1.IODBTLZN_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBACTTLZN
        {
            public short act_no;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBBRS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dest;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] dist;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBROFS
        {
            public short mode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] pln_axes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] ofsvct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBLOFS
        {
            public short mode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] ofsvct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBFIX
        {
            public short mode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] pln_axes;
            public short drl_axes;
            public int i_pos;
            public int r_pos;
            public int z_pos;
            public int cmd_cnt;
            public int act_cnt;
            public int cut;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] shift;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBROT
        {
            public short mode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] pln_axes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] center;
            public int angle;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODB3DCD
        {
            public short mode;
            public short dno;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] cd_axes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] center;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] direct;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] angle;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBMIR
        {
            public short mode;
            public int mir_flag;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] mir_pos;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSCL
        {
            public short mode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] center;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] magnif;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODB3DTO
        {
            public short mode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] ofs_axes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] ofsvct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPOFS
        {
            public short mode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] ofsvct;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBHPST
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public int[] reserve = new int[7];
            public short slct;
            public short hpcc;
            public short multi;
            public short ovr1;
            public short ign_f;
            public short foward;
            public int max_f;
            public short ovr2;
            public short ovr3;
            public short ovr4;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBHPPR_tune
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public int[] reserve = new int[5];
            public short slct;
            public short diff;
            public short fine;
            public short acc_lv;
            public int max_f;
            public short bipl;
            public short aipl;
            public int corner;
            public short clamp;
            public int radius;
            public int max_cf;
            public int min_cf;
            public int foward;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBHPPR
        {
            public Focas1.IODBHPPR_tune tune1 = new Focas1.IODBHPPR_tune();
            public Focas1.IODBHPPR_tune tune2 = new Focas1.IODBHPPR_tune();
            public Focas1.IODBHPPR_tune tune3 = new Focas1.IODBHPPR_tune();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBHPAC_tune
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] reserve = new int[8];
            public short slct;
            public short diff;
            public short fine;
            public short acc_lv;
            public int bipl;
            public short aipl;
            public int corner;
            public int clamp;
            public int c_acc;
            public int foward;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBHPAC
        {
            public Focas1.IODBHPAC_tune tune1 = new Focas1.IODBHPAC_tune();
            public Focas1.IODBHPAC_tune tune2 = new Focas1.IODBHPAC_tune();
            public Focas1.IODBHPAC_tune tune3 = new Focas1.IODBHPAC_tune();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODB3DHDL_data
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public short[] axes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public int[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODB3DHDL
        {
            public Focas1.ODB3DHDL_data data1 = new Focas1.ODB3DHDL_data();
            public Focas1.ODB3DHDL_data data2 = new Focas1.ODB3DHDL_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODB3DPLS_data
        {
            public int right_angle_x;
            public int right_angle_y;
            public int tool_axis;
            public int tool_tip_a_b;
            public int tool_tip_c;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODB3DPLS
        {
            public Focas1.ODB3DPLS_data pls1 = new Focas1.ODB3DPLS_data();
            public Focas1.ODB3DPLS_data pls2 = new Focas1.ODB3DPLS_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBAXISNAME_data
        {
            public byte name;
            public byte suff;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBAXISNAME
        {
            public Focas1.ODBAXISNAME_data data1 = new Focas1.ODBAXISNAME_data();
            public Focas1.ODBAXISNAME_data data2 = new Focas1.ODBAXISNAME_data();
            public Focas1.ODBAXISNAME_data data3 = new Focas1.ODBAXISNAME_data();
            public Focas1.ODBAXISNAME_data data4 = new Focas1.ODBAXISNAME_data();
            public Focas1.ODBAXISNAME_data data5 = new Focas1.ODBAXISNAME_data();
            public Focas1.ODBAXISNAME_data data6 = new Focas1.ODBAXISNAME_data();
            public Focas1.ODBAXISNAME_data data7 = new Focas1.ODBAXISNAME_data();
            public Focas1.ODBAXISNAME_data data8 = new Focas1.ODBAXISNAME_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPDLNAME_data
        {
            public byte name;
            public byte suff1;
            public byte suff2;
            public byte suff3;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSPDLNAME
        {
            public Focas1.ODBSPDLNAME_data data1 = new Focas1.ODBSPDLNAME_data();
            public Focas1.ODBSPDLNAME_data data2 = new Focas1.ODBSPDLNAME_data();
            public Focas1.ODBSPDLNAME_data data3 = new Focas1.ODBSPDLNAME_data();
            public Focas1.ODBSPDLNAME_data data4 = new Focas1.ODBSPDLNAME_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBUNSOLIC_pmc
        {
            public short type;
            public short rdaddr;
            public short rdno;
            public short rdsize;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBUNSOLIC_dmy
        {
            public short type;
            public int dummy1;
            public short dummy2;
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBUNSOLIC_rddata
        {
            [FieldOffset(0)]
            public Focas1.IODBUNSOLIC_pmc pmc = new Focas1.IODBUNSOLIC_pmc();
            [FieldOffset(0)]
            public Focas1.IODBUNSOLIC_dmy dmy = new Focas1.IODBUNSOLIC_dmy();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBUNSOLIC
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string ipaddr = new string(' ', 16);
            public Focas1.IODBUNSOLIC_rddata rddata1 = new Focas1.IODBUNSOLIC_rddata();
            public Focas1.IODBUNSOLIC_rddata rddata2 = new Focas1.IODBUNSOLIC_rddata();
            public Focas1.IODBUNSOLIC_rddata rddata3 = new Focas1.IODBUNSOLIC_rddata();
            public ushort port;
            public short reqaddr;
            public short pmcno;
            public short retry;
            public short timeout;
            public short alivetime;
            public short setno;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBUNSOLICMSG_msg
        {
            public short rdsize;
            [MarshalAs(UnmanagedType.AsAny)]
            public object data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBUNSOLICMSG1
        {
            public Focas1.IDBUNSOLICMSG_msg msg1 = new Focas1.IDBUNSOLICMSG_msg();
            public Focas1.IDBUNSOLICMSG_msg msg2 = new Focas1.IDBUNSOLICMSG_msg();
            public Focas1.IDBUNSOLICMSG_msg msg3 = new Focas1.IDBUNSOLICMSG_msg();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBUNSOLICMSG
        {
            public Focas1.IDBUNSOLICMSG1 msg = new Focas1.IDBUNSOLICMSG1();
            public short getno;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBIDINF
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 60)]
            public string id_name = new string(' ', 60);
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] unit = new byte[12];
            public int id_no;
            public short drv_no;
            public short acc_element;
            public short err_general;
            public short err_id_no;
            public short err_id_name;
            public short err_attr;
            public short err_unit;
            public short err_min_val;
            public short err_max_val;
            public short id_name_len;
            public short id_name_max;
            public int attr;
            public short unit_len;
            public short unit_max;
            public int min_val;
            public int max_val;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSRCSST
        {
            public short acc_element;
            public short err_general;
            public short err_id_no;
            public short err_attr;
            public short err_op_data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSRCSLYT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string axis_name = new string(' ', 8);
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public short[] spndl;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] servo;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBCHAN_data
        {
            public byte chno;
            public sbyte axis;
            public int datanum;
            public ushort datainf;
            public short dataadr;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBCHAN
        {
            public Focas1.IDBCHAN_data data1 = new Focas1.IDBCHAN_data();
            public Focas1.IDBCHAN_data data2 = new Focas1.IDBCHAN_data();
            public Focas1.IDBCHAN_data data3 = new Focas1.IDBCHAN_data();
            public Focas1.IDBCHAN_data data4 = new Focas1.IDBCHAN_data();
            public Focas1.IDBCHAN_data data5 = new Focas1.IDBCHAN_data();
            public Focas1.IDBCHAN_data data6 = new Focas1.IDBCHAN_data();
            public Focas1.IDBCHAN_data data7 = new Focas1.IDBCHAN_data();
            public Focas1.IDBCHAN_data data8 = new Focas1.IDBCHAN_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSD
        {
            public IntPtr chadata;
            public IntPtr count;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IDBSFBCHAN
        {
            public byte chno;
            public sbyte axis;
            public ushort shift;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBCAXIS
        {
            public short dummy;
            public short type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public sbyte[] data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class CFILEINFO_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string fname = new string(' ', 12);
            public int file_size;
            public int file_attr;
            public short year;
            public short month;
            public short day;
            public short hour;
            public short minute;
            public short second;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class CFILEINFO
        {
            public Focas1.CFILEINFO_data data1 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data2 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data3 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data4 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data5 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data6 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data7 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data8 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data9 = new Focas1.CFILEINFO_data();
            public Focas1.CFILEINFO_data data10 = new Focas1.CFILEINFO_data();
        }

        [StructLayout(LayoutKind.Explicit)]
        public class IODBPMC
        {
            [FieldOffset(0)]
            public short type_a;
            [FieldOffset(2)]
            public short type_d;
            [FieldOffset(4)]
            public short datano_s;
            [FieldOffset(6)]
            public short datano_e;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            [FieldOffset(8)]
            public byte[] cdata;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            [FieldOffset(8)]
            public short[] idata;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            [FieldOffset(8)]
            public int[] ldata;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCINF_info
        {
            public char pmc_adr;
            public byte adr_attr;
            public ushort top_num;
            public ushort last_num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCINF1
        {
            public Focas1.ODBPMCINF_info info1 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info2 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info3 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info4 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info5 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info6 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info7 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info8 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info9 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info10 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info11 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info12 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info13 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info14 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info15 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info16 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info17 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info18 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info19 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info20 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info21 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info22 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info23 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info24 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info25 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info26 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info27 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info28 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info29 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info30 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info31 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info32 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info33 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info34 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info35 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info36 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info37 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info38 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info39 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info40 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info41 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info42 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info43 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info44 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info45 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info46 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info47 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info48 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info49 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info50 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info51 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info52 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info53 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info54 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info55 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info56 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info57 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info58 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info59 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info60 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info61 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info62 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info63 = new Focas1.ODBPMCINF_info();
            public Focas1.ODBPMCINF_info info64 = new Focas1.ODBPMCINF_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCINF
        {
            public Focas1.ODBPMCINF1 info = new Focas1.ODBPMCINF1();
            public short datano;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPMCCNTL_info
        {
            public byte tbl_prm;
            public byte data_type;
            public ushort data_size;
            public ushort data_dsp;
            public short dummy;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPMCCNTL1
        {
            public Focas1.IODBPMCCNTL_info info1 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info2 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info3 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info4 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info5 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info6 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info7 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info8 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info9 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info10 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info11 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info12 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info13 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info14 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info15 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info16 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info17 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info18 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info19 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info20 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info21 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info22 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info23 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info24 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info25 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info26 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info27 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info28 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info29 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info30 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info31 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info32 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info33 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info34 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info35 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info36 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info37 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info38 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info39 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info40 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info41 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info42 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info43 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info44 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info45 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info46 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info47 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info48 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info49 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info50 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info51 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info52 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info53 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info54 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info55 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info56 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info57 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info58 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info59 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info60 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info61 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info62 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info63 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info64 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info65 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info66 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info67 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info68 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info69 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info70 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info71 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info72 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info73 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info74 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info75 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info76 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info77 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info78 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info79 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info80 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info81 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info82 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info83 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info84 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info85 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info86 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info87 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info88 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info89 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info90 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info91 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info92 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info93 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info94 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info95 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info96 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info97 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info98 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info99 = new Focas1.IODBPMCCNTL_info();
            public Focas1.IODBPMCCNTL_info info100 = new Focas1.IODBPMCCNTL_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPMCCNTL
        {
            public Focas1.IODBPMCCNTL1 info = new Focas1.IODBPMCCNTL1();
            public short datano_s;
            public short dummy;
            public short datano_e;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCALM_data
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string almmsg = new string(' ', 128);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCALM
        {
            public Focas1.ODBPMCALM_data msg1 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg2 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg3 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg4 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg5 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg6 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg7 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg8 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg9 = new Focas1.ODBPMCALM_data();
            public Focas1.ODBPMCALM_data msg10 = new Focas1.ODBPMCALM_data();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCERR
        {
            public short err_no;
            public short err_dtno;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCTITLE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string mtb = new string(' ', 48);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string machine = new string(' ', 48);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string type = new string(' ', 48);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string prgno = new string(' ', 8);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string prgvers = new string(' ', 4);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string prgdraw = new string(' ', 48);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string date = new string(' ', 32);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string design = new string(' ', 48);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string written = new string(' ', 48);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string remarks = new string(' ', 48);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPMCEXT
        {
            public short type_a;
            public short type_d;
            public short datano_s;
            public short datano_e;
            public short err_code;
            public short reserved;
            [MarshalAs(UnmanagedType.AsAny)]
            public object data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCADR_info
        {
            public byte pmc_adr;
            public byte adr_attr;
            public ushort offset;
            public ushort top;
            public ushort num;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCADR1
        {
            public Focas1.ODBPMCADR_info info1 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info2 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info3 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info4 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info5 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info6 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info7 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info8 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info9 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info10 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info11 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info12 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info13 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info14 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info15 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info16 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info17 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info18 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info19 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info20 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info21 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info22 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info23 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info24 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info25 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info26 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info27 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info28 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info29 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info30 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info31 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info32 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info33 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info34 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info35 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info36 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info37 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info38 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info39 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info40 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info41 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info42 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info43 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info44 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info45 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info46 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info47 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info48 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info49 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info50 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info51 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info52 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info53 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info54 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info55 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info56 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info57 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info58 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info59 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info60 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info61 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info62 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info63 = new Focas1.ODBPMCADR_info();
            public Focas1.ODBPMCADR_info info64 = new Focas1.ODBPMCADR_info();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPMCADR
        {
            public Focas1.ODBPMCADR1 info = new Focas1.ODBPMCADR1();
            public uint io_adr;
            public short datano;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBPRFCNF
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string master_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string master_ver = new string(' ', 3);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string slave_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string slave_ver = new string(' ', 3);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
            public string cntl_ser = new string(' ', 5);
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string cntl_ver = new string(' ', 3);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBBUSPRM
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] reserve1 = new byte[6];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] cls2_name = new byte[32];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 62)]
            public byte[] user_data = new byte[62];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
            public byte[] reserve2 = new byte[96];
            public sbyte fdl_add;
            public sbyte baudrate;
            public ushort tsl;
            public ushort min_tsdr;
            public ushort max_tsdr;
            public byte tqui;
            public byte tset;
            public int ttr;
            public sbyte gap;
            public sbyte hsa;
            public sbyte max_retry;
            public byte bp_flag;
            public ushort min_slv_int;
            public ushort poll_tout;
            public ushort data_cntl;
            public short user_dlen;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSLVPRM
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserve1 = new byte[12];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] user_pdata = new byte[32];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 126)]
            public byte[] cnfg_data = new byte[126];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] slv_udata = new byte[30];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] reserve3 = new byte[8];
            public short dis_enb;
            public ushort ident_no;
            public byte slv_flag;
            public byte slv_type;
            public byte slv_stat;
            public byte wd_fact1;
            public byte wd_fact2;
            public byte min_tsdr;
            public char reserve2;
            public byte grp_ident;
            public short user_plen;
            public short cnfg_dlen;
            public short slv_ulen;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSLVPRM2
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserve1 = new byte[12];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 206)]
            public byte[] user_pdata = new byte[206];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 126)]
            public byte[] cnfg_data = new byte[126];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] slv_udata = new byte[30];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] reserve3 = new byte[8];
            public short dis_enb;
            public ushort ident_no;
            public byte slv_flag;
            public byte slv_type;
            public byte slv_stat;
            public byte wd_fact1;
            public byte wd_fact2;
            public byte min_tsdr;
            public sbyte reserve2;
            public byte grp_ident;
            public short user_plen;
            public short cnfg_dlen;
            public short slv_ulen;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBPRFADR
        {
            public byte di_size;
            public byte di_type;
            public ushort di_addr;
            public short reserve1;
            public byte do_size;
            public byte do_type;
            public ushort do_addr;
            public short reserve2;
            public byte dgn_size;
            public byte dgn_type;
            public ushort dgn_addr;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class IODBSLVADR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] reserve = new byte[7];
            public byte slave_no;
            public byte di_size;
            public byte di_type;
            public ushort di_addr;
            public byte do_size;
            public byte do_type;
            public ushort do_addr;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBSLVST
        {
            public byte cnfg_stat;
            public byte prm_stat;
            public sbyte wdg_stat;
            public byte live_stat;
            public short ident_no;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class ODBNODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string node_name = new string(' ', 20);
            public int node_no;
            public int io_base;
            public int status;
            public int cnc_type;
        }
    }
}
