/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.Extensions
{
	public static class PBXProjectExtensions // TypeDefIndex: 15788
	{
		// Fields
		internal static FlagList appExtensionReleaseBuildFlags; // 0x00
		internal static FlagList appExtensionDebugBuildFlags; // 0x08
		internal static FlagList watchExtensionReleaseBuildFlags; // 0x10
		internal static FlagList watchExtensionDebugBuildFlags; // 0x18
		internal static FlagList watchAppReleaseBuildFlags; // 0x20
		internal static FlagList watchAppDebugBuildFlags; // 0x28
	
		// Nested types
		internal class FlagList : List<KeyValuePair<string, string>> // TypeDefIndex: 15789
		{
			// Constructors
			public FlagList(); // 0x00000001816772C0-0x0000000181677320
	
			// Methods
			public void Add(string flag, string value); // 0x0000000181677230-0x00000001816772C0
		}
	
		// Constructors
		static PBXProjectExtensions(); // 0x000000018168AF00-0x000000018168B9A0
	
		// Extension methods
		private static void SetBuildFlagsFromDict(this PBXProject proj, string configGuid, IEnumerable<KeyValuePair<string, string>> data); // 0x000000018168AA30-0x000000018168AC00
		internal static void SetDefaultAppExtensionReleaseBuildFlags(this PBXProject proj, string configGuid); // 0x000000018168AC80-0x000000018168AD00
		internal static void SetDefaultAppExtensionDebugBuildFlags(this PBXProject proj, string configGuid); // 0x000000018168AC00-0x000000018168AC80
		internal static void SetDefaultWatchExtensionReleaseBuildFlags(this PBXProject proj, string configGuid); // 0x000000018168AE80-0x000000018168AF00
		internal static void SetDefaultWatchExtensionDebugBuildFlags(this PBXProject proj, string configGuid); // 0x000000018168AE00-0x000000018168AE80
		internal static void SetDefaultWatchAppReleaseBuildFlags(this PBXProject proj, string configGuid); // 0x000000018168AD80-0x000000018168AE00
		internal static void SetDefaultWatchAppDebugBuildFlags(this PBXProject proj, string configGuid); // 0x000000018168AD00-0x000000018168AD80
		public static string AddAppExtension(this PBXProject proj, string mainTargetGuid, string name, string bundleId, string infoPlistPath); // 0x000000018168A070-0x000000018168A390
		public static string AddWatchApp(this PBXProject proj, string mainTargetGuid, string watchExtensionTargetGuid, string name, string bundleId, string infoPlistPath); // 0x000000018168A390-0x000000018168A790
		public static string AddWatchExtension(this PBXProject proj, string mainTarget, string name, string bundleId, string infoPlistPath); // 0x000000018168A790-0x000000018168AA30
	}
}
