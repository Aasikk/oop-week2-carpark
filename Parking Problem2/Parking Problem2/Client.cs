using System;

namespace Parking_Problem2
{
    public class Client
    {
        public string Client_Name;
        public int Time_Spent;

        public string ClientName
        {
            get => Client_Name;
            set => Client_Name = value;
        }

        public int TimeSpent
        {
            get => Time_Spent;
            set => Time_Spent = value;
        }

        public Client(string _clientName, int _timeSpent)
        {
            Client_Name = _clientName;
            Time_Spent = _timeSpent;
        }

        public double calculateCharges(int Time_Spent)
        {
            double res = 2;
            if (Time_Spent > 3)
            {
                res += (Time_Spent - 3) * 0.5;
                if (Time_Spent == 24)
                {
                    res =10;
                }
            }
            return res;
        }

        public override string ToString()
        {
            return $"Client name: {Client_Name},  Time spent: {Time_Spent} hours";
        }
    }

}