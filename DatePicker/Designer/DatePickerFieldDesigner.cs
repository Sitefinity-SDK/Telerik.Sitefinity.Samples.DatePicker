using System;
using System.Collections.Generic;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;

namespace DatePicker
{
    class DatePickerFieldDesigner : ContentViewDesignerBase
    {
        /// <summary>
        /// The script control type name passed to the <see cref="T:System.Web.UI.ScriptControlDescriptor"/>. It defaults to the full name
        /// of the current object class. E.g. can be overriden to reuse the script of some of the base classes and just customize
        /// some controls server-side.
        /// </summary>
        /// <value></value>
        protected override string ScriptDescriptorTypeName
        {
            get
            {
                return typeof(ContentViewDesignerBase).FullName;
            }
        }
        protected override void AddViews(Dictionary<string, ControlDesignerView> views)
        {
            var myView = new DatePickerDesignerView();
            views.Add("myview", myView);
        }

        protected override void InitializeControls(GenericContainer container)
        {
            this.PropertyEditor.HideAdvancedMode = true;
            base.InitializeControls(container);
        }

        protected override Type ResourcesAssemblyInfo
        {
            get
            {
                return typeof(Telerik.Sitefinity.Resources.Reference);
            }
        }
    }
}
