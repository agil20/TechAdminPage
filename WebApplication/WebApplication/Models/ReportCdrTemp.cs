using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ReportCdrTemp
    {
        public int? Id { get; set; }
        public DateTime Datetime { get; set; }
        public int Timestamp { get; set; }
        public string Uid { get; set; }
        public string Clid { get; set; }
        public string Src { get; set; }
        public string Srcname { get; set; }
        public string Srcaddr { get; set; }
        public string Dst { get; set; }
        public string Dstname { get; set; }
        public string Dcontext { get; set; }
        public string Channel { get; set; }
        public string Dstchannel { get; set; }
        public string Srctrunk { get; set; }
        public string Dsttrunk { get; set; }
        public string Lastapp { get; set; }
        public string Lastdata { get; set; }
        public int Duration { get; set; }
        public int Ringduration { get; set; }
        public int Talkduration { get; set; }
        public string Disposition { get; set; }
        public int Amaflags { get; set; }
        public string Calltype { get; set; }
        public string Accountcode { get; set; }
        public string Uniqueid { get; set; }
        public string Didnumber { get; set; }
        public string Dodnumber { get; set; }
        public string Recordfile { get; set; }
        public string Recordpath { get; set; }
        public string Srcchanurl { get; set; }
        public string Dstchanurl { get; set; }
        public string Reasonpartya { get; set; }
        public string Reasonpartyb { get; set; }
        public string Reasonpartyc { get; set; }
        public string Reasonpartyd { get; set; }
        public string Reasonpartye { get; set; }
        public string Reasonpartyf { get; set; }
        public int Displayonweb { get; set; }
        public int? SrcDelCdr { get; set; }
        public int? DstDelCdr { get; set; }
        public int? SrcDelRecording { get; set; }
        public int? DstDelRecording { get; set; }
        public string Srcnameprefix { get; set; }
        public string Dstnameprefix { get; set; }
        public int? MisscallIsread { get; set; }
        public int? In2outbound { get; set; }
        public int? Concurrentcalls { get; set; }
        public int? Videocall { get; set; }
        public int? Rascall { get; set; }
        public int? Tryvideocall { get; set; }
        public int? RateId { get; set; }
    }
}
