using UnrealBuildTool;

public class UE_osuServerTarget : TargetRules
{
	public UE_osuServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("UE_osu");
	}
}
