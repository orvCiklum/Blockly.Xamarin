/*
#########################################################################################
Installing

	Windows - powershell
		
        Invoke-WebRequest http://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
        .\build.ps1

	Windows - cmd.exe prompt	
	
        powershell ^
			Invoke-WebRequest http://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
        powershell ^
			.\build.ps1
	
	Mac OSX 

        rm -fr tools/; mkdir ./tools/ ; \
        cp cake.packages.config ./tools/packages.config ; \
        curl -Lsfo build.sh http://cakebuild.net/download/bootstrapper/osx ; \
        chmod +x ./build.sh ;
        ./build.sh

	Linux

        curl -Lsfo build.sh http://cakebuild.net/download/bootstrapper/linux
        chmod +x ./build.sh && ./build.sh

Running Cake to Build targets

	Windows

		tools\Cake\Cake.exe --verbosity=diagnostic --target=libs
		tools\Cake\Cake.exe --verbosity=diagnostic --target=nuget
		tools\Cake\Cake.exe --verbosity=diagnostic --target=samples

		tools\Cake\Cake.exe -experimental --verbosity=diagnostic --target=libs
		tools\Cake\Cake.exe -experimental --verbosity=diagnostic --target=nuget
		tools\Cake\Cake.exe -experimental --verbosity=diagnostic --target=samples
		
	Mac OSX 
	
		mono tools/Cake/Cake.exe --verbosity=diagnostic --target=libs
		mono tools/Cake/Cake.exe --verbosity=diagnostic --target=nuget
#########################################################################################
*/
#tool nuget:?package=XamarinComponent&version=1.1.0.32

#addin nuget:?package=Cake.XCode&version=1.0.8
#addin nuget:?package=Cake.Xamarin.Build&version=1.0.16
#addin nuget:?package=Cake.Xamarin&version=1.3.0.3
#addin nuget:?package=Cake.FileHelpers&version=1.0.3.2

var TARGET = Argument ("t", Argument ("target", "Default"));


BuildSpec buildSpec = new BuildSpec () 
{
	Libs = new ISolutionBuilder [] 
	{
		new DefaultSolutionBuilder 
		{
			SolutionPath = "./source/Blockly.Source.sln",
			OutputFiles = new [] 
			{ 
				new OutputFileCopy 
				{ 
					FromFile = "./source/Blockly.Bindings.XamarinAndroid/bin/Release/Blockly.dll" 
				},
				new OutputFileCopy 
				{ 
					FromFile = "./source/Blockly.Bindings.XamarinIOS/bin/Release/Blockly.dll" 
				},
			}
		}
	},

	Samples = new ISolutionBuilder [] 
	{
		new DefaultSolutionBuilder 
		{ 
			SolutionPath = "./samples/Blockly.Samples.sln" 
		},	
	},

	Components = new []
	{
		new Component 
		{ 
			ManifestDirectory = "./component" 
		},
	},

	NuGets = new [] 
	{
		new NuGetInfo 
		{ 
			NuSpec = "./nuget/HolisticWare.Blockly.nuspec" 
		},
	},
};

Task ("externals")
	.IsDependentOn ("externals-base")
	// .WithCriteria (!FileExists ("./externals/Blockly.aar"))
	.Does 
	(
		() => 
		{
			Information("externals ...");

			if (!DirectoryExists ("./externals/"))
			{
				CreateDirectory ("./externals");
			}

			Information("    downloading ...");

			// if ( ! string.IsNullOrEmpty(AAR_URL) )
			// {
			// 	//DownloadFile (AAR_URL, "./externals/Blockly.aar");
			// }
		}
	);


Task ("clean")
	.IsDependentOn ("clean-base")
	.Does
	(
		() => 
		{
			if (DirectoryExists ("./externals/"))
			{
				DeleteDirectory ("./externals", true);
			}
		}
	);

SetupXamarinBuildTasks (buildSpec, Tasks, Task);

RunTarget (TARGET);
