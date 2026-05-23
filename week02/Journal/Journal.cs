// Journal class of the Journal program. Uses the Entry Class.
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Save(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._entryDate}|{entry._prompt}|{entry._response}|{entry._scale}");
            }
        }
    }
    public void Load(string filename)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._entryDate = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            entry._scale = parts[3];

            _entries.Add(entry);

        }
    }
}