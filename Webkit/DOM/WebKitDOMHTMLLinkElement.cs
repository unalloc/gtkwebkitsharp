//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLLinkElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLLinkElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLLinkElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLLinkElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLLinkElement: GLib.Object
    {
        public WebKitDOMHTMLLinkElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_link_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_type")]
        internal static extern uint webkit_dom_html_link_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_link_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_link_element_get_disabled(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_disabled")]
        internal static extern int webkit_dom_html_link_element_get_disabled(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_disabled(WebKitDOMHTMLLinkElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_disabled")]
        internal static extern void webkit_dom_html_link_element_set_disabled(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_link_element_get_charset(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_charset")]
        internal static extern sbyte* webkit_dom_html_link_element_get_charset(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_charset(WebKitDOMHTMLLinkElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_charset")]
        internal static extern void webkit_dom_html_link_element_set_charset(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_link_element_get_href(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_href")]
        internal static extern sbyte* webkit_dom_html_link_element_get_href(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_href(WebKitDOMHTMLLinkElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_href")]
        internal static extern void webkit_dom_html_link_element_set_href(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_link_element_get_hreflang(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_hreflang")]
        internal static extern sbyte* webkit_dom_html_link_element_get_hreflang(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_hreflang(WebKitDOMHTMLLinkElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_hreflang")]
        internal static extern void webkit_dom_html_link_element_set_hreflang(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_link_element_get_media(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_media")]
        internal static extern sbyte* webkit_dom_html_link_element_get_media(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_media(WebKitDOMHTMLLinkElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_media")]
        internal static extern void webkit_dom_html_link_element_set_media(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_link_element_get_rel(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_rel")]
        internal static extern sbyte* webkit_dom_html_link_element_get_rel(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_rel(WebKitDOMHTMLLinkElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_rel")]
        internal static extern void webkit_dom_html_link_element_set_rel(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_link_element_get_rev(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_rev")]
        internal static extern sbyte* webkit_dom_html_link_element_get_rev(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_rev(WebKitDOMHTMLLinkElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_rev")]
        internal static extern void webkit_dom_html_link_element_set_rev(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_link_element_get_target(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_target")]
        internal static extern sbyte* webkit_dom_html_link_element_get_target(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_link_element_set_target(WebKitDOMHTMLLinkElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_set_target")]
        internal static extern void webkit_dom_html_link_element_set_target(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API WebKitDOMStyleSheet*webkit_dom_html_link_element_get_sheet(WebKitDOMHTMLLinkElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_link_element_get_sheet")]
        internal static extern global::System.IntPtr webkit_dom_html_link_element_get_sheet(global::System.IntPtr self);
    }
}