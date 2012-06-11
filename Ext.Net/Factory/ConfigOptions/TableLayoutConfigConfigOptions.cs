/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    /// <summary>
    /// 
    /// </summary>
    public partial class TableLayoutConfig
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
                
                list.Add("layoutType", new ConfigOption("layoutType", new SerializationOptions("type"), "", this.LayoutType ));
                list.Add("columns", new ConfigOption("columns", new SerializationOptions(JsonMode.Raw), 0, this.Columns ));
                list.Add("tableAttrs", new ConfigOption("tableAttrs", new SerializationOptions(JsonMode.Object), null, this.TableAttrs ));
                list.Add("tDAttrs", new ConfigOption("tDAttrs", new SerializationOptions("tdAttrs",JsonMode.Object), null, this.TDAttrs ));
                list.Add("tRAttrs", new ConfigOption("tRAttrs", new SerializationOptions("trAttrs", JsonMode.Object), null, this.TRAttrs ));

                return list;
            }
        }
    }
}