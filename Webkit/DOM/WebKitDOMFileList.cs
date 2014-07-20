//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMFileList { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMFileList
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMFileListClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMFileListClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMFileList: GLib.Object
    {
        public WebKitDOMFileList(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_file_list_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_file_list_get_type")]
        internal static extern uint webkit_dom_file_list_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_file_list_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMFile*webkit_dom_file_list_item(WebKitDOMFileList* self, gulong index)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_file_list_item")]
        internal static extern global::System.IntPtr webkit_dom_file_list_item(global::System.IntPtr self, uint index);

        // DEBUG: WEBKIT_API gulongwebkit_dom_file_list_get_length(WebKitDOMFileList* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_file_list_get_length")]
        internal static extern uint webkit_dom_file_list_get_length(global::System.IntPtr self);
    }
}