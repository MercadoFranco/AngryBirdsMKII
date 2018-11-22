using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string ListaPajarosPath = @"C:\Users\Maikhol\Documents\GitHub\AngryBirdsMKII\WindowsFormsApp2\JSONES\";

            if (File.Exists(ListaPajarosPath + "ListaPajaros.json"))
            {
                using (StreamReader file = File.OpenText(ListaPajarosPath + "ListaPajaros.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    IslaPajaro.Instancia().pajaros = (List<PajaroComun>)serializer.Deserialize(file, typeof(PajaroComun));
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //string jsonPajaro = JsonConvert.SerializeObject(IslaPajaro.pajaros, Formatting.Indented);
            //File.WriteAllText(ListaPajarosPath + "ListaPajaros.json", JsonConvert.SerializeObject(IslaPajaro.pajaros));
            using (StreamWriter file = File.CreateText(ListaPajarosPath + "ListaPajaros.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, IslaPajaro.Instancia().pajaros);
            }
        }
    }
}