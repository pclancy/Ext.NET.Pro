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
    public partial class GridFilters
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
                
                list.Add("updateBuffer", new ConfigOption("updateBuffer", null, 500, this.UpdateBuffer ));
                list.Add("paramPrefix", new ConfigOption("paramPrefix", null, "gridfilters", this.ParamPrefix ));
                list.Add("filterCls", new ConfigOption("filterCls", null, "ux-filtered-column", this.FilterCls ));
                list.Add("local", new ConfigOption("local", null, false, this.Local ));
                list.Add("autoReload", new ConfigOption("autoReload", null, true, this.AutoReload ));
                list.Add("showMenu", new ConfigOption("showMenu", null, true, this.ShowMenu ));
                list.Add("filtersText", new ConfigOption("filtersText", new SerializationOptions("menuFilterText"), "Filters", this.FiltersText ));
                list.Add("filters", new ConfigOption("filters", new SerializationOptions("filters", JsonMode.AlwaysArray), null, this.Filters ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}