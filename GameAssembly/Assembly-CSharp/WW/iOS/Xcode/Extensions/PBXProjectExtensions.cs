/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.Extensions
{
	public static class PBXProjectExtensions // TypeDefIndex: 16168
	{
		// Fields
		internal static FlagList appExtensionReleaseBuildFlags; // 0x00
		internal static FlagList appExtensionDebugBuildFlags; // 0x08
		internal static FlagList watchExtensionReleaseBuildFlags; // 0x10
		internal static FlagList watchExtensionDebugBuildFlags; // 0x18
		internal static FlagList watchAppReleaseBuildFlags; // 0x20
		internal static FlagList watchAppDebugBuildFlags; // 0x28
	
		// Nested types
		internal class FlagList : List<KeyValuePair<string, string>> // TypeDefIndex: 16169
		{
			// Constructors
			public FlagList(); // 0x0000000180970C40-0x0000000180970CA0
	
			// Methods
			public void Add(string flag, string value); // 0x0000000180970BB0-0x0000000180970C40
		}
	
		// Constructors
		static PBXProjectExtensions(); // 0x0000000180978F70-0x0000000180979A10
	
		// Extension methods
		private static void SetBuildFlagsFromDict(this PBXProject proj, string configGuid, IEnumerable<KeyValuePair<string, string>> data); // 0x0000000180978AB0-0x0000000180978C70
		internal static void SetDefaultAppExtensionReleaseBuildFlags(this PBXProject proj, string configGuid); // 0x0000000180978CF0-0x0000000180978D70
		internal static void SetDefaultAppExtensionDebugBuildFlags(this PBXProject proj, string configGuid); // 0x0000000180978C70-0x0000000180978CF0
		internal static void SetDefaultWatchExtensionReleaseBuildFlags(this PBXProject proj, string configGuid); // 0x0000000180978EF0-0x0000000180978F70
		internal static void SetDefaultWatchExtensionDebugBuildFlags(this PBXProject proj, string configGuid); // 0x0000000180978E70-0x0000000180978EF0
		internal static void SetDefaultWatchAppReleaseBuildFlags(this PBXProject proj, string configGuid); // 0x0000000180978DF0-0x0000000180978E70
		internal static void SetDefaultWatchAppDebugBuildFlags(this PBXProject proj, string configGuid); // 0x0000000180978D70-0x0000000180978DF0
		public static string AddAppExtension(this PBXProject proj, string mainTargetGuid, string name, string bundleId, string infoPlistPath); // 0x0000000180978130-0x0000000180978440
		public static string AddWatchApp(this PBXProject proj, string mainTargetGuid, string watchExtensionTargetGuid, string name, string bundleId, string infoPlistPath); // 0x0000000180978440-0x0000000180978820
		public static string AddWatchExtension(this PBXProject proj, string mainTarget, string name, string bundleId, string infoPlistPath); // 0x0000000180978820-0x0000000180978AB0
	}
}
