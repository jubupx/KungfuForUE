// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class KungfuForUE : ModuleRules
{
	public KungfuForUE(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] 
        { "Core"
        , "CoreUObject"
        , "Engine"
        , "InputCore"
        , "HeadMountedDisplay"
        , "KFEngineRT"
        , "KFEngineUE"
        });
	}
}
