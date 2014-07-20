//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLButtonElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLButtonElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLButtonElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLButtonElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLButtonElement: GLib.Object
    {
        public WebKitDOMHTMLButtonElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_button_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_type")]
        internal static extern uint webkit_dom_html_button_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_button_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_button_element_check_validity(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_check_validity")]
        internal static extern int webkit_dom_html_button_element_check_validity(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_custom_validity(WebKitDOMHTMLButtonElement* self, const gchar* error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_custom_validity")]
        internal static extern void webkit_dom_html_button_element_set_custom_validity(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMHTMLFormElement*webkit_dom_html_button_element_get_form(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_form")]
        internal static extern global::System.IntPtr webkit_dom_html_button_element_get_form(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_button_element_get_form_action(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_form_action")]
        internal static extern sbyte* webkit_dom_html_button_element_get_form_action(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_form_action(WebKitDOMHTMLButtonElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_form_action")]
        internal static extern void webkit_dom_html_button_element_set_form_action(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_button_element_get_form_enctype(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_form_enctype")]
        internal static extern sbyte* webkit_dom_html_button_element_get_form_enctype(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_form_enctype(WebKitDOMHTMLButtonElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_form_enctype")]
        internal static extern void webkit_dom_html_button_element_set_form_enctype(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_button_element_get_form_method(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_form_method")]
        internal static extern sbyte* webkit_dom_html_button_element_get_form_method(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_form_method(WebKitDOMHTMLButtonElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_form_method")]
        internal static extern void webkit_dom_html_button_element_set_form_method(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_button_element_get_form_no_validate(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_form_no_validate")]
        internal static extern int webkit_dom_html_button_element_get_form_no_validate(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_form_no_validate(WebKitDOMHTMLButtonElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_form_no_validate")]
        internal static extern void webkit_dom_html_button_element_set_form_no_validate(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_button_element_get_form_target(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_form_target")]
        internal static extern sbyte* webkit_dom_html_button_element_get_form_target(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_form_target(WebKitDOMHTMLButtonElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_form_target")]
        internal static extern void webkit_dom_html_button_element_set_form_target(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API WebKitDOMValidityState*webkit_dom_html_button_element_get_validity(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_validity")]
        internal static extern global::System.IntPtr webkit_dom_html_button_element_get_validity(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_button_element_get_disabled(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_disabled")]
        internal static extern int webkit_dom_html_button_element_get_disabled(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_disabled(WebKitDOMHTMLButtonElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_disabled")]
        internal static extern void webkit_dom_html_button_element_set_disabled(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_button_element_get_autofocus(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_autofocus")]
        internal static extern int webkit_dom_html_button_element_get_autofocus(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_autofocus(WebKitDOMHTMLButtonElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_autofocus")]
        internal static extern void webkit_dom_html_button_element_set_autofocus(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_button_element_get_name(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_name")]
        internal static extern sbyte* webkit_dom_html_button_element_get_name(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_name(WebKitDOMHTMLButtonElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_name")]
        internal static extern void webkit_dom_html_button_element_set_name(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_button_element_get_value(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_value")]
        internal static extern sbyte* webkit_dom_html_button_element_get_value(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_button_element_set_value(WebKitDOMHTMLButtonElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_set_value")]
        internal static extern void webkit_dom_html_button_element_set_value(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_button_element_get_will_validate(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_will_validate")]
        internal static extern int webkit_dom_html_button_element_get_will_validate(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_button_element_get_validation_message(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_validation_message")]
        internal static extern sbyte* webkit_dom_html_button_element_get_validation_message(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMNodeList*webkit_dom_html_button_element_get_labels(WebKitDOMHTMLButtonElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_button_element_get_labels")]
        internal static extern global::System.IntPtr webkit_dom_html_button_element_get_labels(global::System.IntPtr self);
    }
}