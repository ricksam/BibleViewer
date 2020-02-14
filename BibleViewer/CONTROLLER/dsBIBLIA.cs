using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace BibleViewer
{
  public partial class dsBIBLIA : DefaultDataSource<BIBLIA>
  {
    public dsBIBLIA(Connection cnn)
      : base(cnn)
    { }

    public BIBLIA Get(int id)
    {
      return Get("select * from BIBLIA where ID = " + id.ToString());
    }

    public BIBLIA[] GetList_FromCapitulo(CAPITULOS CAPITULO)
    {
      cnn.QueryParam.Add(CAPITULO.LIVRO);
      cnn.QueryParam.Add(CAPITULO.CAPITULO);

      return GetList(
        @"SELECT B.* 
          FROM BIBLIA B
          INNER JOIN LIVROS L ON L.CODLIVRO = B.CODLIVRO 
          WHERE L.LIVRO = {0} AND B.CAPITULO = {1}", 0);
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
          { Pesquisas += (i == 0 ? "" : " AND ") + string.Format("B.ESCRITURA LIKE {0}", cnn.dbu.Quoted("%" + splits[i] + "%")); }
        }

        return GetList(
        @"SELECT *
          FROM BIBLIA B 
          INNER JOIN LIVROS L ON L.CODLIVRO = B.CODLIVRO
          WHERE " + Pesquisas, 0);
      }
      else
      {
        return GetList(
          @"SELECT *
          FROM BIBLIA B 
          INNER JOIN LIVROS L ON L.CODLIVRO = B.CODLIVRO", 0);
      }

      //return new BIBLIA[] { };
    }
  }
}
