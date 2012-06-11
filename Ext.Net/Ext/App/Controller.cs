/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public partial class Controller : ControllerBase, ICustomConfigSerialization, IVirtual
    {
        /// <summary>
        /// 
        /// </summary>
        public Controller() { }

        #region ICustomConfigSerialization

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public virtual string ToScript(System.Web.UI.Control owner)
        {
            string tpl = "Ext.define(\"{0}\", {{extend: 'Ext.app.Controller', {1} }}){2}";
            return tpl.FormatWith(this.Name ?? this.ClientID, new ClientConfig().Serialize(this, true).Chop(),
                                  this.IsLazy ? "" : ";");
        }

        #endregion
    }
}
