using System;

namespace MVVMSandbox.Model
{
    public class Song
    {
        // Auto implemented properties
        public string Name { get; set; }
        public float Time { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public DateTime? LastPlayed { get; set; }
    }
}
