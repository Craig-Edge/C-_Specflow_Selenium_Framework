1. #Living Donations Automation Framework

2. ##Project description
	* This is the automation framework for the living donations project
	* This framework uses the following technologies, all of which are open source:
		* BODI 
		* C# - 4.7.2 .NET Framework
		* Gherkin
		* Log4Net
		* Selenium 
		* Specflow
		* SpecRun.SpecFlow
		
	* There were some challenges during the creation of this framework:
		* I attempted to have seperate branches with different versions of the Chrome Web Driver
		  this led to multiple version entries in the projects .csproj file that caused intermittent issues at build time.
		* The repo name had whitespace which led to directory filepath issues with local repos, the repo name has since
	      been updated with no whitespace.
	    * The PageFactory and ExpectedConditions classes were depricated from Selenium in version 3.11 which means that alternatives 
	      had to be implemented in their place.  This will be covered in more detail later in the video tutorial, 
		  a link can be found in the “How to use the project” section.

3. ##Framework overview
	* Please click on the link for the Framework Overview document
	(Link to document)

4. ##Steps for installation
	* Things to check:
		* We must ensure that the version of the browsers that is installed on the machine is correct for this project.
		* We have a working version of Visual Studio installed with all of the required additional software, see screenshot below
		* The correct level of access to the repository   
	* Clone the Repo:
		* Open Visual Studio 
		* Click "Clone a repository" on the right hand side in the "Getting Started" section
		* Paste the repo URL into the "Repository Location" field and click clone
	* Build the project
		* Right-click on the project in the solution explorer which by default will be on the right hand pane of the screen
		* Click "Build"
		* If there are build errors reach out to an automation engineer for assistance
	* Install Specflow extension
		* Click on the extensions dropdown menu at the top of the Visual Studio window
		* Click "Manage Extensions", the "Manage Extensions" window will appear
		* Search for "SpecFlow for Visual Studio" and install
	* Create a Specflow account - You will not be able to run Specflow scenarios unless this is performed
		* In the "Test Explorer" pane right-click on a scenario and click run.  If there is no "Text Explorer" pane 
		  click "View" and click the "Test Explorer" option
		* At the bottom of the screen there will be a window named "Output", change the "Show output from" option to "tests"
		* Scroll through the output until you see a message that instructs you to create a Specflow account, there will be a link to the 
		  Specflow account creation page.
		* Click the link
		* Sign up with an email address, I would recommend creating a new email address for this purpose to avoid cluttering up a work email address with emails from Specflow
		* Once the account has been created and linked to Specflow you will be prompted to return to Visual Studio
	* Clean, Build & Run Tests
		* We should now have all of he required set up for you to run your first test.
		* First we will clean the solution, we do this by right-clicking on the project and selecting "Clean"
		* Next we build the solution as we did before
		* Now we run a test scenario as we attempted to before by right-clicking on a test in the "Test Explorer" pane and clicking "Run"
		* The scenario should run without any issues.  If any issues arise please reach out to an automation engineer for support.	

5. ##How to use the project
	* Please click on the link to watch a short video on how to use this framework after the above set up is completed
	(Link to Video)

6. ##Branching Strategy
	* We will follow a GitHub - Flow branching strategy, please click the link for more info 
	[GitHub - Flow](https://docs.github.com/en/get-started/quickstart/github-flow?msclkid=1ee9e23bb42d11ec8ec54444d15d7c64)

7. ##Useful Links
	* [C# Coding best practices](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions?msclkid=72b98579b43311ecb0ee2b34c0bd76c2)
	* [Object Orientated Programming](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/)
	* [Selenium WebDriver](https://www.selenium.dev/documentation/webdriver/?msclkid=8e59ff9fb43311ec8897464babe0fbb5)
	* [SpecFlow](https://docs.specflow.org/projects/getting-started/en/latest/index.html)


