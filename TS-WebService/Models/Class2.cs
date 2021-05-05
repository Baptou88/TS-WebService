using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Models
{
    public class Class2 : IPdm
    {
        public PdmProjectFolderId WorkingProjectsRootFolder => throw new NotImplementedException();

        public PdmProjectFolderId LibraryProjectsRootFolder => throw new NotImplementedException();

        public void AddReferencedProjects(PdmObjectId inProjectId, List<PdmObjectId> inReferencedProjectIds)
        {
            throw new NotImplementedException();
        }

        public void CheckIn(PdmObjectId inObjectId, bool inRecurses)
        {
            throw new NotImplementedException();
        }

        public void CheckInSeveral(List<PdmObjectId> inObjectIds, bool inRecurses)
        {
            throw new NotImplementedException();
        }

        public void CheckOut(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void CloseProject(PdmObjectId inProjectId)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> CopySeveral(List<PdmObjectId> inObjectIds, PdmObjectId inOwnerId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId CreateDocument(PdmObjectId inOwnerId, string inExtension, bool inUseDefaultTemplate)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId CreateDocumentWithTemplate(PdmObjectId inOwnerId, PdmObjectId inTemplateObjectId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId CreateFolder(PdmObjectId inObjectId, string inFolderName)
        {
            throw new NotImplementedException();
        }

        public void CreateLifeCycleSubState(PdmLifeCycleMainState inLifeCycleMainState, string inLifeCycleSubStateName)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId CreateProject(string inProjectName, bool inIsLibrary)
        {
            throw new NotImplementedException();
        }

        public PdmProjectFolderId CreateProjectFolder(PdmProjectFolderId inProjectFolderId, string inFolderName)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId CreateProjectWithTemplate(string inProjectName, PdmObjectId inTemplateObjectId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProjectFolder(PdmProjectFolderId inProjectFolderId)
        {
            throw new NotImplementedException();
        }

        public void DeleteSeveral(List<PdmObjectId> inObjectIds)
        {
            throw new NotImplementedException();
        }

        public void EnsureIsDirty(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public bool Exists(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void ExportExecutablePackage(List<PdmObjectId> inObjectIds, bool inExportsForDelivery, bool inExportsIncrementalPackage, bool inAllowsMeasurement, string inFileFullPath)
        {
            throw new NotImplementedException();
        }

        public void ExportMinorRevisionFile(PdmMinorRevisionId inMinorRevisionId, string inFullName)
        {
            throw new NotImplementedException();
        }

        public void ExportPackage(List<PdmObjectId> inObjectIds, bool inExportsForDelivery, bool inExportsIncrementalPackage, string inFileFullPath)
        {
            throw new NotImplementedException();
        }

        public void ExportToBabylon(PdmObjectId inDocumentId, string inFolderPath, string inFileName)
        {
            throw new NotImplementedException();
        }

        public void ExportViewerPackage(List<PdmObjectId> inObjectIds, bool inExportsForDelivery, bool inExportsIncrementalPackage, bool inAllowsMeasurement, string inFileFullPath)
        {
            throw new NotImplementedException();
        }

        public string GetAuthor(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public string GetComment(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public string GetComplementaryPartNumber(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void GetConstituents(PdmObjectId inObjectId, out List<PdmObjectId> outFolderIds, out List<PdmObjectId> outDocumentObjectIds)
        {
            throw new NotImplementedException();
        }

        public string GetDescription(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public PdmMinorRevisionId GetFinalMinorRevision(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public PdmMajorRevisionId GetLastMajorRevision(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public PdmMinorRevisionId GetLastMinorRevision(PdmMajorRevisionId inMajorRevisionId)
        {
            throw new NotImplementedException();
        }

        public void GetLatestRevision(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public PdmLifeCycleMainState GetLifeCycleMainState(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void GetLifeCycleSubStates(PdmLifeCycleMainState inLifeCycleMainState, out List<PdmObjectId> outLifeCycleSubStateIds, out List<string> outLifeCycleSubStateNames)
        {
            throw new NotImplementedException();
        }

        public PdmMajorRevisionId GetMajorRevision(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public PdmLifeCycleMainState GetMajorRevisionLifeCycleMainState(PdmMajorRevisionId inMajorRevisionId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId GetMajorRevisionLifeCycleSubState(PdmMajorRevisionId inMajorRevisionId)
        {
            throw new NotImplementedException();
        }

        public List<PdmMajorRevisionId> GetMajorRevisions(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public string GetMajorRevisionText(PdmMajorRevisionId inMajorRevisionId)
        {
            throw new NotImplementedException();
        }

        public string GetManufacturer(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public string GetManufacturerPartNumber(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public long GetMinorRevisionFileSize(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public int GetMinorRevisionFileVersion(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public Bitmap GetMinorRevisionPreviewBitmap(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public List<PdmMinorRevisionId> GetMinorRevisions(PdmMajorRevisionId inMajorRevisionId)
        {
            throw new NotImplementedException();
        }

        public string GetMinorRevisionText(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public string GetName(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> GetOpenProjects(bool inGetsWorkingProjects, bool inGetsLibraryProjects)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId GetOwner(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public string GetPartNumber(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId GetPdmObject(PdmMajorRevisionId inMajorRevisionId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId GetProject(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void GetProjectFolderConstituents(PdmProjectFolderId inProjectFolderdId, out List<PdmProjectFolderId> outFolderIds, out List<PdmObjectId> outProjectIds)
        {
            throw new NotImplementedException();
        }

        public string GetProjectFolderName(PdmProjectFolderId inProjectFolderId)
        {
            throw new NotImplementedException();
        }

        public PdmProjectFolderId GetProjectFolderOwner(PdmProjectFolderId inProjectFolderId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId GetProjectMainDocument(PdmObjectId inProjectId)
        {
            throw new NotImplementedException();
        }

        public PdmProjectFolderId GetProjectOwner(PdmObjectId inProjectId)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> GetProjects(bool inGetsWorkingProjects, bool inGetsLibraryProjects)
        {
            throw new NotImplementedException();
        }

        public void GetProjectTemplates(PdmObjectId inProjectId, out PdmObjectId outTemplatesFolderId, out PdmObjectId outDefaultsFolderId)
        {
            throw new NotImplementedException();
        }

        public Real? GetRealUserProperty(PdmObjectId inObjectId, PdmObjectId inPropertyObjectId)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> GetReferencedProjects(PdmObjectId inProjectId)
        {
            throw new NotImplementedException();
        }

        public void GetRevisionTexts(PdmObjectId inObjectId, out string outMajorText, out string outMinorText)
        {
            throw new NotImplementedException();
        }

        public PdmObjectState GetState(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void GetTemplates(out PdmObjectId outUserDocumentTemplatesProjectId, out PdmObjectId outCompanyDocumentTemplatesProjectId, out PdmObjectId outUserProjectTemplatesProjectId, out PdmObjectId outCompanyProjectTemplatesProjectId)
        {
            throw new NotImplementedException();
        }

        public string GetTextUserProperty(PdmObjectId inObjectId, PdmObjectId inPropertyObjectId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectType GetType(PdmObjectId inObjectId, out string outExtension)
        {
            throw new NotImplementedException();
        }

        public bool HasConstituents(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public bool HasProjectFolderConstituents(PdmProjectFolderId inProjectFolderdId)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId ImportFile(string inFullName, PdmObjectId inOwnerId, string inDocumentName)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> ImportPackageAsDistinctCopy(string inFileFullPath, bool inResetsCreationProperties, bool inAllowsPartNumbering)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> ImportPackageAsReplication(string inFileFullPath)
        {
            throw new NotImplementedException();
        }

        public void IncludePackageAsDistinctCopy(string inFileFullPath, bool inResetsCreationProperties, bool inAllowsPartNumbering, PdmObjectId inOwnerId)
        {
            throw new NotImplementedException();
        }

        public bool IsDirty(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public bool IsLibraryProject(PdmObjectId inProjectId)
        {
            throw new NotImplementedException();
        }

        public void MoveProject(PdmObjectId inProjectId, PdmProjectFolderId inDestinationFolderId)
        {
            throw new NotImplementedException();
        }

        public void MoveProjectFolder(PdmProjectFolderId inProjectFolderId, PdmProjectFolderId inDestinationFolderId)
        {
            throw new NotImplementedException();
        }

        public void MoveSeveral(List<PdmObjectId> inObjectIds, PdmObjectId inOwnerId)
        {
            throw new NotImplementedException();
        }

        public bool NeedsGettingLatestRevision(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public bool NeedsUpdating(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void OpenMinorRevision(PdmMinorRevisionId inMinorRevisionId, bool inReadOnly)
        {
            throw new NotImplementedException();
        }

        public void OpenProject(PdmObjectId inProjectId)
        {
            throw new NotImplementedException();
        }

        public void PurgeSeveral(List<PdmObjectId> inObjectIds)
        {
            throw new NotImplementedException();
        }

        public PdmMinorRevisionId ReimportFile(string inFullName, PdmObjectId inDocumentId)
        {
            throw new NotImplementedException();
        }

        public void Restore(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void RestoreLastSave(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void RestoreMinorRevision(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public void Save(PdmObjectId inObjectId, bool inRecurses)
        {
            throw new NotImplementedException();
        }

        public void SaveSeveral(List<PdmObjectId> inObjectIds, bool inRecurses)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> SearchDocumentByName(PdmObjectId inProjectId, string inDocumentName)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> SearchDocumentByNameWithWildcards(PdmObjectId inProjectId, string inDocumentName)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> SearchDocumentByPartNumber(PdmObjectId inProjectId, string inPartNumber)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> SearchDocumentByPartNumberWithWildcards(PdmObjectId inProjectId, string inPartNumber)
        {
            throw new NotImplementedException();
        }

        public PdmObjectId SearchDocumentByUniversalId(PdmObjectId inProjectId, string inDomain, string inName)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> SearchFolderByName(PdmObjectId inProjectId, string inFolderName)
        {
            throw new NotImplementedException();
        }

        public List<PdmMinorRevisionId> SearchMajorRevisionBackReferences(PdmObjectId inProjectId, PdmMajorRevisionId inMajorRevisionId)
        {
            throw new NotImplementedException();
        }

        public List<PdmMinorRevisionId> SearchMinorRevisionBackReferences(PdmObjectId inProjectId, PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public List<PdmMinorRevisionId> SearchMinorRevisionReferences(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }

        public List<PdmObjectId> SearchProjectByName(string inProjectName)
        {
            throw new NotImplementedException();
        }

        public bool SearchPropertyDefinitionInfo(PropertyDefinition inPropertyDefinition, out string outLocalizedDomainName, out string outLocalizedName, out PropertyType outType)
        {
            throw new NotImplementedException();
        }

        public string SearchUserEnumerationLocalizedText(PropertyDefinition inPropertyDefinition, int inValue)
        {
            throw new NotImplementedException();
        }

        public void SetAuthor(PdmObjectId inObjectId, string inAuthor)
        {
            throw new NotImplementedException();
        }

        public void SetComment(PdmObjectId inObjectId, string inComment)
        {
            throw new NotImplementedException();
        }

        public void SetComplementaryPartNumber(PdmObjectId inObjectId, string inComplementaryPartNumber)
        {
            throw new NotImplementedException();
        }

        public void SetDescription(PdmObjectId inObjectId, string inDescription)
        {
            throw new NotImplementedException();
        }

        public void SetLifeCycleMainState(PdmObjectId inObjectId, PdmLifeCycleMainState inLifeCycle)
        {
            throw new NotImplementedException();
        }

        public void SetMajorRevisionLifeCycleMainState(PdmMajorRevisionId inMajorRevisionId, PdmLifeCycleMainState inLifeCycle)
        {
            throw new NotImplementedException();
        }

        public void SetMajorRevisionLifeCycleSubState(PdmMajorRevisionId inMajorRevisionId, PdmObjectId inNewLifeCycleSubStateId)
        {
            throw new NotImplementedException();
        }

        public void SetManufacturer(PdmObjectId inObjectId, string inManufacturer)
        {
            throw new NotImplementedException();
        }

        public void SetManufacturerPartNumber(PdmObjectId inObjectId, string inManufacturerPartNumber)
        {
            throw new NotImplementedException();
        }

        public void SetName(PdmObjectId inObjectId, string inName)
        {
            throw new NotImplementedException();
        }

        public void SetPartNumber(PdmObjectId inObjectId, string inPartNumber)
        {
            throw new NotImplementedException();
        }

        public void SetProjectFolderName(PdmProjectFolderId inProjectFolderId, string inName)
        {
            throw new NotImplementedException();
        }

        public void SetProjectMainDocument(PdmObjectId inProjectId, PdmObjectId inDocumentId)
        {
            throw new NotImplementedException();
        }

        public void SetRealUserProperty(PdmObjectId inObjectId, PdmObjectId inPropertyObjectId, Real inValue)
        {
            throw new NotImplementedException();
        }

        public void SetRevisionTexts(PdmObjectId inObjectId, string inMajorText, string inMinorText)
        {
            throw new NotImplementedException();
        }

        public void SetTextUserProperty(PdmObjectId inObjectId, PdmObjectId inPropertyObjectId, string inValue)
        {
            throw new NotImplementedException();
        }

        public void ShowInProjectTree(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void UndoCheckOut(PdmObjectId inObjectId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDocumentReferences(PdmMinorRevisionId inMinorRevisionId)
        {
            throw new NotImplementedException();
        }
    }
}