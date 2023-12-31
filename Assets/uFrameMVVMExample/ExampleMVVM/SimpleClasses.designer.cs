// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example {
    using Example;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Json;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    
    
    public class ResolutionInformationBase : object {
        
        private Int32 _Height;
        
        private Int32 _Width;
        
        public Int32 Height {
            get {
                return _Height;
            }
            set {
                _Height = value;
            }
        }
        
        public Int32 Width {
            get {
                return _Width;
            }
            set {
                _Width = value;
            }
        }
        
        public virtual string Serialize() {
            var jsonObject = new JSONClass();
            jsonObject.Add("Height", new JSONData(this.Height));
            jsonObject.Add("Width", new JSONData(this.Width));
            return jsonObject.ToString();
        }
        
        public virtual void Deserialize(string json) {
            var node = JSON.Parse(json);
            if (node["Height"] != null) {
                this.Height = node["Height"].AsInt;
            }
            if (node["Width"] != null) {
                this.Width = node["Width"].AsInt;
            }
        }
    }
    
    public class IntroFinishedEventBase : object {
        
        public virtual string Serialize() {
            var jsonObject = new JSONClass();
            return jsonObject.ToString();
        }
        
        public virtual void Deserialize(string json) {
            var node = JSON.Parse(json);
        }
    }
    
    public class AssetLoadingProgressEventBase : object {
        
        private String _Message;
        
        private Single _Progress;
        
        public String Message {
            get {
                return _Message;
            }
            set {
                _Message = value;
            }
        }
        
        public Single Progress {
            get {
                return _Progress;
            }
            set {
                _Progress = value;
            }
        }
        
        public virtual string Serialize() {
            var jsonObject = new JSONClass();
            jsonObject.Add("Message", new JSONData(this.Message));
            jsonObject.Add("Progress", new JSONData(this.Progress));
            return jsonObject.ToString();
        }
        
        public virtual void Deserialize(string json) {
            var node = JSON.Parse(json);
            if (node["Message"] != null) {
                this.Message = node["Message"].AsString;
            }
            if (node["Progress"] != null) {
                this.Progress = node["Progress"].AsFloat;
            }
        }
    }
    
    public class StartAssetLoadingCommandBase : object {
        
        public virtual string Serialize() {
            var jsonObject = new JSONClass();
            return jsonObject.ToString();
        }
        
        public virtual void Deserialize(string json) {
            var node = JSON.Parse(json);
        }
    }
}
