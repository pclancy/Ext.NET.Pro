/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.ComponentModel;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]    
    public partial class DesktopModuleProxy : BaseControl
    {
        /// <summary>
        /// 
        /// </summary>
        public DesktopModuleProxy() 
        { 
        }

        private DesktopModule module;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("")]
        public virtual DesktopModule Module
        {
            get
            {
                return this.module;
            }
            set
            {
                this.module = value;
            }
        }

        public bool CombineModuleID
        {
            get;
            set;
        }

        public bool PreventAdding
        {
            get;
            set;
        }
        
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            var desktop = Desktop.GetInstance();
            if (desktop != null && !this.PreventAdding)
            {
                this.AddToDesktop(desktop);
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            var desktop = Desktop.GetInstance();
            if (desktop != null && !this.PreventAdding)
            {
                this.AddToDesktop(desktop);
            }
        }

        bool added = false;
        private void AddToDesktop(Desktop desktop)
        {
            if (this.added)
            {
                return;
            }

            if (this.CombineModuleID)
            {
                this.Module.ModuleID = this.Parent.ID + this.Module.ModuleID;
                this.Module.Shortcut.SetModule(this.Module.ModuleID);
                this.CombineModuleID = false;
            }
            desktop.Modules.Add(this.Module);
            this.added = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Serialize()
        {
            if (this.CombineModuleID)
            {
                this.Module.ModuleID = this.Parent.ID + this.Module.ModuleID;
                this.Module.Shortcut.SetModule(this.Module.ModuleID);
                this.CombineModuleID = false;
            }

            var desktop = "Ext.ComponentQuery.query('desktop')[0].app";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(desktop + ".addModule({0});", this.Module.RenderToString());

            if (this.Module.Launcher != null)
            {
                var script = DefaultScriptBuilder.Create(this.Module.Launcher).Build(RenderMode.AddTo, "{0}.getModule(\"{1}\")".FormatWith(desktop, this.Module.ModuleID), null, true, false, "addLauncher", true);
                sb.Append(script);
            }

            if (this.Module.Window.Count > 0)
            {
                this.Module.Window.Primary.AutoRender = false;
                var script = DefaultScriptBuilder.Create(this.Module.Window.Primary).Build(RenderMode.AddTo, "{0}.getModule(\"{1}\")".FormatWith(desktop, this.Module.ModuleID), null, true, false, "setWindow", true);
                sb.Append(string.Format("{0}.getModule(\"{1}\").addWindow(function(){{{2}}});", desktop, this.Module.ModuleID, script));
            }

            this.added = true;

            return sb.ToString();
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void RegisterModule()
        {
            ResourceManager.AddInstanceScript(this.Serialize());
        }
    }
}