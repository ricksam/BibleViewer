using lib.Entity;

namespace BibleViewer
{
    public class CAPITULOS : DefaultEntity
    {
        [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
        public int CODLIVRO { get; set; }
        public int CAPITULO { get; set; }
        public string LIVRO { get; set; }
    }

    public class dsCAPITULOS : DefaultDataSource<CAPITULOS>
    {
        public dsCAPITULOS(DbBase DbBase)
          : base(DbBase)
        {
            TodosCapitulos = List();
        }

        CAPITULOS[] TodosCapitulos { get; set; }

        private int IndexCapitulo(CAPITULOS CAPITULO)
        {
            for (int i = 0; i < TodosCapitulos.Length; i++)
            {
                if (TodosCapitulos[i].LIVRO == CAPITULO.LIVRO && TodosCapitulos[i].CAPITULO == CAPITULO.CAPITULO)
                { return i; }
            }
            return -1;
        }

        public CAPITULOS GetAnterior(CAPITULOS CAPITULO)
        {
            int idx = IndexCapitulo(CAPITULO);

            idx--;
            if (idx >= 0 && idx < TodosCapitulos.Length)
            { return TodosCapitulos[idx]; }

            return TodosCapitulos[0];
        }

        public CAPITULOS GetProximo(CAPITULOS CAPITULO)
        {
            int idx = IndexCapitulo(CAPITULO);

            idx++;
            if (idx >= 0 && idx < TodosCapitulos.Length)
            { return TodosCapitulos[idx]; }

            return TodosCapitulos[0];
        }

        public CAPITULOS[] GetList_FromLivro(string LIVRO)
        {
            return List(string.Format("select * from CAPITULOS where  LIVRO = {0}", DbQuoted(LIVRO)));
        }

        public CAPITULOS Get(int CODLIVRO, System.Data.Common.DbTransaction transaction = null)
        {
            return Get(string.Format("SELECT * FROM CAPITULOS WHERE CODLIVRO = {0}", CODLIVRO), transaction);
        }

        public void Save(CAPITULOS tab, System.Data.Common.DbTransaction transaction = null)
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
            { Update(tab, new CAPITULOS() { CODLIVRO = tab.CODLIVRO }, transaction); }
        }

        public void Remove(int CODLIVRO, System.Data.Common.DbTransaction transaction = null)
        {
            DbBase.DbExecute(string.Format("DELETE FROM CAPITULOS WHERE CODLIVRO = {0}", CODLIVRO), transaction);
        }
    }
}
