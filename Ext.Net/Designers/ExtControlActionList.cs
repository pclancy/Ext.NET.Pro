/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ExtControlActionList : System.ComponentModel.Design.DesignerActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DesignerActionItemCollection Items;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ExtControlActionList(IComponent component) : base(component) 
        {
            this.Control = component as BaseControl;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool AutoShow
        {
            get
            {
                return false;
            }
            set
            {
                base.AutoShow = false;
            }
        }

        private BaseControl control;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BaseControl Control
        {
            get
            {
                return this.control;
            }
            set
            {
                this.control = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ID
        {
            get
            {
                return this.Control.ID;
            }
            set
            {
                GetPropertyByName("ID").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void LaunchSupportHome()
        {
            System.Diagnostics.Process.Start("http://www.ext.net/support/");
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void LaunchForums()
        {
            System.Diagnostics.Process.Start("http://www.ext.net/forums/");
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void LaunchDocumentation()
        {
            System.Diagnostics.Process.Start("http://www.ext.net/docs/");
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void LaunchExamples()
        {
            System.Diagnostics.Process.Start("http://www.ext.net/examples/");
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public PropertyDescriptor GetPropertyByName(string name)
        {
            PropertyDescriptor property;
            property = TypeDescriptor.GetProperties(this.Control)[name];

            if (null == property)
                throw new ArgumentException("Matching WebControl property not found.", name);
            else
                return property;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddHeaderItem(new DesignerActionHeaderItem("Properties", "500"));
            this.AddHeaderItem(new DesignerActionHeaderItem("Support [Version " + this.Control.Version + "]", "1000"));

            this.AddMethodItem(new DesignerActionMethodItem(this, "LaunchExamples", "Examples Explorer", "1000", "View the Ext.Net examples online"));
            this.AddMethodItem(new DesignerActionMethodItem(this, "LaunchForums", "Online Forums", "1000", "Visit the Ext.Net Forums"));
            this.AddMethodItem(new DesignerActionMethodItem(this, "LaunchSupportHome", "Ext.Net Support Home", "1000", "Visit the Ext.Net website for more support options", true));
            this.AddMethodItem(new DesignerActionMethodItem(this, "LaunchDocumentation", "Online Documentation", "1000", "View online documentation"));

            this.Items = new DesignerActionItemCollection();

            this.Items.Add(new DesignerActionPropertyItem("ID", "ID", "", "Change the ID of the control"));

            foreach (DesignerActionHeaderItem item in this.Headers)
            {
                this.Items.Add(item);
            }

            foreach (DesignerActionPropertyItem item in this.Properties)
            {
                this.Items.Add(item);
            }

            foreach (DesignerActionMethodItem item in this.Methods)
            {
                this.Items.Add(item);
            }

            return this.Items;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddHeaderItem(DesignerActionHeaderItem item)
        {
            foreach (DesignerActionHeaderItem header in this.Headers)
            {
                if (item.DisplayName == header.DisplayName)
                {
                    return;
                }
            }
            this.Headers.Add(item);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void RemoveHeaderItem(DesignerActionHeaderItem item)
        {
            foreach (DesignerActionHeaderItem header in this.Headers)
            {
                if (item.DisplayName == header.DisplayName)
                {
                    this.Headers.Remove(header);
                    return;
                }
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddPropertyItem(DesignerActionPropertyItem item)
        {
            foreach (DesignerActionPropertyItem property in this.Properties)
            {
                if (item.MemberName == property.MemberName && item.Category == property.Category)
                {
                    return;
                }
            }
            this.Properties.Add(item);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void RemovePropertyItem(DesignerActionPropertyItem item)
        {
            foreach (DesignerActionPropertyItem property in this.Properties)
            {
                if (item.MemberName == property.MemberName && item.Category == property.Category)
                {
                    this.Properties.Remove(property);
                    return;
                }
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddMethodItem(DesignerActionMethodItem item)
        {
            foreach (DesignerActionMethodItem method in this.Methods)
            {
                if (item.MemberName == method.MemberName && item.Category == method.Category)
                {
                    return;
                }
            }
            this.Methods.Add(item);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void RemoveMethodItem(DesignerActionMethodItem item)
        {
            foreach (DesignerActionMethodItem method in this.Methods)
            {
                if (item.MemberName == method.MemberName && item.Category == method.Category)
                {
                    this.Methods.Remove(method);
                    return;
                }
            }
        }

        private List<DesignerActionHeaderItem> headers = new List<DesignerActionHeaderItem>();
        private List<DesignerActionHeaderItem> Headers
        {
            get
            {
                this.headers.Sort(new DesignerActionHeaderItemComparer());
                return this.headers;
            }
        }

        private List<DesignerActionPropertyItem> properties = new List<DesignerActionPropertyItem>();
        private List<DesignerActionPropertyItem> Properties
        {
            get
            {
                return this.properties;
            }
        }

        private List<DesignerActionMethodItem> methods = new List<DesignerActionMethodItem>();
        private List<DesignerActionMethodItem> Methods
        {
            get
            {
                return this.methods;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class DesignerActionHeaderItemComparer : IComparer<DesignerActionHeaderItem>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Compare(DesignerActionHeaderItem att1, DesignerActionHeaderItem att2)
        {
            Int32 cat1 = Convert.ToInt32(att1.Category);
            Int32 cat2 = Convert.ToInt32(att2.Category);

            return cat1.CompareTo(cat2);
        }
    }
}