using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace WordLab
{
    internal class WordDocument
    {
        private Word.Application wordApp;
        public WordDocument()
        {
            try
            {
                wordApp = new Word.Application();
                wordApp.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void OpenDoc(string name)
        {
            try
            {
                object fileName = name;
                wordApp.Documents.Open(ref fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddDoc(string newName)
        {
            try
            {
                Word.Document doc = wordApp.Documents.Add();
                object fileName = newName;
                doc.SaveAs2(ref fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddDoc(string template, string newName)
        {
            try
            {
                object templateFile = template;
                Word.Document doc = wordApp.Documents.Add(ref templateFile);
                object fileName = newName;
                doc.SaveAs2(ref fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CloseDoc()
        {
            try
            {
                object saveChanges = Word.WdSaveOptions.wdPromptToSaveChanges;

                wordApp.Quit(ref saveChanges);
                wordApp = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

