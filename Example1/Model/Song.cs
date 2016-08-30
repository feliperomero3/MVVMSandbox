using System;

namespace MVVMSandbox.Model
{
    class Song
    {
        // Auto implemented properties
        public string Name { get; set; }
        public int Time { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public DateTime? LastPlayed { get; set; }
    }
}
