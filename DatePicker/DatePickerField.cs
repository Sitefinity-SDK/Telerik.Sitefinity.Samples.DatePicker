using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Data.Metadata;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Metadata.Model;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Modules.Forms;
using Telerik.Sitefinity.Modules.Forms.Web.UI.Fields;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using Telerik.Sitefinity.Web.UI.Fields;
using Telerik.Web.UI;

namespace DatePicker
{
    [ControlDesigner(typeof(DatePickerFieldDesigner))]
    [DatabaseMapping(UserFriendlyDataType.Date)]
    public class DatePickerField : FieldControl, IFormFieldControl
    {
        private JavaScriptSerializer serializer = new JavaScriptSerializer();

        public string Minimum
        {
            get;
            set;
        }

        public string Maximum
        {
            get;
            set;
        }
       
        protected override WebControl DescriptionControl
        {
            get
            {
                return this.Container.GetControl<Label>("descriptionLabel", true);
            }
        }

        protected override WebControl ExampleControl
        {
            get
            {
                return this.Container.GetControl<Label>("exampleLabel", true);
            }
        }

        protected override WebControl TitleControl
        {
            get
            {
                return this.Container.GetControl<Label>("titleLabel", true);
            }
        }

        protected virtual RadDatePicker DatePicker
        {
            get
            {
                return this.Container.GetControl<RadDatePicker>("datePicker", true);
            }
        }

        public DatePickerField() : base()
        {
            this.Title = Res.Get<FormsResources>().Untitled;
        }

        protected override void InitializeControls(GenericContainer container)
        {
            this.Value = DateTime.Now;
            if (this.Minimum != null)
            {
                this.DatePicker.MinDate = (DateTime)this.serializer.Deserialize(this.Minimum, typeof(DateTime));
            }

            if (this.Maximum != null)
            {
                this.DatePicker.MaxDate = (DateTime)this.serializer.Deserialize(this.Maximum, typeof(DateTime));
            }

            (this.TitleControl as Label).Text = this.Title;
            (this.DescriptionControl as Label).Text = this.Description;
            (this.ExampleControl as Label).Text = this.Example;
        }

        public override object Value
        {
            get
            {
                return this.DatePicker.SelectedDate;
            }

            set
            {
                this.DatePicker.SelectedDate = value as DateTime?;
            }
        }

        protected override string LayoutTemplateName
        {
            get
            {
                return "DatePicker.DatePickerTemplate.ascx";
            }
        }

        public override IEnumerable<ScriptDescriptor> GetScriptDescriptors()
        {
            var descriptors = new List<ScriptDescriptor>(base.GetScriptDescriptors());
            var descriptor = descriptors.Last() as ScriptControlDescriptor;
            if (this.DatePicker != null)
                descriptor.AddComponentProperty("datepicker", this.DatePicker.ClientID);

            return descriptors;
        }

        public override IEnumerable<ScriptReference> GetScriptReferences()
        {
            var scripts = new List<ScriptReference>(base.GetScriptReferences())
                    {
                        new ScriptReference("DatePicker.DatePickerField.js", typeof(DatePickerField).Assembly.FullName)
                    };
            return scripts;
        }

        private IMetaField metaField;

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public IMetaField MetaField
        {
            get
            {
                if (this.metaField == null)
                {
                    this.metaField = this.LoadDefaultMetaField();
                }

                return this.metaField;
            }

            set
            {
                this.metaField = value;
            }
        }
    }
}