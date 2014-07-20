//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMComment { WebKitDOMCharacterData parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMComment
    {
        // DEBUG: WebKitDOMCharacterData parent_instance
        [FieldOffset(0)]
        public _WebKitDOMCharacterData parent_instance;
    }

    // DEBUG: struct _WebKitDOMCommentClass { WebKitDOMCharacterDataClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMCommentClass
    {
        // DEBUG: WebKitDOMCharacterDataClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMCharacterDataClass parent_class;
    }

    public unsafe partial class WebKitDOMComment: GLib.Object
    {
        public WebKitDOMComment(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_comment_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_comment_get_type")]
        internal static extern uint webkit_dom_comment_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_comment_get_type());
            }
        }
    }
}