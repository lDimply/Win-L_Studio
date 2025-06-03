using UnrealBuildTool;

public class Project_VREditorTarget : TargetRules
{
	public Project_VREditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Project_VR");
	}
}
