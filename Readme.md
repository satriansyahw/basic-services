#basic-services

This project includes a collection of samples showcasing various prebuilt services available in Crosslight such as navigation services, presenter services, platform services and mobile services. All services are programmable in the shared application layer which allows you to streamline the user interaction logic as well as enable maximum code sharing. Mobile services demonstrate a vast array of services commonly available to mobile platform such as telephony services, location services, camera services, social services, map services and much more. To learn more about mobile services in Crosslight, see [Working with Mobile Services](http://developer.intersoftsolutions.com/display/crosslight/Working+with+Mobile+Services).

![image](http://developer.intersoftsolutions.com/download/attachments/3972619/service-samples.png?version=2&modificationDate=1398825355817&api=v2)


#Supported Platforms

This sample works on the following platforms:

* iOS: iOS 8 and above
* Android: 4.0.3 and above (optimized for 5.0 and above)
* WinPhone: WinPhone 7
* WinStore: WinStore 8

This project requires Crosslight 5.0.5000.526 or higher. For more information, see [Crosslight 5.0 Release Notes](http://developer.intersoftsolutions.com/display/crosslight/Crosslight+5.0+Release+Notes).


#Project Structure

* ServicesSamples.Android.Material: Crosslight Android.Material project, works on phones and tablets.
* ServicesSamples.Core: Shared Portable Class Library project running Profile78.
* ServicesSamples.iOS: Crosslight iOS project, works on iPhones and iPad with Storyboard support.
* ServicesSamples.WinPhone: Windows Phone 7 app.
* ServicesSamples.WinRT: Windows Store 8 app.


#Features Overview

* Demonstrates usage of the navigation services, including push navigation, modal navigation, nested modal navigation and list navigation.
* The use of built-in presenters, such as message presenter, toast presenter, action presenter, and activity presenter.
* Useful mobile services such as telephony, camera, browser, mail, location, etc.
* The use of the view service to run operations on UI thread or background thread.

#Features Highlight

This sample demonstrates various services available in Crosslight, such as:

* Navigation Services
	* Basic Navigation
	* Modal Navigation
	* Nested Modal Navigation
	* List Navigation
* Presenter Services
	* Message Presenter
	* Toast Presenter
	* Action Presenter
	* Activity Presenter
* Mobile Services
	* Telephony & Messaging
	* Camera, Library & Media
	* Browser & Mail
	* Contact
	* Social Sharing
	* Location & Maps
	* Notification & Connectivity
* Platform Services
	* View Service

#Running the Sample

This sample is NuGet-enabled. For more information on restoring NuGet packages, check out this document: [Introduction to Crosslight NuGet Packages](http://developer.intersoftsolutions.com/display/crosslight/Introduction+to+Crosslight+NuGet+Packages#IntroductiontoCrosslightNuGetPackages-RestoringCrosslightPackages).

##Running on Mac
If you run this sample on Mac Xamarin Studio, all you have to do is just open the solution using Xamarin Studio and the NuGet packages will be restored automatically. Simply set one of the platform projects as start-up projects and run.

##Running on Windows
If you run this sample on Windows Visual Studio, right-click on the solution, then choose Restore NuGet packages. Wait until all the NuGet packages are restored, then simply set one of the platform projects as start-up projects and run.

#Relevant Links
* [Working with Mobile Services](http://developer.intersoftsolutions.com/display/crosslight/Working+with+Mobile+Services)


Copyright © Intersoft Solutions.
