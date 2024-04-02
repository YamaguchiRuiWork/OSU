using UnrealBuildTool;

public class UE_osuEditorTarget : TargetRules
{
	public UE_osuEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("UE_osu");
	}
}
