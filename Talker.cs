using System.Windows.Forms;

class Talker
{
    public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
    {
        string finalString = "";

        for (int count = 1; count <= numberOfTimes; count++)
        {
            finalString = finalString + thingToSay + "\n";
        }

        MessageBox.Show(finalString);

        return finalString.Length;
    }
}