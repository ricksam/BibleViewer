using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace BibleViewer
{
    public class CONTADOR : DefaultEntity
    {
        public int PALAVRAS { get; set; }
        public int LETRAS { get; set; }
    }

    public class dsCONTADOR : DefaultDataSource<CONTADOR>
    {
        public dsCONTADOR(DbBase DbBase)
          : base(DbBase)
        { }


        public void SetPalavras(int Qtde)
        {
            DbBase.DbExecute(string.Format("update CONTADOR set PALAVRAS =  {0}", Qtde));
        }

        public void SetLetras(int Qtde)
        {
            DbBase.DbExecute(string.Format("update CONTADOR set LETRAS =  {0}", Qtde));
        }
    }
}
