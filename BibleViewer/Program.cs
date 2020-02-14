using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BibleViewer
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
            /*if (args.Length != 0) {
                Utilities.Start();

                BIBLIA[] biblia = (new dsBIBLIA(Utilities.Cnn)).List();

                dsCONTADOR dsContador = new dsCONTADOR(Utilities.Cnn);
                dsPALAVRAS dsPalavra = new dsPALAVRAS(Utilities.Cnn);

                int Total = 0;
                foreach (var versiculo in biblia)
                {
                    string escritura = versiculo.ESCRITURA.Replace("-"," ");
                    string[] palavras = escritura.Split(new char[] { ' ' });
                    foreach (var palavra in palavras)
                    {
                        string texto = lib.Class.Utils.GetNumbersOrLetters(palavra);
                        if (!string.IsNullOrEmpty(texto))
                        {
                            Total += texto.Length;
                            dsPalavra.AddPalavra(texto); }
                    }

                }
                dsPalavra.CommitPalavras();
                dsContador.SetPalavras(dsPalavra.Palavras.Count);
                dsContador.SetLetras(Total);

                Total = 0;
                foreach (var item in dsPalavra.Palavras)
                {
                    Total += item.QTDE;
                }

            }*/

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      if (!lib.Class.Instance.RunningInstance())
      {
        Utilities.Start();
        Application.Run(new frmBiblia());
      }
    }
  }
}
