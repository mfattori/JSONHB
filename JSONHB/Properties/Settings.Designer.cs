﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JSONHB.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("UAV-WHITECAP")]
        public string UAVSerialNumberJson {
            get {
                return ((string)(this["UAVSerialNumberJson"]));
            }
            set {
                this["UAVSerialNumberJson"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CE79B860B520453BA7E144A56360D3B0")]
        public string UAVSecretKeyJson {
            get {
                return ((string)(this["UAVSecretKeyJson"]));
            }
            set {
                this["UAVSecretKeyJson"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://FlyteDEV.dronedeliverycanada.com/controllerboard/Heartbeat")]
        public string FlyteDev {
            get {
                return ((string)(this["FlyteDev"]));
            }
            set {
                this["FlyteDev"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://FlyteUAT.dronedeliverycanada.com/controllerboard/Heartbeat")]
        public string FlyeUAT {
            get {
                return ((string)(this["FlyeUAT"]));
            }
            set {
                this["FlyeUAT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://Flyte.dronedeliverycanada.com/controller/Heartbeat")]
        public string FlyteProd {
            get {
                return ((string)(this["FlyteProd"]));
            }
            set {
                this["FlyteProd"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://173.244.122.69:8090/Heartbeat")]
        public string IRIS {
            get {
                return ((string)(this["IRIS"]));
            }
            set {
                this["IRIS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://flytepollingemulator.azurewebsites.net/api/heartbeat")]
        public string Azure {
            get {
                return ((string)(this["Azure"]));
            }
            set {
                this["Azure"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:9982/heartbeatJSON")]
        public string Local {
            get {
                return ((string)(this["Local"]));
            }
            set {
                this["Local"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int HeartbeatURIJson {
            get {
                return ((int)(this["HeartbeatURIJson"]));
            }
            set {
                this["HeartbeatURIJson"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C86CDD56841742201ED86BD3BA4C5F4E3CDD73D56A0447ED7837C5EAE955C7CC")]
        public string EncryptionKey {
            get {
                return ((string)(this["EncryptionKey"]));
            }
            set {
                this["EncryptionKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("162.247.246.165")]
        public string UDPEndpoint {
            get {
                return ((string)(this["UDPEndpoint"]));
            }
            set {
                this["UDPEndpoint"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AABBCCDD")]
        public string SessionID {
            get {
                return ((string)(this["SessionID"]));
            }
            set {
                this["SessionID"] = value;
            }
        }
    }
}
