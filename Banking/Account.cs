/* 
13.Add Account class 
14.Add balance as private data member to Account class.
15.Add Withdraw and Deposit method to manage balance of Account class.
16.Add Balance as Property to Account class.
17.Test Account class funcationality  in Main method.
*/


namespace Banking
{
    //delegate defination
    public delegate void AccountHandler();

    public class Account
    {
        //Can class have state,behaviour

        private float balance;  //state

        public event AccountHandler underbalance;     //evevt
        public event AccountHandler overbalance;      //evevt

        public float Balance   //Property
        {
            get { return balance; }
            set { balance = value; }
        }

        //static behaviour
        public Account(float amount)
        {
            balance = amount;
        }
        public void Monitor()   //Observing Balance
        {
            //Check

            //Check balance against threshhold
            if (balance < 5000)
            {
                // raise an event underbalance
                // trigger
                underbalance();  //invoking event
            }
            else if (balance >= 250000)
            {
                // raise an event overbalance
                //trriger
                overbalance();  //invoking event
            }
        }
        public void Withdraw(float amount)  //Withdraw method
        {
            balance = balance - amount;
        }
        public void Deposit(float amount)    //deposite method
        {
            balance = balance + amount;
        }

        //is always overrided to convert object state into string 
        public override string ToString()
        {
            return balance.ToString();
        }

    }
}