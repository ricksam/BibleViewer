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
  public partial class dsCAPITULOS : DefaultDataSource<CAPITULOS>
  {     
    public dsCAPITULOS(Connection cnn)
      : base(cnn)
    {
      TodosCapitulos = GetList();
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
      cnn.QueryParam.Add(LIVRO);
      return GetList("select * from CAPITULOS where  LIVRO = {0}", 0);
    }
  }
}
