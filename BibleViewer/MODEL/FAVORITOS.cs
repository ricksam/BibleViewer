using lib.Entity;

namespace BibleViewer
{
    public class FAVORITOS : DefaultEntity
    {
        [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
        public int ID { get; set; }
        public int CODLIVRO { get; set; }
        public int CAPITULO { get; set; }
        public int VERS_I { get; set; }
        public int VERS_F { get; set; }
        public string DESCRICAO { get; set; }
    }

    public class dsFAVORITOS : DefaultDataSource<FAVORITOS>
    {
        public dsFAVORITOS(DbBase DbBase)
          : base(DbBase)
        { }

        public FAVORITOS Get(int ID, System.Data.Common.DbTransaction transaction = null)
        {
            return Get(string.Format("SELECT * FROM FAVORITOS WHERE ID = {0}", ID), transaction);
        }

        public void Save(FAVORITOS tab, System.Data.Common.DbTransaction transaction = null)
        {




            tab.DESCRICAO = base.SetMaxLength(tab.DESCRICAO, 2147483647);

            if (tab.ID == 0)
            {
                Insert(tab, transaction);
                if (transaction != null)
                {
                    tab.ID = this.ReturnLastID(transaction).ToInt();
                }
            }
            else
            { Update(tab, new FAVORITOS() { ID = tab.ID }, transaction); }
        }

        public void Remove(int ID, System.Data.Common.DbTransaction transaction = null)
        {
            DbBase.DbExecute(string.Format("DELETE FROM FAVORITOS WHERE ID = {0}", ID), transaction);
        }
    }
}
