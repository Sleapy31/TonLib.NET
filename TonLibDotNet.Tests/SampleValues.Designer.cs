﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TonLibDotNet {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SampleValues {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SampleValues() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TonLibDotNet.SampleValues", typeof(SampleValues).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7mQrbSrj_NSh&quot;}.
        /// </summary>
        public static string AccountAddress {
            get {
                return ResourceManager.GetString("AccountAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;blocks.getMasterchainInfo&quot;}.
        /// </summary>
        public static string Blocks_GetMasterchainInfo {
            get {
                return ResourceManager.GetString("Blocks_GetMasterchainInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;blocks.masterchainInfo&quot;,
        ///  &quot;last&quot;:{&quot;@type&quot;:&quot;ton.blockIdExt&quot;,
        ///          &quot;workchain&quot;:-1,
        ///          &quot;shard&quot;:&quot;-9223372036854775808&quot;,
        ///          &quot;seqno&quot;:26984517,
        ///          &quot;root_hash&quot;:&quot;k1nEMD+7m+DZAEyktBfy99GTAl/YvFVRBgw3tXr5Xt8=&quot;,
        ///          &quot;file_hash&quot;:&quot;BKPbMdegxyBMEdeWTNY0RG4SI8Cw7tlqCOQkahlj0cM=&quot;},
        ///  &quot;state_root_hash&quot;:&quot;/K7jV7AXp/MKqBL/+3XWpU3kFYp2ObdDG+b9minKUn8=&quot;,
        ///  &quot;init&quot;:{&quot;@type&quot;:&quot;ton.blockIdExt&quot;,
        ///          &quot;workchain&quot;:-1,
        ///          &quot;shard&quot;:&quot;0&quot;,
        ///          &quot;seqno&quot;:0,
        ///          &quot;root_ha [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Blocks_MasterchainInfo {
            get {
                return ResourceManager.GetString("Blocks_MasterchainInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;config&quot;,&quot;config&quot;:&quot;test-value&quot;,&quot;blockchain_name&quot;:&quot;test&quot;,&quot;use_callbacks_for_network&quot;:true,&quot;ignore_cache&quot;:true}.
        /// </summary>
        public static string Config {
            get {
                return ResourceManager.GetString("Config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;error&quot;,&quot;code&quot;:400,&quot;message&quot;:&quot;INVALID_ACCOUNT_ADDRESSFailed to parse account address&quot;}.
        /// </summary>
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;fullAccountState&quot;,&quot;address&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7mQrbSrj_NSh&quot;},&quot;balance&quot;:&quot;136217239329079&quot;,&quot;last_transaction_id&quot;:{&quot;@type&quot;:&quot;internal.transactionId&quot;,&quot;lt&quot;:&quot;34942442000005&quot;,&quot;hash&quot;:&quot;vhl79O/OZ4LCC7cdkKj22uNv5diIrIltOLujpFOLwTk=&quot;},&quot;block_id&quot;:{&quot;@type&quot;:&quot;ton.blockIdExt&quot;,&quot;workchain&quot;:-1,&quot;shard&quot;:&quot;-9223372036854775808&quot;,&quot;seqno&quot;:27011756,&quot;root_hash&quot;:&quot;AhS55h8lmOyxtw29gWux0XZzXgiAbE69UsP44xIWdXM=&quot;,&quot;file_hash&quot;:&quot;TwDj86Fbvgvxte2UXpYtm2CpMSC/wIyxZph6mPDn99A=&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string FullAccountState {
            get {
                return ResourceManager.GetString("FullAccountState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;getAccountState&quot;,&quot;account_address&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7mQrbSrj_NSh&quot;}}.
        /// </summary>
        public static string GetAccountState {
            get {
                return ResourceManager.GetString("GetAccountState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;init&quot;,&quot;options&quot;:{&quot;@type&quot;:&quot;options&quot;,&quot;config&quot;:{&quot;@type&quot;:&quot;config&quot;,&quot;config&quot;:&quot;test-value&quot;,&quot;blockchain_name&quot;:&quot;test&quot;,&quot;use_callbacks_for_network&quot;:true,&quot;ignore_cache&quot;:true},&quot;keystore_type&quot;:{&quot;@type&quot;:&quot;keyStoreTypeDirectory&quot;,&quot;directory&quot;:&quot;D:/Temp/&quot;}}}.
        /// </summary>
        public static string Init {
            get {
                return ResourceManager.GetString("Init", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;internal.transactionId&quot;,&quot;lt&quot;:&quot;34942442000005&quot;,&quot;hash&quot;:&quot;vhl79O/OZ4LCC7cdkKj22uNv5diIrIltOLujpFOLwTk=&quot;}.
        /// </summary>
        public static string Internal_TransactionId {
            get {
                return ResourceManager.GetString("Internal_TransactionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;liteServer.getInfo&quot;}.
        /// </summary>
        public static string LiteServer_GetInfo {
            get {
                return ResourceManager.GetString("LiteServer_GetInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;liteServer.info&quot;,&quot;now&quot;:1675246773,&quot;version&quot;:257,&quot;capabilities&quot;:&quot;7&quot;}.
        /// </summary>
        public static string LiteServer_Info {
            get {
                return ResourceManager.GetString("LiteServer_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;msg.dataRaw&quot;,&quot;body&quot;:&quot;te6cckEBAQEAAgAAAEysuc0=&quot;,&quot;init_state&quot;:&quot;???&quot;}.
        /// </summary>
        public static string Msg_DataRaw {
            get {
                return ResourceManager.GetString("Msg_DataRaw", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;msg.dataText&quot;,&quot;text&quot;:&quot;Um95YWx0eQ==&quot;}.
        /// </summary>
        public static string Msg_DataText {
            get {
                return ResourceManager.GetString("Msg_DataText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;options.info&quot;,&quot;config_info&quot;:{&quot;@type&quot;:&quot;options.configInfo&quot;,&quot;default_wallet_id&quot;:&quot;698983191&quot;,&quot;default_rwallet_init_public_key&quot;:&quot;Puasxr0QfFZZnYISRphVse7XHKfW7pZU5SJarVHXvQ+rpzkD&quot;}}.
        /// </summary>
        public static string Options_Info {
            get {
                return ResourceManager.GetString("Options_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;raw.fullAccountState&quot;,&quot;balance&quot;:&quot;136219372128177&quot;,&quot;code&quot;:&quot;te6cckEBAQEAcQAA3v8AIN0gggFMl7ohggEznLqxn3Gw7UTQ0x/THzHXC//jBOCk8mCDCNcYINMf0x/TH/gjE7vyY+1E0NMf0x/T/9FRMrryoVFEuvKiBPkBVBBV+RDyo/gAkyDXSpbTB9QC+wDo0QGkyMsfyx/L/8ntVBC9ba0=&quot;,&quot;data&quot;:&quot;te6cckEBAQEAKgAAUAAAACMpqaMXb7DhKt9TV4heY445fd1j4cnc24PkHSaiiBxRdV3sZK6FBhF3&quot;,&quot;last_transaction_id&quot;:{&quot;@type&quot;:&quot;internal.transactionId&quot;,&quot;lt&quot;:&quot;34948872000007&quot;,&quot;hash&quot;:&quot;j2fRsAIg2Abex+P+GCRu9dNcmGs36Wd9U0gedEGX8oA=&quot;},&quot;block_id&quot;:{&quot;@type&quot;:&quot;ton.blockIdExt&quot;,&quot;workchain&quot;:-1 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Raw_FullAccountState {
            get {
                return ResourceManager.GetString("Raw_FullAccountState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;raw.getAccountState&quot;,&quot;account_address&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7mQrbSrj_NSh&quot;}}.
        /// </summary>
        public static string Raw_GetAccountState {
            get {
                return ResourceManager.GetString("Raw_GetAccountState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;raw.getTransactions&quot;,&quot;account_address&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7mQrbSrj_NSh&quot;},&quot;from_transaction_id&quot;:{&quot;@type&quot;:&quot;internal.transactionId&quot;,&quot;lt&quot;:34948872000007,&quot;hash&quot;:&quot;j2fRsAIg2Abex\u002BP\u002BGCRu9dNcmGs36Wd9U0gedEGX8oA=&quot;}}.
        /// </summary>
        public static string Raw_GetTransactions {
            get {
                return ResourceManager.GetString("Raw_GetTransactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;raw.message&quot;,&quot;source&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQAyAAlbgteBHCuI50EzuVvu9Zrk4Ts7pKU3bsphGBcyY0O_&quot;},&quot;destination&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7mQrbSrj_NSh&quot;},&quot;value&quot;:&quot;880000000&quot;,&quot;fwd_fee&quot;:&quot;666672&quot;,&quot;ihr_fee&quot;:&quot;1&quot;,&quot;created_lt&quot;:&quot;34948872000005&quot;,&quot;body_hash&quot;:&quot;lqKW0iTyhcZ77pPDD4owkVfw2qNdxbh+QQt4YwoJz8c=&quot;,&quot;msg_data&quot;:{&quot;@type&quot;:&quot;msg.dataRaw&quot;,&quot;body&quot;:&quot;te6cckEBAQEAAgAAAEysuc0=&quot;,&quot;init_state&quot;:&quot;12345&quot;}}.
        /// </summary>
        public static string Raw_Message {
            get {
                return ResourceManager.GetString("Raw_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;raw.transaction&quot;,&quot;utime&quot;:1675263677,&quot;data&quot;:&quot;te6cC9u5d6&quot;,&quot;transaction_id&quot;:{&quot;@type&quot;:&quot;internal.transactionId&quot;,&quot;lt&quot;:&quot;34948872000007&quot;,&quot;hash&quot;:&quot;j2fRsAIg2Abex+P+GCRu9dNcmGs36Wd9U0gedEGX8oA=&quot;},&quot;fee&quot;:&quot;12&quot;,&quot;storage_fee&quot;:&quot;13&quot;,&quot;other_fee&quot;:&quot;15&quot;,&quot;in_msg&quot;:{&quot;@type&quot;:&quot;raw.message&quot;,&quot;source&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQAyAAlbgteBHCuI50EzuVvu9Zrk4Ts7pKU3bsphGBcyY0O_&quot;},&quot;destination&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7mQrbSrj_NSh&quot;},&quot;value&quot;:&quot;0&quot;,&quot;fwd_fee&quot;:&quot;6 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Raw_Transaction {
            get {
                return ResourceManager.GetString("Raw_Transaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;raw.transactions&quot;,&quot;transactions&quot;:[{&quot;@type&quot;:&quot;raw.transaction&quot;,&quot;utime&quot;:1675263677,&quot;data&quot;:&quot;abcdef&quot;,&quot;transaction_id&quot;:{&quot;@type&quot;:&quot;internal.transactionId&quot;,&quot;lt&quot;:&quot;34948872000007&quot;,&quot;hash&quot;:&quot;j2fRsAIg2Abex+P+GCRu9dNcmGs36Wd9U0gedEGX8oA=&quot;},&quot;fee&quot;:&quot;0&quot;,&quot;storage_fee&quot;:&quot;0&quot;,&quot;other_fee&quot;:&quot;0&quot;,&quot;in_msg&quot;:{&quot;@type&quot;:&quot;raw.message&quot;,&quot;source&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQAyAAlbgteBHCuI50EzuVvu9Zrk4Ts7pKU3bsphGBcyY0O_&quot;},&quot;destination&quot;:{&quot;@type&quot;:&quot;accountAddress&quot;,&quot;account_address&quot;:&quot;EQCJTkhd1W2wztkVNp_dsKBpv2SIoUWoIyzI7m [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Raw_Transactions {
            get {
                return ResourceManager.GetString("Raw_Transactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;sync&quot;}.
        /// </summary>
        public static string Sync {
            get {
                return ResourceManager.GetString("Sync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;ton.blockIdExt&quot;,
        ///          &quot;workchain&quot;:-1,
        ///          &quot;shard&quot;:&quot;-9223372036854775808&quot;,
        ///          &quot;seqno&quot;:26984517,
        ///          &quot;root_hash&quot;:&quot;k1nEMD+7m+DZAEyktBfy99GTAl/YvFVRBgw3tXr5Xt8=&quot;,
        ///          &quot;file_hash&quot;:&quot;BKPbMdegxyBMEdeWTNY0RG4SI8Cw7tlqCOQkahlj0cM=&quot;}.
        /// </summary>
        public static string Ton_BlockIdEx {
            get {
                return ResourceManager.GetString("Ton_BlockIdEx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;updateSyncState&quot;,&quot;sync_state&quot;:{&quot;@type&quot;:&quot;syncStateInProgress&quot;,&quot;from_seqno&quot;:27005885,&quot;to_seqno&quot;:27011756,&quot;current_seqno&quot;:27011750}}.
        /// </summary>
        public static string UpdateSyncState {
            get {
                return ResourceManager.GetString("UpdateSyncState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;@type&quot;:&quot;wallet.v3.accountState&quot;,&quot;wallet_id&quot;:&quot;698983191&quot;,&quot;seqno&quot;:35}.
        /// </summary>
        public static string Wallet_V3AccountState {
            get {
                return ResourceManager.GetString("Wallet_V3AccountState", resourceCulture);
            }
        }
    }
}
