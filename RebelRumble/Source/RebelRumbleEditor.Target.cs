// © Jamie Page 2019

using UnrealBuildTool;
using System.Collections.Generic;

public class RebelRumbleEditorTarget : TargetRules
{
	public RebelRumbleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "RebelRumble" } );
	}
}
