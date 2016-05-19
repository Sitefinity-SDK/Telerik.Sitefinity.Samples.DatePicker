Progress.Sitefinity.Samples.DatePicker
=====================================

[![Build Status](http://sdk-jenkins-ci.cloudapp.net/buildStatus/icon?job=Telerik.Sitefinity.Samples.DatePicker.CI)](http://sdk-jenkins-ci.cloudapp.net/job/Telerik.Sitefinity.Samples.DatePicker.CI/)

The Date Picker sample projects contains a _Forms_ widget with a custom widget designer. The user can drag and drop the _DatePicker_ widget from the _Forms_ toolbox and place the widget in a form. In the form, the widget defines a _RadDatePicker_ that enables the user to choose a date. The custom widget designer of the form allows users to define a range that is automatically validated by the _RadDatePicker_ built-in validation. 

Using the Date Picker sample, you can: 

* Create a _DatePicker_ form widget
* Register the widget in Sitefinity CMS toolbox
* Create a custom widget designer to manage the range of the date 
* Create a form and a page that displays the form from the code. 


### Requirements
* Sitefinity CMS license
* .NET Framework 4
* Visual Studio 2012
* Microsoft SQL Server 2008R2 or later versions


### Prerequisites

Clear the NuGet cache files. To do this:

1. In Windows Explorer, open the **%localappdata%\NuGet\Cache** folder.
2. Select all files and delete them.

### Nuget package restoration
The solution in this repository relies on NuGet packages with automatic package restore while the build procedure takes place.   
For a full list of the referenced packages and their versions see the [packages.config](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.DatePicker/blob/master/SitefinityWebApp/packages.config) file.    
For a history and additional information related to package versions on different releases of this repository, see the [Releases page](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.DatePicker/releases).    


### Installation instructions: SDK Samples from GitHub

1. In Solution Explorer, navigate to _SitefinityWebApp_ » *App_Data* » _Sitefinity_ » _Configuration_ and select the **StartupConfig.config** file. 
2. Modify the **dbType**, **sqlInstance** and **dbName** values to match your server settings.
3. Build the solution.

For version-specific details about the required Sitefinity CMS NuGet packages for this sample application, click on [Releases](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.DatePicker/releases).

### Login

To login into the Sitefinity CMS backend, use the following credentials:  
**Username:** admin   
**Password:** password

### Additional resources
Progress Sitefinity CMS documentation
* [Develop: Use and extend Sitefinity CMS functionality](http://docs.sitefinity.com/develop-create-and-manage-website-content)
* [Date picker widget: Create the control](http://docs.sitefinity.com/date-picker-widget-create-the-control)
* [Date picker widget: Create the control designer](http://docs.sitefinity.com/date-picker-widget-create-the-control-designer)