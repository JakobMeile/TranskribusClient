﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrClient.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrClient.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TrClient.
        /// </summary>
        internal static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to januar
        ///februar
        ///marts
        ///april
        ///maj
        ///juni
        ///juli
        ///august
        ///september
        ///oktober
        ///november
        ///december
        ///jan
        ///feb
        ///febr
        ///mar
        ///apr
        ///jun
        ///jul
        ///aug
        ///sep
        ///sept
        ///okt
        ///oktbr
        ///nov
        ///novbr
        ///dec
        ///decbr
        ///.
        /// </summary>
        internal static string MonthNames {
            get {
                return ResourceManager.GetString("MonthNames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://schema.primaresearch.org/PAGE/gts/pagecontent/2013-07-15.
        /// </summary>
        internal static string PAGENameSpace {
            get {
                return ResourceManager.GetString("PAGENameSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://schema.primaresearch.org/PAGE/gts/pagecontent/2013-07-15 http://schema.primaresearch.org/PAGE/gts/pagecontent/2013-07-15/pagecontent.xsd.
        /// </summary>
        internal static string PAGESchemaLocation {
            get {
                return ResourceManager.GetString("PAGESchemaLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ingenting.
        /// </summary>
        internal static string Test {
            get {
                return ResourceManager.GetString("Test", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon TrClient {
            get {
                object obj = ResourceManager.GetObject("TrClient", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://transkribus.eu/TrpServer/rest/.
        /// </summary>
        internal static string TrpServerBaseAddress {
            get {
                return ResourceManager.GetString("TrpServerBaseAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to collections/list.xml.
        /// </summary>
        internal static string TrpServerPathCollectionsList {
            get {
                return ResourceManager.GetString("TrpServerPathCollectionsList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to collections/_ColID_/list.xml.
        /// </summary>
        internal static string TrpServerPathDocumentsList {
            get {
                return ResourceManager.GetString("TrpServerPathDocumentsList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to auth/login.
        /// </summary>
        internal static string TrpServerPathLogin {
            get {
                return ResourceManager.GetString("TrpServerPathLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to collections/_ColID_/_DocID_/fulldoc.xml.
        /// </summary>
        internal static string TrpServerPathPagesList {
            get {
                return ResourceManager.GetString("TrpServerPathPagesList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to collections/_ColID_/_DocID_/_PageNr_/text?overwrite=true.
        /// </summary>
        internal static string TrpServerPathUpload {
            get {
                return ResourceManager.GetString("TrpServerPathUpload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://files.transkribus.eu/Get?id=.
        /// </summary>
        internal static string TrpServerTranscriptURL {
            get {
                return ResourceManager.GetString("TrpServerTranscriptURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://www.w3.org/2001/XMLSchema-instance.
        /// </summary>
        internal static string XMLSchemaInstance {
            get {
                return ResourceManager.GetString("XMLSchemaInstance", resourceCulture);
            }
        }
    }
}
