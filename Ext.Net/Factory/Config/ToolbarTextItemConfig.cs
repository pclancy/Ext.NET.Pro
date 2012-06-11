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

namespace Ext.Net
{
    public partial class ToolbarTextItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ToolbarTextItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ToolbarTextItem.Config Conversion to ToolbarTextItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolbarTextItem(ToolbarTextItem.Config config)
        {
            return new ToolbarTextItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolbarItem.Config 
        { 
			/*  Implicit ToolbarTextItem.Config Conversion to ToolbarTextItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ToolbarTextItem.Builder(ToolbarTextItem.Config config)
			{
				return new ToolbarTextItem.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string text = "";

			/// <summary>
			/// A Toolbar Text item.
			/// </summary>
			[DefaultValue("")]
			public virtual string Text 
			{ 
				get
				{
					return this.text;
				}
				set
				{
					this.text = value;
				}
			}
        
			private BoxComponentListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public BoxComponentListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new BoxComponentListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private BoxComponentDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public BoxComponentDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new BoxComponentDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}