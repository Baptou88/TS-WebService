using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSolid.Kernel.Automating;


namespace TS_WebService.Models.TopSolid
{
    public class Loup
    {
        private int loup;

        public LoopType loupType { get; private set; }

        public Loup(ElementId el ,Int32 loup)
        {
            this.loup = loup;
            try
            {
                loupType = TopSolidHost.Shapes.GetLoopType(el, loup);
                
            } catch
            {

            }
            
        }
    }
}