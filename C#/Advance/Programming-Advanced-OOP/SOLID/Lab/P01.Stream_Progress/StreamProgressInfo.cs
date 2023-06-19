using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        //private File file;
        private IStreamable _stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable file)
        {
            this._stream = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this._stream.BytesSent * 100) / this._stream.Length;
        }
    }
}
