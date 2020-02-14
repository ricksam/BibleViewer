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
  public partial class dsLIVROS : DefaultDataSource<LIVROS>
  {
    public dsLIVROS(Connection cnn)
      : base(cnn)
    { }

    public LIVROS Get(int id)
    {
      return Get("select * from LIVROS where CODLIVRO = " + id.ToString());
    }

    public LIVROS[] GetList_Search(string s) 
    {
      cnn.QueryParam.Add("%" + s + "%");
      return GetList("SELECT * FROM LIVROS WHERE LIVRO LIKE {0}", 0); 
    }
  }
}
