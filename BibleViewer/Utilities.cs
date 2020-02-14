using System;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Visual;

namespace BibleViewer
{
  public static class Utilities
  {
    #region public static void Start()
    public static void Start()
    {
      try
      {
                //enmConnection DbType = enmConnection.SQLite;
                //InfoConnection InfoConnection = new InfoConnection("", Utilities.PastaDados() + "\\DATABASE\\bible_jfa_rc.db", "", "");

                //Cnn = new Connection();
                //Cnn.Connect(DbType, InfoConnection);
                string cs = string.Format("Data Source={0};Pooling=true;FailIfMissing=false", Utilities.PastaDados() + "\\DATABASE\\bible_jfa_rc.db");
                Cnn = new lib.Entity.SQLite(cs);
        
      }
      catch (Exception ex)
      {
        Msg.Warning(ex.Message);
      }
    }
    #endregion

    #region Fields
    public static lib.Entity.SQLite Cnn { get; set; }
    public static string DirectoryPortable = System.Windows.Forms.Application.StartupPath;
    #endregion

    #region public static string PastaDados()
    public static string PastaDados()
    {
      return DirectoryPortable;
      /*if (System.Configuration.ConfigurationSettings.AppSettings["Portable"] == "true")
      { return DirectoryPortable; }
      else
      { return lib.Visual.Functions.GetDirAppCondig(); }*/
    }
    #endregion

  }
}
