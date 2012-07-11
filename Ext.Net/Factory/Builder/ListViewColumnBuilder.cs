/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class ListViewColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<ListViewColumn, ListViewColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ListViewColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListViewColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListViewColumn.Config config) : base(new ListViewColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ListViewColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Set the CSS text-align property of the column. Defaults to 'left'.
			/// </summary>
            public virtual ListViewColumn.Builder Align(TextAlign align)
            {
                this.ToComponent().Align = align;
                return this as ListViewColumn.Builder;
            }
             
 			/// <summary>
			/// Optional. This option can be used to add a CSS class to the cell of each row for this column.
			/// </summary>
            public virtual ListViewColumn.Builder Cls(string cls)
            {
                this.ToComponent().Cls = cls;
                return this as ListViewColumn.Builder;
            }
             
 			/// <summary>
			/// (optional) The name of the field in the grid's Ext.data.Store's Ext.data.Record definition from which to draw the column's value. If not specified, the column's index is used as an index into the Record's data Array.
			/// </summary>
            public virtual ListViewColumn.Builder DataIndex(string dataIndex)
            {
                this.ToComponent().DataIndex = dataIndex;
                return this as ListViewColumn.Builder;
            }
             
 			/// <summary>
			/// The header text to display in the Grid view.
			/// </summary>
            public virtual ListViewColumn.Builder Header(string header)
            {
                this.ToComponent().Header = header;
                return this as ListViewColumn.Builder;
            }
             
 			/// <summary>
			/// Specify true to enable sorting on this column (defaults to false).
			/// </summary>
            public virtual ListViewColumn.Builder Sortable(bool sortable)
            {
                this.ToComponent().Sortable = sortable;
                return this as ListViewColumn.Builder;
            }
             
 			/// <summary>
			/// Specify a string to pass as the configuration string for Ext.XTemplate. By default an Ext.XTemplate will be implicitly created using the dataIndex.
			/// </summary>
            public virtual ListViewColumn.Builder Template(string template)
            {
                this.ToComponent().Template = template;
                return this as ListViewColumn.Builder;
            }
             
 			// /// <summary>
			// /// An XTemplate to use to process a Record's data to produce a column's rendered value.
			// /// </summary>
            // public virtual TBuilder XTemplate(XTemplate xTemplate)
            // {
            //    this.ToComponent().XTemplate = xTemplate;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// Percentage of the container width this column should be allocated. Columns that have no width specified will be allocated with an equal percentage to fill 100% of the container width. To easily take advantage of the full container width, leave the width of at least one column undefined. Note that if you do not want to take up the full width of the container, the width of every column needs to be explicitly defined.
			/// </summary>
            public virtual ListViewColumn.Builder Width(double width)
            {
                this.ToComponent().Width = width;
                return this as ListViewColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ListViewColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ListViewColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ListViewColumn.Builder ListViewColumn()
        {
            return this.ListViewColumn(new ListViewColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public ListViewColumn.Builder ListViewColumn(ListViewColumn component)
        {
            return new ListViewColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ListViewColumn.Builder ListViewColumn(ListViewColumn.Config config)
        {
            return new ListViewColumn.Builder(new ListViewColumn(config));
        }
    }
}