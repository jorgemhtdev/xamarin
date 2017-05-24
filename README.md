# Basic guide to learn Xamarin  
![alt text](https://img.shields.io/badge/C%23-Xamarin-blue.svg) 
![alt text](https://img.shields.io/github/license/mashape/apistatus.svg) 
![alt text](https://img.shields.io/badge/progress-15%25-red.svg)

![alt text](https://raw.githubusercontent.com/jorgemht/Xamarin/master/img/Xamarin_logo.png) 

## Getting started

Xamarin is a cross-platform technology where is possible to build native mobile apps for iOS and Android (of course also for Windows Phone) using C#.

## What's Xamarin?

- Founded in May 2011, acquired by Microsoft in February 2016.
- Native iOS, Android, Mac and Windows Mobile App development platform.
- Alway update.
- Native characteristics:
	- Native User Interface.
	- Full SDK Access.
	- Native Perfomance.
	- Share code across platforms.
		
### Differences between traditional Xamarin and Xamarin.Forms

- **[Traditional Xamarin]()**
	- The custom UI is more important than code sharing. Interactions that require native behavior.
	- Use many platform-specific APIs.
- **[Xamarin Forms(XF)](https://github.com/jorgemht/Xamarin/wiki/1.-Xamarin-Forms)** - Provides a way to quickly build native apps for iOS, Android, Windows and macOS, completely in C#: 
	- Code sharing is more important than custom UI.
	- Common interactions across device platforms.
	
![alt text](https://raw.githubusercontent.com/jorgemht/Xamarin/master/img/xamarin.jpg)
	
### The problem of multiplatform development	

In the next table, we can see how each platform integrated its own IDE, one o more programming languages with a specific language for the views and different desing pattern that apply to each platform.

   |   | IOS | ANDROID | WINDOWS |
   | ------------- | ------------- | ------------- | ------------- |
   | IDE	| XCode	|Android Studio	 |Visual Studio |
   | Language	| ObjectiveC o Swift | Java | C# | 		
   | Views	| Storyboard o XIBS | AXML | XAML |
   | Design Pattern	| MVC | MVC | [MVVM](https://www.xamarin.com/forms) |

### What options do we have? Hybrid or native apps

- A native app is a smartphone application developed specifically for a mobile operating system:
	- Native UI is better user experience. Best performance.
	- Access to device hardware or software.
	- Best security.
	
- Hybrid applications are websites packaged into a native wrapper:
	- Portability, one code base can use in multiple platforms.
	- Access to varius hardware or software capabilities through plug-ins.
	- Cheaper origination costs.
	- We write html and javascript code that has to be interpreted by a web browser. 

![alt text](https://raw.githubusercontent.com/jorgemht/Xamarin/master/img/what-is-hybrid.png)	

Xamarin offers us a different alternative because it allows us to develop native applications for the most used platforms (iOS, Android and Windows). We have access to native APIS and .NET APIs with the same language, C#.

Interesting alternatives to Xamarin like [React Native](https://facebook.github.io/react-native/) or [Ruby Motion](http://www.rubymotion.com) but, in my opinion by acceptance, quota, community and evolution Xamarin shines with its own light.

> Native applications have the best performance, highest security, and best user experience.

## Install Xamarin

To install Xamarin, simply head over to http://xamarin.com/download and download the installer. 

If you do not have visual studio installed in your computer, you can download visual studio plus xamarin https://www.visualstudio.com/xamarin/ and click download and later "Visual Studio Community with Xamarin for Windows" (under the button Download Xamarin Studio Community).

*Setting Up Xamarin (Manual Installation):*

- **Windows Users**
    - [Xamarin.Android Manual Installation](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/).
    - [Xamarin.iOS Manual Installation](https://developer.xamarin.com/guides/ios/getting_started/installation/windows/).
- **Mac Users**
    - [Xamarin.Android Manual Installation](https://developer.xamarin.com/guides/android/getting_started/installation/mac/manual_installation/).
    - [Xamarin.iOS Manual Installation](https://developer.xamarin.com/guides/ios/getting_started/installation/mac/manual_installation/).
    
### Setting Up a Mobile Device:

You can run your Xamarin Forms apps in simulators. While these simulators work reasonably well, in some cases you may need to deploy your app to a real device.

- [Android device](https://developer.xamarin.com/guides/android/getting_started/installation/set_up_device_for_development/).
- [iOS device](https://developer.xamarin.com/guides/ios/getting_started/installation/device_provisioning/).
- [Windows 10 Mobile](https://docs.microsoft.com/en-gb/windows/uwp/get-started/enable-your-device-for-development).
- [Windows Phone 8](https://msdn.microsoft.com/en-us/library/windows/apps/ff769508(v=vs.105).aspx).

### Xamarin Live Player

**Xamarin Live Player** is an app for Android and iOS, which allows the developers to continuously build, test and debug their apps directly from Visual Studio 2017 IDE.
- [Download Xamarin Live Player for iOS](https://itunes.apple.com/us/app/xamarin-live-player/id1228841832?ls=1&mt=8).
- [Download Xamarin Live Player for Android](https://play.google.com/store/apps/details?id=com.xamarin.live).

## Tools and resources:
- **Only Windows**
	- [Visual Studio 2017](https://www.visualstudio.com/downloads/).
	- [Xamarin](http://xamarin.com/download).
	- [Visual Studio 2017 + Xamarin](https://www.visualstudio.com/xamarin/).
	- **Visual Studio Extension**
  		- [Resharper](https://www.jetbrains.com/resharper) -  It finds compiler errors, runtime errors, redundancies, and code smells right as you type, suggesting intelligent corrections for them [...(more information)](https://www.visualstudiogallery.msdn.microsoft.com/EA4AC039-1B5C-4D11-804E-9BEDE2E63ECF) 
- **Only Mac**
	- [Visual Studio](https://www.visualstudio.com/vs/visual-studio-mac). 
	- [Sketch app](https://www.sketchapp.com) - Sketch is an amazing app for Mac that allows you to easily create stunning designs, mostly for UI and UX designers.
- [Genymotion](https://www.genymotion.com) - Genymotion is a fast third-party emulator that can be used instead of the default Android emulator. In some cases it's as good as or better than developing on actual devices!
- [Lucidchart](https://www.lucidchart.com) - Lucidchart is an ideal diagram tool for:
	- [ER diagram tool](https://www.lucidchart.com/pages/tour/ER_diagram_tool).
  	- [UML diagram tool](https://www.lucidchart.com/pages/examples/uml_diagram_tool).
	- [Database Design tool](https://www.lucidchart.com/pages/database-diagram/database-design-tool).
	- [Integrations](https://www.lucidchart.com/pages/integrations).
- **Working with Json**
	- [Postman](https://www.getpostman.com) - Postman is a powerful HTTP client for testing web service.
 	- [Fiddler](http://www.telerik.com/fiddler) - Fiddler is a data monitoring tool that allows you to see incoming and outgoing HTTP(s) traffic from your computer.
  	- [Jsonlint](https://jsonlint.com) - Open source project which allows you to validate your JSON data.
	- [Json editor](http://www.jsoneditoronline.org) - Similar to the previous one, except that it allows to edit the Json with a friendly interface.
	- **[Json2csharp](http://json2csharp.com) - Generate c# classes from json.**
- **Design**
	- [Color Adobe](color.adobe.com) - "The color blender". I do not combine colors but color adober offers color themes for anyone who wants to use them. You can create a color combination from a color, a photo or by exploring other users themes.
		- [most popular](https://color.adobe.com/explore/?filter=most-popular&time=all).
		- [most used](https://color.adobe.com/explore/?filter=most-used&time=all).
		- [random](https://color.adobe.com/explore/?filter=random&time=all).
	- Free Icons
		- [Icons](https://thenounproject.com).
	- [Android Asset Studio](https://romannurik.github.io/AndroidAssetStudio/index.html) - A collection of tools to easily generate assets such as launcher icons for your Android app.
- **Placeholders**
	- [Lipsum](http://lipsum.com) - Filler text commonly used to demonstrate the visual presentation.
	- [Lorempixel](http://lorempixel.com) - Filler images commonly used to demonstrate the visual presentation.
	- [Placehold](https://placehold.it) - Filler images commonly used to demonstrate the visual presentation.
- **Public APIs**
	- Currency Exchange:
		- [Open Exchangerates](https://docs.openexchangerates.org/docs/) - Exchange rates and currency conversion.  [Signup](https://openexchangerates.org/signup). [Example](https://github.com/jorgemht/Xamarin/tree/master/CurrencyConverterJSON).
	
## Controls Reference

 **The content of 'Controls Reference' taken from [here](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls)**

Xamarin.Forms uses use the native controls of each target platform. This means applications can use Portable Class Libraries or Shared Projects to house this shared code, and then make platform specific applications that will consume the shared code.

There are four main control groups used to create the user interface of a Xamarin.Forms application: 
- [Pages](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/pages).
- [Layouts](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/layouts).
- [Views](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/views) - We use the word 'view' to refer to visual elements like buttons, texts or text boxes, also known as controls or widgets on other platforms.
- [Cells](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/cells).

At runtime each control will be mapped to its native equivalent, which is what will be rendered.

**The following tables are a content of the links previously mentioned (Pages, Layouts, Views, Cells).**
 
- **Pages** 

   | TYPE  | DESCRIPTION |
   | ------------- | ------------- |
   | ContentPage	 | 	A ContentPage displays a single View, often a container such as a StackLayout or a ScrollView.	 |
   | MasterDetailPage	 | 	A Page that manages two panes of information. |
   | NavigationPage	 | 	A Page that manages the navigation and user-experience of a stack of other pages. |
   | TabbedPage	 | A Page that allows navigation between children pages, using tabs.	 |
   | TemplatedPage	 |A Page that displays full-screen content with a control template, and the base class for ContentPage.	 |
   | CarouselPage	 | A Page allowing swipe gestures between subpages, like a gallery.	 |
   
   ![alt text](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/pages/Images/Pages.png) 
   
- **Layouts** 

   | TYPE  | DESCRIPTION |
   | ------------- | ------------- |
   | ContentPresenter	 | A layout manager for templated views. Used within a ControlTemplate to mark where the content to be presented appears.	 |
   | ContentView	 | An element with a single content. ContentView has very little use of its own. Its purpose is to serve as a base class for user-defined compound views.	 |
   | Frame	 | An element containing a single child, with some framing options. Frame have a default Xamarin.Forms.Layout.Padding of 20.	 |
   | ScrollView	 | An element capable of scrolling if it's Content requires. |
   | TemplatedView	 | An element that displays content with a control template, and the base class for ContentView.	 |
   | AbsoluteLayout	 | Positions child elements at absolute requested positions. User assigned anchors and bounds defines the position and size of the control.	 |
   | Grid	 | A layout containing views arranged in rows and columns. |
   | RelativeLayout	 | A Layout that uses Constraints to layout its children.	 |
   | StackLayout	 | A Layout that positions child elements in a single line which can be oriented vertically or horizontally. This layout will set the child bounds automatically during a layout cycle. User assigned bounds will be overwritten and thus should not be set on a child element by the user. |
   
   ![alt text](https://developer.xamarin.com/guides/xamarin-forms/user-interface/controls/layouts/Images/Layouts.png)
   
- **Views** We use the word 'view' to refer to visual elements like buttons, texts or text boxes, 
  also known as controls or widgets on other platforms. 
  
  | TYPE  | DESCRIPTION |
  | ------------- | ------------- |
  | ActivityIndicator	| A visual control used to indicate that something is ongoing. This control gives a visual clue to the user that something is happening, without information about its progress.	  |
  | BoxView           | A View used to draw a solid colored rectangle. BoxView is a useful stand-in for images or custom elements when doing initial prototyping. BoxView has a default size request of 40x40. If you need a different size, assign the VisualElement.WidthRequest and the VisualElement.HeightRequest. |
  | Button	          | A button View that reacts to touch events.	  |
  | DatePicker        | A View that allows date picking. The visual representation of a DatePicker is very similar to the one of Entry, except that a special control for picking a date appears in place of a keyboard |
  | Editor	          | A control that can edit multiple lines of text. |
  | Entry             | A control that can edit a single line of text. Entry is a single line text entry. It is best used for collecting small discrete pieces of information, like usernames and passwords. |
  | Image	            | A View that holds an image.  |
  | Label             | A View that displays text in a read only format. A Label is used to display single-line text elements as well as multi-lines blocks of text.  |
  | ListView	        | An ItemView that displays a collection of data as a vertical list. |
  | OpenGLView	      | A View that displays OpenGL content. |
  | Picker	          | A View control for picking an element in a list. The visual representation of a Picker is similar to a Entry, but a picker control appears in place of a keyboard. |
  | ProgressBar	      | A View control indicating a progress. |
  | SearchBar	        | A View control that provides a search box.|
  | Slider	          | A View control that inputs a linear value. |
  | Stepper	          | A View control that inputs a discrete value, constrained to a range.|
  | Switch	          | A View control that provides a toggled value.  |
  | TableView	        | A View that holds rows of Cells.  |
  | TimePicker	      | A View control that provides time picking. The visual representation of a TimePicker is very similar to the one of Entry, except that a special control for picking a time appears in place of a keyboard. |  
  | WebView	          | A View that presents HTML content. |
  
 - **Cells** 
 
      | TYPE  | DESCRIPTION |
      | ------------- | ------------- |
      | EntryCell	| A Xamarin.Forms.Cell with a label and a single line text entry field.|
      | SwitchCell	| A Xamarin.Forms.Cell with a label and an on/off switch. |
      | TextCell	| A Xamarin.Forms.Cell with primary and secondary text. |
      | ImageCell	| A Text Cell that also includes an image. |
      

##  Recommended links

### Official Guides:

- [Read more about xamarin forms](https://www.xamarin.com/forms)
- [Xamarin guiades](https://developer.xamarin.com/guides/)
- [Xamarin blog](https://blog.xamarin.com)
- [There is a book about Xamarin](https://developer.xamarin.com/guides/xamarin-forms/creating-mobile-apps-xamarin-forms/)
- [Introduction to Web Services](https://developer.xamarin.com/guides/cross-platform/application_fundamentals/web_services/)
- [Consuming a RESTful Web Service](https://developer.xamarin.com/guides/xamarin-forms/cloud-services/consuming/rest/)
- [Async Support Overview](https://developer.xamarin.com/guides/cross-platform/advanced/async_support_overview/)
- [Xamarin Live Player](https://developer.xamarin.com/guides/cross-platform/live/) - The developers can pair their device with Visual Studio 2017 and you won’t "need a Mac or other machines anymore".

### Security

- [Oauth authentication flow](https://oauth.net/core/diagram.png)
- [oauth](https://oauth.net) - An open protocol to allow secure authorization in a simple and standard method from web, mobile and desktop applications.
- [The Ultimate Guide to Mobile API Security](https://stormpath.com/blog/the-ultimate-guide-to-mobile-api-security)

### Cloud computing. 
- **What Is Cloud Computing?**
	- [PCMAG](http://www.pcmag.com/article2/0,2817,2372163,00.asp)
	- [A beginner's guide](https://azure.microsoft.com/en-in/overview/what-is-cloud-computing/)
- **[Microsoft Azure](azure.microsoft.com):**
	- [Visual Studio Dev Essentials](azure.microsoft.com//pricing/member-offers/vs-dev-essentials/) - Dev Essentials gives you the experience to use Azure for free for 1 year, with a monthly credit of $ 25. 
	- [What is the Azure SDK for .NET?](https://docs.microsoft.com/en-us/azure/dotnet-sdk)
	- [Get the SDKs and command-line tools you need](https://azure.microsoft.com/en-us/downloads)
	- [Azure webinars](https://azure.microsoft.com/en-gb/overview/webinars)
	- [ZUMO-API-VERSION](https://docs.microsoft.com/en-us/azure/app-service-mobile/app-service-mobile-client-and-server-versioning)
	- [Azure Security Services and Technologies](https://docs.microsoft.com/en-us/azure/security/azure-security-services-technologies)
	- [Protecting Web API Backend with Azure Active Directory and API Management](https://azure.microsoft.com/en-us/resources/videos/protecting-web-api-backend-with-azure-active-directory-and-api-management)
- **[Aws Amazon](https://aws.amazon.com)**	
- **[Cloud Google](cloud.google.com)**


### JSON:
- [What is JSON?](https://developers.squarespace.com/what-is-json)
- [Introducing JSON](http://json.org)

### NuGet:

- [What is NuGet?](https://www.nuget.org)
- [MVVM Light](https://www.nuget.org/packages/MvvmLightLibs)
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json) ([Web official](http://www.newtonsoft.com/json))
- [Mobile SQLiteStore](https://www.nuget.org/packages/Microsoft.Azure.Mobile.Client.SQLiteStore/) - Offline sync, azure allows offline synchronization of data with few lines of code.
	- Allows access to information without a network.
	- Automatic data synchronization with local cache.
	- Control over when synchronization is performed.

### Backend as a service provider:

- [Parse](http://parseplatform.org)
- [Realm](https://realm.io)
- [Firebase](https://firebase.google.com/)

### ASP.NET

- [What's the relationship between the Xamarin and .Net Core?](https://forums.xamarin.com/discussion/67734/whats-the-relationship-between-the-xamarin-and-net-core)
- [Getting Started with ASP.NET Core](https://developer.xamarin.com/guides/cross-platform/asp-net-core/)


## Purpose & Goal

More than a primer, these examples are intended to get programmers up to speed on xamarin as fast as possible so they 
can begin using xamarin productively. These examples only cover the language. To increase your understanding, 
you are encouraged to experiment with them along the way. Play the 'what-if' game. 

You could read the different examples with theory and you have another place called “development app” 
where you can download some app and continue developing (expanding features).

**About "Tools and resources" ... I do not receive any money through affiliate or otherwise. These tools I use daily. I only share my opinion on what tools to use. If you know of others that can be useful also be delighted to try them**	

## People to follow

- Rob Gibbens 
	- [Esilient network services with mobile Xamarin apps](http://arteksoftware.com/resilient-network-services-with-xamarin/)
 	- [Blog](http://arteksoftware.com)
	- [Github](https://github.com/RobGibbens)
- James Montemagno
	- [Blog](http://motzcod.es).
	- [Github](https://github.com/jamesmontemagno) [ConnectivityPlugin](https://github.com/jamesmontemagno/ConnectivityPlugin) and [MediaPlugin](https://github.com/jamesmontemagno/MediaPlugin).
- Michael Wolfenden
	- [Github](https://github.com/michael-wolfenden) [Polly](https://github.com/App-vNext/Polly).
- Simon Cropp
	- [Github](https://github.com/SimonCropp) ... [Fody](https://github.com/Fody/) and [AsyncErrorHandler](https://github.com/Fody/AsyncErrorHandler).
- Geoffrey Huntley
	- [Blog](https://ghuntley.com)
	- [Github](https://github.com/ghuntley)	 [MvvmCross](https://github.com/MvvmCross/MvvmCross)
- Paul Betts 
	- [Blog](https://log.paulbetts.org)
	- [Github](https://github.com/paulcbetts) ... [Refit](https://github.com/paulcbetts/refit), [Akavache](https://github.com/akavache/Akavache), [Fusillade](https://github.com/paulcbetts/Fusillade), and [ModernHttpClient](https://github.com/paulcbetts/ModernHttpClient)	

## License

The Basic guide to learn Xamarin is released under the MIT License.
