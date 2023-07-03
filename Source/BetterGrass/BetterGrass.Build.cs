using UnrealBuildTool;

public class BetterGrass : ModuleRules
{
	public BetterGrass(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
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
				"SML",
				"Engine",
				"InputCore",
				"OnlineSubsystem", "OnlineSubsystemUtils", "OnlineSubsystemNULL",
				"SignificanceManager",
				"PhysX", "APEX", "PhysXVehicles", "ApexDestruction",
				"AkAudio",
				"ReplicationGraph",
				"UMG",
				"AIModule",
				"NavigationSystem",
				"AssetRegistry",
				"GameplayTasks",
				"AnimGraphRuntime",
				"Slate", "SlateCore",
				"Json",
				"AbstractInstance"
				// ... add other public dependencies that you statically link with here ...
			}
		);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore", "AITestSuite",
				// ... add private dependencies that you statically link with here ...	
			}
		);
		
		PublicDependencyModuleNames.AddRange( new string[] { "Core", "Projects" } );		
		PrivateDependencyModuleNames.AddRange( new string[] { "CoreUObject", "Engine" } );
	}
}