using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardoAndradeExamenProgresoalfanumericos.Models
{
    internal class LAAllNotes
    {
        public ObservableCollection<LANote> Notes { get; set; } = new ObservableCollection<LANote>();

        public LAAllNotes() =>
            LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            string appDataPath = FileSystem.AppDataDirectory;
            IEnumerable<LANote> notes = Directory
                .EnumerateFiles(appDataPath, "*.notes.txt")
                .Select(filename => new LANote()

                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                })
                .OrderBy(notes => notes.Date);

            foreach (LANote note in notes) 
                Notes.Add(note);

        }
    }
}
