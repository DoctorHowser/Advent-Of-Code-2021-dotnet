namespace Advent;

class CodeProcessor
{
    private string gamma = "";
    private string epsilon = "";


    private int count = 0;

    private List<int> running = new List<int>();


    public CodeProcessor(int codeLength) {
        while (running.Count < codeLength)
        {
             running.Add(0);
        }
    }

    public int GetPowerConsumption()
    {   
        //I want to use bitwise, but im getting all turned around. This didnt work...
        // return Convert.ToInt32(gamma, 2) * ~Convert.ToInt32(gamma, 2);
        return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
    }

    private void ProcessPower() {
        foreach (int num in running)
        {
            if(num >= count) {
                gamma += '1';
                epsilon += '0';
            } else {
                gamma += '0';
                epsilon += '1';
            }
        }
    }

    public void ProcessCode(string Code)
    {
        
        for (int i = 0; i < Code.Length; i++)
        {
            char c = Code[i];
            //Seems like a quirk? char minus a char '0' makes an int...
            //update the index of running 
            
            running[i] += c - '0';
        }

    }

    public void ProcessCodes(List<string> Codes) {
        count = Codes.Count / 2;
        foreach (var code in Codes) {
            ProcessCode(code);
        }
        //All codes processed, ready to calc
        ProcessPower();
    }
}
