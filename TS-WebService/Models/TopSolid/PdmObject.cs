using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Models.TopSolid
{
    public class PdmObject
    {
        public PdmObject(PdmObjectId _id)
        {
            ID = _id;
            List<PdmObjectId> Folders;
            List<PdmObjectId> Documents;
            Name = TopSolidHost.Pdm.GetName(_id);
            TopSolidHost.Pdm.GetConstituents(ID, outFolderIds: out Folders, outDocumentObjectIds: out Documents);
            FolderIds = new List<PdmObject>();
            foreach (PdmObjectId Folder in Folders)
            {
                FolderIds.Add(new PdmObject(Folder));
            }
            DocObjectIds = new List<PdmObject>();
            foreach (PdmObjectId Document in Documents)
            {
                DocObjectIds.Add(new PdmObject(Document));
            }
            State = TopSolidHost.Pdm.GetState(ID);
            strState = State.ToString();
            string outExtension;
            objectType = TopSolidHost.Pdm.GetType(_id, out outExtension);
            Extension = outExtension;
            MajorRevisions = new List<MajorRevision>();
            try
            {
                foreach (PdmMajorRevisionId rev in TopSolidHost.Pdm.GetMajorRevisions(ID))
                {
                    MajorRevisions.Add(new MajorRevision(rev));
                }
            } catch
            {

            }
            
        }

        public PdmObjectId ID { get; private set; }
        public string Name {
            get {
                return TopSolidHost.Pdm.GetName(ID);
            }
            private set {
                //TopSolidHost.Pdm.SetName(ID, "test1");
            }
        }
        public string Author
        {
            get
            {
                return TopSolidHost.Pdm.GetAuthor(ID);
            }
            private set
            {

            }
        }
        public string Description
        {
            get
            {
                return TopSolidHost.Pdm.GetDescription(ID);
            }
        }
        public string Comment
        {
            get
            {
                return TopSolidHost.Pdm.GetComment(ID);
            }
        }

        public List<PdmObject> FolderIds { get; private set; }
        public List<PdmObject> DocObjectIds { get; private set; }
        public PdmObjectState State { get; private set; }
        public string strState { get; private set; }
        public PdmObjectType objectType { get; private set; }
        public string Extension { get; private set; }
        public List<MajorRevision> MajorRevisions { get; private set; }

       
    }
}