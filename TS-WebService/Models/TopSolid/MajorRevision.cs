using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;

namespace TS_WebService.Models.TopSolid
{
    public class MajorRevision
    {
        public MajorRevision(PdmMajorRevisionId _id)
        {
            Id = _id.Id;
            Name = _id.ToString();
            MinorRevisions = new List<PdmMinorRevisionId>();
            PdmMinorRevisionId = TopSolidHost.Pdm.GetMinorRevisions(_id);
            foreach (PdmMinorRevisionId rev in PdmMinorRevisionId)
            {
                MinorRevisions.Add(rev);
            }
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public List<PdmMinorRevisionId> MinorRevisions { get; private set; }
        public List<PdmMinorRevisionId> PdmMinorRevisionId { get; private set; }
    }
}