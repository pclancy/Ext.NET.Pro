/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CheckColumnListeners : ColumnListeners
    {
        private ComponentListener checkChange;

        /// <summary>
        /// Fires when the checked state of a row changes
        /// Parameters:
        ///     - item
        ///     - rowIndex
        ///         The row index
        ///     - record
        ///         The record
        ///     - checked
        ///         True if the box is checked
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "record")]
        [ListenerArgument(3, "checked")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("checkchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the checked state of a row changes")]
        public virtual ComponentListener CheckChange
        {
            get
            {
                return this.checkChange ?? (this.checkChange = new ComponentListener());
            }
        }
    }
}
