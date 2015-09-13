namespace BookIt.Server.Api.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class TimeFrame
    {
        public TimeFrame(Time start, Time end)
        {
            this.Start = start;
            this.End = end;
        }

        [DataMember]
        public Time Start { get; set; }
        [DataMember]
        public Time End { get; set; }
    }
}