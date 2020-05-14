using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEssai
{
    static class Program
    {
        private delegate string DisQuelquechose();

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            DisQuelquechose monInstanceDeDisQuelquechose = new DisQuelquechose(Exemple);
            DisQuelquechose monInstance = new DisQuelquechose(HelloWord);
            DisQuelquechose instanceExemple = new DisQuelquechose(Exemple);
            DisQuelquechose instance = new DisQuelquechose(DisBonjour);
            DisQuelquechose monInstanceDeDisQuelqueChose = new DisQuelquechose(Afficher);



        }

    //valentin
    private static string DisBonjour()
        {
            return "Bonjour";
        }

        //andrea
        public static string HelloWord()
        {
            return "hello word !";
        }
        //nordine
        public static string Afficher()
        {
            return "affiche";
        }

        //gaylord
        private static string Exemple(string tuut)
        {
            return "code";
        }
        private static string Exemple()
        {
            return "code";
        }
    }
}
