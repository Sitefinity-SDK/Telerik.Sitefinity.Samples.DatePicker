DatePicker sample widget
=====================================

>**Latest supported version**: Sitefinity CMS 11.0.6700.0

>**Documentation articles**: [Tutorial: Create a date picker widget](http://docs.sitefinity.com/tutorial-create-a-date-picker-widget-webforms)

### Overview

The Date Picker sample projects contains a _Forms_ widget with a custom widget designer. The user can drag and drop the _DatePicker_ widget from the _Forms_ toolbox and place the widget in a form. In the form, the widget defines a _RadDatePicker_ that enables the user to choose a date. The custom widget designer of the form allows users to define a range that is automatically validated by the _RadDatePicker_ built-in validation. 

Using the Date Picker sample, you can: 

* Create a _DatePicker_ form widget
* Register the widget in Sitefinity CMS toolbox
* Create a custom widget designer to manage the range of the date 
* Create a form and a page that displays the form from the code. 

### Prerequisites
- You must have a Sitefinity CMS license.
- Your setup must comply with the system requirements.  
 For more information, see the [System requirements](https://docs.sitefinity.com/system-requirements) for the  respective Sitefinity CMS version.

### Installation

1. Clone the sample repository.
2. Clear the NuGet cache files.  
 a. Open the solution file in Visual Studio.  
 b. In the toolbar, navigate to _Tools >> NuGet Package Manager >> Package Manager Settings_.  
 c. In the left pane, navigate to _NuGet Package Manager >> General_.  
 d. Click _Clear All NuGet Cache(s)_.  
3. Restore the NuGet packages in the solution.  
   
   >**NOTE**: The solution in this repository relies on NuGet packages with automatic package restore while the build procedure takes place.   
   >For a full list of the referenced packages and their versions see the [packages.config](http://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.DatePicker/blob/master/SitefinityWebApp/packages.config) file.    
   >For a history and additional information related to package versions on different releases of this repository, see the [Releases page](http://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.DatePicker/releases).
   >  
   a. Navigate to _Tools >> NuGet Package Manager >> Package Manager Console_.  
   b. In _Source_, select Sitefinity CMS NuGet Repository.  
   c. Click _Restore_ button.
3. In Visual Studio's _Solution Explorer_, navigate to _SitefinityWebApp_ >> _App_Data_ >> _Sitefinity_ >> _Configuration_ and select the `StartupConfig.config` file. 
4. Modify the `dbType`, `sqlInstance`, and `dbName` values to match your server settings.
5. Build the solution.

### Login

1. In the context menu of SitefinityWebApp, click _View >> View in Browser_.  
 After the project initializes, the _License activation_ page appears.
2. Activate your license.  
 For more information, see [Activate a license](http://docs.sitefinity.com/activate-a-license).
3. Setup the project using procedure using procedure [Setup the project](https://docs.sitefinity.com/configure-and-start-a-project).
4. To login into the Sitefinity CMS backend, use the following credentials:  
 **Username:** admin  
 **Password:** password

### Additional resources
Progress Sitefinity CMS documentation: [Develop: Use and extend Sitefinity CMS functionality](http://docs.sitefinity.com/develop-create-and-manage-website-content)
