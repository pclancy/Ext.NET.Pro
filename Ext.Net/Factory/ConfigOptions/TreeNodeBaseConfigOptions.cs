/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public abstract partial class TreeNodeBase
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
                
                list.Add("allowChildren", new ConfigOption("allowChildren", null, true, this.AllowChildren ));
                list.Add("allowDrag", new ConfigOption("allowDrag", null, true, this.AllowDrag ));
                list.Add("allowDrop", new ConfigOption("allowDrop", null, true, this.AllowDrop ));
                list.Add("checked", new ConfigOption("checked", new SerializationOptions(typeof(ThreeStateBoolJsonConverter)), ThreeStateBool.Undefined, this.Checked ));
                list.Add("cls", new ConfigOption("cls", null, "", this.Cls ));
                list.Add("disabled", new ConfigOption("disabled", null, false, this.Disabled ));
                list.Add("draggable", new ConfigOption("draggable", null, false, this.Draggable ));
                list.Add("editable", new ConfigOption("editable", null, true, this.Editable ));
                list.Add("expandable", new ConfigOption("expandable", new SerializationOptions(typeof(ThreeStateBoolJsonConverter)), ThreeStateBool.Undefined, this.Expandable ));
                list.Add("expanded", new ConfigOption("expanded", null, false, this.Expanded ));
                list.Add("hidden", new ConfigOption("hidden", null, false, this.Hidden ));
                list.Add("href", new ConfigOption("href", null, "#", this.Href ));
                list.Add("hrefTarget", new ConfigOption("hrefTarget", null, "", this.HrefTarget ));
                list.Add("iconFile", new ConfigOption("iconFile", new SerializationOptions("icon"), "", this.IconFile ));
                list.Add("iconClsProxy", new ConfigOption("iconClsProxy", new SerializationOptions("iconCls"), "", this.IconClsProxy ));
                list.Add("isTarget", new ConfigOption("isTarget", null, true, this.IsTarget ));
                list.Add("qtip", new ConfigOption("qtip", null, "", this.Qtip ));
                list.Add("qtipConfig", new ConfigOption("qtipConfig", new SerializationOptions("qtipCfg", JsonMode.Object), null, this.QtipConfig ));
                list.Add("singleClickExpand", new ConfigOption("singleClickExpand", null, false, this.SingleClickExpand ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("customAttributes", new ConfigOption("customAttributes", new SerializationOptions("-", typeof(CustomConfigJsonConverter)), null, this.CustomAttributes ));
                list.Add("uIProvider", new ConfigOption("uIProvider", new SerializationOptions("uiProvider", JsonMode.Value), "", this.UIProvider ));
                list.Add("uIProviderClass", new ConfigOption("uIProviderClass", new SerializationOptions("uiProvider", JsonMode.Raw), "Ext.tree.TreeNodeUI", this.UIProviderClass ));

                return list;
            }
        }
    }
}