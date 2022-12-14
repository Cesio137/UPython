// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UPython : ModuleRules
{
	public UPython(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bUseRTTI = true;
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
				"$(PluginDir)/Source/ThirdParty/UPythonLibrary",
				"$(PluginDir)/Source/ThirdParty/UPythonLibrary/Win64/Include"
                
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "CoreUObject",
				"Engine",
                "Json", 
                "JsonUtilities", 
				"UPythonLibrary",
				"Projects"
                // ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
