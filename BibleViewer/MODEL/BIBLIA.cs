using lib.Entity;

namespace BibleViewer
{
    public class BIBLIA : DefaultEntity
    {
        [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
        public int ID { get; set; }
        public int CODLIVRO { get; set; }
        public int CAPITULO { get; set; }
        public int VERSICULO { get; set; }
        public string ESCRITURA { get; set; }
        public string LIVRO { get; set; }
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(LIVRO))
            { return string.Format("({0} {1},{2}) {3}", LIVRO, CAPITULO, VERSICULO, ESCRITURA); }
            else
            { return VERSICULO + " " + ESCRITURA; }
        }
    }

    public class dsBIBLIA : DefaultDataSource<BIBLIA>
    {
        public dsBIBLIA(DbBase DbBase)
          : base(DbBase)
        { }

        public BIBLIA Get(int ID, System.Data.Common.DbTransaction transaction = null)
        {
            return Get(string.Format("SELECT * FROM BIBLIA WHERE ID = {0}", ID), transaction);
        }

        public BIBLIA[] GetList_FromCapitulo(CAPITULOS CAPITULO)
        {
            //DbBase.QueryParam.Add(CAPITULO.LIVRO);
            //DbBase.QueryParam.Add(CAPITULO.CAPITULO);

            return List(
                string.Format(@"SELECT B.* 
                  FROM BIBLIA B
                  INNER JOIN LIVROS L ON L.CODLIVRO = B.CODLIVRO 
                  WHERE L.LIVRO = {0} AND B.CAPITULO = {1}",
                  DbQuoted(CAPITULO.LIVRO),
                  CAPITULO.CAPITULO));
        }

        public BIBLIA[] Search(string s)
        {
            s = s.Trim();
            if (!string.IsNullOrEmpty(s))
            {
                string[] splits = s.Split(new char[] { ' ' });

                string Pesquisas = "";
                for (int i = 0; i < splits.Length; i++)
                {
                    if (!string.IsNullOrEmpty(splits[i]))
                    { Pesquisas += (i == 0 ? "" : " AND ") + string.Format("B.ESCRITURA LIKE {0}", DbQuoted("%" + splits[i] + "%")); }
                }

                return List(
                @"SELECT *
          FROM BIBLIA B 
          INNER JOIN LIVROS L ON L.CODLIVRO = B.CODLIVRO
          WHERE " + Pesquisas);
            }
            else
            {
                return List(
                  @"SELECT *
          FROM BIBLIA B 
          INNER JOIN LIVROS L ON L.CODLIVRO = B.CODLIVRO");
            }

            //return new BIBLIA[] { };
        }

        public void Save(BIBLIA tab, System.Data.Common.DbTransaction transaction = null)
        {



            tab.ESCRITURA = base.SetMaxLength(tab.ESCRITURA, 2147483647);

            if (tab.ID == 0)
            {
                Insert(tab, transaction);
                if (transaction != null)
                {
                    tab.ID = this.ReturnLastID(transaction).ToInt();
                }
            }
            else
            { Update(tab, new BIBLIA() { ID = tab.ID }, transaction); }
        }

        public void Remove(int ID, System.Data.Common.DbTransaction transaction = null)
        {
            DbBase.DbExecute(string.Format("DELETE FROM BIBLIA WHERE ID = {0}", ID), transaction);
        }
    }
}
