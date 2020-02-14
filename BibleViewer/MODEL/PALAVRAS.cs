using System.Linq;
using System.Collections.Generic;
using lib.Entity;

namespace BibleViewer
{
    public class PALAVRAS : DefaultEntity
    {
        [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
        public int ID { get; set; }
        public string PALAVRA { get; set; }
        public int QTDE { get; set; }
    }

    public class dsPALAVRAS : DefaultDataSource<PALAVRAS>
    {
        public dsPALAVRAS(DbBase DbBase)
          : base(DbBase)
        { }

        public List<PALAVRAS> Palavras = new List<PALAVRAS>();

        

        public void AddPalavra(string Texto)
        {
            PALAVRAS Palavra = Palavras.Where(q => q.PALAVRA == Texto).FirstOrDefault();
            if (Palavra != null)
            {
                Palavra.QTDE++;
            }
            else
            {
                Palavras.Add(new PALAVRAS() { PALAVRA = Texto, QTDE = 1 });
            }
        }

        public void CommitPalavras()
        {
            this.RemoveAllData<PALAVRAS>();
            System.Data.Common.DbTransaction transaction = this.DbBase.BeginTransaction();
            try
            {
                foreach (var item in Palavras)
                {
                    this.Save(item, transaction);
                }
                transaction.Commit();
            }
            catch { transaction.Rollback(); }
            finally
            {
                DbBase.Close();
            }
        }

        public PALAVRAS Get(int ID, System.Data.Common.DbTransaction transaction = null)
        {
            return Get(string.Format("SELECT * FROM PALAVRAS WHERE ID = {0}", ID), transaction);
        }

        public void Save(PALAVRAS tab, System.Data.Common.DbTransaction transaction = null)
        {
            tab.PALAVRA = base.SetMaxLength(tab.PALAVRA, 2147483647);


            if (tab.ID == 0)
            {
                Insert(tab, transaction);
                if (transaction != null)
                {
                    tab.ID = this.ReturnLastID(transaction).ToInt();
                }
            }
            else
            { Update(tab, new PALAVRAS() { ID = tab.ID }, transaction); }
        }

        public void Remove(int ID, System.Data.Common.DbTransaction transaction = null)
        {
            DbBase.DbExecute(string.Format("DELETE FROM PALAVRAS WHERE ID = {0}", ID), transaction);
        }
    }
}
