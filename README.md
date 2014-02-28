Telerik.Sitefinity.Samples.DatePicker
=====================================


The Date Picker sample projects contains a _Forms_ widget with a custom widget designer. The user can drag and drop the _DatePicker_ widget from the _Forms_ toolbox and place the widget in a form. In the form, the widget defines a _RadDatePicker_ that enables the user to choose a date. The custom widget designer of the form allows users to define a range that is automatically validated by the _RadDatePicker_ built-in validation. 

Using the Date Picker sample, you can: 

* Create a _DatePicker_ form widget
* Register the widget in Sitefinity toolbox
* Create a custom widget designer to manage the range of the date 
* Create a form and a page that displays the form from the code. 


### Requirements

* Sitefinity 6.3 license

* .NET Framework 4

* Visual Studio 2012

* Microsoft SQL Server 2008R2 or later versions


### Installation instructions: SDK Samples from GitHub

1. Clone the [Telerik.Sitefinity.Samples.Dependencies](https://github.com/Sitefinty-SDK/Telerik.Sitefinity.Samples.Dependencies) repo to get all assemblies necessary to run for the samples.
2. Fix broken references in the class libraries, for example in **SitefinityWebApp** and **Telerik.Sitefinity.Samples.Common**:

  1. In Solution Explorer, open the context menu of your project node and click _Properties_.  
  
    The Project designer is displayed.
  2. Select the _Reference Paths_ tab page.
  3. Browse and select the folder where **Telerik.Sitefinity.Samples.Dependencies** folder is located.
  4. Click the _Add Folder_ button.


3. In Solution Explorer, navigate to _SitefinityWebApp_ -> *App_Data* -> _Sitefinity_ -> _Configuration_ and select the **DataConfig.config** file. 
4. Modify the **connectionString** value to match your server address.
5. Build the solution.

### Login

To login to Sitefinity backend, use the following credentials: 

**Username:** admin

**Password:** password

### Additional resources

[Developers Guide](http://www.sitefinity.com/documentation/documentationarticles/developers-guide)

[Create a date picker widget - create the widget](http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-create-a-date-picker-control/creating-the-control)

[Create a date picker widget - create the widget designer](http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-create-a-date-picker-control/creating-the-control-designer)
