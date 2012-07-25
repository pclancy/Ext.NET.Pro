/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class CustomIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ModelIdGenerator.Builder<CustomIdGenerator, CustomIdGenerator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CustomIdGenerator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CustomIdGenerator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CustomIdGenerator.Config config) : base(new CustomIdGenerator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CustomIdGenerator component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CustomIdGenerator.Builder</returns>
            public virtual CustomIdGenerator.Builder Generate(Action<JFunction> action)
            {
                action(this.ToComponent().Generate);
                return this as CustomIdGenerator.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CustomIdGenerator(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator.Builder CustomIdGenerator()
        {
            return this.CustomIdGenerator(new CustomIdGenerator());
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator.Builder CustomIdGenerator(CustomIdGenerator component)
        {
            return new CustomIdGenerator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator.Builder CustomIdGenerator(CustomIdGenerator.Config config)
        {
            return new CustomIdGenerator.Builder(new CustomIdGenerator(config));
        }
    }
}