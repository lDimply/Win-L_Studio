using UnrealBuildTool;

public class Project_VRTarget : TargetRules
{
	public Project_VRTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Project_VR");
	}
}
