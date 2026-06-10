using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
namespace WpfApp4
{
    internal class DocumentWord
    {
        //создаем обьект класса приложения
        private Word.Application wordApp;
        public DocumentWord()
        {
            try
            {
                wordApp = new Word.Application();
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddDoc(string template,string newName)
        {
            try
            {
                object templateFile = template;
                Word.Document doc = wordApp.Documents.Add();
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
            public void Replace(string stubToPeplace,string text,string nameDoc)
            {
            try
            {
                Word.Document doc = wordApp.Documents[nameDoc];
                bool found;
                do
                {
                    var range = doc.Content;
                    found = range.Find.Execute(
                     FindText: stubToPeplace,
                     ReplaceWith: text);
                } while (found);
                    doc.Save();         
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    }

