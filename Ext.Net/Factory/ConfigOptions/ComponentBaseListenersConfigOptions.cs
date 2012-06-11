/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    public abstract partial class ComponentBaseListeners
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("added", new ConfigOption("added", new SerializationOptions("added", typeof(ListenerJsonConverter)), null, this.Added ));
                list.Add("afterRender", new ConfigOption("afterRender", new SerializationOptions("afterrender", typeof(ListenerJsonConverter)), null, this.AfterRender ));
                list.Add("beforeDestroy", new ConfigOption("beforeDestroy", new SerializationOptions("beforedestroy", typeof(ListenerJsonConverter)), null, this.BeforeDestroy ));
                list.Add("beforeHide", new ConfigOption("beforeHide", new SerializationOptions("beforehide", typeof(ListenerJsonConverter)), null, this.BeforeHide ));
                list.Add("beforeRender", new ConfigOption("beforeRender", new SerializationOptions("beforerender", typeof(ListenerJsonConverter)), null, this.BeforeRender ));
                list.Add("beforeShow", new ConfigOption("beforeShow", new SerializationOptions("beforeshow", typeof(ListenerJsonConverter)), null, this.BeforeShow ));
                list.Add("beforeStateRestore", new ConfigOption("beforeStateRestore", new SerializationOptions("beforestaterestore", typeof(ListenerJsonConverter)), null, this.BeforeStateRestore ));
                list.Add("beforeStateSave", new ConfigOption("beforeStateSave", new SerializationOptions("beforestatesave", typeof(ListenerJsonConverter)), null, this.BeforeStateSave ));
                list.Add("destroy", new ConfigOption("destroy", new SerializationOptions("destroy", typeof(ListenerJsonConverter)), null, this.Destroy ));
                list.Add("disable", new ConfigOption("disable", new SerializationOptions("disable", typeof(ListenerJsonConverter)), null, this.Disable ));
                list.Add("enable", new ConfigOption("enable", new SerializationOptions("enable", typeof(ListenerJsonConverter)), null, this.Enable ));
                list.Add("hide", new ConfigOption("hide", new SerializationOptions("hide", typeof(ListenerJsonConverter)), null, this.Hide ));
                list.Add("render", new ConfigOption("render", new SerializationOptions("render", typeof(ListenerJsonConverter)), null, this.Render ));
                list.Add("removed", new ConfigOption("removed", new SerializationOptions("removed", typeof(ListenerJsonConverter)), null, this.Removed ));
                list.Add("show", new ConfigOption("show", new SerializationOptions("show", typeof(ListenerJsonConverter)), null, this.Show ));
                list.Add("stateRestore", new ConfigOption("stateRestore", new SerializationOptions("staterestore", typeof(ListenerJsonConverter)), null, this.StateRestore ));
                list.Add("stateSave", new ConfigOption("stateSave", new SerializationOptions("statesave", typeof(ListenerJsonConverter)), null, this.StateSave ));

                return list;
            }
        }
    }
}