// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DeukwooLee : ModuleRules
{
	public DeukwooLee(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "UMG", "HeadMountedDisplay" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        // 경로 생략 코드
        PublicIncludePaths.AddRange(new string[] { "DeukwooLee", "DeukwooLee/Public", "DeukwooLee/Public/GameMode" });
        PrivateIncludePaths.AddRange(new string[] { "DeukwooLee/Private", "DeukwooLee/Private/GameMode" });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
