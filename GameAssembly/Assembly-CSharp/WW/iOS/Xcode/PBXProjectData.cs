/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode.PBX;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	internal class PBXProjectData // TypeDefIndex: 15755
	{
		// Fields
		private Dictionary<string, SectionBase> m_Section; // 0x10
		private PBXElementDict m_RootElements; // 0x18
		private PBXElementDict m_UnknownObjects; // 0x20
		private string m_ObjectVersion; // 0x28
		private List<string> m_SectionOrder; // 0x30
		private Dictionary<string, KnownSectionBase<PBXObjectData>> m_UnknownSections; // 0x38
		private KnownSectionBase<PBXBuildFileData> buildFiles; // 0x40
		private KnownSectionBase<PBXFileReferenceData> fileRefs; // 0x48
		private KnownSectionBase<PBXGroupData> groups; // 0x50
		public KnownSectionBase<PBXContainerItemProxyData> containerItems; // 0x58
		public KnownSectionBase<PBXReferenceProxyData> references; // 0x60
		public KnownSectionBase<PBXSourcesBuildPhaseData> sources; // 0x68
		public KnownSectionBase<PBXFrameworksBuildPhaseData> frameworks; // 0x70
		public KnownSectionBase<PBXResourcesBuildPhaseData> resources; // 0x78
		public KnownSectionBase<PBXCopyFilesBuildPhaseData> copyFiles; // 0x80
		public KnownSectionBase<PBXShellScriptBuildPhaseData> shellScripts; // 0x88
		public KnownSectionBase<PBXNativeTargetData> nativeTargets; // 0x90
		public KnownSectionBase<PBXTargetDependencyData> targetDependencies; // 0x98
		public KnownSectionBase<PBXVariantGroupData> variantGroups; // 0xA0
		public KnownSectionBase<XCBuildConfigurationData> buildConfigs; // 0xA8
		public KnownSectionBase<XCConfigurationListData> buildConfigLists; // 0xB0
		public PBXProjectSection project; // 0xB8
		private Dictionary<string, Dictionary<string, PBXBuildFileData>> m_FileGuidToBuildFileMap; // 0xC0
		private Dictionary<string, PBXFileReferenceData> m_ProjectPathToFileRefMap; // 0xC8
		private Dictionary<string, string> m_FileRefGuidToProjectPathMap; // 0xD0
		private Dictionary<PBXSourceTree, Dictionary<string, PBXFileReferenceData>> m_RealPathToFileRefMap; // 0xD8
		private Dictionary<string, PBXGroupData> m_ProjectPathToGroupMap; // 0xE0
		private Dictionary<string, string> m_GroupGuidToProjectPathMap; // 0xE8
		private Dictionary<string, PBXGroupData> m_GuidToParentGroupMap; // 0xF0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass55_0 // TypeDefIndex: 15756
		{
			// Fields
			public string prevSectionName; // 0x10
			public Predicate<string> <>9__0; // 0x18
	
			// Constructors
			public <>c__DisplayClass55_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <ReadFromStream>b__0(string x); // 0x0000000180FF6910-0x0000000180FF6930
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass60_0 // TypeDefIndex: 15757
		{
			// Fields
			public Dictionary<string, bool> allGuids; // 0x10
	
			// Constructors
			public <>c__DisplayClass60_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RepairStructureImpl>b__0(PBXBuildFileData o); // 0x0000000180FF6930-0x0000000180FF69B0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15758
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<PBXGroupData, bool> <>9__60_1; // 0x08
			public static Func<PBXSourcesBuildPhaseData, bool> <>9__60_2; // 0x10
			public static Func<PBXFrameworksBuildPhaseData, bool> <>9__60_3; // 0x18
			public static Func<PBXResourcesBuildPhaseData, bool> <>9__60_4; // 0x20
			public static Func<PBXCopyFilesBuildPhaseData, bool> <>9__60_5; // 0x28
			public static Func<PBXShellScriptBuildPhaseData, bool> <>9__60_6; // 0x30
			public static Func<PBXNativeTargetData, bool> <>9__60_7; // 0x38
			public static Func<PBXVariantGroupData, bool> <>9__60_8; // 0x40
			public static Func<XCConfigurationListData, bool> <>9__60_9; // 0x48
	
			// Constructors
			static <>c(); // 0x0000000180FF69B0-0x0000000180FF6A10
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RepairStructureImpl>b__60_1(PBXGroupData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_2(PBXSourcesBuildPhaseData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_3(PBXFrameworksBuildPhaseData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_4(PBXResourcesBuildPhaseData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_5(PBXCopyFilesBuildPhaseData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_6(PBXShellScriptBuildPhaseData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_7(PBXNativeTargetData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_8(PBXVariantGroupData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
			internal bool <RepairStructureImpl>b__60_9(XCConfigurationListData o); // 0x0000000180FF5DA0-0x0000000180FF5DC0
		}
	
		// Constructors
		public PBXProjectData(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public PBXBuildFileData BuildFilesGet(string guid); // 0x00000001816843A0-0x0000000181684400
		public void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile); // 0x0000000181684100-0x0000000181684240
		public void BuildFilesRemove(string targetGuid, string fileGuid); // 0x0000000181684400-0x00000001816844C0
		public PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid); // 0x0000000181684290-0x00000001816843A0
		public IEnumerable<PBXBuildFileData> BuildFilesGetAll(); // 0x0000000181684240-0x0000000181684290
		public void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef); // 0x0000000181685870-0x00000001816859C0
		public PBXFileReferenceData FileRefsGet(string guid); // 0x0000000181685B30-0x0000000181685B90
		public PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree); // 0x0000000181685A50-0x0000000181685B30
		public PBXFileReferenceData FileRefsGetByProjectPath(string path); // 0x00000001816859C0-0x0000000181685A50
		public void FileRefsRemove(string guid); // 0x0000000181685B90-0x0000000181685E40
		public PBXGroupData GroupsGet(string guid); // 0x0000000181686150-0x00000001816861B0
		public PBXGroupData GroupsGetByChild(string childGuid); // 0x0000000181685F90-0x0000000181685FF0
		public PBXGroupData GroupsGetMainGroup(); // 0x0000000181686080-0x0000000181686150
		public PBXGroupData GroupsGetByProjectPath(string sourceGroup); // 0x0000000181685FF0-0x0000000181686080
		public void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr); // 0x0000000181685EA0-0x0000000181685F90
		public void GroupsAddDuplicate(PBXGroupData gr); // 0x0000000181685E40-0x0000000181685EA0
		public void GroupsRemove(string guid); // 0x00000001816861B0-0x00000001816862A0
		public FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef); // 0x00000001816844C0-0x0000000181684CC0
		public FileGUIDListBase BuildSectionAny(string sectionGuid); // 0x0000000181684CC0-0x0000000181684E90
		private void RefreshBuildFilesMapForBuildFileGuidList(Dictionary<string, PBXBuildFileData> mapForTarget, FileGUIDListBase list); // 0x0000000181687260-0x0000000181687460
		private void RefreshMapsForGroupChildren(string projectPath, string realPath, PBXSourceTree realPathTree, PBXGroupData parent); // 0x0000000181687460-0x0000000181687960
		private void RefreshAuxMaps(); // 0x0000000181686D70-0x0000000181687260
		public void Clear(); // 0x0000000181684E90-0x0000000181685870
		private void BuildCommentMapForBuildFiles(GUIDToCommentMap comments, List<string> guids, string sectName); // 0x0000000181681670-0x00000001816818C0
		private GUIDToCommentMap BuildCommentMap(); // 0x00000001816818C0-0x0000000181684100
		private static PBXElementDict ParseContent(string content); // 0x00000001816862A0-0x00000001816864C0
		public void ReadFromStream(TextReader sr); // 0x00000001816864C0-0x0000000181686D70
		public string WriteToString(); // 0x0000000181689900-0x000000018168A070
		private void RepairStructure(List<string> allGuids); // 0x0000000181689770-0x0000000181689900
		private static void RemoveMissingGuidsFromGuidList(GUIDList guidList, Dictionary<string, bool> allGuids); // 0x0000000181687960-0x0000000181687C80
		private static bool RemoveObjectsFromSection<T>(KnownSectionBase<T> section, Dictionary<string, bool> allGuids, Func<T, bool> checker)
			where T : PBXObjectData, new();
		private bool RepairStructureImpl(Dictionary<string, bool> allGuids); // 0x0000000181687C80-0x0000000181689770
	}
}
