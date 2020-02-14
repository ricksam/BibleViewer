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
  public partial class dsFAVORITOS : DefaultDataSource<FAVORITOS>
  {
    public dsFAVORITOS(Connection cnn)
      : base(cnn)
    { }

    public FAVORITOS Get(int id)
    {
      return Get("select * from FAVORITOS where ID = " + id.ToString());
    }

    public bool Save(FAVORITOS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "FAVORITOS";
      this.sb.AddField("CODLIVRO", Tab.CODLIVRO);
      this.sb.AddField("CAPITULO", Tab.CAPITULO);
      this.sb.AddField("VERS_I", Tab.VERS_I);
      this.sb.AddField("VERS_F", Tab.VERS_F);
      this.sb.AddField("DESCRICAO", Tab.DESCRICAO, 40);

      bool Gravou = false;
      if (Tab.ID == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.ID = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where ID = " + Tab.ID)); }

      return Gravou;
    }

    public bool Remove(int ID)
    {
      this.sb.Clear();
      this.sb.Table = "FAVORITOS";
      return this.cnn.Exec(this.sb.getDelete("where ID = " + ID));
    }
  }
}
