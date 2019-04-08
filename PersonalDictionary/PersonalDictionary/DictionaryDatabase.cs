using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using SQLite;

namespace PersonalDictionary
{

    public class DictionaryDatabase
    {
        public SQLiteConnection conn;

        public DictionaryDatabase(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<User>();
            conn.CreateTable<Word>();
 
        }

        public void AddNewWord(Word w)
        {
            try
            {
                conn.Insert(w);
                Debug.WriteLine("inserted successfully");
            }
            catch (Exception e) { Debug.WriteLine("ALREADY INSERTED"); }
        }

        public void UpdateWord(Word w)
        {
            try
            {
                conn.Update(w);
            }
            catch (Exception e) { }

        }

        public void DeleteWord(Word w)
        {
            try
            {
                Debug.Write(App.DictionaryDb.conn.Query<Word>("Select * From Words (Turkish, English) VALUES (?, ?)", w.Turkish, w.English).ToString());

                App.DictionaryDb.conn.Query<Word>("Delete From Words (Turkish, English) VALUES (?, ?)", w.Turkish, w.English);


               // conn.Delete(w);
                Debug.WriteLine("DELETED");
            }
            catch (Exception e) {
                Debug.WriteLine("DELETE ERROR");
            }
        }

        public bool AddNewUser(string email, string password)
        {
            try
            {
                conn.Insert(new User(email, password));
                Debug.WriteLine("new user");
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("user has already exists");
                return true;
            }


        }

    }
}
