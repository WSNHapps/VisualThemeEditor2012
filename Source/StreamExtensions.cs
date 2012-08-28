using System.IO;
using System.Runtime.InteropServices;

namespace VisualThemeEditor2012
{
    public static class StreamExtensions
    {
        public static T ReadStruct<T>( this Stream stream ) where T : struct
        {
            var sz = Marshal.SizeOf( typeof( T ) );
            var buffer = new byte[sz];
            stream.Read( buffer, 0, sz );
            var pinnedBuffer = GCHandle.Alloc( buffer, GCHandleType.Pinned );
            var structure = (T)Marshal.PtrToStructure( pinnedBuffer.AddrOfPinnedObject(), typeof( T ) );
            pinnedBuffer.Free();
            return structure;
        }
    }
}