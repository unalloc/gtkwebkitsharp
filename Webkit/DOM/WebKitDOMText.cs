//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMText { WebKitDOMCharacterData parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMText
    {
        // DEBUG: WebKitDOMCharacterData parent_instance
        [FieldOffset(0)]
        public _WebKitDOMCharacterData parent_instance;
    }

    // DEBUG: struct _WebKitDOMTextClass { WebKitDOMCharacterDataClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMTextClass
    {
        // DEBUG: WebKitDOMCharacterDataClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMCharacterDataClass parent_class;
    }

    public unsafe partial class WebKitDOMText: GLib.Object
    {
        public WebKitDOMText(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_text_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_text_get_type")]
        internal static extern uint webkit_dom_text_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_text_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMText*webkit_dom_text_split_text(WebKitDOMText* self, gulong offset, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_text_split_text")]
        internal static extern global::System.IntPtr webkit_dom_text_split_text(global::System.IntPtr self, uint offset, global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMText*webkit_dom_text_replace_whole_text(WebKitDOMText* self, const gchar* content, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_text_replace_whole_text")]
        internal static extern global::System.IntPtr webkit_dom_text_replace_whole_text(global::System.IntPtr self, global::System.IntPtr content, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gchar*webkit_dom_text_get_whole_text(WebKitDOMText* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_text_get_whole_text")]
        internal static extern sbyte* webkit_dom_text_get_whole_text(global::System.IntPtr self);
    }
}