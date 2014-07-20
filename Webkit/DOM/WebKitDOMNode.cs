//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using Webbed.Core;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMNode { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMNode
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMNodeClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMNodeClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMNode: GLib.Object
    {
        public WebKitDOMNode(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_node_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_type")]
        internal static extern uint webkit_dom_node_get_type();

        public GLib.GType Type
        {
            get
            {
                return  new GLib.GType((IntPtr)webkit_dom_node_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_insert_before(WebKitDOMNode* self, WebKitDOMNode* new_child, WebKitDOMNode* ref_child, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_insert_before")]
        internal static extern global::System.IntPtr webkit_dom_node_insert_before(global::System.IntPtr self, global::System.IntPtr new_child, global::System.IntPtr ref_child, ref global::System.IntPtr error);

        public WebKitDOMNode InsertBefore(WebKitDOMNode new_child, WebKitDOMNode ref_child)
        {
            IntPtr error;
            IntPtr handle = webkit_dom_node_insert_before(this.Handle, new_child.Handle, ref_child.Handle, ref error);            
            if(error != IntPtr.Zero)
                throw new GLib.GException(error);

            return new WebKitDOMNode(handle);
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_replace_child(WebKitDOMNode* self, WebKitDOMNode* new_child, WebKitDOMNode* old_child, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_replace_child")]
        internal static extern global::System.IntPtr webkit_dom_node_replace_child(global::System.IntPtr self, global::System.IntPtr new_child, global::System.IntPtr old_child, ref global::System.IntPtr error);

        public WebKitDOMNode ReplaceChild(WebKitDOMNode new_child, WebKitDOMNode ref_child)
        {
            IntPtr error;
                IntPtr handle = webkit_dom_node_replace_child(this.Handle, new_child.Handle, ref_child.Handle, ref error);
            if(error != IntPtr.Zero)
                throw new GLib.GException(error);
                return new WebKitDOMNode(handle);
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_remove_child(WebKitDOMNode* self, WebKitDOMNode* old_child, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_remove_child")]
        internal static extern global::System.IntPtr webkit_dom_node_remove_child(global::System.IntPtr self, global::System.IntPtr old_child, ref global::System.IntPtr error);

        public WebKitDOMNode RemoveChild(WebKitDOMNode old_child)
        {
            IntPtr error;
                IntPtr handle = webkit_dom_node_remove_child(this.Handle, old_child.Handle, ref error);
                if(error != IntPtr.Zero)
                throw new GLib.GException(error);
                return new WebKitDOMNode(handle);
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_append_child(WebKitDOMNode* self, WebKitDOMNode* new_child, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_append_child")]
        internal static extern global::System.IntPtr webkit_dom_node_append_child(global::System.IntPtr self, global::System.IntPtr new_child, ref global::System.IntPtr error);

        public WebKitDOMNode AppendChild(WebKitDOMNode new_child)
        {
            IntPtr error;
                IntPtr handle = webkit_dom_node_append_child(this.Handle, new_child.Handle, ref error);
                if(error != IntPtr.Zero)
                throw new GLib.GException(error);
                return new WebKitDOMNode(handle);
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_has_child_nodes(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_has_child_nodes")]
        internal static extern bool webkit_dom_node_has_child_nodes(global::System.IntPtr self);

        public bool HasChildNodes
        {
            get
            {
                return webkit_dom_node_has_child_nodes(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_clone_node(WebKitDOMNode* self, gboolean deep)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_clone_node")]
        internal static extern global::System.IntPtr webkit_dom_node_clone_node(global::System.IntPtr self, bool deep);

        public WebKitDOMNode CloneNode(bool deep)
        {
            new WebKitDOMNode(webkit_dom_node_clone_node(this.Handle,deep));
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_node_normalize(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_normalize")]
        internal static extern void webkit_dom_node_normalize(global::System.IntPtr self);

        public void Normalize()
        {
            webkit_dom_node_normalize(this.Handle);
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_is_supported(WebKitDOMNode* self, const gchar* feature, const gchar* version)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet=CharSet.Ansi
            EntryPoint="webkit_dom_node_is_supported")]
        internal static extern bool webkit_dom_node_is_supported(global::System.IntPtr self, string feature, string version);

        public bool IsSupported(string feature, string version)
        {
            return webkit_dom_node_is_supported(this.Handle, feature, version);
        }


        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_has_attributes(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_has_attributes")]
        internal static extern bool webkit_dom_node_has_attributes(global::System.IntPtr self);

        public bool HasAttributes
        {
            get
            {
                return webkit_dom_node_has_attributes(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_is_same_node(WebKitDOMNode* self, WebKitDOMNode* other)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_is_same_node")]
        internal static extern bool webkit_dom_node_is_same_node(global::System.IntPtr self, global::System.IntPtr other);

        public bool IsSameNode(WebKitDOMNode other)
        {
            return webkit_dom_node_is_same_node(this.Handle,other.Handle);
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_is_equal_node(WebKitDOMNode* self, WebKitDOMNode* other)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_is_equal_node")]
        internal static extern int webkit_dom_node_is_equal_node(global::System.IntPtr self, global::System.IntPtr other);

        public bool IsEqualNode(WebKitDOMNode other)
        {
            return webkit_dom_node_is_equal_node(this.Handle, other.Handle);
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_lookup_prefix(WebKitDOMNode* self, const gchar* namespace_uri)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet=CharSet.Ansi
            EntryPoint="webkit_dom_node_lookup_prefix")]
        internal static extern string webkit_dom_node_lookup_prefix(global::System.IntPtr self, string namespace_uri);

        public string LookupPrefix(string namespace_uri)
        {
            return webkit_dom_node_lookup_prefix(this.Handle, namespace_uri);
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_is_default_namespace(WebKitDOMNode* self, const gchar* namespace_uri)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_is_default_namespace")]
        internal static extern bool webkit_dom_node_is_default_namespace(global::System.IntPtr self, global::System.IntPtr namespace_uri);

        public string NodeIsDefaultNamespace(string namespace_uri)
        {
            return webkit_dom_node_is_default_namespace(this.Handle, namespace_uri);
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_lookup_namespace_uri(WebKitDOMNode* self, const gchar* prefix)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_lookup_namespace_uri")]
        internal static extern string webkit_dom_node_lookup_namespace_uri(global::System.IntPtr self, global::System.IntPtr prefix);

        public string LookupPrefix(string prefix)
        {
            return webkit_dom_node_lookup_namespace_uri(this.Handle, prefix);
        }

        // DEBUG: WEBKIT_API gushortwebkit_dom_node_compare_document_position(WebKitDOMNode* self, WebKitDOMNode* other)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_compare_document_position")]
        internal static extern ushort webkit_dom_node_compare_document_position(global::System.IntPtr self, global::System.IntPtr other);

        public ushort CompareDocumentPosition(WebKitDOMNode other)
        {
            return webkit_dom_node_compare_document_position(this.Handle, other.Handle);
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_contains(WebKitDOMNode* self, WebKitDOMNode* other)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_contains")]
        internal static extern bool webkit_dom_node_contains(global::System.IntPtr self, global::System.IntPtr other);

        public bool Contains(WebKitDOMNode other)
        {
            return webkit_dom_node_contains(this.Handle, other.Handle);
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_node_dispatch_event(WebKitDOMNode* self, WebKitDOMEvent* event, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_dispatch_event")]
        internal static extern bool webkit_dom_node_dispatch_event(global::System.IntPtr self, global::System.IntPtr @event, ref global::System.IntPtr error);

        public bool DispatchEvent(WebKitDOMEvent @event)
        {
            IntPtr error;
                IntPtr handle = webkit_dom_node_remove_child(this.Handle, old_child.Handle, ref error);
                if(error != IntPtr.Zero)
                throw new GLib.GException(error);
                return new WebKitDOMNode(handle);
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_get_node_name(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_get_node_name")]
        internal static extern string webkit_dom_node_get_node_name(global::System.IntPtr self);

        public string NodeName{
            get{
                return webkit_dom_node_get_node_name(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_get_node_value(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_get_node_value")]
        internal static extern string webkit_dom_node_get_node_value(global::System.IntPtr self);

        public string NodeValue{
            get{
                return webkit_dom_node_get_node_value(this);
            }
            set{
                IntPtr error;
                    webkit_dom_node_set_node_value(this.Handle,value, &errorHandle);
                    if(error != IntPtr.Zero)
                throw new GLib.GException(error);
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_node_set_node_value(WebKitDOMNode* self, const gchar* value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_set_node_value")]
        internal static extern void webkit_dom_node_set_node_value(global::System.IntPtr self, string value, ref global::System.IntPtr error);

        
        // DEBUG: WEBKIT_API gushortwebkit_dom_node_get_node_type(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_node_type")]
        internal static extern ushort webkit_dom_node_get_node_type(global::System.IntPtr self);

        public ushort NodeType{
            get{
                return webkit_dom_node_get_node_type(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_get_parent_node(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_parent_node")]
        internal static extern global::System.IntPtr webkit_dom_node_get_parent_node(global::System.IntPtr self);

        public WebKitDOMNode ParentNode{
            get{
                IntPtr handle = webkit_dom_node_get_parent_node(this.Handle);
                return new WebKitDOMNode(handle);
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNodeList*webkit_dom_node_get_child_nodes(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_child_nodes")]
        internal static extern global::System.IntPtr webkit_dom_node_get_child_nodes(global::System.IntPtr self);

        public WebKitDOMNodeList ChildNodes{
            get{
                IntPtr handle = webkit_dom_node_get_child_nodes(this.Handle);
                return new WebKitDOMNodeList(handle);
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_get_first_child(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_first_child")]
        internal static extern global::System.IntPtr webkit_dom_node_get_first_child(global::System.IntPtr self);

        public WebKitDOMNode FirstChild{
            get{
                IntPtr handle = webkit_dom_node_get_first_child(this.Handle);
                return new WebKitDOMNode(handle);
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_get_last_child(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_last_child")]
        internal static extern global::System.IntPtr webkit_dom_node_get_last_child(global::System.IntPtr self);

        public WebKitDOMNode LastChild{
            get{
                IntPtr handle = webkit_dom_node_get_last_child(this.Handle);
                return new WebKitDOMNode(handle);
            }
        } 

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_get_previous_sibling(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_previous_sibling")]
        internal static extern global::System.IntPtr webkit_dom_node_get_previous_sibling(global::System.IntPtr self);

        public WebKitDOMNode PreviousSibling{
            get{
                IntPtr handle = webkit_dom_node_get_previous_sibling(this.Handle);
                return new WebKitDOMNode(handle);
            }
        } 

        // DEBUG: WEBKIT_API WebKitDOMNode*webkit_dom_node_get_next_sibling(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_next_sibling")]
        internal static extern global::System.IntPtr webkit_dom_node_get_next_sibling(global::System.IntPtr self);

        public WebKitDOMNode NextSibling{
            get{
                IntPtr handle = webkit_dom_node_get_next_sibling(this.Handle);
                return new WebKitDOMNode(handle);
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMNamedNodeMap*webkit_dom_node_get_attributes(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_attributes")]
        internal static extern global::System.IntPtr webkit_dom_node_get_attributes(global::System.IntPtr self);

        public WebKitDOMNamedNodeMap Attributes{
            get{
                return new WebKitDOMNamedNodeMap(webkit_dom_node_get_attributes(this.Handle));
            }
        }

        // DEBUG: WEBKIT_API WebKitDOMDocument*webkit_dom_node_get_owner_document(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_owner_document")]
        internal static extern global::System.IntPtr webkit_dom_node_get_owner_document(global::System.IntPtr self);

        public WebKitDOMNamedNodeMap OwnerDocument{
            get{
                return new WebKitDOMDocument(webkit_dom_node_get_owner_document(this.Handle));
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_get_namespace_uri(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_get_namespace_uri")]
        internal static extern string webkit_dom_node_get_namespace_uri(global::System.IntPtr self);

        public string OwnerDocument{
            get{
                return webkit_dom_node_get_namespace_uri(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_get_prefix(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_get_prefix")]
        internal static extern string webkit_dom_node_get_prefix(global::System.IntPtr self);

        public string Prefix{
            get{
                return webkit_dom_node_get_prefix(this.Handle);
            }set{
                IntPtr error;
                webkit_dom_node_set_prefix(this.Handle,value,ref error);
                if(error != IntPtr.Zero)
                    throw new GLib.GException(error);
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_node_set_prefix(WebKitDOMNode* self, const gchar* value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_set_prefix")]
        internal static extern void webkit_dom_node_set_prefix(global::System.IntPtr self, string value, ref global::System.IntPtr error);



        // DEBUG: WEBKIT_API gchar*webkit_dom_node_get_local_name(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_get_local_name")]
        internal static extern string webkit_dom_node_get_local_name(global::System.IntPtr self);

        public string LocalName{
            get{
                return webkit_dom_node_get_local_name(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_get_base_uri(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_get_base_uri")]
        internal static extern string webkit_dom_node_get_base_uri(global::System.IntPtr self);

        public string BaseUri{
            get{
                return webkit_dom_node_get_base_uri(this.Handle);
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_node_get_text_content(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_get_text_content")]
        internal static extern string webkit_dom_node_get_text_content(global::System.IntPtr self);

        public string TextContent{
            get{
                return webkit_dom_node_get_text_content(this.Handle);
            }set{
                IntPtr error;
                webkit_dom_node_set_text_content(this.Handle,value,ref error);
                if(error != IntPtr.Zero)
                    throw new GLib.GException(error);
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_dom_node_set_text_content(WebKitDOMNode* self, const gchar* value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,CharSet= CharSet.Ansi,
            EntryPoint="webkit_dom_node_set_text_content")]
        internal static extern void webkit_dom_node_set_text_content(global::System.IntPtr self,string value, ref global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMElement*webkit_dom_node_get_parent_element(WebKitDOMNode* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_node_get_parent_element")]
        internal static extern global::System.IntPtr webkit_dom_node_get_parent_element(global::System.IntPtr self);

        public WebKitDOMElement ParentElement{
            get{
                return new WebKitDOMElement(webkit_dom_node_get_parent_element(this.Handle));
            }
        }
    }
}