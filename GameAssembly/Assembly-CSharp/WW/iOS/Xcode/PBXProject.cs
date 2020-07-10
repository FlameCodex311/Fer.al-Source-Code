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
	public class PBXProject // TypeDefIndex: 15754
	{
		// Fields
		private PBXProjectData m_Data; // 0x10
	
		// Properties
		internal KnownSectionBase<PBXContainerItemProxyData> containerItems { get; } // 0x0000000181697D20-0x0000000181697D40 
		internal KnownSectionBase<PBXReferenceProxyData> references { get; } // 0x000000018038E060-0x000000018038E080 
		internal KnownSectionBase<PBXSourcesBuildPhaseData> sources { get; } // 0x0000000181697E10-0x0000000181697E30 
		internal KnownSectionBase<PBXFrameworksBuildPhaseData> frameworks { get; } // 0x0000000181697D70-0x0000000181697D90 
		internal KnownSectionBase<PBXResourcesBuildPhaseData> resources { get; } // 0x0000000181697DF0-0x0000000181697E10 
		internal KnownSectionBase<PBXCopyFilesBuildPhaseData> copyFiles { get; } // 0x0000000181697D40-0x0000000181697D70 
		internal KnownSectionBase<PBXShellScriptBuildPhaseData> shellScripts { get; } // 0x00000001807356B0-0x00000001807356E0 
		internal KnownSectionBase<PBXNativeTargetData> nativeTargets { get; } // 0x0000000181697D90-0x0000000181697DC0 
		internal KnownSectionBase<PBXTargetDependencyData> targetDependencies { get; } // 0x0000000181697E30-0x0000000181697E60 
		internal KnownSectionBase<PBXVariantGroupData> variantGroups { get; } // 0x0000000181697E60-0x0000000181697E90 
		internal KnownSectionBase<XCBuildConfigurationData> buildConfigs { get; } // 0x0000000181697CF0-0x0000000181697D20 
		internal KnownSectionBase<XCConfigurationListData> buildConfigLists { get; } // 0x0000000181697CC0-0x0000000181697CF0 
		internal PBXProjectSection project { get; } // 0x0000000181697DC0-0x0000000181697DF0 
	
		// Constructors
		public PBXProject(); // 0x0000000181697C60-0x0000000181697CC0
	
		// Methods
		internal PBXBuildFileData BuildFilesGet(string guid); // 0x00000001816913D0-0x0000000181691440
		internal void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile); // 0x0000000181691200-0x0000000181691350
		internal void BuildFilesRemove(string targetGuid, string fileGuid); // 0x0000000181691440-0x0000000181691510
		internal PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid); // 0x00000001816913B0-0x00000001816913D0
		internal IEnumerable<PBXBuildFileData> BuildFilesGetAll(); // 0x0000000181691350-0x00000001816913B0
		internal void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef); // 0x00000001816919E0-0x0000000181691B40
		internal PBXFileReferenceData FileRefsGet(string guid); // 0x0000000181691CD0-0x0000000181691D40
		internal PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree); // 0x0000000181691BE0-0x0000000181691CD0
		internal PBXFileReferenceData FileRefsGetByProjectPath(string path); // 0x0000000181691B40-0x0000000181691BE0
		internal void FileRefsRemove(string guid); // 0x0000000181691D40-0x0000000181691D60
		internal PBXGroupData GroupsGet(string guid); // 0x00000001816931B0-0x0000000181693220
		internal PBXGroupData GroupsGetByChild(string childGuid); // 0x0000000181693080-0x00000001816930F0
		internal PBXGroupData GroupsGetMainGroup(); // 0x0000000181693190-0x00000001816931B0
		internal PBXGroupData GroupsGetByProjectPath(string sourceGroup); // 0x00000001816930F0-0x0000000181693190
		internal void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr); // 0x0000000181692F80-0x0000000181693080
		internal void GroupsAddDuplicate(PBXGroupData gr); // 0x0000000181692F10-0x0000000181692F80
		internal void GroupsRemove(string guid); // 0x0000000181693220-0x0000000181693320
		internal FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef); // 0x0000000181691510-0x0000000181691540
		internal FileGUIDListBase BuildSectionAny(string sectionGuid); // 0x0000000181691540-0x0000000181691560
		public static string GetPBXProjectPath(string buildPath); // 0x0000000181692DC0-0x0000000181692E00
		public static string GetUnityTargetName(); // 0x0000000181692EB0-0x0000000181692EE0
		public static string GetUnityTestTargetName(); // 0x0000000181692EE0-0x0000000181692F10
		public string ProjectGuid(); // 0x00000001816934B0-0x0000000181693500
		public string TargetGuidByName(string name); // 0x0000000181696F20-0x0000000181697160
		public static bool IsKnownExtension(string ext); // 0x0000000181693380-0x00000001816934B0
		public static bool IsBuildable(string ext); // 0x0000000181693320-0x0000000181693380
		private string AddFileImpl(string path, string projectPath, PBXSourceTree tree, bool isFolderReference); // 0x000000018168F7F0-0x000000018168FB00
		public string AddFile(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source /* Metadata: 0x00784F04 */); // 0x000000018168FC60-0x000000018168FD10
		public string AddFolderReference(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source /* Metadata: 0x00784F08 */); // 0x000000018168FD10-0x000000018168FDC0
		private void AddBuildFileImpl(string targetGuid, string fileGuid, bool weak, string compileFlags); // 0x000000018168DFC0-0x000000018168E3A0
		public void AddFileToBuild(string targetGuid, string fileGuid); // 0x000000018168FC40-0x000000018168FC60
		public void AddFileToBuildWithFlags(string targetGuid, string fileGuid, string compileFlags); // 0x000000018168FC20-0x000000018168FC40
		public void AddFileToBuildSection(string targetGuid, string sectionGuid, string fileGuid); // 0x000000018168FB00-0x000000018168FC20
		public List<string> GetCompileFlagsForFile(string targetGuid, string fileGuid); // 0x00000001816921F0-0x0000000181692340
		public void SetCompileFlagsForFile(string targetGuid, string fileGuid, List<string> compileFlags); // 0x00000001816966C0-0x0000000181696770
		public void AddAssetTagForFile(string targetGuid, string fileGuid, string tag); // 0x000000018168DA10-0x000000018168DBA0
		public void RemoveAssetTagForFile(string targetGuid, string fileGuid, string tag); // 0x0000000181693630-0x00000001816938C0
		public void AddAssetTagToDefaultInstall(string targetGuid, string tag); // 0x000000018168DBA0-0x000000018168DC60
		public void RemoveAssetTagFromDefaultInstall(string targetGuid, string tag); // 0x00000001816938C0-0x00000001816939A0
		public void RemoveAssetTag(string tag); // 0x00000001816939A0-0x0000000181693F00
		public bool ContainsFileByRealPath(string path); // 0x0000000181691660-0x0000000181691680
		public bool ContainsFileByRealPath(string path, PBXSourceTree sourceTree); // 0x00000001816915C0-0x0000000181691660
		public bool ContainsFileByProjectPath(string path); // 0x0000000181691560-0x00000001816915C0
		public bool ContainsFramework(string targetGuid, string framework); // 0x0000000181691680-0x0000000181691720
		public void AddFrameworkToProject(string targetGuid, string framework, bool weak); // 0x000000018168FDC0-0x000000018168FEB0
		public void RemoveFrameworkFromProject(string targetGuid, string framework); // 0x0000000181695AD0-0x0000000181695B50
		public bool AddCapability(string targetGuid, PBXCapabilityType capability, string entitlementsFilePath = null, bool addOptionalFramework = false /* Metadata: 0x00784F0C */); // 0x000000018168E9D0-0x000000018168EDA0
		public void SetTeamId(string targetGuid, string teamId); // 0x0000000181696C50-0x0000000181696D10
		public string FindFileGuidByRealPath(string path, PBXSourceTree sourceTree); // 0x0000000181691F80-0x0000000181692100
		public string FindFileGuidByRealPath(string path); // 0x0000000181691DB0-0x0000000181691F80
		public string FindFileGuidByProjectPath(string path); // 0x0000000181691D60-0x0000000181691DB0
		public void RemoveFileFromBuild(string targetGuid, string fileGuid); // 0x0000000181694F20-0x00000001816957A0
		public void RemoveFile(string fileGuid); // 0x00000001816957A0-0x0000000181695A60
		private void RemoveGroupIfEmpty(PBXGroupData gr); // 0x0000000181695F00-0x0000000181696000
		private void RemoveGroupChildrenRecursive(PBXGroupData parent); // 0x0000000181695B50-0x0000000181695F00
		internal void RemoveFilesByProjectPathRecursive(string projectPath); // 0x0000000181695A60-0x0000000181695AD0
		internal List<string> GetGroupChildrenFiles(string projectPath); // 0x0000000181692930-0x0000000181692BC0
		internal HashSet<string> GetGroupChildrenFilesRefs(string projectPath); // 0x0000000181692670-0x0000000181692930
		internal HashSet<string> GetFileRefsByProjectPaths(IEnumerable<string> paths); // 0x0000000181692460-0x0000000181692670
		private PBXGroupData GetPBXGroupChildByName(PBXGroupData group, string name); // 0x0000000181692BC0-0x0000000181692DC0
		private PBXGroupData CreateSourceGroup(string sourceGroup); // 0x0000000181691720-0x00000001816919E0
		internal void AddExternalProjectDependency(string path, string projectPath, PBXSourceTree sourceTree); // 0x000000018168F4C0-0x000000018168F7F0
		internal void AddExternalLibraryDependency(string targetGuid, string filename, string remoteFileGuid, string projectPath, string remoteInfo); // 0x000000018168EF00-0x000000018168F4C0
		public string AddTarget(string name, string ext, string type); // 0x00000001816904C0-0x00000001816908F0
		private IEnumerable<string> GetAllTargetGuids(); // 0x0000000181692100-0x00000001816921F0
		public string GetTargetProductFileRef(string targetGuid); // 0x0000000181692E30-0x0000000181692EB0
		internal void AddTargetDependency(string targetGuid, string targetDependencyGuid); // 0x0000000181690240-0x00000001816904C0
		private string AddBuildConfigForTarget(string targetGuid, string name); // 0x000000018168DC60-0x000000018168DE20
		private void RemoveBuildConfigForTarget(string targetGuid, string name); // 0x0000000181693F00-0x0000000181694010
		public string BuildConfigByName(string targetGuid, string name); // 0x0000000181690CD0-0x0000000181690F00
		public IEnumerable<string> BuildConfigNames(); // 0x0000000181690F00-0x0000000181691200
		public void AddBuildConfig(string name); // 0x000000018168DE20-0x000000018168DFC0
		public void RemoveBuildConfig(string name); // 0x0000000181694010-0x00000001816942B0
		public string AddSourcesBuildPhase(string targetGuid); // 0x0000000181690110-0x0000000181690240
		public string AddResourcesBuildPhase(string targetGuid); // 0x000000018168FFE0-0x0000000181690110
		public string AddFrameworksBuildPhase(string targetGuid); // 0x000000018168FEB0-0x000000018168FFE0
		public string AddCopyFilesBuildPhase(string targetGuid, string name, string dstPath, string subfolderSpec); // 0x000000018168EDA0-0x000000018168EF00
		internal string GetConfigListForTarget(string targetGuid); // 0x0000000181692340-0x0000000181692460
		internal void SetBaseReferenceForConfig(string configGuid, string baseReference); // 0x0000000181696000-0x0000000181696090
		public void AddBuildProperty(string targetGuid, string name, string value); // 0x000000018168E600-0x000000018168E810
		public void AddBuildProperty(IEnumerable<string> targetGuids, string name, string value); // 0x000000018168E810-0x000000018168E9D0
		public void AddBuildPropertyForConfig(string configGuid, string name, string value); // 0x000000018168E560-0x000000018168E600
		public void AddBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value); // 0x000000018168E3A0-0x000000018168E560
		public void SetBuildProperty(string targetGuid, string name, string value); // 0x00000001816964B0-0x00000001816966C0
		public void SetBuildProperty(IEnumerable<string> targetGuids, string name, string value); // 0x00000001816962F0-0x00000001816964B0
		public void SetBuildPropertyForConfig(string configGuid, string name, string value); // 0x0000000181696090-0x0000000181696130
		public void SetBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value); // 0x0000000181696130-0x00000001816962F0
		internal void RemoveBuildProperty(string targetGuid, string name); // 0x0000000181694B70-0x0000000181694D80
		internal void RemoveBuildProperty(IEnumerable<string> targetGuids, string name); // 0x0000000181694D80-0x0000000181694F20
		internal void RemoveBuildPropertyForConfig(string configGuid, string name); // 0x00000001816942B0-0x00000001816943A0
		internal void RemoveBuildPropertyForConfig(IEnumerable<string> configGuids, string name); // 0x00000001816943A0-0x0000000181694540
		internal void RemoveBuildPropertyValueList(string targetGuid, string name, IEnumerable<string> valueList); // 0x0000000181694960-0x0000000181694B70
		internal void RemoveBuildPropertyValueList(IEnumerable<string> targetGuids, string name, IEnumerable<string> valueList); // 0x00000001816947A0-0x0000000181694960
		internal void RemoveBuildPropertyValueListForConfig(string configGuid, string name, IEnumerable<string> valueList); // 0x0000000181694700-0x00000001816947A0
		internal void RemoveBuildPropertyValueListForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> valueList); // 0x0000000181694540-0x0000000181694700
		public void UpdateBuildProperty(string targetGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x00000001816977E0-0x00000001816979F0
		public void UpdateBuildProperty(IEnumerable<string> targetGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x00000001816979F0-0x0000000181697BB0
		public void UpdateBuildPropertyForConfig(string configGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x0000000181697320-0x00000001816977E0
		public void UpdateBuildPropertyForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues); // 0x0000000181697160-0x0000000181697320
		internal string ShellScriptByName(string targetGuid, string name); // 0x0000000181696D10-0x0000000181696F20
		internal void AppendShellScriptBuildPhase(string targetGuid, string name, string shellPath, string shellScript); // 0x0000000181690B90-0x0000000181690CD0
		internal void AppendShellScriptBuildPhase(IEnumerable<string> targetGuids, string name, string shellPath, string shellScript); // 0x00000001816908F0-0x0000000181690B90
		public void ReadFromFile(string path); // 0x0000000181693500-0x0000000181693590
		public void ReadFromString(string src); // 0x00000001816935B0-0x0000000181693630
		public void ReadFromStream(TextReader sr); // 0x0000000181693590-0x00000001816935B0
		public void WriteToFile(string path); // 0x0000000181697BB0-0x0000000181697BF0
		public void WriteToStream(TextWriter sw); // 0x0000000181697BF0-0x0000000181697C40
		public string WriteToString(); // 0x0000000181697C40-0x0000000181697C60
		internal PBXProjectObjectData GetProjectInternal(); // 0x0000000181692E00-0x0000000181692E30
		internal void SetTargetAttributes(string key, string value); // 0x0000000181696770-0x0000000181696C50
	}
}
