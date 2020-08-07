/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode.PBX;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal class PBXProjectData // TypeDefIndex: 16135
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass55_0 // TypeDefIndex: 16136
		{
			// Fields
			public string prevSectionName; // 0x10
			public Predicate<string> <>9__0; // 0x18
	
			// Constructors
			public <>c__DisplayClass55_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <ReadFromStream>b__0(string x); // 0x000000018097C1D0-0x000000018097C1F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass60_0 // TypeDefIndex: 16137
		{
			// Fields
			public Dictionary<string, bool> allGuids; // 0x10
	
			// Constructors
			public <>c__DisplayClass60_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RepairStructureImpl>b__0(PBXBuildFileData o); // 0x00000001814D0F50-0x00000001814D0FD0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16138
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
			static <>c(); // 0x00000001814D0FD0-0x00000001814D1030
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RepairStructureImpl>b__60_1(PBXGroupData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_2(PBXSourcesBuildPhaseData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_3(PBXFrameworksBuildPhaseData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_4(PBXResourcesBuildPhaseData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_5(PBXCopyFilesBuildPhaseData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_6(PBXShellScriptBuildPhaseData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_7(PBXNativeTargetData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_8(PBXVariantGroupData o); // 0x00000001814D0F30-0x00000001814D0F50
			internal bool <RepairStructureImpl>b__60_9(XCConfigurationListData o); // 0x00000001814D0F30-0x00000001814D0F50
		}
	
		// Constructors
		public PBXProjectData(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public PBXBuildFileData BuildFilesGet(string guid); // 0x00000001814B9D80-0x00000001814B9DE0
		public void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile); // 0x00000001814B9AE0-0x00000001814B9C20
		public void BuildFilesRemove(string targetGuid, string fileGuid); // 0x00000001814B9DE0-0x00000001814B9EA0
		public PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid); // 0x00000001814B9C70-0x00000001814B9D80
		public IEnumerable<PBXBuildFileData> BuildFilesGetAll(); // 0x00000001814B9C20-0x00000001814B9C70
		public void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef); // 0x00000001814BB030-0x00000001814BB180
		public PBXFileReferenceData FileRefsGet(string guid); // 0x00000001814BB2F0-0x00000001814BB350
		public PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree); // 0x00000001814BB210-0x00000001814BB2F0
		public PBXFileReferenceData FileRefsGetByProjectPath(string path); // 0x00000001814BB180-0x00000001814BB210
		public void FileRefsRemove(string guid); // 0x00000001814BB350-0x00000001814BB5F0
		public PBXGroupData GroupsGet(string guid); // 0x00000001814BB900-0x00000001814BB960
		public PBXGroupData GroupsGetByChild(string childGuid); // 0x00000001814BB740-0x00000001814BB7A0
		public PBXGroupData GroupsGetMainGroup(); // 0x00000001814BB830-0x00000001814BB900
		public PBXGroupData GroupsGetByProjectPath(string sourceGroup); // 0x00000001814BB7A0-0x00000001814BB830
		public void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr); // 0x00000001814BB650-0x00000001814BB740
		public void GroupsAddDuplicate(PBXGroupData gr); // 0x00000001814BB5F0-0x00000001814BB650
		public void GroupsRemove(string guid); // 0x00000001814BB960-0x00000001814BBA50
		public FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef); // 0x00000001814B9EA0-0x00000001814BA500
		public FileGUIDListBase BuildSectionAny(string sectionGuid); // 0x00000001814BA500-0x00000001814BA6D0
		private void RefreshBuildFilesMapForBuildFileGuidList(Dictionary<string, PBXBuildFileData> mapForTarget, FileGUIDListBase list); // 0x00000001814BC7B0-0x00000001814BC9A0
		private void RefreshMapsForGroupChildren(string projectPath, string realPath, PBXSourceTree realPathTree, PBXGroupData parent); // 0x00000001814BC9A0-0x00000001814BCEA0
		private void RefreshAuxMaps(); // 0x00000001814BC2D0-0x00000001814BC7B0
		public void Clear(); // 0x00000001814BA6D0-0x00000001814BB030
		private void BuildCommentMapForBuildFiles(GUIDToCommentMap comments, List<string> guids, string sectName); // 0x00000001814B7880-0x00000001814B7AC0
		private GUIDToCommentMap BuildCommentMap(); // 0x00000001814B7AC0-0x00000001814B9AE0
		private static PBXElementDict ParseContent(string content); // 0x00000001814BBA50-0x00000001814BBB10
		public void ReadFromStream(TextReader sr); // 0x00000001814BBB10-0x00000001814BC2D0
		public string WriteToString(); // 0x00000001814BEDD0-0x00000001814BF4E0
		private void RepairStructure(List<string> allGuids); // 0x00000001814BEC40-0x00000001814BEDD0
		private static void RemoveMissingGuidsFromGuidList(GUIDList guidList, Dictionary<string, bool> allGuids); // 0x00000001814BCEA0-0x00000001814BD1B0
		private static bool RemoveObjectsFromSection<T>(KnownSectionBase<T> section, Dictionary<string, bool> allGuids, Func<T, bool> checker)
			where T : PBXObjectData, new();
		private bool RepairStructureImpl(Dictionary<string, bool> allGuids); // 0x00000001814BD1B0-0x00000001814BEC40
	}
}
