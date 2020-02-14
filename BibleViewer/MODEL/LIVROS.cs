using lib.Entity;

namespace BibleViewer
{
    public class LIVROS : DefaultEntity
    {
        [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
        public int CODLIVRO { get; set; }
        public string LIVRO { get; set; }
        public override string ToString()
        {
            return LIVRO;
        }
    }

    public class dsLIVROS : DefaultDataSource<LIVROS>
    {
        public dsLIVROS(DbBase DbBase)
          : base(DbBase)
        { }

        public LIVROS Get(int CODLIVRO, System.Data.Common.DbTransaction transaction = null)
        {
            return Get(string.Format("SELECT * FROM LIVROS WHERE CODLIVRO = {0}", CODLIVRO), transaction);
        }

        public LIVROS[] GetList_Search(string s)
        {
            return List(string.Format("SELECT * FROM LIVROS WHERE LIVRO LIKE {0}", DbQuoted("%" + s + "%")));
        }

        public void Save(LIVROS tab, System.Data.Common.DbTransaction transaction = null)
        {
            tab.LIVRO = base.SetMaxLength(tab.LIVRO, 2147483647);

            if (tab.CODLIVRO == 0)
            {
                Insert(tab, transaction);
                if (transaction != null)
                {
                    tab.CODLIVRO = this.ReturnLastID(transaction).ToInt();
                }
            }
            else
            { Update(tab, new LIVROS() { CODLIVRO = tab.CODLIVRO }, transaction); }
        }

        public void Remove(int CODLIVRO, System.Data.Common.DbTransaction transaction = null)
        {
            DbBase.DbExecute(string.Format("DELETE FROM LIVROS WHERE CODLIVRO = {0}", CODLIVRO), transaction);
        }
    }
}
