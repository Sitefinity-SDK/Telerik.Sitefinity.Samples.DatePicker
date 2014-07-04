using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using DatePicker;
using Telerik.Sitefinity.Modules.Forms.Web.UI;
using Telerik.Sitefinity.Modules.Forms.Web.UI.Fields;
using Telerik.Sitefinity.Samples.Common;
using Telerik.Sitefinity.Services;

namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {
        private const string SamplesThemeName = "SamplesTheme";
        private const string SamplesThemePath = "~/App_Data/Sitefinity/WebsiteTemplates/Samples/App_Themes/Samples";

        private const string SamplesTemplateId = "015b4db0-1d4f-4938-afec-5da59749e0e8";
        private const string SamplesTemplateName = "SamplesMasterPage";
        private const string SamplesTemplatePath = "~/App_Data/Sitefinity/WebsiteTemplates/Samples/App_Master/Samples.master";

        private const string DatePickerFormWidgetPageId = "b210e2f7-3a43-4621-a729-9c13b463a6c4";
        private const string DatePickerFormWidgetPageName = "DatePicker Form Widget";
        private const string DatePickerFormId = "C9C544BF-1152-4223-94DB-6119CD5E973A";

        protected void Application_Start(object sender, EventArgs e)
        {
            SystemManager.ApplicationStart += this.SystemManager_ApplicationStart; 
        }

        private void SystemManager_ApplicationStart(object sender, EventArgs e)
        {
            SystemManager.RunWithElevatedPrivilegeDelegate worker = new SystemManager.RunWithElevatedPrivilegeDelegate(this.CreateSampleWorker);
            SystemManager.RunWithElevatedPrivilege(worker);
        }

        private void CreateSampleWorker(object[] args)
        {            
            SampleUtilities.RegisterFormWidget("DatePickerWidget", typeof(DatePickerField), "Samples");
            SampleUtilities.RegisterTheme(SamplesThemeName, SamplesThemePath);
            SampleUtilities.RegisterTemplate(new Guid(SamplesTemplateId), SamplesTemplateName, SamplesTemplateName, SamplesTemplatePath, SamplesThemeName);

            var result = SampleUtilities.CreatePage(new Guid(DatePickerFormWidgetPageId), DatePickerFormWidgetPageName, true);

            if (result)
            {
                SampleUtilities.SetTemplateToPage(new Guid(DatePickerFormWidgetPageId), new Guid(SamplesTemplateId));

                var controls = new Dictionary<Control, string>();

                DatePickerField dateField = new DatePickerField();
                dateField.Title = "Date:";

                controls.Add(dateField, "Body");

                FormSubmitButton submitButton = new FormSubmitButton();
                submitButton.Text = "Submit";

                controls.Add(submitButton, "Body");

                SampleUtilities.CreateForm(new Guid(DatePickerFormId), "SampleForm", "Sample Form", "Form submitted successfully. Thank you!", controls);

                FormsControl form = new FormsControl();
                form.FormId = new Guid(DatePickerFormId);

                SampleUtilities.AddControlToPage(new Guid(DatePickerFormWidgetPageId), form, "Content", "Forms Control");

                SampleUtilities.CreateUsersAndRoles();
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}