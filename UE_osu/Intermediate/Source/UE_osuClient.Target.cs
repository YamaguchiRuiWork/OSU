using UnrealBuildTool;

public class UE_osuClientTarget : TargetRules
{
	public UE_osuClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("UE_osu");
	}
}
