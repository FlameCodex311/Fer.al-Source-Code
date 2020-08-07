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
	public class PBXProject // TypeDefIndex: 16134
	{
		// Fields
		private PBXProjectData m_Data; // 0x10
	
		// Properties
		internal KnownSectionBase<PBXContainerItemProxyData> containerItems { get; } // 0x00000001814CA860-0x00000001814CA880 
		internal KnownSectionBase<PBXReferenceProxyData> references { get; } // 0x000000018043C600-0x000000018043C620 
		internal KnownSectionBase<PBXSourcesBuildPhaseData> sources { get; } // 0x00000001814CA920-0x00000001814CA940 
		internal KnownSectionBase<PBXFrameworksBuildPhaseData> frameworks { get; } // 0x00000001814CA8A0-0x00000001814CA8C0 
		internal KnownSectionBase<PBXResourcesBuildPhaseData> resources { get; } // 0x00000001814CA900-0x00000001814CA920 
		internal KnownSectionBase<PBXCopyFilesBuildPhaseData> copyFiles { get; } // 0x00000001814CA880-0x00000001814CA8A0 
		internal KnownSectionBase<PBXShellScriptBuildPhaseData> shellScripts { get; } // 0x0000000180FA75B0-0x0000000180FA75D0 
		internal KnownSectionBase<PBXNativeTargetData> nativeTargets { get; } // 0x00000001814CA8C0-0x00000001814CA8E0 
		internal KnownSectionBase<PBXTargetDependencyData> targetDependencies { get; } // 0x00000001814CA940-0x00000001814CA960 
		internal KnownSectionBase<PBXVariantGroupData> variantGroups { get; } // 0x00000001814CA960-0x00000001814CA980 
		internal KnownSectionBase<XCBuildConfigurationData> buildConfigs { get; } // 0x00000001814CA840-0x00000001814CA860 
		internal KnownSectionBase<XCConfigurationListData> buildConfigLists { get; } // 0x00000001814CA820-0x00000001814CA840 
		internal PBXProjectSection project { get; } // 0x00000001814CA8E0-0x00000001814CA900 
	
		// Constructors
		public PBXProject(); // 0x00000001814CA7C0-0x00000001814CA820
	
		// Methods
		internal PBXBuildFileData BuildFilesGet(string guid); // 0x00000001814C4350-0x00000001814C43B0
		internal void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile); // 0x00000001814C4190-0x00000001814C42E0
		internal void BuildFilesRemove(string targetGuid, string fileGuid); // 0x00000001814C43B0-0x00000001814C4480
		internal PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid); // 0x00000001814C4330-0x00000001814C4350
		internal IEnumerable<PBXBuildFileData> BuildFilesGetAll(); // 0x00000001814C42E0-0x00000001814C4330
		internal void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef); // 0x00000001814C4930-0x00000001814C4A90
		internal PBXFileReferenceData FileRefsGet(string guid); // 0x00000001814C4C20-0x00000001814C4C80
		internal PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree); // 0x00000001814C4B30-0x00000001814C4C20
		internal PBXFileReferenceData FileRefsGetByProjectPath(string path); // 0x00000001814C4A90-0x00000001814C4B30
		internal void FileRefsRemove(string guid); // 0x00000001814C4C80-0x00000001814C4CA0
		internal PBXGroupData GroupsGet(string guid); // 0x00000001814C6090-0x00000001814C60F0
		internal PBXGroupData GroupsGetByChild(string childGuid); // 0x00000001814C5F60-0x00000001814C5FD0
		internal PBXGroupData GroupsGetMainGroup(); // 0x00000001814C6070-0x00000001814C6090
		internal PBXGroupData GroupsGetByProjectPath(string sourceGroup); // 0x00000001814C5FD0-0x00000001814C6070
		internal void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr); // 0x00000001814C5E60-0x00000001814C5F60
		internal void GroupsAddDuplicate(PBXGroupData gr); // 0x00000001814C5E00-0x00000001814C5E60
		internal void GroupsRemove(string guid); // 0x00000001814C60F0-0x00000001814C61F0
		internal FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef); // 0x00000001814C4480-0x00000001814C44B0
		internal FileGUIDListBase BuildSectionAny(string sectionGuid); // 0x00000001814C44B0-0x00000001814C44D0
		public static string GetPBXProjectPath(string buildPath); // 0x00000001814C5CB0-0x00000001814C5CF0
		public static string GetUnityTargetName(); // 0x00000001814C5DA0-0x00000001814C5DD0
		public static string GetUnityTestTargetName(); // 0x00000001814C5DD0-0x00000001814C5E00
		public string ProjectGuid(); // 0x00000001814C62B0-0x00000001814C62F0
		public string TargetGuidByName(string name); // 0x00000001814C9B40-0x00000001814C9D70
		public static bool IsKnownExtension(string ext); // 0x00000001814C6250-0x00000001814C62B0
		public static bool IsBuildable(string ext); // 0x00000001814C61F0-0x00000001814C6250
		private string AddFileImpl(string path, string projectPath, PBXSourceTree tree, bool isFolderReference); // 0x00000001814C2A90-0x00000001814C2D20
		public string AddFile(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source /* Metadata: 0x007BB920 */); // 0x00000001814C2E40-0x00000001814C2EF0
		public string AddFolderReference(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source /* Metadata: 0x007BB924 */); // 0x00000001814C2EF0-0x00000001814C2FA0
		private void AddBuildFileImpl(string targetGuid, string fileGuid, bool weak, string compileFlags); // 0x00000001814C1500-0x00000001814C1750
		public void AddFileToBuild(string targetGuid, string fileGuid); // 0x00000001814C2E20-0x00000001814C2E40
		public void AddFileToBuildWithFlags(string targetGuid, string fileGuid, string compileFlags); // 0x00000001814C2E00-0x00000001814C2E20
		public void AddFileToBuildSection(string targetGuid, string sectionGuid, string fileGuid); // 0x00000001814C2D20-0x00000001814C2E00
		public List<string> GetCompileFlagsForFile(string targetGuid, string fileGuid); // 0x00000001814C5110-0x00000001814C5260
		public void SetCompileFlagsForFile(string targetGuid, string fileGuid, List<string> compileFlags); // 0x00000001814C93B0-0x00000001814C9460
		public void AddAssetTagForFile(string targetGuid, string fileGuid, string tag); // 0x00000001814C0FB0-0x00000001814C1130
		public void RemoveAssetTagForFile(string targetGuid, string fileGuid, string tag); // 0x00000001814C6420-0x00000001814C66A0
		public void AddAssetTagToDefaultInstall(string targetGuid, string tag); // 0x00000001814C1130-0x00000001814C11F0
		public void RemoveAssetTagFromDefaultInstall(string targetGuid, string tag); // 0x00000001814C66A0-0x00000001814C6780
		public void RemoveAssetTag(string tag); // 0x00000001814C6780-0x00000001814C6CC0
		public bool ContainsFileByRealPath(string path); // 0x00000001814C45C0-0x00000001814C45E0
		public bool ContainsFileByRealPath(string path, PBXSourceTree sourceTree); // 0x00000001814C4530-0x00000001814C45C0
		public bool ContainsFileByProjectPath(string path); // 0x00000001814C44D0-0x00000001814C4530
		public bool ContainsFramework(string targetGuid, string framework); // 0x00000001814C45E0-0x00000001814C4680
		public void AddFrameworkToProject(string targetGuid, string framework, bool weak); // 0x00000001814C2FA0-0x00000001814C3090
		public void RemoveFrameworkFromProject(string targetGuid, string framework); // 0x00000001814C8850-0x00000001814C88D0
		public bool AddCapability(string targetGuid, PBXCapabilityType capability, string entitlementsFilePath = null, bool addOptionalFramework = false /* Metadata: 0x007BB928 */); // 0x00000001814C1D50-0x00000001814C2100
		public void SetTeamId(string targetGuid, string teamId); // 0x00000001814C9880-0x00000001814C9940
		public string FindFileGuidByRealPath(string path, PBXSourceTree sourceTree); // 0x00000001814C4EB0-0x00000001814C5020
		public string FindFileGuidByRealPath(string path); // 0x00000001814C4CF0-0x00000001814C4EB0
		public string FindFileGuidByProjectPath(string path); // 0x00000001814C4CA0-0x00000001814C4CF0
		public void RemoveFileFromBuild(string targetGuid, string fileGuid); // 0x00000001814C7CE0-0x00000001814C8540
		public void RemoveFile(string fileGuid); // 0x00000001814C8540-0x00000001814C87E0
		private void RemoveGroupIfEmpty(PBXGroupData gr); // 0x00000001814C8C50-0x00000001814C8D20
		private void RemoveGroupChildrenRecursive(PBXGroupData parent); // 0x00000001814C88D0-0x00000001814C8C50
		internal void RemoveFilesByProjectPathRecursive(string projectPath); // 0x00000001814C87E0-0x00000001814C8850
		internal List<string> GetGroupChildrenFiles(string projectPath); // 0x00000001814C5830-0x00000001814C5AC0
		internal HashSet<string> GetGroupChildrenFilesRefs(string projectPath); // 0x00000001814C5580-0x00000001814C5830
		internal HashSet<string> GetFileRefsByProjectPaths(IEnumerable<string> paths); // 0x00000001814C5370-0x00000001814C5580
		private PBXGroupData GetPBXGroupChildByName(PBXGroupData group, string name); // 0x00000001814C5AC0-0x00000001814C5CB0
		private PBXGroupData CreateSourceGroup(string sourceGroup); // 0x00000001814C4680-0x00000001814C4930
		internal void AddExternalProjectDependency(string path, string projectPath, PBXSourceTree sourceTree); // 0x00000001814C27B0-0x00000001814C2A90
		internal void AddExternalLibraryDependency(string targetGuid, string filename, string remoteFileGuid, string projectPath, string remoteInfo); // 0x00000001814C2220-0x00000001814C27B0
		public string AddTarget(string name, string ext, string type); // 0x00000001814C3570-0x00000001814C3930
		private IEnumerable<string> GetAllTargetGuids(); // 0x00000001814C5020-0x00000001814C5110
		public string GetTargetProductFileRef(string targetGuid); // 0x00000001814C5D20-0x00000001814C5DA0
		internal void AddTargetDependency(string targetGuid, string targetDependencyGuid); // 0x00000001814C3330-0x00000001814C3570
		private string AddBuildConfigForTarget(string targetGuid, string name); // 0x00000001814C11F0-0x00000001814C1370
		private void RemoveBuildConfigForTarget(string targetGuid, string name); // 0x00000001814C6CC0-0x00000001814C6DD0
		public string BuildConfigByName(string targetGuid, string name); // 0x00000001814C3C80-0x00000001814C3EA0
		public IEnumerable<string> BuildConfigNames(); // 0x00000001814C3EA0-0x00000001814C4190
		public void AddBuildConfig(string name); // 0x00000001814C1370-0x00000001814C1500
		public void RemoveBuildConfig(string name); // 0x00000001814C6DD0-0x00000001814C7060
		public string AddSourcesBuildPhase(string targetGuid); // 0x00000001814C3250-0x00000001814C3330
		public string AddResourcesBuildPhase(string targetGuid); // 0x00000001814C3170-0x00000001814C3250
		public string AddFrameworksBuildPhase(string targetGuid); // 0x00000001814C3090-0x00000001814C3170
		public string AddCopyFilesBuildPhase(string targetGuid, string name, string dstPath, string subfolderSpec); // 0x00000001814C2100-0x00000001814C2220
		internal string GetConfigListForTarget(string targetGuid); // 0x00000001814C5260-0x00000001814C5370
		internal void SetBaseReferenceForConfig(string configGuid, string baseReference); // 0x00000001814C8D20-0x00000001814C8DB0
		public void AddBuildProperty(string targetGuid, string name, string value); // 0x00000001814C19A0-0x00000001814C1BA0
		public void AddBuildProperty(IEnumerable<string> targetGuids, string name, string value); // 0x00000001814C1BA0-0x00000001814C1D50
		public void AddBuildPropertyForConfig(string configGuid, string name, string value); // 0x00000001814C1900-0x00000001814C19A0
		public void AddBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value); // 0x00000001814C1750-0x00000001814C1900
		public void SetBuildProperty(string targetGuid, string name, string value); // 0x00000001814C91B0-0x00000001814C93B0
		public void SetBuildProperty(IEnumerable<string> targetGuids, string name, string value); // 0x00000001814C9000-0x00000001814C91B0
		public void SetBuildPropertyForConfig(string configGuid, string name, string value); // 0x00000001814C8DB0-0x00000001814C8E50
		public void SetBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value); // 0x00000001814C8E50-0x00000001814C9000
		internal void RemoveBuildProperty(string targetGuid, string name); // 0x00000001814C7950-0x00000001814C7B50
		internal void RemoveBuildProperty(IEnumerable<string> targetGuids, string name); // 0x00000001814C7B50-0x00000001814C7CE0
		internal void RemoveBuildPropertyForConfig(string configGuid, string name); // 0x00000001814C7060-0x00000001814C7150
		internal void RemoveBuildPropertyForConfig(IEnumerable<string> configGuids, string name); // 0x00000001814C7150-0x00000001814C72E0
		internal void RemoveBuildPropertyValueList(string targetGuid, string name, IEnumerable<string> valueList); // 0x00000001814C7750-0x00000001814C7950
		internal void RemoveBuildPropertyValueList(IEnumerable<string> targetGuids, string name, IEnumerable<string> valueList); // 0x00000001814C75A0-0x00000001814C7750
		internal void RemoveBuildPropertyValueListForConfig(string configGuid, string name, IEnumerable<string> valueList); // 0x00000001814C7490-0x00000001814C75A0
		internal void RemoveBuildPropertyValueListForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> valueList); // 0x00000001814C72E0-0x00000001814C7490
		public void UpdateBuildProperty(string targetGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x00000001814CA350-0x00000001814CA560
		public void UpdateBuildProperty(IEnumerable<string> targetGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x00000001814CA560-0x00000001814CA710
		public void UpdateBuildPropertyForConfig(string configGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x00000001814C9F20-0x00000001814CA350
		public void UpdateBuildPropertyForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x00000001814C9D70-0x00000001814C9F20
		internal string ShellScriptByName(string targetGuid, string name); // 0x00000001814C9940-0x00000001814C9B40
		internal void AppendShellScriptBuildPhase(string targetGuid, string name, string shellPath, string shellScript); // 0x00000001814C3B80-0x00000001814C3C80
		internal void AppendShellScriptBuildPhase(IEnumerable<string> targetGuids, string name, string shellPath, string shellScript); // 0x00000001814C3930-0x00000001814C3B80
		public void ReadFromFile(string path); // 0x00000001814C62F0-0x00000001814C6380
		public void ReadFromString(string src); // 0x00000001814C63A0-0x00000001814C6420
		public void ReadFromStream(TextReader sr); // 0x00000001814C6380-0x00000001814C63A0
		public void WriteToFile(string path); // 0x00000001814CA710-0x00000001814CA750
		public void WriteToStream(TextWriter sw); // 0x00000001814CA750-0x00000001814CA7A0
		public string WriteToString(); // 0x00000001814CA7A0-0x00000001814CA7C0
		internal PBXProjectObjectData GetProjectInternal(); // 0x00000001814C5CF0-0x00000001814C5D20
		internal void SetTargetAttributes(string key, string value); // 0x00000001814C9460-0x00000001814C9880
	}
}
