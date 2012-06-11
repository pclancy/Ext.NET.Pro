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
    public partial class UuidIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ModelIdGenerator.Builder<UuidIdGenerator, UuidIdGenerator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new UuidIdGenerator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UuidIdGenerator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UuidIdGenerator.Config config) : base(new UuidIdGenerator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(UuidIdGenerator component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.UuidIdGenerator(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator.Builder UuidIdGenerator()
        {
            return this.UuidIdGenerator(new UuidIdGenerator());
        }

        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator.Builder UuidIdGenerator(UuidIdGenerator component)
        {
            return new UuidIdGenerator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator.Builder UuidIdGenerator(UuidIdGenerator.Config config)
        {
            return new UuidIdGenerator.Builder(new UuidIdGenerator(config));
        }
    }
}