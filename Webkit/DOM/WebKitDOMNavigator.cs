//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMNavigator { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMNavigator
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMNavigatorClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMNavigatorClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMNavigator: GLib.Object
    {
        public WebKitDOMNavigator(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_navigator_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_type")]
        internal static extern uint webkit_dom_navigator_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_navigator_get_type());
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_navigator_java_enabled(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_java_enabled")]
        internal static extern int webkit_dom_navigator_java_enabled(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_navigator_get_storage_updates(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_storage_updates")]
        internal static extern void webkit_dom_navigator_get_storage_updates(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_app_code_name(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_app_code_name")]
        internal static extern sbyte* webkit_dom_navigator_get_app_code_name(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_app_name(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_app_name")]
        internal static extern sbyte* webkit_dom_navigator_get_app_name(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_app_version(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_app_version")]
        internal static extern sbyte* webkit_dom_navigator_get_app_version(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_language(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_language")]
        internal static extern sbyte* webkit_dom_navigator_get_language(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_user_agent(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_user_agent")]
        internal static extern sbyte* webkit_dom_navigator_get_user_agent(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_platform(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_platform")]
        internal static extern sbyte* webkit_dom_navigator_get_platform(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMDOMPluginArray*webkit_dom_navigator_get_plugins(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_plugins")]
        internal static extern global::System.IntPtr webkit_dom_navigator_get_plugins(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMDOMMimeTypeArray*webkit_dom_navigator_get_mime_types(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_mime_types")]
        internal static extern global::System.IntPtr webkit_dom_navigator_get_mime_types(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_product(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_product")]
        internal static extern sbyte* webkit_dom_navigator_get_product(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_product_sub(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_product_sub")]
        internal static extern sbyte* webkit_dom_navigator_get_product_sub(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_vendor(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_vendor")]
        internal static extern sbyte* webkit_dom_navigator_get_vendor(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_navigator_get_vendor_sub(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_vendor_sub")]
        internal static extern sbyte* webkit_dom_navigator_get_vendor_sub(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_navigator_get_cookie_enabled(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_cookie_enabled")]
        internal static extern int webkit_dom_navigator_get_cookie_enabled(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_navigator_get_on_line(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_on_line")]
        internal static extern int webkit_dom_navigator_get_on_line(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMGeolocation*webkit_dom_navigator_get_geolocation(WebKitDOMNavigator* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_navigator_get_geolocation")]
        internal static extern global::System.IntPtr webkit_dom_navigator_get_geolocation(global::System.IntPtr self);
    }
}