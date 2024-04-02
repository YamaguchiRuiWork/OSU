using UnrealBuildTool;

public class UE_osuTarget : TargetRules
{
	public UE_osuTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("UE_osu");
	}
}
