namespace BookIt.Server.Api.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Time
    {
        public Time(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
        }

        [DataMember]
        public int Hour { get; private set; }
        [DataMember]
        public int Minute { get; private set; }
    }
}