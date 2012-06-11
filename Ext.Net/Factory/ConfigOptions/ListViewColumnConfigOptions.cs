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
    public partial class ListViewColumn
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
                
                list.Add("align", new ConfigOption("align", new SerializationOptions(JsonMode.ToLower), TextAlign.Left, this.Align ));
                list.Add("cls", new ConfigOption("cls", null, null, this.Cls ));
                list.Add("dataIndex", new ConfigOption("dataIndex", null, null, this.DataIndex ));
                list.Add("header", new ConfigOption("header", null, "", this.Header ));
                list.Add("sortable", new ConfigOption("sortable", null, false, this.Sortable ));
                list.Add("template", new ConfigOption("template", new SerializationOptions("tpl"), "", this.Template ));
                list.Add("xTemplate", new ConfigOption("xTemplate", new SerializationOptions("tpl", typeof(LazyControlJsonConverter)), null, this.XTemplate ));
                list.Add("width", new ConfigOption("width", null, 0.0, this.Width ));

                return list;
            }
        }
    }
}