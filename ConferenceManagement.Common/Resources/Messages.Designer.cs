﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConferenceManagement.Common.Resources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public Messages() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("ConferenceManagement.Common.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        public static string FileContentNullOrEmpty {
            get {
                return ResourceManager.GetString("FileContentNullOrEmpty", resourceCulture);
            }
        }
        
        public static string LunchStartRangeTimeError {
            get {
                return ResourceManager.GetString("LunchStartRangeTimeError", resourceCulture);
            }
        }
        
        public static string NetworkingEventRangeTimeError {
            get {
                return ResourceManager.GetString("NetworkingEventRangeTimeError", resourceCulture);
            }
        }
        
        public static string TrackNameFormat {
            get {
                return ResourceManager.GetString("TrackNameFormat", resourceCulture);
            }
        }
        
        public static string MinutesNameFormat {
            get {
                return ResourceManager.GetString("MinutesNameFormat", resourceCulture);
            }
        }
        
        public static string Lightning {
            get {
                return ResourceManager.GetString("Lightning", resourceCulture);
            }
        }
        
        public static string Lunch {
            get {
                return ResourceManager.GetString("Lunch", resourceCulture);
            }
        }
        
        public static string NetworkingEvent {
            get {
                return ResourceManager.GetString("NetworkingEvent", resourceCulture);
            }
        }
    }
}