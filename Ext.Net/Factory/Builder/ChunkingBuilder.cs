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
    public partial class Chunking
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridFeature.Builder<Chunking, Chunking.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Chunking()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Chunking component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Chunking.Config config) : base(new Chunking(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Chunking component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual Chunking.Builder ChunkSize(int chunkSize)
            {
                this.ToComponent().ChunkSize = chunkSize;
                return this as Chunking.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Chunking.Builder RowHeight(int rowHeight)
            {
                this.ToComponent().RowHeight = rowHeight;
                return this as Chunking.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Chunking.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Chunking(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Chunking.Builder Chunking()
        {
            return this.Chunking(new Chunking());
        }

        /// <summary>
        /// 
        /// </summary>
        public Chunking.Builder Chunking(Chunking component)
        {
            return new Chunking.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Chunking.Builder Chunking(Chunking.Config config)
        {
            return new Chunking.Builder(new Chunking(config));
        }
    }
}