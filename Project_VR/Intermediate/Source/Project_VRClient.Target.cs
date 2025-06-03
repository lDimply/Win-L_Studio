using UnrealBuildTool;

public class Project_VRClientTarget : TargetRules
{
	public Project_VRClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Project_VR");
	}
}
