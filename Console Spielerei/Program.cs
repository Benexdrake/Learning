
﻿using Azure;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;


namespace Console_Spielerei

{
    class Program
    {
        public static async Task Main()
        {

            

            
            //var secrets = new Secrets();
            //string startPage = "https://www.amazon.de/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.de%2Fref%3Dnav_ya_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=deflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&";
            //string[] pages =
            //{
            //    "https://www.amazon.de/Nintendo-Splatoon-3-Switch/dp/B09JH35KQY/?_encoding=UTF8&pd_rd_w=sxPis&content-id=amzn1.sym.334f809e-3300-40ce-8741-870dea477993&pf_rd_p=334f809e-3300-40ce-8741-870dea477993&pf_rd_r=9DGA7V2S119X3AK0VMAE&pd_rd_wg=eomIh&pd_rd_r=b73e05b4-f5cd-45c8-be69-2b864952adc4&ref_=pd_gw_crs_zg_bs_300992",
            //    "https://www.amazon.de/Sonic-Frontiers-Day-One-PlayStation/dp/B0BBZHV9PH/?_encoding=UTF8&pd_rd_w=caRg5&content-id=amzn1.sym.0bf9ab1e-db90-4058-8c91-2e3e5b4712b7&pf_rd_p=0bf9ab1e-db90-4058-8c91-2e3e5b4712b7&pf_rd_r=T6PXDKTCGQ2VTVXRMZA7&pd_rd_wg=2H5TR&pd_rd_r=f5e30c8c-d786-4f67-b677-89525bcb6eff&ref_=pd_gw_ci_mcx_mr_hp_atf_m",
            //    "https://www.amazon.de/Kirby-das-vergessene-Land-Nintendo/dp/B09JH4QXVF/?_encoding=UTF8&pd_rd_w=sxPis&content-id=amzn1.sym.334f809e-3300-40ce-8741-870dea477993&pf_rd_p=334f809e-3300-40ce-8741-870dea477993&pf_rd_r=9DGA7V2S119X3AK0VMAE&pd_rd_wg=eomIh&pd_rd_r=b73e05b4-f5cd-45c8-be69-2b864952adc4&ref_=pd_gw_crs_zg_bs_300992",
            //    "https://www.amazon.de/Nintendo-Pok%C3%A9mon-Purpur-Switch/dp/B09TTZZWW6/?_encoding=UTF8&pd_rd_w=sxPis&content-id=amzn1.sym.334f809e-3300-40ce-8741-870dea477993&pf_rd_p=334f809e-3300-40ce-8741-870dea477993&pf_rd_r=9DGA7V2S119X3AK0VMAE&pd_rd_wg=eomIh&pd_rd_r=b73e05b4-f5cd-45c8-be69-2b864952adc4&ref_=pd_gw_crs_zg_bs_300992"
            //};
            //
            //Amazon_Api api = new(secrets.Username,secrets.Password, true);
            //await api.Login();
            //
            //await Task.Delay(1000);
            //
            //foreach (var page in pages)
            //{
            //    await api.Preorder(page, false);
            //    await Task.Delay(1000);
            //}

            Test t = new();

            List<string> filePaths = new();

            string mainPath = "C:\\Users\\RichterB\\Desktop";
            string searchPath = Path.Combine(mainPath, "Ordner");
            string outputPath = Path.Combine(mainPath, "Output");
            string savePath = Path.Combine(outputPath, "Combined");

            string zipPath = Path.Combine(outputPath, "zip");
            string unZipPath = Path.Combine(outputPath, "unzip");

            t.directoriesPathList.Add(searchPath);






            // Sucht nach Ordnern
            t.FindDirectories(searchPath);

            // Ausgabe aller gefundenen Ordner
            foreach (var path in t.directoriesPathList)
            {
                Console.WriteLine(path);
                // durchsucht jeden Ordner nach .txt Dateien
                var files = t.FindFile(path, "txt").Result;

                // Gefundene Dateien werden in eine Liste gespeichert.
                foreach (var f in files)
                {
                    filePaths.Add(f);
                }
            }
            
            foreach (var f in filePaths)
            {
                // Trennt den Pfad von dem Dateinamen
                // Dateiname
                string file = t.GetFileName(f);
                // Ordnerpfad
                string filePath = t.GetPathName(f);

                // Bewegt die gefundenen Dateien aus dem Ordnerpfad in einen neuen Ordner.
                t.MoveFile(filePath,outputPath,file);
            }

            // Sucht alle Dateien aus dem Ordner Output mit der Endung .txt
            var outputFiles = t.FindFile(outputPath,"txt").Result;

            foreach (var file in outputFiles)
            {
                var readFile = t.ReadFile(file);

                // Sortiert Einträge nach Suchparameter und speichert diese in eigene Dateien.
                await t.SaveFile(readFile.ToArray(), "ABSCHNITT", savePath, "csv");
                await t.SaveFile(readFile.ToArray(), "ARZTGRUPPEN", savePath, "csv");
            }


            // Suchen nach .Zip Dateien im Ordner Ordner

            var zipFiles = t.FindFile(searchPath,"zip").Result;

            foreach (var zip in zipFiles)
            {
                // kopieren der Dateien nach Output\zip
                // Trennt den Pfad von dem Dateinamen
                // Dateiname
                string file = t.GetFileName(zip);
                // Ordnerpfad
                string filePath = t.GetPathName(zip);
                // Bewegt die gefundenen Dateien aus dem Ordnerpfad in einen neuen Ordner.
                t.MoveFile(filePath, zipPath, file);
            }


            // Sucht nach .zip Dateien im zip Ordner
            zipFiles = t.FindFile(zipPath, "zip").Result;

            foreach (var zip in zipFiles)
            {
                // Entpackt Dateien im unzip Ordner
                t.UnpackZip(zip, unZipPath);
            }


        }
    }
}