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

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ToolbarSeparator
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSeparator(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ToolbarSeparator.Config Conversion to ToolbarSeparator
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolbarSeparator(ToolbarSeparator.Config config)
        {
            return new ToolbarSeparator(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolbarItem.Config 
        { 
			/*  Implicit ToolbarSeparator.Config Conversion to ToolbarSeparator.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ToolbarSeparator.Builder(ToolbarSeparator.Config config)
			{
				return new ToolbarSeparator.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}