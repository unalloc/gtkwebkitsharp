//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMNodeFilter { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMNodeFilter
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMNodeFilterClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMNodeFilterClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMNodeFilter: GLib.Object
    {
        public WebKitDOMNodeFilter(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_node_filter_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_filter_get_type")]
        internal static extern uint webkit_dom_node_filter_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_node_filter_get_type());
            }
        }

        // DEBUG: WEBKIT_API gshortwebkit_dom_node_filter_accept_node(WebKitDOMNodeFilter* self, WebKitDOMNode* n)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_filter_accept_node")]
        internal static extern short webkit_dom_node_filter_accept_node(global::System.IntPtr self, global::System.IntPtr n);
    }
}