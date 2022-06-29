using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;

internal class BoardOfRecords
{
    static bool hasNewRecord = false;
    public static (int score, string name)[] records = new (int score, string name)[10];
    public static void ReadRecords()
    {
        try
        {
            StreamReader reader = new StreamReader("Records.txt");
            string[] input = reader.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 10; i++)
            {
                int score = int.Parse(input[i * 2]);
                string name = input[i * 2 + 1];
                records[i] = (score, name);
            }
            reader.Close();
        }
        catch
        {
            records[0] = (70, "Сетчатый питон");
            records[1] = (65, "Центрально-африканский скальный питон");
            records[2] = (58, "Южноафриканский скальный питон");
            records[3] = (57, "Бирманский питон");
            records[4] = (56, "Скребковый питон");
            records[5] = (52, "Зелёная анаконда");
            records[6] = (47, "Аметистовый питон");
            records[7] = (46, "Индийский питон");
            records[8] = (46, "Желтая анаконда");
            records[9] = (43, "Удав");
            hasNewRecord = true;
        }
    }
    public static void SaveRecords()
    {
        if (hasNewRecord)
        {
            StreamWriter writer = new StreamWriter("Records.txt");
            for (int i = 0; i < 10; i++)
            {
                writer.Write(records[i].score.ToString()+'\n');
                writer.Write(records[i].name+'\n');
            }
            writer.Close();
        }
    }
    public static bool CheckResult(int score)
    {
        if (score > records[9].score)
            return true;
        return false;
    }
    public static int DetermineLocation(int score)
    {
        int recordID = 9;
        while (recordID > 0)
        {
            if (score > BoardOfRecords.records[recordID].score && score <= BoardOfRecords.records[recordID - 1].score)
                break;
            recordID--;
        }
        for (int i = 9; i>recordID; i--)
        {
            records[i] = records[i - 1];
        }
        return recordID;
    }
    public static void AddNewRecord(int position, int score, string name)
    {
        hasNewRecord = true;
        records[position] = (score, name);
    }
}