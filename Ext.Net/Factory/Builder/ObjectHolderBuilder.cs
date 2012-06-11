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
    public partial class ObjectHolder
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<ObjectHolder, ObjectHolder.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ObjectHolder()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ObjectHolder component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ObjectHolder.Config config) : base(new ObjectHolder(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ObjectHolder component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ObjectHolder.Builder</returns>
            public virtual ObjectHolder.Builder Items(Action<JsonObject> action)
            {
                action(this.ToComponent().Items);
                return this as ObjectHolder.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual ObjectHolder.Builder UpdateData()
            {
                this.ToComponent().UpdateData();
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ObjectHolder(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder.Builder ObjectHolder()
        {
            return this.ObjectHolder(new ObjectHolder());
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder.Builder ObjectHolder(ObjectHolder component)
        {
            return new ObjectHolder.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder.Builder ObjectHolder(ObjectHolder.Config config)
        {
            return new ObjectHolder.Builder(new ObjectHolder(config));
        }
    }
}