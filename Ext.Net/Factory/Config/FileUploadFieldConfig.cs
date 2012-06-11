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
    public partial class FileUploadField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FileUploadField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FileUploadField.Config Conversion to FileUploadField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileUploadField(FileUploadField.Config config)
        {
            return new FileUploadField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TextFieldBase.Config 
        { 
			/*  Implicit FileUploadField.Config Conversion to FileUploadField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FileUploadField.Builder(FileUploadField.Config config)
			{
				return new FileUploadField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string text = null;

			/// <summary>
			/// The Text value to initialize this field with.
			/// </summary>
			[DefaultValue(null)]
			public override string Text 
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

			private string buttonText = "Browse...";

			/// <summary>
			/// The button text to display on the upload button (defaults to 'Browse...'). Note that if you supply a value for ButtonCfg, the ButtonCfg.Text value will be used instead if available.
			/// </summary>
			[DefaultValue("Browse...")]
			public virtual string ButtonText 
			{ 
				get
				{
					return this.buttonText;
				}
				set
				{
					this.buttonText = value;
				}
			}

			private bool buttonOnly = false;

			/// <summary>
			/// True to display the file upload field as a button with no visible text field (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ButtonOnly 
			{ 
				get
				{
					return this.buttonOnly;
				}
				set
				{
					this.buttonOnly = value;
				}
			}

			private int buttonOffset = 3;

			/// <summary>
			/// The number of pixels of space reserved between the button and the text field (defaults to 3).  Note that this only applies if ButtonOnly=false.
			/// </summary>
			[DefaultValue(3)]
			public virtual int ButtonOffset 
			{ 
				get
				{
					return this.buttonOffset;
				}
				set
				{
					this.buttonOffset = value;
				}
			}

			private bool readOnly = true;

			/// <summary>
			/// True to mark the field as readOnly in HTML (defaults to false) -- Note: this only sets the element's readOnly DOM attribute.
			/// </summary>
			[DefaultValue(true)]
			public override bool ReadOnly 
			{ 
				get
				{
					return this.readOnly;
				}
				set
				{
					this.readOnly = value;
				}
			}

			private Icon icon = Icon.None;

			/// <summary>
			/// The icon to use in the Button. See also, IconCls to set an icon with a custom Css class.
			/// </summary>
			[DefaultValue(Icon.None)]
			public override Icon Icon 
			{ 
				get
				{
					return this.icon;
				}
				set
				{
					this.icon = value;
				}
			}

			private string iconCls = "";

			/// <summary>
			/// A css class which sets a background image to be used as the icon for this button.
			/// </summary>
			[DefaultValue("")]
			public override string IconCls 
			{ 
				get
				{
					return this.iconCls;
				}
				set
				{
					this.iconCls = value;
				}
			}
        
			private FileUploadFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public FileUploadFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new FileUploadFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private FileUploadFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public FileUploadFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new FileUploadFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}