using UnrealBuildTool;

public class Project_VRServerTarget : TargetRules
{
	public Project_VRServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Project_VR");
	}
}
