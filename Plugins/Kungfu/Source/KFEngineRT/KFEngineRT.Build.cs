// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

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
        
        PrivateIncludePaths.AddRange(HeadPaths);
        
        string[]  PPaths = new string[]
        {
            "KFApp",
            "KFApp/Network",
            "KFApp/EditMode",
            "KFApp/EditMode/Serialize",
            "KFApp/AppGlobal",
            "KFApp/AppStartup",

            "KFRuntime",
            "KFRuntime/KFData",
            "KFRuntime/KFScript",
            "KFRuntime/Core",
            "KFRuntime/ACTS",
            "KFRuntime/iSay"
        
        };
        
        
        for(int i = 0;i < PPaths.Length; i ++)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, PPaths[i]));
        }
        
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
