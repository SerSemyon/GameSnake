namespace SnakeGame;

internal class ScoreList : ListBox
{
    public ScoreList() : base() { }
    public void ShowRecords((int score, string name)[] records)
    {
        this.Items.Clear();
        for (int i = 0; i < records.Length; i++)
        {
            Items.Add(Convert.ToString(i + 1) + ". " + Convert.ToString(records[i].score) + " " + records[i].name);
        }
    }
}
