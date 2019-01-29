// © Jamie Page 2019

using UnrealBuildTool;
using System.Collections.Generic;

public class RebelRumbleTarget : TargetRules
{
	public RebelRumbleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "RebelRumble" } );
	}
}
