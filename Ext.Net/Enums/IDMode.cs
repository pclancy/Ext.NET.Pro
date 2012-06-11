/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public enum IDMode
    {
        /// <summary>
        /// [Default] Inherits the IDMode for the Parent. This is the default functionality of all Ext.Net Components.
        /// </summary>
        Inherit,
        
        /// <summary>
        /// Legacy functionality for generating CliendID's. No change from default ASP.NET functionality.
        /// </summary>
        Legacy,
        
        /// <summary>
        /// Render the "id" property in the client as exactly the value set. Developer must manually ensure client-side ID uniqueness.
        /// </summary>
        Static,
        
        /// <summary>
        /// Do not render the "id" property in the client. 
        /// </summary>
        Ignore,
        
        /// <summary>
        /// Only render the "id" property if the .ID is explicitly set, otherwise renders as the ClientID if autogenerated by the ASP.NET runtime.
        /// </summary>
        Explicit,

        /// <summary>
        /// Only render the ClientID property if the .ID is explicitly set.
        /// </summary>
        Client,

        /// <summary>
        /// The ClientID value is generated by concatenating the ID value of the parent naming container with the ID value of the control. Each segment is separated by an underscore character (_).
        /// </summary>
        Predictable,

        /// <summary>
        /// The ClientID value is generated by concatenating the ID value of the parent Ext.NET component of the parent naming container with the ID value of the control. Each segment is separated by an underscore character (_).
        /// </summary>
        Parent
    }
}