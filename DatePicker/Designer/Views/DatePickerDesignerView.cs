using System.Collections.Generic;
using System.Web.UI;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using Telerik.Web.UI;

namespace DatePicker
{
    public class DatePickerDesignerView : ContentViewDesignerView
    {
        public override string ViewTitle
        {
            get
            {
                return "Limitations";
            }
        }

        public override string ViewName
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public virtual RadDatePicker MinimumPicker
        {
            get
            {
                return this.Container.GetControl<RadDatePicker>("minimumDate", true);
            }
        }

        public virtual RadDatePicker MaximumPicker
        {
            get
            {
                return this.Container.GetControl<RadDatePicker>("maximumDate", true);
            }
        }

        public override IEnumerable<ScriptDescriptor> GetScriptDescriptors()
        {
            var descriptor = new ScriptControlDescriptor(typeof(DatePickerDesignerView).FullName, this.ClientID);
            descriptor.AddComponentProperty("minimumPicker", this.MinimumPicker.ClientID);
            descriptor.AddComponentProperty("maximumPicker", this.MaximumPicker.ClientID);

            return new[] { descriptor };
        }

        public override IEnumerable<ScriptReference> GetScriptReferences()
        {
            return new List<ScriptReference>()
            {
               new ScriptReference("Telerik.Sitefinity.Web.UI.ControlDesign.Scripts.IDesignerViewControl.js", 
                                     typeof(Telerik.Sitefinity.Web.UI.Fields.TextField).Assembly.GetName().ToString()),
                new ScriptReference("DatePicker.Designer.Views.DatePickerDesignerView.js", typeof(DatePickerDesignerView).Assembly.GetName().ToString())
            };
        }

        protected override string LayoutTemplateName
        {
            get
            {
                return "DatePicker.Designer.Views.DatePickerDesignerView.ascx";
            }
        }

        protected override void InitializeControls(GenericContainer container)
        {
        }

        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                //we use div wrapper tag to make easier common styling
                return HtmlTextWriterTag.Div;
            }
        }
    }
}