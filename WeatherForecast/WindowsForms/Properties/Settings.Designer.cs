﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsForms.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static WindowsForms.Settings defaultInstance = ((WindowsForms.Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new WindowsForms.Settings())));
        
        public static WindowsForms.Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string userName {
            get {
                return ((string)(this["userName"]));
            }
            set {
                this["userName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int userZipcode {
            get {
                return ((int)(this["userZipcode"]));
            }
            set {
                this["userZipcode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int userForecastPreference {
            get {
                return ((int)(this["userForecastPreference"]));
            }
            set {
                this["userForecastPreference"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int userTemperatureTypePreference {
            get {
                return ((int)(this["userTemperatureTypePreference"]));
            }
            set {
                this["userTemperatureTypePreference"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string userZipcodeList {
            get {
                return ((string)(this["userZipcodeList"]));
            }
            set {
                this["userZipcodeList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("a1fcc507923163ff1bae113a80d8f82a")]
        public string apiKey {
            get {
                return ((string)(this["apiKey"]));
            }
            set {
                this["apiKey"] = value;
            }
        }
    }
}
