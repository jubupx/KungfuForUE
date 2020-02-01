// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class KFEngineRT : ModuleRules
{
	public KFEngineRT(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        string[] HeadPaths = {
            "KFEngineRT/KFRuntime"
            ,"KFEngineRT/KFRuntime/ACTS"
            ,"KFEngineRT/KFRuntime/Core"
            ,"KFEngineRT/KFRuntime/iSay"
            ,"KFEngineRT/KFRuntime/KFData"
            ,"KFEngineRT/KFRuntime/KFScript"
            ,"KFEngineRT/KFRuntime/Serialize"

             , "KFEngineRT/KFApp"
             , "KFEngineRT/KFApp/Network"
             , "KFEngineRT/KFApp/EditMode"
             , "KFEngineRT/KFApp/EditMode/Serialize"
             , "KFEngineRT/KFApp/AppGlobal"
             , "KFEngineRT/KFApp/AppStartup"
        };

        PublicIncludePaths.AddRange(HeadPaths);
        PrivateIncludePaths.AddRange(HeadPaths);



        PublicDependencyModuleNames.AddRange(new string[] 
        { "Core"
        , "CoreUObject"
        , "Engine"
        , "InputCore"
        , "HeadMountedDisplay"
        , "Sockets"
        ,"Networking"
        });
	}
}
