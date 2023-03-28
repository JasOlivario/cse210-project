public class Journal
{
    
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntry()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    public void SaveToCSV(string file_name)
    {
        using (StreamWriter outputFile = new StreamWriter(file_name))
        {
            //You can add text to the file with the WriteLine method
             foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.getEntryAsCSV());
            }
        }
    }

    public void LoadFromCSV(string file_name)
    {
        string[] lines = System.IO.File.ReadAllLines(file_name); 
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            CreateJournalEntry(parts[0], parts[1], parts[2]);
        }
    }

    
}
