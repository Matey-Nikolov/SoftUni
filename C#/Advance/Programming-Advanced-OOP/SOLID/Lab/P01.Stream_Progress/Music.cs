using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class Music : IStreamable
    {
        private string _artist;
        private string _album;

        public Music(string artist, string album, int length, int bytesSent)
        {
            this._artist = artist;
            this._artist = album;
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
