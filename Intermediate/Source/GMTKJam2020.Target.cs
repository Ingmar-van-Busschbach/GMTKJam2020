using UnrealBuildTool;

public class GMTKJam2020Target : TargetRules
{
	public GMTKJam2020Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GMTKJam2020");
	}
}
